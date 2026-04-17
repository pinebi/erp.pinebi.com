// Minimal service worker - PWA install prompt için gerekli
// Blazor Server SignalR kullandığından cache yapmıyoruz, sadece passthrough
self.addEventListener('install', (e) => { self.skipWaiting(); });
self.addEventListener('activate', (e) => { self.clients.claim(); });
self.addEventListener('fetch', (e) => { /* passthrough */ });
