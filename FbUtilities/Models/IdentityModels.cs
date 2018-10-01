using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FbUtilities.Models
{
    // You can add profile data for the user by adding more properties to your FbUtilitiesUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class FbUtilitiesUser : IdentityUser
    {
        public string Name { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<FbUtilitiesUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class FbUtilitiesDbContext : IdentityDbContext<FbUtilitiesUser>
    {
        public FbUtilitiesDbContext()
            : base("FacebokUtilitiesConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FbUtilitiesUser>().ToTable("FbUtilitiesUser").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        }

        public static FbUtilitiesDbContext Create()
        {
            return new FbUtilitiesDbContext();
        }
    }
}