using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class newEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentModel");

            migrationBuilder.DropTable(
                name: "PropertyModel");

            migrationBuilder.CreateTable(
                name: "SuperHerois",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altura = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHerois", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instrutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuperHeroiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmes_SuperHerois_SuperHeroiId",
                        column: x => x.SuperHeroiId,
                        principalTable: "SuperHerois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuperPoderes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuperPoder = table.Column<string>(name: "Super_Poder", type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperHeroiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperPoderes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuperPoderes_SuperHerois_SuperHeroiId",
                        column: x => x.SuperHeroiId,
                        principalTable: "SuperHerois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SuperHerois",
                columns: new[] { "Id", "Altura", "Descricao", "Nome" },
                values: new object[,]
                {
                    { new Guid("9416cc13-a931-432b-9331-f65ceddcee12"), 1.9299999999999999, "Batman foi originalmente apresentado como um vigilante implacável que frequentemente matava ou mutilava criminosos, mas evoluiu para um personagem com um código moral rigoroso e um forte senso de justiça. Ao contrário da maioria dos super-heróis, Batman não possui superpoderes, confiando apenas em seu intelecto, habilidades de luta e riqueza.", "Batman" },
                    { new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"), 1.7, "Viúva Negra, cujo nome verdadeiro é Natasha Romanoff, é uma agente secreta e super-heroína treinada que aparece na Marvel Comics. Associado às equipes de super-heróis S.H.I.E.L.D. e os Vingadores, a Viúva Negra compensa sua falta de superpoderes com treinamento de nível mundial como atleta, acrobata, especialista em artes marciais e especialista em armas.", "Viúva Negra" },
                    { new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"), 1.7, "Luke Skywalker era um fazendeiro de Tatooine que cresceu de origens humildes para se tornar um dos maiores Jedi que a galáxia já conheceu. Junto com seus amigos Princesa Leia e Han Solo, Luke lutou contra o Império do mal, descobriu a verdade sobre sua ascendência e acabou com a tirania dos Sith..", "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Descricao", "Instrutor", "Lancamento", "SuperHeroiId", "Titulo" },
                values: new object[,]
                {
                    { new Guid("01e568ba-5288-4658-8328-26e55025635e"), "Viúva Negra é um filme de super-herói americano de 2021 baseado na Marvel Comics apresentando o personagem de mesmo nome. Produzido pela Marvel Studios e distribuído pela Walt Disney Studios Motion Pictures, é o 24º filme do Universo Cinematográfico Marvel (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"), "Viúva Negra" },
                    { new Guid("1decb0b7-9e4d-4830-b88d-e1456ffa0a8b"), "O Retorno de Jedi (também conhecido como Star Wars: Episódio VI – O Retorno de Jedi) é um filme épico americano de ópera espacial de 1983, dirigido por Richard Marquand. O roteiro é de Lawrence Kasdan e George Lucas a partir de uma história de Lucas, que também foi produtor executivo.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"), "Guerra nas Estrelas: Episode VI – O retorno de Jedi" },
                    { new Guid("2ba6a240-e848-460b-9d04-ca3a909c23af"), "Batman Begins é um filme de super-herói de 2005 dirigido por Christopher Nolan e escrito por Nolan e David S. Goyer. Baseado no personagem Batman da DC Comics, é estrelado por Christian Bale como Bruce Wayne / Batman, com Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9416cc13-a931-432b-9331-f65ceddcee12"), "Batman Begins" },
                    { new Guid("305ae1b5-7752-4e6d-96a3-71545a4b9981"), "O Cavaleiro das Trevas Ressurge é um filme de super-heróis de 2012 dirigido por Christopher Nolan, que co-escreveu o roteiro com seu irmão Jonathan Nolan, e a história com David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9416cc13-a931-432b-9331-f65ceddcee12"), "O Cavaleiro das trevas - Ressurreição" },
                    { new Guid("72ab7eff-e2a4-4083-811d-9ac71a0117c2"), "The Empire Strikes Back (também conhecido como Star Wars: Episódio V – The Empire Strikes Back) é um filme épico americano de ópera espacial de 1980 dirigido por Irvin Kershner e escrito por Leigh Brackett e Lawrence Kasdan, baseado em uma história de George Lucas..", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"), "Guera nas estrelas: Episode V – O império contra ataca" },
                    { new Guid("cf8fb197-9ddf-4941-aa8c-930b15e7dbbc"), "Star Wars (intitulado retroativamente Star Wars: Episódio IV – Uma Nova Esperança) é um filme épico americano de ópera espacial de 1977 escrito e dirigido por George Lucas, produzido pela Lucasfilm e distribuído pela 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"), "Guerra nas estrelas: Episode IV – Uma nova esperança" },
                    { new Guid("d951cf9b-8719-4ee8-b060-98c3b688c88c"), "O Cavaleiro das Trevas é um filme de super-herói de 2008 dirigido, produzido e co-escrito por Christopher Nolan. Baseado no personagem Batman da DC Comics, o filme é a segunda parcela da trilogia O Cavaleiro das Trevas de Nolan e uma sequência de Batman Begins de 2005, estrelado por Christian Bale e apoiado por Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal e Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9416cc13-a931-432b-9331-f65ceddcee12"), "O Cavaleiro das trevas" }
                });

            migrationBuilder.InsertData(
                table: "SuperPoderes",
                columns: new[] { "Id", "Descricao", "SuperHeroiId", "Super_Poder" },
                values: new object[,]
                {
                    { new Guid("170a204f-6665-4287-8f96-7ecee1edaff2"), "Skywalker é capaz de desviar o fogo de um blaster de volta para o oponente que está atirando.", new Guid("f0f0ff80-f94c-44c0-aa51-27fb6d40930a"), "Desvia o poder do blaster." },
                    { new Guid("4f7c0bac-6119-4370-8fdf-4f8d983b1620"), "Sempre esta a um passo a frente", new Guid("9416cc13-a931-432b-9331-f65ceddcee12"), "Inteligência" },
                    { new Guid("5cf9ae17-26d5-4389-aca6-1dcced8eabad"), "Conhece técnicas para espionar as pessoas.", new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"), "Espionagem" },
                    { new Guid("dae1ebef-8e1c-4dcf-8b2b-354dfb416ba5"), "Habilidades de luta especiais", new Guid("9416cc13-a931-432b-9331-f65ceddcee12"), "Luta" },
                    { new Guid("e0af1b89-2aa6-4d2e-852b-822f080ff1b2"), "Sabe como se infiltrar no inimigo.", new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"), "Infiltração" },
                    { new Guid("eb174f2b-574f-449e-a212-7911cef0494e"), "Tem o conhecimento de como minar os outros.", new Guid("dedfeb26-a21b-43fe-a78d-bbee062126a3"), "Subterfúgio" },
                    { new Guid("f7273626-0aec-435f-9b88-931483608475"), "Possui muito dinheiro", new Guid("9416cc13-a931-432b-9331-f65ceddcee12"), "Fortuna" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_SuperHeroiId",
                table: "Filmes",
                column: "SuperHeroiId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperPoderes_SuperHeroiId",
                table: "SuperPoderes",
                column: "SuperHeroiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "SuperPoderes");

            migrationBuilder.DropTable(
                name: "SuperHerois");

            migrationBuilder.CreateTable(
                name: "PropertyModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Family = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Street = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOverdue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PropertyModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentModel_PropertyModel_PropertyModelId",
                        column: x => x.PropertyModelId,
                        principalTable: "PropertyModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentModel_PropertyModelId",
                table: "PaymentModel",
                column: "PropertyModelId");
        }
    }
}
