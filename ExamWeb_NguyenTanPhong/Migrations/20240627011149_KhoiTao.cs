using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_NguyenTanPhong.Migrations
{
    public partial class KhoiTao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaDe = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DienVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false),
                    GiaVe = table.Column<double>(type: "float", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
