using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamWeb_NguyenMinhQuan.Migrations
{
    /// <inheritdoc />
    public partial class InitSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tuade = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DienVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false),
                    GiaVe = table.Column<double>(type: "float", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phims", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Phims",
                columns: new[] { "Id", "DienVien", "GiaVe", "ThoiLuong", "TrongNuoc", "Tuade" },
                values: new object[,]
                {
                    { 1, "Son Ye Jin, Hyun Bin", 120000.5, 120, false, "Hạ cánh nơi anh" },
                    { 2, "Trần Phương Anh, Đông Nhi", 100000.0, 105, true, "Mắt biếc" },
                    { 3, "Song Kang Ho", 150000.0, 132, false, "Parasite" },
                    { 4, "Leonardo DiCaprio", 200000.0, 195, false, "Titanic" },
                    { 5, "Trấn Thành, Kiều Minh Tuấn", 90000.0, 130, true, "Bố già" },
                    { 6, "Nhã Phương", 110000.0, 115, true, "Gái già lắm chiêu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phims");
        }
    }
}
