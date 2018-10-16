using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoSessionCookie.Models
{
    public class DemoSessionCookieContext : DbContext
    {
        public DemoSessionCookieContext (DbContextOptions<DemoSessionCookieContext> options)
            : base(options)
        {
        }

        public DbSet<DemoSessionCookie.Models.User> User { get; set; }
    }
}
