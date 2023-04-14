using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SammourProfile.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Expertises",
                columns: new[] { "Id", "Date", "Description", "Field" },
                values: new object[,]
                {
                    { 1, "Sep 2022", "I started studying Web developer at TUC Yrkeshögskola and is expected to finish in Jun 2024:  (Design & UX)-(HTML & CSS)-(C#)-(ASP Net Core)-(JavaScript)-(DataBase)", "Web developer" },
                    { 2, "Jun 2022", "I finished studying General course - IT / Web (Web development) at Mullsjö Folkhögskola.", "Web development" },
                    { 3, "Sep 2020", "I moved to live in Sweden (New culture - New Challenges)", "Move to Sweden" },
                    { 4, "Okt 2017", "I started working in Dar Amman Academy, Jordan (Organize training and academy events or workshops, Manage and organize databases, Handle correspondence, complaints and questions, Supervise the work of the administrative staff.)", "Administrativ assistant" },
                    { 5, "May 2017", "I started working as a freelancer on several platforms: Data entry/Designing with Illustrator and Photoshop programs/Translating reports and writing research", "Web Freelancer" },
                    { 6, "Okt 2016", "I started working in West America University (Regional Office), Jordan (Plans, organizes, maintains, develops and manages admissions and registration services processes and functions.)", "Head of Admissions and Registration" },
                    { 7, "Jun 2015", "I started working in Consulting institution, Jordan (Organize meetings, corporate events, conferences and manage databases, Handle correspondence, complaints and questions, Supervise the work of the administrative staff, Design advertising and brochures for the company)", "Administrativ assistant" },
                    { 8, "Sep 2015", "Graphic design (Photoshop, Illustrator)", "Graphic design" },
                    { 9, "Jun 1994", "I finished studying Chemical Engineering in Jordan University, Jordan", "B.Sc. Chemical Engineering" },
                    { 10, "1994-2008", "Matematik och naturvetenskap lärare, Labbarbetare, Kemiingenjör", "Various previous jobs" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "C# is a simple & powerful object-oriented programming language developed by Microsoft. C# can be used to create various types of applications, such as web, windows, console applications, or other types of applications using Visual studio.", "/images/C-Sharp.png", "C-Sharp" },
                    { 2, "Structured Query Language (SQL) is a standardized programming language that is used to manage relational databases and perform various operations on the data in them.", "/images/SQL.png", "SQL" },
                    { 3, "HTML (HyperText Markup Language) is the most basic building block of the Web. It defines the meaning and structure of web content.", "/images/HTML.png", "HTML" },
                    { 4, "Cascading Style Sheets (CSS) is a style sheet language used for describing the look and formatting of a document written in a markup language. CSS3 is a latest standard of css earlier versions(CSS2).", "/images/CSS.png", "CSS" },
                    { 5, "ASP.NET Core MVC is a rich framework for building web apps and APIs using the Model-View-Controller design pattern. The Model-View-Controller (MVC) architectural pattern separates an application into three main groups of components: Models, Views, and Controllers.", "/images/ASPNET.png", "ASP.NET Core MVC" },
                    { 6, "Entity Framework Core (EF Core) is an open-source, lightweight, and cross-platform version of Entity Framework data-access technology. It is an Object-Relational Mapper (ORM) tool that enables developers to work with relational databases using .NET objects.", "/images/EF.png", "Entity Framework (EF) Core" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
