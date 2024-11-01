﻿namespace HospitalSystem.Persistance.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
        {
            public void Configure(EntityTypeBuilder<Patient> builder)
            {
                
                builder.ToTable("Patients");


                builder.Property(p => p.FirstName)
                       .IsRequired();
               
                builder.Property(p => p.LastName)
                        .IsRequired();


            builder.Property(p => p.ZipCode)
                       .HasMaxLength(20);

                builder.Property(p => p.City)
                       .HasMaxLength(100);

            builder.Property(p => p.Country)
                       .HasMaxLength(100);

                builder.Property(p => p.DateOfBirth)
                       .IsRequired();

            builder.Property(p => p.Gender)
                       .IsRequired();


            builder.HasMany(p => p.Appointments)
                       .WithOne(a => a.Patient)
                       .HasForeignKey(a => a.PatientID)
                       .OnDelete(DeleteBehavior.Cascade);

                builder.HasMany(p => p.MedicalRecords)
                       .WithOne(mr => mr.Patient)
                       .HasForeignKey(mr => mr.PatientID)
                       .OnDelete(DeleteBehavior.Cascade);
            }
        }
    }
