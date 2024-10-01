﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Context;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(FinalDBContext))]
    [Migration("20241001104342_VerificaRelacionamento")]
    partial class VerificaRelacionamento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("backend.Entities.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailCadastro")
                        .HasColumnType("longtext");

                    b.Property<string>("Nickname")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeCadastro")
                        .HasColumnType("longtext");

                    b.Property<string>("SenhaCadastro")
                        .HasColumnType("longtext");

                    b.Property<string>("TelCadastro")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cadastros");
                });

            modelBuilder.Entity("backend.Entities.RegistroDePartida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CadastroId")
                        .HasColumnType("int");

                    b.Property<int>("QntDerrota")
                        .HasColumnType("int");

                    b.Property<int>("QntEmpate")
                        .HasColumnType("int");

                    b.Property<int>("QntPartida")
                        .HasColumnType("int");

                    b.Property<int>("QntVitoria")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CadastroId");

                    b.ToTable("RegistroDePartidas");
                });

            modelBuilder.Entity("backend.Entities.RegistroDePartida", b =>
                {
                    b.HasOne("backend.Entities.Cadastro", "Cadastro")
                        .WithMany("RegistroDePartidas")
                        .HasForeignKey("CadastroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cadastro");
                });

            modelBuilder.Entity("backend.Entities.Cadastro", b =>
                {
                    b.Navigation("RegistroDePartidas");
                });
#pragma warning restore 612, 618
        }
    }
}
