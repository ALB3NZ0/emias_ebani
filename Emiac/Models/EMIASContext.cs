using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Emiac.Models
{
    public partial class EMIASContext : DbContext
    {
        public EMIASContext()
        {
        }

        public EMIASContext(DbContextOptions<EMIASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<AnalysDocument> AnalysDocuments { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<AppointmentDocument> AppointmentDocuments { get; set; } = null!;
        public virtual DbSet<Direction> Directions { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<ResearchDocument> ResearchDocuments { get; set; } = null!;
        public virtual DbSet<Specialite> Specialites { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("PK__Admin__69F567660FA7DF40");

                entity.ToTable("Admin");

                entity.Property(e => e.IdAdmin).HasColumnName("ID_Admin");

                entity.Property(e => e.EnterPassword).HasMaxLength(50);

                entity.Property(e => e.NameAdmin).HasMaxLength(50);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<AnalysDocument>(entity =>
            {
                entity.HasKey(e => e.IdAnalysDocument)
                    .HasName("PK__AnalysDo__2CCDFF7CF84E55F0");

                entity.ToTable("AnalysDocument");

                entity.Property(e => e.IdAnalysDocument).HasColumnName("Id_AnalysDocument");

                entity.Property(e => e.AppointmentsId).HasColumnName("Appointments_ID");

                
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.IdAppointments)
                    .HasName("PK__Appointm__D0ADF98A5913FAC5");

                entity.Property(e => e.IdAppointments).HasColumnName("ID_Appointments");

                entity.Property(e => e.AppointmentDate).HasColumnType("date");

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.Oms).HasColumnName("OMS");

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");


            });

            modelBuilder.Entity<AppointmentDocument>(entity =>
            {
                entity.HasKey(e => e.IdAppointmentDocument)
                    .HasName("PK__Appointm__ADE9B71564ADFCB7");

                entity.ToTable("AppointmentDocument");

                entity.Property(e => e.IdAppointmentDocument).HasColumnName("Id_AppointmentDocument");

                entity.Property(e => e.AppointmentsId).HasColumnName("Appointments_ID");


            });

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.HasKey(e => e.IdDirection)
                    .HasName("PK__Directio__59A79AAFE0632CD4");

                entity.Property(e => e.IdDirection).HasColumnName("ID_Direction");

                entity.Property(e => e.OmsId).HasColumnName("OMS_ID");

                entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");


            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.IdDoctor)
                    .HasName("PK__Doctor__3246951CE5E67E92");

                entity.ToTable("Doctor");

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.EnterPassword).HasMaxLength(50);

                entity.Property(e => e.NameDoctor).HasMaxLength(50);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.WorkAddress).HasMaxLength(50);


            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Oms)
                    .HasName("PK__Patient__CB396B8B71037F4C");

                entity.ToTable("Patient");

                entity.Property(e => e.Oms)
                    .ValueGeneratedNever()
                    .HasColumnName("OMS");

                entity.Property(e => e.AddressPatient).HasMaxLength(255);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LivingAddress).HasMaxLength(255);

                entity.Property(e => e.NamePatient).HasMaxLength(50);

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(18);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<ResearchDocument>(entity =>
            {
                entity.HasKey(e => e.IdResearchDocument)
                    .HasName("PK__Research__2A774A12EFBB1D15");

                entity.ToTable("ResearchDocument");

                entity.Property(e => e.IdResearchDocument).HasColumnName("Id_ResearchDocument");

                entity.Property(e => e.AppointmentsId).HasColumnName("Appointments_ID");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(1)
                    .IsFixedLength();

            });

            modelBuilder.Entity<Specialite>(entity =>
            {
                entity.HasKey(e => e.IdSpeciality)
                    .HasName("PK__Speciali__8D22304D1B4DD737");

                entity.Property(e => e.IdSpeciality).HasColumnName("ID_Speciality");

                entity.Property(e => e.NameSpecialites).HasMaxLength(50);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__Status__5AC2A734823035AA");

                entity.ToTable("Status");

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.NameStatus).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
