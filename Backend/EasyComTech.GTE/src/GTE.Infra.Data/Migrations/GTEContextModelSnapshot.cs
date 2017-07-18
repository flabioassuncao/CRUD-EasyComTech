using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GTE.Infra.Data.Context;

namespace GTE.Infra.Data.Migrations
{
    [DbContext(typeof(GTEContext))]
    partial class GTEContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GTE.Domain.Entities.AccountType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("AccountType");
                });

            modelBuilder.Entity("GTE.Domain.Entities.BankInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber");

                    b.Property<Guid>("AccountTypeId");

                    b.Property<string>("Agency");

                    b.Property<string>("Bank");

                    b.Property<string>("CPF");

                    b.Property<string>("Name");

                    b.Property<Guid?>("ProgrammerId");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.ToTable("BankInformation");
                });

            modelBuilder.Entity("GTE.Domain.Entities.BestTimeToWork", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("BestTimeToWork");
                });

            modelBuilder.Entity("GTE.Domain.Entities.Knowledge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LevelOfKnowledgeAndroid");

                    b.Property<int>("LevelOfKnowledgeAngularJs");

                    b.Property<int>("LevelOfKnowledgeAspNetMVC");

                    b.Property<int>("LevelOfKnowledgeBootstrap");

                    b.Property<int>("LevelOfKnowledgeC");

                    b.Property<int>("LevelOfKnowledgeCPlusPlus");

                    b.Property<int>("LevelOfKnowledgeCSS");

                    b.Property<int>("LevelOfKnowledgeCake");

                    b.Property<int>("LevelOfKnowledgeDjango");

                    b.Property<int>("LevelOfKnowledgeHTML");

                    b.Property<int>("LevelOfKnowledgeIOS");

                    b.Property<int>("LevelOfKnowledgeIllustrator");

                    b.Property<int>("LevelOfKnowledgeIonic");

                    b.Property<int>("LevelOfKnowledgeJava");

                    b.Property<int>("LevelOfKnowledgeJquery");

                    b.Property<int>("LevelOfKnowledgeMajento");

                    b.Property<int>("LevelOfKnowledgeMySQL");

                    b.Property<int>("LevelOfKnowledgeMySQLServer");

                    b.Property<int>("LevelOfKnowledgePHP");

                    b.Property<int>("LevelOfKnowledgePhotoshop");

                    b.Property<int>("LevelOfKnowledgePhyton");

                    b.Property<int>("LevelOfKnowledgeRuby");

                    b.Property<int>("LevelOfKnowledgeSEO");

                    b.Property<int>("LevelOfKnowledgeSalesforce");

                    b.Property<int>("LevelOfKnowledgeWordpress");

                    b.Property<string>("LinkCRUD");

                    b.Property<string>("OtherLanguageOrFramework");

                    b.Property<Guid?>("ProgrammerId");

                    b.HasKey("Id");

                    b.ToTable("Knowledge");
                });

            modelBuilder.Entity("GTE.Domain.Entities.OccupationArea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BestTimeToWorkId");

                    b.Property<string>("City");

                    b.Property<decimal>("HourlySalaryRequirements");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Portfolio");

                    b.Property<Guid?>("ProgrammerId");

                    b.Property<string>("Skype");

                    b.Property<string>("State");

                    b.Property<Guid>("WillingnessToWorkId");

                    b.HasKey("Id");

                    b.HasIndex("BestTimeToWorkId");

                    b.HasIndex("WillingnessToWorkId");

                    b.ToTable("OccupationArea");
                });

            modelBuilder.Entity("GTE.Domain.Entities.Programmer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BankInformationId");

                    b.Property<string>("Email");

                    b.Property<bool>("Excluded");

                    b.Property<Guid>("KnowledgeId");

                    b.Property<Guid>("OccupationAreaId");

                    b.HasKey("Id");

                    b.HasIndex("BankInformationId")
                        .IsUnique();

                    b.HasIndex("KnowledgeId")
                        .IsUnique();

                    b.HasIndex("OccupationAreaId")
                        .IsUnique();

                    b.ToTable("Programmer");
                });

            modelBuilder.Entity("GTE.Domain.Entities.WillingnessToWork", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("WillingnessToWork");
                });

            modelBuilder.Entity("GTE.Domain.Entities.BankInformation", b =>
                {
                    b.HasOne("GTE.Domain.Entities.AccountType", "AccountType")
                        .WithMany("BankInformation")
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GTE.Domain.Entities.OccupationArea", b =>
                {
                    b.HasOne("GTE.Domain.Entities.BestTimeToWork", "BestTimeToWork")
                        .WithMany("OccupationArea")
                        .HasForeignKey("BestTimeToWorkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GTE.Domain.Entities.WillingnessToWork", "WillingnessToWork")
                        .WithMany("OccupationArea")
                        .HasForeignKey("WillingnessToWorkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GTE.Domain.Entities.Programmer", b =>
                {
                    b.HasOne("GTE.Domain.Entities.BankInformation", "BankInformation")
                        .WithOne("Programmer")
                        .HasForeignKey("GTE.Domain.Entities.Programmer", "BankInformationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GTE.Domain.Entities.Knowledge", "Knowledge")
                        .WithOne("Programmer")
                        .HasForeignKey("GTE.Domain.Entities.Programmer", "KnowledgeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GTE.Domain.Entities.OccupationArea", "OccupationArea")
                        .WithOne("Programmer")
                        .HasForeignKey("GTE.Domain.Entities.Programmer", "OccupationAreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
