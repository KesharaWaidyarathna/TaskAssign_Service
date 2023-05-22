using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAssign.Migrations
{
    /// <inheritdoc />
    public partial class holidays_insert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoliyDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

			migrationBuilder.InsertData(
		            table: "Holidays",
		        columns: new[] { "HoliyDay", "Name" },
		        values: new object[,]
		        {
			        {  new DateTime(2023,6,3),"Poson Full Moon Poya Day" },
			        {  new DateTime(2023,6,29),"Id Ul-Alha" },
			        {  new DateTime(2023,7,3),"Adhi Esala Full Moon Poya Day" },
			        {  new DateTime(2023,8,1),"Esala Full Moon Poya Day" },
			        {  new DateTime(2023,8,30),"Nikini Full Moon Poya Day" },
			        {  new DateTime(2023,9,28),"Milad un-Nabi" },
			        {  new DateTime(2023,9,29),"Binara Full Moon Poya Day" },
			        {  new DateTime(2023,10,28),"Vap Full Moon Poya Day" },
			        {  new DateTime(2023,11,12),"Deepavali" },
			        {  new DateTime(2023,11,26),"Ill Full Moon Poya Day" },
			        {  new DateTime(2023,12,25),"Christmas Day" },
			        {  new DateTime(2023,12,26),"Unduvap Full Moon Poya Day" }
                });
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holidays");
        }
    }
}
