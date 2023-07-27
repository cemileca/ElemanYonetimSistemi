using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ElemanYonetimSistemi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreakTime",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BreakName = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakTime", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryName = table.Column<string>(type: "text", nullable: false),
                    CountryShirtName = table.Column<string>(type: "text", nullable: false),
                    ZipCode = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departman",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmanName = table.Column<string>(type: "text", nullable: false),
                    DepartmanSeniorID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departman", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departman_Departman_DepartmanSeniorID",
                        column: x => x.DepartmanSeniorID,
                        principalTable: "Departman",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityName = table.Column<string>(type: "text", nullable: false),
                    CountryID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DistrictName = table.Column<string>(type: "text", nullable: false),
                    DistrictDescription = table.Column<string>(type: "text", nullable: false),
                    Quarter = table.Column<string>(type: "text", nullable: false),
                    CityID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.ID);
                    table.ForeignKey(
                        name: "FK_District_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BreakTimeEmployee",
                columns: table => new
                {
                    BreakTimesID = table.Column<int>(type: "integer", nullable: false),
                    EmployeesID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakTimeEmployee", x => new { x.BreakTimesID, x.EmployeesID });
                    table.ForeignKey(
                        name: "FK_BreakTimeEmployee_BreakTime_BreakTimesID",
                        column: x => x.BreakTimesID,
                        principalTable: "BreakTime",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonalID = table.Column<int>(type: "integer", nullable: false),
                    ScoreOfEmployee = table.Column<decimal>(type: "numeric", nullable: false),
                    Salary = table.Column<decimal>(type: "numeric", nullable: false),
                    DepartmanID = table.Column<int>(type: "integer", nullable: true),
                    StartOfWork = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndOfWork = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Departman_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "Departman",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobName = table.Column<string>(type: "text", nullable: false),
                    JobDescription = table.Column<string>(type: "text", nullable: true),
                    JobDepartmanID = table.Column<int>(type: "integer", nullable: true),
                    EmployeeID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Job_Departman_JobDepartmanID",
                        column: x => x.JobDepartmanID,
                        principalTable: "Departman",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Job_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FullAdress",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullAdressName = table.Column<string>(type: "text", nullable: false),
                    FullAdressDescrition = table.Column<string>(type: "text", nullable: false),
                    CountryID = table.Column<int>(type: "integer", nullable: false),
                    CityID = table.Column<int>(type: "integer", nullable: false),
                    DistrictID = table.Column<int>(type: "integer", nullable: false),
                    PersonalID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullAdress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FullAdress_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FullAdress_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FullAdress_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IndividualNo = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PhotoUrl = table.Column<string>(type: "text", nullable: true),
                    TasksID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TaskName = table.Column<string>(type: "text", nullable: false),
                    TaskDescription = table.Column<string>(type: "text", nullable: false),
                    Respite = table.Column<string>(type: "text", nullable: false),
                    TaskAuthorizedID = table.Column<int>(type: "integer", nullable: false),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    EmployeeID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tasks_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Tasks_Personals_TaskAuthorizedID",
                        column: x => x.TaskAuthorizedID,
                        principalTable: "Personals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BreakTimeEmployee_EmployeesID",
                table: "BreakTimeEmployee",
                column: "EmployeesID");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryID",
                table: "City",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Departman_DepartmanSeniorID",
                table: "Departman",
                column: "DepartmanSeniorID");

            migrationBuilder.CreateIndex(
                name: "IX_District_CityID",
                table: "District",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmanID",
                table: "Employees",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonalID",
                table: "Employees",
                column: "PersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_FullAdress_CityID",
                table: "FullAdress",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_FullAdress_CountryID",
                table: "FullAdress",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_FullAdress_DistrictID",
                table: "FullAdress",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_FullAdress_PersonalID",
                table: "FullAdress",
                column: "PersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployeeID",
                table: "Job",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Job_JobDepartmanID",
                table: "Job",
                column: "JobDepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Personals_TasksID",
                table: "Personals",
                column: "TasksID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_EmployeeID",
                table: "Tasks",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskAuthorizedID",
                table: "Tasks",
                column: "TaskAuthorizedID");

            migrationBuilder.AddForeignKey(
                name: "FK_BreakTimeEmployee_Employees_EmployeesID",
                table: "BreakTimeEmployee",
                column: "EmployeesID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Personals_PersonalID",
                table: "Employees",
                column: "PersonalID",
                principalTable: "Personals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FullAdress_Personals_PersonalID",
                table: "FullAdress",
                column: "PersonalID",
                principalTable: "Personals",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personals_Tasks_TasksID",
                table: "Personals",
                column: "TasksID",
                principalTable: "Tasks",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Employees_EmployeeID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Personals_TaskAuthorizedID",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "BreakTimeEmployee");

            migrationBuilder.DropTable(
                name: "FullAdress");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "BreakTime");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departman");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
