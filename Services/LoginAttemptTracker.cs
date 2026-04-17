using System.Collections.Concurrent;

namespace MACHINEBISS_Web.Services
{
    /// <summary>
    /// Kullanici adi bazli basarisiz giris denemelerini takip eder.
    /// 5 basarisiz deneme sonrasi 15 dakika kilitlenir.
    /// In-memory — uygulama restart olursa sifirlanir.
    /// </summary>
    public class LoginAttemptTracker
    {
        private const int MaxAttempts = 5;
        private static readonly TimeSpan LockDuration = TimeSpan.FromMinutes(15);

        private class AttemptInfo
        {
            public int FailedCount;
            public DateTime? LockedUntil;
            public DateTime LastAttempt = DateTime.UtcNow;
        }

        private readonly ConcurrentDictionary<string, AttemptInfo> _attempts = new(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Kullanici kilitli mi? Kilitliyse kalan sureyi dakika cinsinden dondurur.
        /// </summary>
        public bool IsLocked(string username, out int remainingMinutes)
        {
            remainingMinutes = 0;
            if (string.IsNullOrWhiteSpace(username)) return false;

            if (_attempts.TryGetValue(username, out var info) && info.LockedUntil.HasValue)
            {
                if (info.LockedUntil.Value > DateTime.UtcNow)
                {
                    remainingMinutes = (int)Math.Ceiling((info.LockedUntil.Value - DateTime.UtcNow).TotalMinutes);
                    return true;
                }
                else
                {
                    // Kilit suresi dolmus, sifirla
                    info.FailedCount = 0;
                    info.LockedUntil = null;
                }
            }
            return false;
        }

        /// <summary>
        /// Basarisiz bir deneme kaydeder. Limit asilirsa kullaniciyi kilitler.
        /// </summary>
        public void RegisterFailedAttempt(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return;

            var info = _attempts.GetOrAdd(username, _ => new AttemptInfo());
            lock (info)
            {
                info.FailedCount++;
                info.LastAttempt = DateTime.UtcNow;
                if (info.FailedCount >= MaxAttempts)
                {
                    info.LockedUntil = DateTime.UtcNow.Add(LockDuration);
                }
            }
        }

        /// <summary>
        /// Basarili giris sonrasi sayaclari sifirlar.
        /// </summary>
        public void ResetAttempts(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return;
            _attempts.TryRemove(username, out _);
        }

        /// <summary>
        /// Kalan deneme hakki.
        /// </summary>
        public int RemainingAttempts(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return MaxAttempts;
            if (_attempts.TryGetValue(username, out var info))
            {
                return Math.Max(0, MaxAttempts - info.FailedCount);
            }
            return MaxAttempts;
        }
    }
}
