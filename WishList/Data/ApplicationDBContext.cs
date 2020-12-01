using System;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}
