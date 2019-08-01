using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EventsScreenProject.Models
{
    public class MyAppContext:DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EventField>(builder =>
            {
                builder.HasOne<Event>(c => c.MyEvent)
                    .WithMany(c => c.EventFields)
                    .HasForeignKey(c => c.EventId);

                builder.HasKey(c => c.Id);
            });

            modelBuilder.Entity<TemplateField>(builder =>
            {
                builder.HasOne<Template>(c => c.MyTemplate)
                    .WithMany(c => c.TemplateFields)
                    .HasForeignKey(c => c.TemplateId);

                builder.HasKey(c => c.Id);
            });

            modelBuilder.Entity<Event>(builder =>
            {
                builder.HasOne<Template>(c => c.MyTemplate)
                    .WithMany(c => c.Events)
                    .HasForeignKey(c => c.TemplateId);

                builder.HasKey(c => c.Id);
            });

            modelBuilder.Entity<EventField>(builder =>
            {
                builder.HasOne<TemplateField>(c => c.MyTemplateField)
                    .WithMany(c => c.EventFields)
                    .HasForeignKey(c => c.TemplateFiledId);

                builder.HasKey(c => c.Id);
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventField> EventFields { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateField> TemplateFields { get; set; }

    }
}
