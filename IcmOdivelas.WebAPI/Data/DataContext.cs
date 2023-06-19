using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcmOdivelas.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IcmOdivelas.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){ }       

        public DbSet<Member> Members { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MemberFunction> MemberFunctions { get; set; }     
        
    }
}