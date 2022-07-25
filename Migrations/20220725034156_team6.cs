using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team6_API.Migrations
{
    public partial class team6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "managers",
                columns: table => new
                {
                    Man_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Man_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Man_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Man_Phone = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managers", x => x.Man_Id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Phone = table.Column<long>(type: "bigint", nullable: false),
                    Emp_Doj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Emp_Dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_LeaveBal = table.Column<int>(type: "int", nullable: false),
                    Man_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Emp_Id);
                    table.ForeignKey(
                        name: "FK_employees_managers_Man_Id",
                        column: x => x.Man_Id,
                        principalTable: "managers",
                        principalColumn: "Man_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "leaveDetails",
                columns: table => new
                {
                    Leave_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Id = table.Column<int>(type: "int", nullable: false),
                    Man_Id = table.Column<int>(type: "int", nullable: false),
                    No_OfDays = table.Column<int>(type: "int", nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Applied_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaveDetails", x => x.Leave_Id);
                    table.ForeignKey(
                        name: "FK_leaveDetails_employees_Emp_Id",
                        column: x => x.Emp_Id,
                        principalTable: "employees",
                        principalColumn: "Emp_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_leaveDetails_managers_Man_Id",
                        column: x => x.Man_Id,
                        principalTable: "managers",
                        principalColumn: "Man_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_Man_Id",
                table: "employees",
                column: "Man_Id");

            migrationBuilder.CreateIndex(
                name: "IX_leaveDetails_Emp_Id",
                table: "leaveDetails",
                column: "Emp_Id");

            migrationBuilder.CreateIndex(
                name: "IX_leaveDetails_Man_Id",
                table: "leaveDetails",
                column: "Man_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leaveDetails");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "managers");
        }
    }
}
