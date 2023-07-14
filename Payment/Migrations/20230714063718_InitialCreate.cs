using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payment.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receiver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rec_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rec_Phone = table.Column<int>(type: "int", nullable: false),
                    Rec_ID_NO = table.Column<int>(type: "int", nullable: false),
                    Rec_Dst_Acc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Remmiter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rem_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rem_Phone = table.Column<int>(type: "int", nullable: false),
                    Rem_ID_NO = table.Column<int>(type: "int", nullable: false),
                    Rem_Src_Acc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remmiter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receiver");

            migrationBuilder.DropTable(
                name: "Remmiter");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
