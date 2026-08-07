using Hospital.WPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.WPF.Data
{
    public class HospitalPatientDbContext : DbContext
    {
        public HospitalPatientDbContext(DbContextOptions<HospitalPatientDbContext> options)
            : base(options)
        {
        }


        public DbSet<Patient> Patients => Set<Patient>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigurePatient(modelBuilder);
        }
        private static void ConfigurePatient(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patients");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.PatientNumber)
                .HasMaxLength(50)
                .IsRequired();
                entity.HasIndex(x => x.PatientNumber)
                .IsUnique();
                entity.Property(x => x.FullName)
                .HasMaxLength(100)
                .IsRequired();
                entity.Property(x => x.Email)
                .HasMaxLength(200);
                entity.HasIndex(x => x.Email);
                entity.Property(x => x.PhoneNumber)
                .HasMaxLength(20);
                entity.Property(x => x.Gender)
                .HasMaxLength(20);
    
            });
        }
    }
}
