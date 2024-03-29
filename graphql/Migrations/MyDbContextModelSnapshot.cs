﻿// <auto-generated />
using System;
using graphqlAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Filme", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instrutor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Lancamento")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SuperHeroiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperHeroiId");

                    b.ToTable("Filmes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2ba6a240-e848-460b-9d04-ca3a909c23af"),
                            Descricao = "Batman Begins é um filme de super-herói de 2005 dirigido por Christopher Nolan e escrito por Nolan e David S. Goyer. Baseado no personagem Batman da DC Comics, é estrelado por Christian Bale como Bruce Wayne / Batman, com Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instrutor = "Christopher Nolan",
                            Lancamento = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperHeroiId = new Guid("9416cc13-a931-432b-9331-f65ceddcee12"),
                            Titulo = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("d951cf9b-8719-4ee8-b060-98c3b688c88c"),
                            Descricao = "O Cavaleiro das Trevas é um filme de super-herói de 2008 dirigido, produzido e co-escrito por Christopher Nolan. Baseado no personagem Batman da DC Comics, o filme é a segunda parcela da trilogia O Cavaleiro das Trevas de Nolan e uma sequência de Batman Begins de 2005, estrelado por Christian Bale e apoiado por Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal e Morgan Freeman.",
                            Instrutor = "Christopher Nolan",
                            Lancamento = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperHeroiId = new Guid("9416cc13-a931-432b-9331-f65ceddcee12"),
                            Titulo = "O Cavaleiro das trevas"
                        },
                        new
                        {
                            Id = new Guid("305ae1b5-7752-4e6d-96a3-71545a4b9981"),
                            Descricao = "O Cavaleiro das Trevas Ressurge é um filme de super-heróis de 2012 dirigido por Christopher Nolan, que co-escreveu o roteiro com seu irmão Jonathan Nolan, e a história com David S. Goyer.",
                            Instrutor = "Christopher Nolan",
                            Lancamento = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperHeroiId = new Guid("9416cc13-a931-432b-9331-f65ceddcee12"),
                            Titulo = "O Cavaleiro das trevas - Ressurreição"
                        },
                        new
                        {
                            Id = new Guid("cf8fb197-9ddf-4941-aa8c-930b15e7dbbc"),
                            Descricao = "Star Wars (intitulado retroativamente Star Wars: Episódio IV – Uma Nova Esperança) é um filme épico americano de ópera espacial de 1977 escrito e dirigido por George Lucas, produzido pela Lucasfilm e distribuído pela 20th Century Fox.",
                            Instrutor = "George Lucas",
                            Lancamento = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperHeroiId = new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"),
                            Titulo = "Guerra nas estrelas: Episode IV – Uma nova esperança"
                        },
                        new
                        {
                            Id = new Guid("72ab7eff-e2a4-4083-811d-9ac71a0117c2"),
                            Descricao = "The Empire Strikes Back (também conhecido como Star Wars: Episódio V – The Empire Strikes Back) é um filme épico americano de ópera espacial de 1980 dirigido por Irvin Kershner e escrito por Leigh Brackett e Lawrence Kasdan, baseado em uma história de George Lucas..",
                            Instrutor = "Irvin Kershner",
                            Lancamento = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperHeroiId = new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"),
                            Titulo = "Guera nas estrelas: Episode V – O império contra ataca"
                        },
                        new
                        {
                            Id = new Guid("1decb0b7-9e4d-4830-b88d-e1456ffa0a8b"),
                            Descricao = "O Retorno de Jedi (também conhecido como Star Wars: Episódio VI – O Retorno de Jedi) é um filme épico americano de ópera espacial de 1983, dirigido por Richard Marquand. O roteiro é de Lawrence Kasdan e George Lucas a partir de uma história de Lucas, que também foi produtor executivo.",
                            Instrutor = "Richard Marquand",
                            Lancamento = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperHeroiId = new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"),
                            Titulo = "Guerra nas Estrelas: Episode VI – O retorno de Jedi"
                        },
                        new
                        {
                            Id = new Guid("01e568ba-5288-4658-8328-26e55025635e"),
                            Descricao = "Viúva Negra é um filme de super-herói americano de 2021 baseado na Marvel Comics apresentando o personagem de mesmo nome. Produzido pela Marvel Studios e distribuído pela Walt Disney Studios Motion Pictures, é o 24º filme do Universo Cinematográfico Marvel (MCU).",
                            Instrutor = "Cate Shortland",
                            Lancamento = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperHeroiId = new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"),
                            Titulo = "Viúva Negra"
                        });
                });

            modelBuilder.Entity("Domain.Models.SuperHeroi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SuperHerois");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9416cc13-a931-432b-9331-f65ceddcee12"),
                            Altura = 1.9299999999999999,
                            Descricao = "Batman foi originalmente apresentado como um vigilante implacável que frequentemente matava ou mutilava criminosos, mas evoluiu para um personagem com um código moral rigoroso e um forte senso de justiça. Ao contrário da maioria dos super-heróis, Batman não possui superpoderes, confiando apenas em seu intelecto, habilidades de luta e riqueza.",
                            Nome = "Batman"
                        },
                        new
                        {
                            Id = new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"),
                            Altura = 1.7,
                            Descricao = "Luke Skywalker era um fazendeiro de Tatooine que cresceu de origens humildes para se tornar um dos maiores Jedi que a galáxia já conheceu. Junto com seus amigos Princesa Leia e Han Solo, Luke lutou contra o Império do mal, descobriu a verdade sobre sua ascendência e acabou com a tirania dos Sith..",
                            Nome = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"),
                            Altura = 1.7,
                            Descricao = "Viúva Negra, cujo nome verdadeiro é Natasha Romanoff, é uma agente secreta e super-heroína treinada que aparece na Marvel Comics. Associado às equipes de super-heróis S.H.I.E.L.D. e os Vingadores, a Viúva Negra compensa sua falta de superpoderes com treinamento de nível mundial como atleta, acrobata, especialista em artes marciais e especialista em armas.",
                            Nome = "Viúva Negra"
                        });
                });

            modelBuilder.Entity("graphqlAPI.Models.SuperPoder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SuperHeroiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Super_Poder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperHeroiId");

                    b.ToTable("SuperPoderes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f7c0bac-6119-4370-8fdf-4f8d983b1620"),
                            Descricao = "Sempre esta a um passo a frente",
                            SuperHeroiId = new Guid("9416cc13-a931-432b-9331-f65ceddcee12"),
                            SuperPoder = "Inteligência"
                        },
                        new
                        {
                            Id = new Guid("dae1ebef-8e1c-4dcf-8b2b-354dfb416ba5"),
                            Descricao = "Habilidades de luta especiais",
                            SuperHeroiId = new Guid("9416cc13-a931-432b-9331-f65ceddcee12"),
                            SuperPoder = "Luta"
                        },
                        new
                        {
                            Id = new Guid("f7273626-0aec-435f-9b88-931483608475"),
                            Descricao = "Possui muito dinheiro",
                            SuperHeroiId = new Guid("9416cc13-a931-432b-9331-f65ceddcee12"),
                            SuperPoder = "Fortuna"
                        },
                        new
                        {
                            Id = new Guid("170a204f-6665-4287-8f96-7ecee1edaff2"),
                            Descricao = "Skywalker é capaz de desviar o fogo de um blaster de volta para o oponente que está atirando.",
                            SuperHeroiId = new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"),
                            SuperPoder = "Desvia o poder do blaster."
                        },
                        new
                        {
                            Id = new Guid("5cf9ae17-26d5-4389-aca6-1dcced8eabad"),
                            Descricao = "Conhece técnicas para espionar as pessoas.",
                            SuperHeroiId = new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"),
                            SuperPoder = "Espionagem"
                        },
                        new
                        {
                            Id = new Guid("e0af1b89-2aa6-4d2e-852b-822f080ff1b2"),
                            Descricao = "Sabe como se infiltrar no inimigo.",
                            SuperHeroiId = new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"),
                            SuperPoder = "Infiltração"
                        },
                        new
                        {
                            Id = new Guid("eb174f2b-574f-449e-a212-7911cef0494e"),
                            Descricao = "Tem o conhecimento de como minar os outros.",
                            SuperHeroiId = new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"),
                            SuperPoder = "Subterfúgio"
                        });
                });

            modelBuilder.Entity("Domain.Models.Filme", b =>
                {
                    b.HasOne("Domain.Models.SuperHeroi", "SuperHeroi")
                        .WithMany("Filmes")
                        .HasForeignKey("SuperHeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SuperHeroi");
                });

            modelBuilder.Entity("graphqlAPI.Models.SuperPoder", b =>
                {
                    b.HasOne("Domain.Models.SuperHeroi", "SuperHeroi")
                        .WithMany("SuperPoderes")
                        .HasForeignKey("SuperHeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SuperHeroi");
                });

            modelBuilder.Entity("Domain.Models.SuperHeroi", b =>
                {
                    b.Navigation("Filmes");

                    b.Navigation("SuperPoderes");
                });
#pragma warning restore 612, 618
        }
    }
}
