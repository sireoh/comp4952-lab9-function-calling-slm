﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfFuncCallSK.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    School = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { 1, "Tom", "Max", "Nursing" },
                    { 2, "Ann", "Fay", "Mining" },
                    { 3, "Joe", "Sun", "Nursing" },
                    { 4, "Sue", "Fox", "Computing" },
                    { 5, "Ben", "Ray", "Mining" },
                    { 6, "Zoe", "Cox", "Business" },
                    { 7, "Sam", "Ray", "Mining" },
                    { 8, "Dan", "Ash", "Medicine" },
                    { 9, "Pat", "Lee", "Computing" },
                    { 10, "Kim", "Day", "Nursing" },
                    { 11, "Tim", "Rex", "Computing" },
                    { 12, "Rob", "Ram", "Nursing" },
                    { 13, "Jan", "Fry", "Mining" },
                    { 14, "Jim", "Tex", "Nursing" },
                    { 15, "Ben", "Kid", "Business" },
                    { 16, "Mia", "Chu", "Medicine" },
                    { 17, "Ted", "Tao", "Computing" },
                    { 18, "Amy", "Day", "Nursing" },
                    { 19, "Ian", "Roy", "Nursing" },
                    { 20, "Liz", "Kit", "Nursing" },
                    { 21, "Mat", "Tan", "Medicine" },
                    { 22, "Deb", "Roy", "Medicine" },
                    { 23, "Ana", "Ray", "Mining" },
                    { 24, "Lyn", "Poe", "Computing" },
                    { 25, "Amy", "Raj", "Nursing" },
                    { 26, "Kim", "Ash", "Mining" },
                    { 27, "Bec", "Kid", "Nursing" },
                    { 28, "Eva", "Fry", "Computing" },
                    { 29, "Eli", "Lap", "Business" },
                    { 30, "Sam", "Yim", "Nursing" },
                    { 31, "Joe", "Hui", "Mining" },
                    { 32, "Liz", "Jin", "Nursing" },
                    { 33, "Ric", "Kuo", "Business" },
                    { 34, "Pam", "Mak", "Computing" },
                    { 35, "Cat", "Yao", "Medicine" },
                    { 36, "Lou", "Zhu", "Mining" },
                    { 37, "Tom", "Dag", "Business" },
                    { 38, "Stu", "Day", "Business" },
                    { 39, "Tom", "Gad", "Mining" },
                    { 40, "Bob", "Bee", "Business" },
                    { 41, "Jim", "Ots", "Business" },
                    { 42, "Tom", "Mag", "Business" },
                    { 43, "Hal", "Doe", "Mining" },
                    { 44, "Roy", "Kim", "Mining" },
                    { 45, "Vis", "Cox", "Nursing" },
                    { 46, "Kay", "Aga", "Nursing" },
                    { 47, "Reo", "Hui", "Nursing" },
                    { 48, "Bob", "Roe", "Mining" },
                    { 49, "Jay", "Eff", "Computing" },
                    { 50, "Eva", "Chu", "Business" },
                    { 51, "Lex", "Rae", "Nursing" },
                    { 52, "Lin", "Dex", "Mining" },
                    { 53, "Liz", "Dag", "Business" },
                    { 54, "Ben", "Shy", "Computing" },
                    { 55, "Rob", "Bos", "Nursing" },
                    { 56, "Ali", "Mac", "Business" },
                    { 57, "Edi", "Gee", "Computing" },
                    { 58, "Eva", "Cao", "Mining" },
                    { 59, "Jun", "Lam", "Computing" },
                    { 60, "Eli", "Tao", "Computing" },
                    { 61, "Ana", "Bay", "Computing" },
                    { 62, "Gil", "Tal", "Mining" },
                    { 63, "Wes", "Dey", "Nursing" },
                    { 64, "Nea", "Tan", "Computing" },
                    { 65, "Ava", "Day", "Nursing" },
                    { 66, "Rie", "Ray", "Business" },
                    { 67, "Ken", "Sim", "Nursing" },
                    { 68, "Liz", "Kim", "Nursing" },
                    { 69, "Max", "Fur", "Mining" },
                    { 70, "Edi", "Kai", "Mining" },
                    { 71, "Joe", "Sha", "Business" },
                    { 72, "Gem", "Lin", "Nursing" },
                    { 73, "Ama", "Kam", "Nursing" },
                    { 74, "Zac", "Der", "Business" },
                    { 75, "Liz", "Car", "Nursing" },
                    { 76, "Kit", "Ngo", "Nursing" },
                    { 77, "Tom", "Ren", "Computing" },
                    { 78, "Kal", "Hon", "Nursing" },
                    { 79, "Avi", "Gil", "Business" },
                    { 80, "Ada", "Dao", "Business" },
                    { 81, "Eva", "Kim", "Mining" },
                    { 82, "Amy", "Kam", "Computing" },
                    { 83, "Noa", "Sim", "Business" },
                    { 84, "Ben", "Kai", "Computing" },
                    { 85, "Mae", "Car", "Business" },
                    { 86, "Mae", "Der", "Mining" },
                    { 87, "Lee", "Hon", "Business" },
                    { 88, "Gus", "Lin", "Business" },
                    { 89, "Ava", "Bay", "Nursing" },
                    { 90, "Ari", "Sim", "Mining" },
                    { 91, "Kai", "Lee", "Business" },
                    { 92, "Ali", "Doe", "Business" },
                    { 93, "Ivy", "Kim", "Computing" },
                    { 94, "Mia", "Sun", "Nursing" },
                    { 95, "Lia", "Fox", "Mining" },
                    { 96, "Ian", "Day", "Business" },
                    { 97, "Bra", "Tan", "Computing" },
                    { 98, "Eli", "Chu", "Business" },
                    { 99, "Max", "Cox", "Nursing" },
                    { 100, "Ann", "Kuo", "Business" },
                    { 101, "Liv", "Kim", "Computing" },
                    { 102, "Jay", "Tan", "Mining" },
                    { 103, "Ace", "Sun", "Nursing" },
                    { 104, "Kit", "Doe", "Business" },
                    { 105, "Kim", "Kay", "Nursing" },
                    { 106, "Lyn", "Bar", "Business" },
                    { 107, "Tae", "Sae", "Computing" },
                    { 108, "Pri", "Day", "Nursing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
