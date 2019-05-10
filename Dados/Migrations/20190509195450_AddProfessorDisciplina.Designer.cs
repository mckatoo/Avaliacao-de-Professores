﻿// <auto-generated />
using System;
using Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dados.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190509195450_AddProfessorDisciplina")]
    partial class AddProfessorDisciplina
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Entidades.Ano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Numero");

                    b.HasKey("Id");

                    b.ToTable("Anos");
                });

            modelBuilder.Entity("Dominio.Entidades.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnoId");

                    b.Property<int?>("DisciplinaId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("AnoId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Dominio.Entidades.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Dominio.Entidades.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Dominio.Entidades.ProfessorDisciplina", b =>
                {
                    b.Property<int>("ProfessorId");

                    b.Property<int>("DisciplinaId");

                    b.HasKey("ProfessorId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("ProfessorDisciplinas");
                });

            modelBuilder.Entity("Dominio.Entidades.Curso", b =>
                {
                    b.HasOne("Dominio.Entidades.Ano", "Ano")
                        .WithMany()
                        .HasForeignKey("AnoId");

                    b.HasOne("Dominio.Entidades.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId");
                });

            modelBuilder.Entity("Dominio.Entidades.ProfessorDisciplina", b =>
                {
                    b.HasOne("Dominio.Entidades.Disciplina", "Disciplina")
                        .WithMany("ProfessorDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dominio.Entidades.Professor", "Professor")
                        .WithMany("ProfessorDisciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}