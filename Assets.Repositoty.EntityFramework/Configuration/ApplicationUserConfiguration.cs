using Assets.Models.Users;

namespace Assets.Repository.EntityFramework.Configuration
{
    public class ApplicationUserConfiguration : BaseEntityConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
            ToTable("ApplicationUsers");

            HasKey(s => s.Id); //configure primary key, we can also user [Key] attribute in the model

            Property(s => s.FirstName).HasMaxLength(256).IsRequired();
            Property(s => s.LastName).HasMaxLength(256).IsRequired();
            Property(s => s.UserName).HasMaxLength(256).IsRequired();
            Property(s => s.DateOfBirth).IsRequired();
            Property(s => s.Phone).HasMaxLength(128).IsRequired();
        }
    }
}
