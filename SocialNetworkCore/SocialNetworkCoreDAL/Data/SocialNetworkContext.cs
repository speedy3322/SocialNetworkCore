using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetworkCoreDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetworkCoreDAL.Data
{
    public class SocialNetworkContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Membership> Memberships { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);            
        }
    }
}
