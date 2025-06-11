using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamWeb_NguyenMinhQuan.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Phims",
               columns: new[] { "Id", "DienVien", "GiaVe", "ThoiLuong", "TrongNuoc", "Tuade" },
               values: new object[,]
               {
                    { 1, "Son Ye Jin, Hyun Bin", 120000.5, 120, "false", "Hạ cánh nơi anh" },
                    { 2, "Trần Phương Anh, Đông Nhi", 100000.0, 105, "true", "Mắt biếc" },
                    { 3, "Song Kang Ho", 150000.0, 132, "false", "Parasite" },
                    { 4, "Leonardo DiCaprio", 200000.0, 195, "false", "Titanic" },
                    { 5, "Trấn Thành, Kiều Minh Tuấn", 90000.0, 130, "true", "Bố già" },
                    { 6, "Nhã Phương", 110000.0, 115, "true", "Gái già lắm chiêu" }
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "Phims",
               keyColumn: "Id",
               keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
