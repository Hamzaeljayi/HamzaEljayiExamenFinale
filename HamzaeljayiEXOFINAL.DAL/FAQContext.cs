using HamzaeljayiEXOFINAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HamzaeljayiEXOFINAL.DAL
{
    public class FAQContext : DbContext
    {
        public DbSet<FAQItem> FAQItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\MSSQLLocalDB;Database=FAQManagerDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FAQItem>().HasData(
                new FAQItem
                {
                    Id = 1,
                    Question = "Comment accéder au portail étudiant ?",
                    Answer = "Vous pouvez accéder via le site officiel du Collège LaSalle.",
                    Category = "Portail",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new FAQItem
                {
                    Id = 2,
                    Question = "Comment contacter le support informatique ?",
                    Answer = "Envoyez un courriel au support IT.",
                    Category = "Support",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new FAQItem
                {
                    Id = 3,
                    Question = "Quels sont les horaires du collège ?",
                    Answer = "Le collège est ouvert du lundi au vendredi.",
                    Category = "Général",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}

