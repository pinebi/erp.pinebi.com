using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.Services;

/// <summary>
/// Startup'ta calisir. DbContext'teki model tablolarinda, fiziksel DB'de olmayan kolonlari
/// ALTER TABLE ile ekler. Property tipine gore SQL Server tipi uretir. Idempotent: mevcut
/// kolonlara dokunmaz, sadece eksikleri ekler. Yeni modele kolon eklemek icin sadece C# property
/// eklemeniz yeterli; uygulama ilk calistiginda otomatik sutun olusur.
/// </summary>
public static class AutoMigrator
{
    public static void SyncMissingColumns(DbContext ctx)
    {
        var conn = ctx.Database.GetDbConnection();
        if (conn.State != System.Data.ConnectionState.Open) conn.Open();

        foreach (var entity in ctx.Model.GetEntityTypes())
        {
            var tableName = entity.GetTableName();
            if (string.IsNullOrEmpty(tableName)) continue;
            var schema = entity.GetSchema() ?? "dbo";

            // Mevcut kolonlari cek
            var existing = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"SELECT c.name FROM sys.columns c
                                    INNER JOIN sys.tables t ON t.object_id = c.object_id
                                    INNER JOIN sys.schemas s ON s.schema_id = t.schema_id
                                    WHERE t.name = @tbl AND s.name = @sch";
                var p1 = cmd.CreateParameter(); p1.ParameterName = "@tbl"; p1.Value = tableName; cmd.Parameters.Add(p1);
                var p2 = cmd.CreateParameter(); p2.ParameterName = "@sch"; p2.Value = schema; cmd.Parameters.Add(p2);
                try
                {
                    using var rd = cmd.ExecuteReader();
                    while (rd.Read()) existing.Add(rd.GetString(0));
                }
                catch { continue; }
            }

            if (existing.Count == 0) continue; // Tablo yok, CreateTables zaten olusturacak

            int added = 0;
            foreach (var prop in entity.GetProperties())
            {
                var colName = prop.GetColumnName();
                if (string.IsNullOrEmpty(colName) || existing.Contains(colName)) continue;

                var sqlType = GetSqlType(prop);
                if (sqlType == null) continue;

                var nullable = prop.IsNullable ? "NULL" : "NOT NULL";
                var defaultVal = prop.IsNullable ? "" : GetDefault(prop);

                var ddl = $"ALTER TABLE [{schema}].[{tableName}] ADD [{colName}] {sqlType} {nullable} {defaultVal}".Trim();
                try
                {
                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = ddl;
                    cmd.ExecuteNonQuery();
                    added++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"AutoMigrator: {tableName}.{colName} eklenemedi: {ex.Message.Substring(0, Math.Min(120, ex.Message.Length))}");
                }
            }
            if (added > 0) Console.WriteLine($"AutoMigrator: {tableName} tablosuna {added} kolon eklendi.");
        }
    }

    private static string? GetSqlType(IProperty prop)
    {
        var clrType = Nullable.GetUnderlyingType(prop.ClrType) ?? prop.ClrType;
        var maxLen = prop.GetMaxLength();

        if (clrType == typeof(string))
            return maxLen.HasValue ? $"NVARCHAR({maxLen})" : "NVARCHAR(MAX)";
        if (clrType == typeof(int)) return "INT";
        if (clrType == typeof(long)) return "BIGINT";
        if (clrType == typeof(short)) return "SMALLINT";
        if (clrType == typeof(byte)) return "TINYINT";
        if (clrType == typeof(bool)) return "BIT";
        if (clrType == typeof(decimal)) return "DECIMAL(18,4)";
        if (clrType == typeof(double)) return "FLOAT";
        if (clrType == typeof(float)) return "REAL";
        if (clrType == typeof(DateTime)) return "DATETIME2";
        if (clrType == typeof(DateTimeOffset)) return "DATETIMEOFFSET";
        if (clrType == typeof(Guid)) return "UNIQUEIDENTIFIER";
        if (clrType == typeof(byte[])) return "VARBINARY(MAX)";
        return null;
    }

    private static string GetDefault(IProperty prop)
    {
        var clrType = Nullable.GetUnderlyingType(prop.ClrType) ?? prop.ClrType;
        if (clrType == typeof(string)) return "DEFAULT ''";
        if (clrType == typeof(bool)) return "DEFAULT 0";
        if (clrType == typeof(DateTime) || clrType == typeof(DateTimeOffset)) return "DEFAULT SYSDATETIME()";
        if (clrType == typeof(Guid)) return "DEFAULT NEWID()";
        // sayisal
        if (clrType.IsValueType) return "DEFAULT 0";
        return "";
    }
}
