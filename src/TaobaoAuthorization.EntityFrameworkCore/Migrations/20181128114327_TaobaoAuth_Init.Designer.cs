﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaobaoAuthorization.EntityFrameworkCore;

namespace TaobaoAuthorization.Migrations
{
    [DbContext(typeof(TaobaoAuthorizationDbContext))]
    [Migration("20181128114327_TaobaoAuth_Init")]
    partial class TaobaoAuth_Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaobaoAuthorization.Authorizations.AuthOrder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AppKey");

                    b.Property<string>("AuthState")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AuthView")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<string>("Error")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ErrorDescription")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<long>("PartnerId");

                    b.Property<string>("RedirectUri")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("TaobaoCode")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId", "AppKey", "AuthState")
                        .IsUnique();

                    b.ToTable("AuthOrders");
                });

            modelBuilder.Entity("TaobaoAuthorization.Partners.Partner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsDisabled");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("PartnerKey")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PartnerName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SecretKey")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PartnerKey")
                        .IsUnique();

                    b.ToTable("Partners");
                });
#pragma warning restore 612, 618
        }
    }
}
