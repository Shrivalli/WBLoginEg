using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginEg.Models
{
    public class WBProjectContext:DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WBProjectContext()
        {

        }
        public WBProjectContext(DbContextOptions options,IHttpContextAccessor httpContextAccessor) :base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<User> Users { get; set; }
    }
}
