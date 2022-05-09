using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Data
{
    public class MyWebApiContext:IdentityDbContext<ApplicationUser>
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options)
            :base(options)
        {

        }

        public DbSet<Conference> Conferences { get; set; }

       
    }
}
