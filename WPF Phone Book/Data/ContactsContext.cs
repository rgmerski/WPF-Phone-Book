using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace WPF_Phone_Book.Data
{
    public class Context : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }

        string physicalPath = @"Data Source=" + Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "Data"), "Database.db");
        //string physicalPath = @"Data Source=C:\book.db";

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite(physicalPath);
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\contacts.db");
    }
}
