﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBP.Web.Models.Context;

namespace PBP.Web.Migrations.Suggestion
{
    [DbContext(typeof(SuggestionContext))]
    partial class SuggestionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PBP.Web.Models.Domain.Suggestion", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AcceptEmail");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("SendEmail");

                    b.Property<DateTime>("SendTime");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Guid");

                    b.ToTable("Suggestions");
                });
#pragma warning restore 612, 618
        }
    }
}
