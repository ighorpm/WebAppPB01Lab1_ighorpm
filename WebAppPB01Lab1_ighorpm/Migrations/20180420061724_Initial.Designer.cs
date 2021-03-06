﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebAppPB01Lab1_ighorpm.Models;

namespace WebAppPB01Lab1_ighorpm.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20180420061724_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppPB01Lab1_ighorpm.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF");

                    b.Property<DateTime>("DataCadastrada");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
