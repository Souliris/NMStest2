using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NMStest2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    ResourceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    resourceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceId);
                });

            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    PlanetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanetName = table.Column<string>(nullable: true),
                    Sentinels = table.Column<string>(nullable: true),
                    planetResource1ResourceId = table.Column<int>(nullable: true),
                    planetResource2ResourceId = table.Column<int>(nullable: true),
                    planetResource3ResourceId = table.Column<int>(nullable: true),
                    planetResource4ResourceId = table.Column<int>(nullable: true),
                    HasAcientBones = table.Column<bool>(nullable: false),
                    HasSalvageScrap = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.PlanetId);
                    table.ForeignKey(
                        name: "FK_Planet_Resource_planetResource1ResourceId",
                        column: x => x.planetResource1ResourceId,
                        principalTable: "Resource",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Planet_Resource_planetResource2ResourceId",
                        column: x => x.planetResource2ResourceId,
                        principalTable: "Resource",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Planet_Resource_planetResource3ResourceId",
                        column: x => x.planetResource3ResourceId,
                        principalTable: "Resource",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Planet_Resource_planetResource4ResourceId",
                        column: x => x.planetResource4ResourceId,
                        principalTable: "Resource",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StarSystems",
                columns: table => new
                {
                    SystemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SystemName = table.Column<string>(maxLength: 100, nullable: false),
                    StarType = table.Column<string>(nullable: true),
                    EconomyType = table.Column<string>(nullable: true),
                    ConflictType = table.Column<string>(nullable: true),
                    Planet1PlanetId = table.Column<int>(nullable: true),
                    Planet2PlanetId = table.Column<int>(nullable: true),
                    Planet3PlanetId = table.Column<int>(nullable: true),
                    Planet4PlanetId = table.Column<int>(nullable: true),
                    Planet5PlanetId = table.Column<int>(nullable: true),
                    Planet6PlanetId = table.Column<int>(nullable: true),
                    Planet7PlanetId = table.Column<int>(nullable: true),
                    Planet8PlanetId = table.Column<int>(nullable: true),
                    Planet9PlanetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarSystems", x => x.SystemId);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet1PlanetId",
                        column: x => x.Planet1PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet2PlanetId",
                        column: x => x.Planet2PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet3PlanetId",
                        column: x => x.Planet3PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet4PlanetId",
                        column: x => x.Planet4PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet5PlanetId",
                        column: x => x.Planet5PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet6PlanetId",
                        column: x => x.Planet6PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet7PlanetId",
                        column: x => x.Planet7PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet8PlanetId",
                        column: x => x.Planet8PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarSystems_Planet_Planet9PlanetId",
                        column: x => x.Planet9PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Planet_planetResource1ResourceId",
                table: "Planet",
                column: "planetResource1ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Planet_planetResource2ResourceId",
                table: "Planet",
                column: "planetResource2ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Planet_planetResource3ResourceId",
                table: "Planet",
                column: "planetResource3ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Planet_planetResource4ResourceId",
                table: "Planet",
                column: "planetResource4ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet1PlanetId",
                table: "StarSystems",
                column: "Planet1PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet2PlanetId",
                table: "StarSystems",
                column: "Planet2PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet3PlanetId",
                table: "StarSystems",
                column: "Planet3PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet4PlanetId",
                table: "StarSystems",
                column: "Planet4PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet5PlanetId",
                table: "StarSystems",
                column: "Planet5PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet6PlanetId",
                table: "StarSystems",
                column: "Planet6PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet7PlanetId",
                table: "StarSystems",
                column: "Planet7PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet8PlanetId",
                table: "StarSystems",
                column: "Planet8PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_StarSystems_Planet9PlanetId",
                table: "StarSystems",
                column: "Planet9PlanetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StarSystems");

            migrationBuilder.DropTable(
                name: "Planet");

            migrationBuilder.DropTable(
                name: "Resource");
        }
    }
}
