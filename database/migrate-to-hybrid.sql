-- ============================================================
-- Pine -> Hibrit (Pine + Mikro) gecis scripti
-- ============================================================
-- Calistirilan hedef DB'ye 413 Mikro V16 tablosunun sema kopyasini ekler.
-- Kaynak: PineERP_Yeni (Mikro V16 template DB).
-- Mevcut Pine tablolarini (pine_*) ETKILEMEZ - yanina eklenir.
-- ============================================================
-- Kullanim:
--   USE [hedef_tenant_db];
--   :setvar SOURCE_DB PineERP_Yeni
--   EXEC sp_add_mikro_schema_to_current_db
-- Veya asagidaki blogu dogrudan hedef DB'de calistir.
-- ============================================================

DECLARE @t NVARCHAR(200), @sql NVARCHAR(MAX);
DECLARE @cnt INT = 0, @skip INT = 0;

DECLARE c CURSOR FOR
    SELECT TABLE_NAME
    FROM PineERP_Yeni.INFORMATION_SCHEMA.TABLES
    WHERE TABLE_TYPE = 'BASE TABLE'
      AND TABLE_NAME NOT IN (
        SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES
      );

OPEN c;
FETCH NEXT FROM c INTO @t;
WHILE @@FETCH_STATUS = 0
BEGIN
    SET @sql = 'SELECT TOP 0 * INTO ' + QUOTENAME(@t) +
               ' FROM PineERP_Yeni.dbo.' + QUOTENAME(@t);
    BEGIN TRY
        EXEC sp_executesql @sql;
        SET @cnt = @cnt + 1;
    END TRY
    BEGIN CATCH
        SET @skip = @skip + 1;
        PRINT 'SKIP ' + @t + ': ' + ERROR_MESSAGE();
    END CATCH
    FETCH NEXT FROM c INTO @t;
END
CLOSE c; DEALLOCATE c;

PRINT CAST(@cnt AS VARCHAR) + ' Mikro tablosu eklendi, ' + CAST(@skip AS VARCHAR) + ' atlandi.';
SELECT COUNT(*) AS toplam_tablo FROM INFORMATION_SCHEMA.TABLES;
