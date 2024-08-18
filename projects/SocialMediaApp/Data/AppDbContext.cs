using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
using SocialMediaApp.Models;

namespace SocialMediaApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options):base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<FriendshipModel>Friends { get; set; }
        public DbSet<CommentModel>Comments { get; set; }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     // User-Post relationship
        //     modelBuilder.Entity<PostModel>()
        //         .HasOne(p => p.User)
        //         .WithMany(u => u.Posts)
        //         .HasForeignKey(p => p.UserId)
        //         .OnDelete(DeleteBehavior.Cascade); // Specify cascade delete behavior if needed

        //     // Post-Comment relationship
        //     modelBuilder.Entity<CommentModel>()
        //         .HasOne(c => c.Post)
        //         .WithMany(p => p.Comments)
        //         .HasForeignKey(c => c.PostId);

        //     // User-Comment relationship
        //     modelBuilder.Entity<CommentModel>()
        //         .HasOne(c => c.User)
        //         .WithMany(u => u.Comments)
        //         .HasForeignKey(c => c.UserId);

        //     // Friendship relationships
        //     modelBuilder.Entity<FriendshipModel>()
        //         .HasOne(f => f.User)
        //         .WithMany(u => u.Friendships)
        //         .HasForeignKey(f => f.UserId)
        //         .OnDelete(DeleteBehavior.Restrict);

        //     modelBuilder.Entity<FriendshipModel>()
        //         .HasOne(f => f.Friend)
        //         .WithMany()
        //         .HasForeignKey(f => f.FriendId)
        //         .OnDelete(DeleteBehavior.Restrict);
        // }
    }
} 