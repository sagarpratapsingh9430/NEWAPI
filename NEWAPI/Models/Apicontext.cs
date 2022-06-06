using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace NEWAPI.Models
{
    public class Apicontext : DbContext
    {

        public Apicontext(DbContextOptions<Apicontext> options) : base(options)
        {

        }
        public DbSet<ApiModel> MVCDemo6 { get; set; }

    }

}
