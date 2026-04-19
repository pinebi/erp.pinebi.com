(function () {
    window.pinebiTakvim = {
        calendar: null,
        _loaderPromise: null,
        _loadFC: function () {
            if (typeof FullCalendar !== 'undefined') return Promise.resolve();
            if (this._loaderPromise) return this._loaderPromise;
            this._loaderPromise = new Promise(function (resolve, reject) {
                if (!document.getElementById('fc-css')) {
                    var l = document.createElement('link');
                    l.id = 'fc-css'; l.rel = 'stylesheet';
                    l.href = 'https://cdn.jsdelivr.net/npm/fullcalendar@6.1.15/index.global.min.css';
                    document.head.appendChild(l);
                }
                var s = document.createElement('script');
                s.src = 'https://cdn.jsdelivr.net/npm/fullcalendar@6.1.15/index.global.min.js';
                s.onload = resolve;
                s.onerror = function () { reject(new Error('FullCalendar yuklenemedi')); };
                document.head.appendChild(s);
            });
            return this._loaderPromise;
        },
        _attachTooltip: function (info) {
            var e = info.event;
            var ext = e.extendedProps || {};
            var lines = [];
            lines.push(e.title || '');
            if (e.start) {
                var fmt = function (d) {
                    return d.toLocaleString('tr-TR', { weekday:'short', day:'2-digit', month:'short', hour:'2-digit', minute:'2-digit' });
                };
                if (e.allDay) {
                    lines.push(e.start.toLocaleDateString('tr-TR'));
                } else {
                    lines.push(fmt(e.start) + (e.end ? ' - ' + e.end.toLocaleTimeString('tr-TR', {hour:'2-digit',minute:'2-digit'}) : ''));
                }
            }
            if (ext.location) lines.push('Konum: ' + ext.location);
            if (ext.cariKod) lines.push('Cari: ' + ext.cariKod + (ext.cariUnvan ? ' ('+ext.cariUnvan+')' : ''));
            if (ext.roomAd) lines.push('Oda: ' + ext.roomAd);
            if (ext.aciklama) lines.push('---\n' + ext.aciklama);
            info.el.setAttribute('title', lines.join('\n'));

            // Ozel hover popup - fare konumunu takip eder
            var buildHtml = function () {
                var html = '<div style="font-weight:600; color:#235881; margin-bottom:6px;">' + escapeHtml(e.title || '') + '</div>';
                if (e.start) {
                    html += '<div style="color:#64748b; font-size:12px; margin-bottom:8px;">';
                    if (e.allDay) {
                        html += e.start.toLocaleDateString('tr-TR', { weekday:'long', day:'2-digit', month:'long' });
                    } else {
                        html += e.start.toLocaleString('tr-TR', { weekday:'short', day:'2-digit', month:'short', hour:'2-digit', minute:'2-digit' });
                        if (e.end) html += ' - ' + e.end.toLocaleTimeString('tr-TR', { hour:'2-digit', minute:'2-digit' });
                    }
                    html += '</div>';
                }
                if (ext.location) html += '<div><b>Konum:</b> ' + escapeHtml(ext.location) + '</div>';
                if (ext.cariKod) html += '<div><b>Cari:</b> ' + escapeHtml(ext.cariKod) + (ext.cariUnvan ? ' - ' + escapeHtml(ext.cariUnvan) : '') + '</div>';
                if (ext.roomAd) html += '<div><b>Oda:</b> ' + escapeHtml(ext.roomAd) + '</div>';
                if (ext.aciklama) html += '<div style="margin-top:8px; padding-top:8px; border-top:1px solid #f1f5f9; white-space:pre-wrap;">' + escapeHtml(ext.aciklama) + '</div>';
                return html;
            };

            var ensurePop = function () {
                var pop = document.getElementById('pinebi-event-pop');
                if (!pop) {
                    pop = document.createElement('div');
                    pop.id = 'pinebi-event-pop';
                    pop.style.cssText = 'position:fixed; z-index:99999; background:white; border:1px solid #e2e8f0; border-radius:10px; box-shadow:0 10px 30px rgba(15,23,42,0.18); padding:12px 14px; min-width:240px; max-width:340px; font-size:13px; font-family:-apple-system,BlinkMacSystemFont,Segoe UI,sans-serif; color:#334155; pointer-events:none; display:none;';
                    document.body.appendChild(pop);
                }
                return pop;
            };

            var place = function (clientX, clientY) {
                var pop = ensurePop();
                pop.innerHTML = buildHtml();
                pop.style.display = 'block';
                // Olc
                var w = pop.offsetWidth, h = pop.offsetHeight;
                var gap = 14;
                var left = clientX + gap;
                var top = clientY + gap;
                // Ekran tasmasi kontrolu
                if (left + w + 8 > window.innerWidth) left = clientX - w - gap;
                if (top + h + 8 > window.innerHeight) top = clientY - h - gap;
                if (left < 8) left = 8;
                if (top < 8) top = 8;
                pop.style.left = left + 'px';
                pop.style.top = top + 'px';
            };

            info.el.addEventListener('mouseenter', function (ev) { place(ev.clientX, ev.clientY); });
            info.el.addEventListener('mousemove', function (ev) { place(ev.clientX, ev.clientY); });
            info.el.addEventListener('mouseleave', function () {
                var pop = document.getElementById('pinebi-event-pop');
                if (pop) pop.style.display = 'none';
            });
        },
        _dedupe: function (events) {
            if (!events) return [];
            var seen = {};
            var out = [];
            events.forEach(function (e) {
                var id = (e && e.id) ? String(e.id) : null;
                if (!id) { out.push(e); return; }
                if (seen[id]) return;
                seen[id] = true;
                out.push(e);
            });
            return out;
        },
        init: function (dotnetRef, initialEvents) {
            var self = this;
            return this._loadFC().then(function () {
                var el = document.getElementById('pinebi-fc');
                if (!el) return;
                if (self.calendar) { try { self.calendar.destroy(); } catch(e){} self.calendar = null; }
                // Konteyner icerigini temizle (eski DOM arti klarini at)
                el.innerHTML = '';
                initialEvents = self._dedupe(initialEvents);
                self.calendar = new FullCalendar.Calendar(el, {
                    initialView: 'timeGridWeek',
                    locale: 'tr',
                    firstDay: 1,
                    height: 'auto',
                    nowIndicator: true,
                    editable: true,
                    selectable: true,
                    headerToolbar: { left: 'prev,next today', center: 'title', right: 'dayGridMonth,timeGridWeek,timeGridDay,listWeek' },
                    buttonText: { today: 'Bugun', month: 'Ay', week: 'Hafta', day: 'Gun', list: 'Liste' },
                    slotMinTime: '07:00', slotMaxTime: '21:00',
                    events: initialEvents || [],
                    eventDidMount: function (info) { self._attachTooltip(info); },
                    select: function (info) {
                        dotnetRef.invokeMethodAsync('YeniEtkinlik', info.startStr, info.endStr, info.allDay === true);
                    },
                    eventClick: function (info) {
                        dotnetRef.invokeMethodAsync('EtkinligiAc', info.event.id);
                    },
                    eventDrop: function (info) {
                        dotnetRef.invokeMethodAsync('EtkinligiTasi', info.event.id, info.event.startStr, info.event.endStr || info.event.startStr);
                    },
                    eventResize: function (info) {
                        dotnetRef.invokeMethodAsync('EtkinligiTasi', info.event.id, info.event.startStr, info.event.endStr || info.event.startStr);
                    }
                });
                self.calendar.render();
            });
        },
        setEvents: function (events) {
            if (!this.calendar) return;
            var cal = this.calendar;
            cal.getEvents().forEach(function (e) { e.remove(); });
            this._dedupe(events).forEach(function (e) { cal.addEvent(e); });
            cal.render();
        }
    };

    function escapeHtml(s) {
        return String(s == null ? '' : s)
            .replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;').replace(/'/g, '&#39;');
    }
})();
