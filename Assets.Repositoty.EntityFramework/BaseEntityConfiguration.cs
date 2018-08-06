using Assets.Models;
using System.Data.Entity.ModelConfiguration;

namespace Assets.Repository.EntityFramework
{
   public abstract class BaseEntityConfiguration<TEntity> : EntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        protected BaseEntityConfiguration()
        {
            Property(e => e.StatusCd).HasColumnName("IsActive").HasColumnType("varchar").HasMaxLength(1).IsRequired();

            Property(e => e.RecordTimeStamp).HasColumnName("RecordTs").IsRowVersion().IsRequired();

            Property(a => a.CreateByUser).HasColumnName("CreatedUser").HasMaxLength(128).IsRequired();
            Property(a => a.UpdateByUser).HasColumnName("ModifiedUser").HasMaxLength(128).IsRequired();  

            Property(a => a.CreateDate).HasColumnName("CreateDateTime").IsRequired();
            Property(a => a.UpdateDate).HasColumnName("ModifiedDateTime").IsRequired();  
        }
    }
}
