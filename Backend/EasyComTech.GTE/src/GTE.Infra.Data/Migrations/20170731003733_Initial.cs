using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GTE.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BestTimeToWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestTimeToWork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LevelOfKnowledgeAndroid = table.Column<int>(nullable: false),
                    LevelOfKnowledgeAngularJs = table.Column<int>(nullable: false),
                    LevelOfKnowledgeAspNetMVC = table.Column<int>(nullable: false),
                    LevelOfKnowledgeBootstrap = table.Column<int>(nullable: false),
                    LevelOfKnowledgeC = table.Column<int>(nullable: true),
                    LevelOfKnowledgeCPlusPlus = table.Column<int>(nullable: true),
                    LevelOfKnowledgeCSS = table.Column<int>(nullable: true),
                    LevelOfKnowledgeCake = table.Column<int>(nullable: true),
                    LevelOfKnowledgeDjango = table.Column<int>(nullable: true),
                    LevelOfKnowledgeHTML = table.Column<int>(nullable: true),
                    LevelOfKnowledgeIOS = table.Column<int>(nullable: false),
                    LevelOfKnowledgeIllustrator = table.Column<int>(nullable: true),
                    LevelOfKnowledgeIonic = table.Column<int>(nullable: false),
                    LevelOfKnowledgeJava = table.Column<int>(nullable: true),
                    LevelOfKnowledgeJquery = table.Column<int>(nullable: false),
                    LevelOfKnowledgeMajento = table.Column<int>(nullable: true),
                    LevelOfKnowledgeMySQL = table.Column<int>(nullable: true),
                    LevelOfKnowledgeMySQLServer = table.Column<int>(nullable: true),
                    LevelOfKnowledgePHP = table.Column<int>(nullable: false),
                    LevelOfKnowledgePhotoshop = table.Column<int>(nullable: true),
                    LevelOfKnowledgePhyton = table.Column<int>(nullable: true),
                    LevelOfKnowledgeRuby = table.Column<int>(nullable: true),
                    LevelOfKnowledgeSEO = table.Column<int>(nullable: true),
                    LevelOfKnowledgeSalesforce = table.Column<int>(nullable: true),
                    LevelOfKnowledgeWordpress = table.Column<int>(nullable: false),
                    LinkCRUD = table.Column<string>(nullable: true),
                    OtherLanguageOrFramework = table.Column<string>(nullable: true),
                    ProgrammerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WillingnessToWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WillingnessToWork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: true),
                    AccountTypeId = table.Column<Guid>(nullable: true),
                    Agency = table.Column<string>(nullable: true),
                    Bank = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProgrammerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankInformation_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OccupationArea",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BestTimeToWorkId = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    HourlySalaryRequirements = table.Column<decimal>(nullable: false),
                    Linkedin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Portfolio = table.Column<string>(nullable: true),
                    ProgrammerId = table.Column<Guid>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    WillingnessToWorkId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OccupationArea_BestTimeToWork_BestTimeToWorkId",
                        column: x => x.BestTimeToWorkId,
                        principalTable: "BestTimeToWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccupationArea_WillingnessToWork_WillingnessToWorkId",
                        column: x => x.WillingnessToWorkId,
                        principalTable: "WillingnessToWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programmer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BankInformationId = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Excluded = table.Column<bool>(nullable: false),
                    KnowledgeId = table.Column<Guid>(nullable: false),
                    OccupationAreaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programmer_BankInformation_BankInformationId",
                        column: x => x.BankInformationId,
                        principalTable: "BankInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Programmer_Knowledge_KnowledgeId",
                        column: x => x.KnowledgeId,
                        principalTable: "Knowledge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Programmer_OccupationArea_OccupationAreaId",
                        column: x => x.OccupationAreaId,
                        principalTable: "OccupationArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankInformation_AccountTypeId",
                table: "BankInformation",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationArea_BestTimeToWorkId",
                table: "OccupationArea",
                column: "BestTimeToWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationArea_WillingnessToWorkId",
                table: "OccupationArea",
                column: "WillingnessToWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Programmer_BankInformationId",
                table: "Programmer",
                column: "BankInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programmer_KnowledgeId",
                table: "Programmer",
                column: "KnowledgeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programmer_OccupationAreaId",
                table: "Programmer",
                column: "OccupationAreaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programmer");

            migrationBuilder.DropTable(
                name: "BankInformation");

            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DropTable(
                name: "OccupationArea");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "BestTimeToWork");

            migrationBuilder.DropTable(
                name: "WillingnessToWork");
        }
    }
}
