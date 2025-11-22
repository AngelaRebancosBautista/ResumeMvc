using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeMvc.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.RenameColumn(
                name: "ProfileText",
                table: "Resumes",
                newName: "Aboutme");

            migrationBuilder.RenameColumn(
                name: "PeriodAndDegree",
                table: "Educations",
                newName: "Year");

            migrationBuilder.CreateTable(
                name: "Ilike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Favorite_Food = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Favorite_Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Favorite_Drinks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Favorite_Movie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilike_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "My_Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Time_Management = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Communication_Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Problem_Solving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teamwork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adaptability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Self_Motivation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technical = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_My_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_My_Skills_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilike_ResumeId",
                table: "Ilike",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_My_Skills_ResumeId",
                table: "My_Skills",
                column: "ResumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ilike");

            migrationBuilder.DropTable(
                name: "My_Skills");

            migrationBuilder.RenameColumn(
                name: "Aboutme",
                table: "Resumes",
                newName: "ProfileText");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Educations",
                newName: "PeriodAndDegree");

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certifications_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_ResumeId",
                table: "Certifications",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ResumeId",
                table: "Experiences",
                column: "ResumeId");
        }
    }
}
