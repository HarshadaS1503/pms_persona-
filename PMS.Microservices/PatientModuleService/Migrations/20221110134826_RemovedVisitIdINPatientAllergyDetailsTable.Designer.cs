// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientModuleService.EfCoreSetup;

namespace PatientModuleService.Migrations
{
    [DbContext(typeof(PatientModuleContext))]
    [Migration("20221110134826_RemovedVisitIdINPatientAllergyDetailsTable")]
    partial class RemovedVisitIdINPatientAllergyDetailsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoginService.Models.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("LoginService.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenderID");

                    b.HasIndex("RoleID");

                    b.HasIndex("StatusID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LoginService.Models.Gender", b =>
                {
                    b.Property<int>("GenderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderID");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("LoginService.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("LoginService.Models.UserLogin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenderID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RememberMe")
                        .HasColumnType("bit");

                    b.Property<int?>("StatusID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("GenderID");

                    b.HasIndex("StatusID");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("PatientModuleService.Models.AllergyDetails", b =>
                {
                    b.Property<int>("AllergyDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyClinicalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllergyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllergyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllergyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllergyType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AllergyDetailsId");

                    b.ToTable("AllergyDetails");
                });

            modelBuilder.Entity("PatientModuleService.Models.Appointments", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("VisitId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("PatientModuleService.Models.DiagnosisDetails", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiagnosisCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiagnosisDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DiagnosisIsDepricated")
                        .HasColumnType("bit");

                    b.HasKey("DiagnosisId");

                    b.ToTable("DiagnosisDetails");
                });

            modelBuilder.Entity("PatientModuleService.Models.DrugDataDetails", b =>
                {
                    b.Property<int>("DrugId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DrugForm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugGenericName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugManufactureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugStrength")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrugId");

                    b.ToTable("DrugDataDetails");
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientAllergyDetails", b =>
                {
                    b.Property<int>("PatientAllergyDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergy_Clinical_Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Allergyid")
                        .HasColumnType("int");

                    b.Property<bool>("Is_Allergy_Fatal")
                        .HasColumnType("bit");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<int>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientAllergyDetailsId");

                    b.HasIndex("Allergyid");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientAllergyDetails");
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientDiagnosis", b =>
                {
                    b.Property<int>("PatientDiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<int>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientDiagnosisId");

                    b.HasIndex("DiagnosisId");

                    b.HasIndex("VisitId");

                    b.ToTable("PatientDiagnosis");
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientEmergencyContacts", b =>
                {
                    b.Property<int>("PatientEmergencyContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Contact")
                        .HasColumnType("bigint");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<int>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientEmergencyContactId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientEmergencyContacts");
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientMedication", b =>
                {
                    b.Property<int>("PatientMedicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dosage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrugId")
                        .HasColumnType("int");

                    b.Property<string>("Frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdon")
                        .HasColumnType("datetime2");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedon")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientMedicationId");

                    b.HasIndex("DrugId");

                    b.HasIndex("VisitId");

                    b.ToTable("PatientMedication");
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientProcedures", b =>
                {
                    b.Property<int>("PatientProceduresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProcedureId")
                        .HasColumnType("int");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<int>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientProceduresId");

                    b.HasIndex("ProcedureId");

                    b.HasIndex("VisitId");

                    b.ToTable("PatientProcedures");
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientVitals", b =>
                {
                    b.Property<int>("VisitVitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodPressure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BodyTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RespirationRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdon")
                        .HasColumnType("datetime2");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedon")
                        .HasColumnType("datetime2");

                    b.HasKey("VisitVitalId");

                    b.HasIndex("VisitId");

                    b.ToTable("PatientVitals");
                });

            modelBuilder.Entity("PatientModuleService.Models.ProcedureDetails", b =>
                {
                    b.Property<int>("ProcedureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProcedureCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcedureDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProcedureIsDepricated")
                        .HasColumnType("bit");

                    b.HasKey("ProcedureId");

                    b.ToTable("ProcedureDetails");
                });

            modelBuilder.Entity("LoginService.Models.ApplicationUser", b =>
                {
                    b.HasOne("LoginService.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoginService.Models.ApplicationRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID");

                    b.HasOne("LoginService.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoginService.Models.UserLogin", b =>
                {
                    b.HasOne("LoginService.Models.Gender", null)
                        .WithMany("Users")
                        .HasForeignKey("GenderID");

                    b.HasOne("LoginService.Models.Status", null)
                        .WithMany("Users")
                        .HasForeignKey("StatusID");
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientAllergyDetails", b =>
                {
                    b.HasOne("PatientModuleService.Models.AllergyDetails", "AllergyDetails")
                        .WithMany()
                        .HasForeignKey("Allergyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoginService.Models.ApplicationUser", "Users")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientDiagnosis", b =>
                {
                    b.HasOne("PatientModuleService.Models.DiagnosisDetails", "DiagnosisDetails")
                        .WithMany()
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientModuleService.Models.Appointments", "Appointments")
                        .WithMany()
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientEmergencyContacts", b =>
                {
                    b.HasOne("LoginService.Models.ApplicationUser", "Users")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientMedication", b =>
                {
                    b.HasOne("PatientModuleService.Models.DrugDataDetails", "DrugDataDetails")
                        .WithMany()
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientModuleService.Models.Appointments", "Appointments")
                        .WithMany()
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientProcedures", b =>
                {
                    b.HasOne("PatientModuleService.Models.ProcedureDetails", "ProcedureDetails")
                        .WithMany()
                        .HasForeignKey("ProcedureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientModuleService.Models.Appointments", "Appointments")
                        .WithMany()
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientModuleService.Models.PatientVitals", b =>
                {
                    b.HasOne("PatientModuleService.Models.Appointments", "Appointments")
                        .WithMany()
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
