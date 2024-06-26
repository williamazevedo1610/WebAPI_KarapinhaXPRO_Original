﻿// <auto-generated />
using System;
using K.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace K.DAL.Migrations
{
    [DbContext(typeof(KarapinhaContext))]
    [Migration("20240614214958_CorrectServicoMigration")]
    partial class CorrectServicoMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("K.Model.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("K.Model.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("K.Model.Marcacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Perfil")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("TotalPagar")
                        .HasColumnType("float");

                    b.Property<int?>("UtilizadorID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UtilizadorID");

                    b.ToTable("Marcacaos");
                });

            modelBuilder.Entity("K.Model.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perfis");
                });

            modelBuilder.Entity("K.Model.Profissional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BilheteIden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fotografia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServicoID")
                        .HasColumnType("int");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServicoID");

                    b.ToTable("Profissionals");
                });

            modelBuilder.Entity("K.Model.ProfissionalHorario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HorarioID")
                        .HasColumnType("int");

                    b.Property<int>("ProfissionalID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HorarioID");

                    b.HasIndex("ProfissionalID");

                    b.ToTable("ProfissionalsHorarios");
                });

            modelBuilder.Entity("K.Model.Servico", b =>
                {
                    b.Property<int>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServico"));

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("IdServico");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("K.Model.ServicoMarcacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<TimeOnly>("Hora")
                        .HasColumnType("time");

                    b.Property<int>("MarcacaoId")
                        .HasColumnType("int");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcacaoId");

                    b.HasIndex("ServicoId");

                    b.ToTable("ServicoMarcacaos");
                });

            modelBuilder.Entity("K.Model.Utilizador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Activar")
                        .HasColumnType("bit");

                    b.Property<string>("BilheteIden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PerfilID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("telefone")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PerfilID");

                    b.ToTable("Utilizadors");
                });

            modelBuilder.Entity("K.Model.Marcacao", b =>
                {
                    b.HasOne("K.Model.Utilizador", "User")
                        .WithMany()
                        .HasForeignKey("UtilizadorID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("K.Model.Profissional", b =>
                {
                    b.HasOne("K.Model.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("K.Model.ProfissionalHorario", b =>
                {
                    b.HasOne("K.Model.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("K.Model.Profissional", "Profissional")
                        .WithMany()
                        .HasForeignKey("ProfissionalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Horario");

                    b.Navigation("Profissional");
                });

            modelBuilder.Entity("K.Model.Servico", b =>
                {
                    b.HasOne("K.Model.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("K.Model.ServicoMarcacao", b =>
                {
                    b.HasOne("K.Model.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("K.Model.Marcacao", "Marcacao")
                        .WithMany()
                        .HasForeignKey("MarcacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("K.Model.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marcacao");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("K.Model.Utilizador", b =>
                {
                    b.HasOne("K.Model.Perfil", "perfil")
                        .WithMany()
                        .HasForeignKey("PerfilID");

                    b.Navigation("perfil");
                });
#pragma warning restore 612, 618
        }
    }
}
