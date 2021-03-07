﻿// <auto-generated />
using System;
using CadastroEstabelecimento.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroEstabelecimento.Migrations
{
    [DbContext(typeof(CadastroEstabelecimentoContext))]
    [Migration("20210306222227_criarstatus")]
    partial class criarstatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CadastroEstabelecimento.Models.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoriaDescricao");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("CadastroEstabelecimento.Models.Estabelecimentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Agencia");

                    b.Property<int>("CategoriasId");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj")
                        .IsRequired();

                    b.Property<string>("Conta");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<string>("Razao")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<int>("StatusID");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("CategoriasId");

                    b.ToTable("Estabelecimentos");
                });

            modelBuilder.Entity("CadastroEstabelecimento.Models.Estabelecimentos", b =>
                {
                    b.HasOne("CadastroEstabelecimento.Models.Categorias", "Categorias")
                        .WithMany("Estabelecimentos")
                        .HasForeignKey("CategoriasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
