using Microsoft.EntityFrameworkCore.Migrations;

namespace NMStest2.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planet_Resource_planetResource1ResourceId",
                table: "Planet");

            migrationBuilder.DropForeignKey(
                name: "FK_Planet_Resource_planetResource2ResourceId",
                table: "Planet");

            migrationBuilder.DropForeignKey(
                name: "FK_Planet_Resource_planetResource3ResourceId",
                table: "Planet");

            migrationBuilder.DropForeignKey(
                name: "FK_Planet_Resource_planetResource4ResourceId",
                table: "Planet");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet1PlanetId",
                table: "StarSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet2PlanetId",
                table: "StarSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet3PlanetId",
                table: "StarSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet4PlanetId",
                table: "StarSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet5PlanetId",
                table: "StarSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet6PlanetId",
                table: "StarSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet7PlanetId",
                table: "StarSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet8PlanetId",
                table: "StarSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_StarSystems_Planet_Planet9PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet1PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet2PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet3PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet4PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet5PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet6PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet7PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet8PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_StarSystems_Planet9PlanetId",
                table: "StarSystems");

            migrationBuilder.DropIndex(
                name: "IX_Planet_planetResource1ResourceId",
                table: "Planet");

            migrationBuilder.DropIndex(
                name: "IX_Planet_planetResource2ResourceId",
                table: "Planet");

            migrationBuilder.DropIndex(
                name: "IX_Planet_planetResource3ResourceId",
                table: "Planet");

            migrationBuilder.DropIndex(
                name: "IX_Planet_planetResource4ResourceId",
                table: "Planet");

            migrationBuilder.DropColumn(
                name: "Planet1PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "Planet2PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "Planet3PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "Planet4PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "Planet5PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "Planet6PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "Planet7PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "Planet8PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "Planet9PlanetId",
                table: "StarSystems");

            migrationBuilder.DropColumn(
                name: "planetResource1ResourceId",
                table: "Planet");

            migrationBuilder.DropColumn(
                name: "planetResource2ResourceId",
                table: "Planet");

            migrationBuilder.DropColumn(
                name: "planetResource3ResourceId",
                table: "Planet");

            migrationBuilder.DropColumn(
                name: "planetResource4ResourceId",
                table: "Planet");

            migrationBuilder.AddColumn<int>(
                name: "PlanetId",
                table: "Resource",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "foreignKey",
                table: "Resource",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SystemId",
                table: "Planet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PlanetId",
                table: "Resource",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_Planet_SystemId",
                table: "Planet",
                column: "SystemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planet_StarSystems_SystemId",
                table: "Planet",
                column: "SystemId",
                principalTable: "StarSystems",
                principalColumn: "SystemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_Planet_PlanetId",
                table: "Resource",
                column: "PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planet_StarSystems_SystemId",
                table: "Planet");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_Planet_PlanetId",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Resource_PlanetId",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Planet_SystemId",
                table: "Planet");

            migrationBuilder.DropColumn(
                name: "PlanetId",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "foreignKey",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "SystemId",
                table: "Planet");

            migrationBuilder.AddColumn<int>(
                name: "Planet1PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Planet2PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Planet3PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Planet4PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Planet5PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Planet6PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Planet7PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Planet8PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Planet9PlanetId",
                table: "StarSystems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "planetResource1ResourceId",
                table: "Planet",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "planetResource2ResourceId",
                table: "Planet",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "planetResource3ResourceId",
                table: "Planet",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "planetResource4ResourceId",
                table: "Planet",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Planet_Resource_planetResource1ResourceId",
                table: "Planet",
                column: "planetResource1ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planet_Resource_planetResource2ResourceId",
                table: "Planet",
                column: "planetResource2ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planet_Resource_planetResource3ResourceId",
                table: "Planet",
                column: "planetResource3ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planet_Resource_planetResource4ResourceId",
                table: "Planet",
                column: "planetResource4ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet1PlanetId",
                table: "StarSystems",
                column: "Planet1PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet2PlanetId",
                table: "StarSystems",
                column: "Planet2PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet3PlanetId",
                table: "StarSystems",
                column: "Planet3PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet4PlanetId",
                table: "StarSystems",
                column: "Planet4PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet5PlanetId",
                table: "StarSystems",
                column: "Planet5PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet6PlanetId",
                table: "StarSystems",
                column: "Planet6PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet7PlanetId",
                table: "StarSystems",
                column: "Planet7PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet8PlanetId",
                table: "StarSystems",
                column: "Planet8PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarSystems_Planet_Planet9PlanetId",
                table: "StarSystems",
                column: "Planet9PlanetId",
                principalTable: "Planet",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
