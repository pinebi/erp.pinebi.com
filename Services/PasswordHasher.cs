namespace MACHINEBISS_Web.Services
{
    /// <summary>
    /// BCrypt tabanli sifre hashleme ve dogrulama servisi.
    /// Mevcut duz metin sifreler icin otomatik migration desteklenir.
    /// </summary>
    public static class PasswordHasher
    {
        private const int WorkFactor = 11;

        /// <summary>
        /// Yeni bir sifreyi BCrypt ile hashler.
        /// </summary>
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, WorkFactor);
        }

        /// <summary>
        /// Verilen sifrenin hash ile eslesip eslesmedigini kontrol eder.
        /// Eger DB'deki deger BCrypt formatinda degilse (eski duz metin), duz karsilastirma yapar
        /// ve cagiran tarafa migration gerektigini bildirir (needsMigration = true).
        /// </summary>
        public static bool Verify(string password, string? storedHash, out bool needsMigration)
        {
            needsMigration = false;

            if (string.IsNullOrEmpty(storedHash))
                return false;

            // BCrypt hash'leri $2a$, $2b$, $2y$ ile baslar
            if (storedHash.StartsWith("$2a$") || storedHash.StartsWith("$2b$") || storedHash.StartsWith("$2y$"))
            {
                try
                {
                    return BCrypt.Net.BCrypt.Verify(password, storedHash);
                }
                catch
                {
                    return false;
                }
            }

            // Eski duz metin sifre — gecici olarak kabul et ama migration gerekli
            if (storedHash == password)
            {
                needsMigration = true;
                return true;
            }

            return false;
        }
    }
}
