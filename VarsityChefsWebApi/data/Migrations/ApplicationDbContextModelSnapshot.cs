﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VarsityChefsWebApi.data.DbContext;

namespace VarsityChefsWebApi.data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VarsityChefsWebApi.Models.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdentityId");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId");

                    b.ToTable("Applicants");
                });

            modelBuilder.Entity("VarsityChefsWebApi.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allegies");

                    b.Property<int>("ApplicantId");

                    b.Property<string>("BootSize");

                    b.Property<string>("CellNumber");

                    b.Property<string>("DateOfBirth");

                    b.Property<DateTime>("DateRegistered");

                    b.Property<bool>("Declaration");

                    b.Property<string>("Disability");

                    b.Property<bool>("DoYouHaveAnyAllegies");

                    b.Property<bool>("DoYouHaveAnyDisability");

                    b.Property<bool>("DoYouHaveApermentResidence");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("Gender");

                    b.Property<bool>("HaveYouOrYourParentsBeenEmployedByVarsityChefs");

                    b.Property<bool>("HaveYouParticipatedInCookingShowBefore");

                    b.Property<string>("IdNumber");

                    b.Property<string>("Institution");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("JacketSize");

                    b.Property<string>("LastName");

                    b.Property<string>("Nationality");

                    b.Property<string>("PassportNumber");

                    b.Property<string>("Qualification");

                    b.Property<bool>("Status");

                    b.Property<string>("Telephone");

                    b.Property<string>("WhichCookingShows");

                    b.Property<string>("YearOfStudy");

                    b.Property<string>("YearStarted");

                    b.HasKey("Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("AuthWebApi.Models.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<long?>("FacebookId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PictureUrl");

                    b.ToTable("AppUser");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VarsityChefsWebApi.Models.Applicant", b =>
                {
                    b.HasOne("AuthWebApi.Models.Entities.AppUser", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId");
                });

            modelBuilder.Entity("VarsityChefsWebApi.Models.Application", b =>
                {
                    b.OwnsOne("VarsityChefsWebApi.Models.AlternativePerson", "AlternativePerson", b1 =>
                        {
                            b1.Property<int?>("ApplicationId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("AlternativeCellNumber");

                            b1.Property<string>("AlternativeEmailAddress");

                            b1.Property<string>("AlternativeInitials");

                            b1.Property<string>("AlternativeName");

                            b1.Property<string>("AlternativeRelationShip");

                            b1.Property<string>("AlternativeSurname");

                            b1.Property<string>("AlternativeTelephone");

                            b1.ToTable("Applications");

                            b1.HasOne("VarsityChefsWebApi.Models.Application")
                                .WithOne("AlternativePerson")
                                .HasForeignKey("VarsityChefsWebApi.Models.AlternativePerson", "ApplicationId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.OwnsOne("VarsityChefsWebApi.Models.AlternativeAddress", "AlternativeAddress", b2 =>
                                {
                                    b2.Property<int?>("AlternativePersonApplicationId")
                                        .ValueGeneratedOnAdd()
                                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                                    b2.Property<string>("AlternativeCity");

                                    b2.Property<string>("AlternativeCode");

                                    b2.Property<string>("AlternativeCountry");

                                    b2.Property<string>("AlternativeLine1");

                                    b2.Property<string>("AlternativeLine2");

                                    b2.Property<string>("AlternativeLine3");

                                    b2.Property<string>("AlternativeProvince");

                                    b2.Property<string>("AlternativeSurburb");

                                    b2.ToTable("Applications");

                                    b2.HasOne("VarsityChefsWebApi.Models.AlternativePerson")
                                        .WithOne("AlternativeAddress")
                                        .HasForeignKey("VarsityChefsWebApi.Models.AlternativeAddress", "AlternativePersonApplicationId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });
                        });

                    b.OwnsOne("VarsityChefsWebApi.Models.PostalAddress", "PostalAddress", b1 =>
                        {
                            b1.Property<int?>("ApplicationId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("PostalCity");

                            b1.Property<string>("PostalCode");

                            b1.Property<string>("PostalCountry");

                            b1.Property<string>("PostalLine1");

                            b1.Property<string>("PostalLine2");

                            b1.Property<string>("PostalLine3");

                            b1.Property<string>("PostalProvince");

                            b1.Property<string>("PostalSurburb");

                            b1.ToTable("Applications");

                            b1.HasOne("VarsityChefsWebApi.Models.Application")
                                .WithOne("PostalAddress")
                                .HasForeignKey("VarsityChefsWebApi.Models.PostalAddress", "ApplicationId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("VarsityChefsWebApi.Models.ResidentialAddress", "ResidentialAddress", b1 =>
                        {
                            b1.Property<int?>("ApplicationId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("ResCity");

                            b1.Property<string>("ResCode");

                            b1.Property<string>("ResCountry");

                            b1.Property<string>("ResLine1");

                            b1.Property<string>("ResLine2");

                            b1.Property<string>("ResLine3");

                            b1.Property<string>("ResProvince");

                            b1.Property<string>("ResSurburb");

                            b1.ToTable("Applications");

                            b1.HasOne("VarsityChefsWebApi.Models.Application")
                                .WithOne("ResidentialAddress")
                                .HasForeignKey("VarsityChefsWebApi.Models.ResidentialAddress", "ApplicationId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
