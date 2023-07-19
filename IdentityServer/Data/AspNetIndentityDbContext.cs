using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Data
{
    public class AspNetIndentityDbContext :IdentityDbContext
    {
        public AspNetIndentityDbContext(DbContextOptions<AspNetIndentityDbContext> options):base(options)
        {
            
        }
    }
}
