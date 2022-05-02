using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1.Data.Migrations
{
    public partial class tblcreatn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAppoinment",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AppDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialist = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAppoinment", x => x.AppId);
                });

            migrationBuilder.CreateTable(
                name: "TblDoctorReg",
                columns: table => new
                {
                    D_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D_FName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    D_LName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    D_ContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    D_EMail = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    D_Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    D_Qualiifcation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    D_Specialization = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    D_Experience = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    D_Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Confirm_D_Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDoctorReg", x => x.D_Id);
                });

            migrationBuilder.CreateTable(
                name: "TblUserReg",
                columns: table => new
                {
                    U_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_FName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    U_LName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    U_ContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UEMail = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    U_Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    U_Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Confirm_U_Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUserReg", x => x.U_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAppoinment");

            migrationBuilder.DropTable(
                name: "TblDoctorReg");

            migrationBuilder.DropTable(
                name: "TblUserReg");
        }
    }
}
