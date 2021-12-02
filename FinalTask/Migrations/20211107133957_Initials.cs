using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalTask.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Patronymic = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Passport = table.Column<string>(nullable: false),
                    Photo = table.Column<string>(nullable: false),
                    Relevance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Patronymic = table.Column<string>(nullable: false),
                    ExamFee = table.Column<double>(nullable: false),
                    Photo = table.Column<string>(nullable: false),
                    Relevance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataExam = table.Column<DateTime>(nullable: false),
                    DisciplineName = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: true),
                    TeacherId = table.Column<int>(nullable: true),
                    Relevance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exams_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Name", "Passport", "Patronymic", "Photo", "Relevance", "SurName", "Year" },
                values: new object[,]
                {
                    { 1, "ул. Мира, д. 1, кв. 42", "Иван", "ВК864157", "Евгеньевич", "student1.jpg", true, "Коралев", 2002 },
                    { 9, "ул. Мира, д. 124в, кв.34", "Владислав", "МН657812", "Викторович", "student9.jpg", true, "Мавлен", 2001 },
                    { 8, "ул. Щорса, д. 78, кв. 22", "Сергей", "ВК789654", "Андреевич", "student8.jpg", true, "Каприн", 2001 },
                    { 7, "ул. Ватутина, д. 150, кв. 1", "Владимир", "ДН963852", "Едуардович", "student7.jpg", true, "Крамченко", 2002 },
                    { 6, "ул. Артема, д. 110, кв. 110", "Олег", "АВ147852", "Сергеевич", "student6.jpg", true, "Водянов", 2000 },
                    { 10, "ул. Тельмана, д. 34, кв. 7", "Даниил", "КР159753", "Олегович,", "student10.jpg", true, "Купринов", 2001 },
                    { 4, "ул. Ватутина, д. 3б, кв. 24", "Андрей", "НК639852", "Дмитриевич", "student4.jpg", true, "Кружкин", 2003 },
                    { 3, "ул. Артема, д. 269, кв. 1", "Виктор", "НЕ314796", "Ярославович", "student3.jpg", true, "Комаров", 2003 },
                    { 2, "ул. Мира, д. 51, кв. 5", "Сергей", "ВН214786", "Аркадьевич", "student2.jpg", true, "Викторов", 2003 },
                    { 5, "ул. Ленина, д. 28а, кв. 99", "Геннадий", "КН545821", "Генадьевич", "student5.jpg", true, "Легасов", 2002 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ExamFee", "Name", "Patronymic", "Photo", "Relevance", "SurName" },
                values: new object[,]
                {
                    { 9, 300.0, "Камил", "Андреевич", "teacher9.jpg", true, "Карасев" },
                    { 1, 800.0, "Иван", "Дмитриевич", "teacher1.jpg", true, "Иванов" },
                    { 2, 1000.0, "Евгений", "Генадьевич", "teacher2.jpg", true, "Петров" },
                    { 3, 900.0, "Виктор", "Сергеевич", "teacher3.jpg", true, "Ахметов" },
                    { 4, 800.0, "Артем", "Сергеевич", "teacher4.jpg", true, "Черышев" },
                    { 5, 1000.0, "Владимир", "Сергеевич", "teacher5.jpg", true, "Дзюба" },
                    { 6, 900.0, "Андрей", "Викторович", "teacher6.jpg", true, "Жирков" },
                    { 7, 500.0, "Сергей", "Олегович", "teacher7.jpg", true, "Павлов" },
                    { 8, 500.0, "Вадим", "Ярославович", "teacher8.jpg", true, "Сереженко" },
                    { 10, 400.0, "Дмитрий", "Дмитриевич", "teacher10.jpg", true, "Басов" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "DataExam", "DisciplineName", "Relevance", "Score", "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Математика", true, 75, 1, 1 },
                    { 18, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Философия", true, 80, 8, 9 },
                    { 17, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "История", true, 75, 7, 9 },
                    { 16, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Физическая культура", true, 91, 6, 8 },
                    { 15, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Физическая культура", true, 94, 5, 8 },
                    { 14, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Философия", true, 80, 4, 7 },
                    { 13, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "История", true, 75, 3, 7 },
                    { 12, new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Русский язык", true, 90, 2, 6 },
                    { 11, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Русский язык", true, 74, 1, 6 },
                    { 10, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский язык", true, 74, 10, 5 },
                    { 9, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Английский язык", true, 89, 9, 5 },
                    { 8, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Право", true, 75, 8, 4 },
                    { 7, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Право", true, 80, 7, 4 },
                    { 6, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Физика", true, 80, 6, 3 },
                    { 5, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Физика", true, 75, 5, 3 },
                    { 4, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Литература", true, 75, 4, 2 },
                    { 3, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Литература", true, 60, 3, 2 },
                    { 2, new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Математика", true, 90, 2, 1 },
                    { 19, new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Физика", true, 90, 9, 10 },
                    { 20, new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Математика", true, 74, 10, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_StudentId",
                table: "Exams",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_TeacherId",
                table: "Exams",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
