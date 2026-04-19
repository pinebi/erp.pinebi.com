using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Db;

/// <summary>
/// Mikro entity'lerinin [Key] attribute'u yok; OnModelCreating'te konvansiyona gore PK set edilir:
///   1. Property adi "Guid" ile bitiyorsa -> PK
///   2. "RecId" -> PK
///   3. Hicbiri yoksa ilk property -> PK
/// </summary>
public partial class MikroContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.FindPrimaryKey() != null) continue;
            var props = entityType.ClrType
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead && p.CanWrite)
                .ToList();

            var guidProp = props.FirstOrDefault(p => p.Name.EndsWith("Guid", StringComparison.Ordinal));
            var recIdProp = props.FirstOrDefault(p => p.Name == "RecId");
            var keyProp = guidProp ?? recIdProp ?? props.FirstOrDefault();

            if (keyProp != null)
                modelBuilder.Entity(entityType.ClrType).HasKey(keyProp.Name);
            else
                modelBuilder.Entity(entityType.ClrType).HasNoKey();
        }
    }
}
