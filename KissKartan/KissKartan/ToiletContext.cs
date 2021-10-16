using System;
using Microsoft.EntityFrameworkCore;
using KissKartan.API.Models;

namespace KissKartan.API
{
    public class ToiletContext : DbContext
    {
        public DbSet<Toilet> Toilets { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<TypeProperty> Types { get; set; }
        public string DbPath { get; private set; }

        public ToiletContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}toilet.db";

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}
