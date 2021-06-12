using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonedelGusto.Migrations
{
    public partial class Salone2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Visitatore",
                table: "Visitatore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stand",
                table: "Stand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prodotto",
                table: "Prodotto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Espositore",
                table: "Espositore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Azienda",
                table: "Azienda");

            migrationBuilder.RenameTable(
                name: "Visitatore",
                newName: "Visitatori");

            migrationBuilder.RenameTable(
                name: "Stand",
                newName: "Stands");

            migrationBuilder.RenameTable(
                name: "Prodotto",
                newName: "Prodotti");

            migrationBuilder.RenameTable(
                name: "Espositore",
                newName: "Espositori");

            migrationBuilder.RenameTable(
                name: "Azienda",
                newName: "Aziende");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visitatori",
                table: "Visitatori",
                column: "IdVisitatore");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stands",
                table: "Stands",
                column: "IdStand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prodotti",
                table: "Prodotti",
                column: "IdProdotto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Espositori",
                table: "Espositori",
                column: "Id_Espositore");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aziende",
                table: "Aziende",
                column: "Id_Azienda");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30794658-98e8-43eb-93d2-3f1d0086e264", "ee2df750-64ff-4147-8d42-cf26257e9131", "Visitatore", "VISITATORE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91b69dfe-2200-4f39-bd6b-82d01c0c0a11", "3e029f24-3e68-4636-b097-c777886d61db", "Amministratore", "AMMINISTRATORE" });

            migrationBuilder.CreateIndex(
                name: "IX_Visitatori_IdProdotto",
                table: "Visitatori",
                column: "IdProdotto");

            migrationBuilder.CreateIndex(
                name: "IX_Visitatori_IdStand",
                table: "Visitatori",
                column: "IdStand");

            migrationBuilder.CreateIndex(
                name: "IX_Stands_IdAzienda",
                table: "Stands",
                column: "IdAzienda");

            migrationBuilder.CreateIndex(
                name: "IX_Stands_IdVisitatore",
                table: "Stands",
                column: "IdVisitatore");

            migrationBuilder.CreateIndex(
                name: "IX_Prodotti_IdVisitatore",
                table: "Prodotti",
                column: "IdVisitatore");

            migrationBuilder.CreateIndex(
                name: "IX_Aziende_IdStand",
                table: "Aziende",
                column: "IdStand");

            migrationBuilder.AddForeignKey(
                name: "FK_Aziende_Stands_IdStand",
                table: "Aziende",
                column: "IdStand",
                principalTable: "Stands",
                principalColumn: "IdStand",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prodotti_Visitatori_IdVisitatore",
                table: "Prodotti",
                column: "IdVisitatore",
                principalTable: "Visitatori",
                principalColumn: "IdVisitatore",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stands_Aziende_IdAzienda",
                table: "Stands",
                column: "IdAzienda",
                principalTable: "Aziende",
                principalColumn: "Id_Azienda",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stands_Visitatori_IdVisitatore",
                table: "Stands",
                column: "IdVisitatore",
                principalTable: "Visitatori",
                principalColumn: "IdVisitatore",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitatori_Prodotti_IdProdotto",
                table: "Visitatori",
                column: "IdProdotto",
                principalTable: "Prodotti",
                principalColumn: "IdProdotto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitatori_Stands_IdStand",
                table: "Visitatori",
                column: "IdStand",
                principalTable: "Stands",
                principalColumn: "IdStand",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aziende_Stands_IdStand",
                table: "Aziende");

            migrationBuilder.DropForeignKey(
                name: "FK_Prodotti_Visitatori_IdVisitatore",
                table: "Prodotti");

            migrationBuilder.DropForeignKey(
                name: "FK_Stands_Aziende_IdAzienda",
                table: "Stands");

            migrationBuilder.DropForeignKey(
                name: "FK_Stands_Visitatori_IdVisitatore",
                table: "Stands");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitatori_Prodotti_IdProdotto",
                table: "Visitatori");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitatori_Stands_IdStand",
                table: "Visitatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visitatori",
                table: "Visitatori");

            migrationBuilder.DropIndex(
                name: "IX_Visitatori_IdProdotto",
                table: "Visitatori");

            migrationBuilder.DropIndex(
                name: "IX_Visitatori_IdStand",
                table: "Visitatori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stands",
                table: "Stands");

            migrationBuilder.DropIndex(
                name: "IX_Stands_IdAzienda",
                table: "Stands");

            migrationBuilder.DropIndex(
                name: "IX_Stands_IdVisitatore",
                table: "Stands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prodotti",
                table: "Prodotti");

            migrationBuilder.DropIndex(
                name: "IX_Prodotti_IdVisitatore",
                table: "Prodotti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Espositori",
                table: "Espositori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aziende",
                table: "Aziende");

            migrationBuilder.DropIndex(
                name: "IX_Aziende_IdStand",
                table: "Aziende");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30794658-98e8-43eb-93d2-3f1d0086e264");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91b69dfe-2200-4f39-bd6b-82d01c0c0a11");

            migrationBuilder.RenameTable(
                name: "Visitatori",
                newName: "Visitatore");

            migrationBuilder.RenameTable(
                name: "Stands",
                newName: "Stand");

            migrationBuilder.RenameTable(
                name: "Prodotti",
                newName: "Prodotto");

            migrationBuilder.RenameTable(
                name: "Espositori",
                newName: "Espositore");

            migrationBuilder.RenameTable(
                name: "Aziende",
                newName: "Azienda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visitatore",
                table: "Visitatore",
                column: "IdVisitatore");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stand",
                table: "Stand",
                column: "IdStand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prodotto",
                table: "Prodotto",
                column: "IdProdotto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Espositore",
                table: "Espositore",
                column: "Id_Espositore");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Azienda",
                table: "Azienda",
                column: "Id_Azienda");
        }
    }
}
