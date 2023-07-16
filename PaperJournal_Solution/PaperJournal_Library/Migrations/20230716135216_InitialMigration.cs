using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaperJournal_Library.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    StaffID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountFullName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AccountEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: false),
                    AccountRole = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Account__96D4AAF714BF8003", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "JournalInfo",
                columns: table => new
                {
                    JournalID = table.Column<int>(type: "int", nullable: false),
                    JournalName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ShortJournalDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JournalI__2501038619640AE7", x => x.JournalID);
                });

            migrationBuilder.CreateTable(
                name: "Paper",
                columns: table => new
                {
                    PaperID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PaperTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Authors = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    JournalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paper", x => x.PaperID);
                    table.ForeignKey(
                        name: "FK__Paper__JournalID__286302EC",
                        column: x => x.JournalID,
                        principalTable: "JournalInfo",
                        principalColumn: "JournalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "StaffID", "AccountEmail", "AccountFullName", "AccountPassword", "AccountRole", "Birthday" },
                values: new object[,]
                {
                    { "ACC0006", "manager1@SpringerLink.com", "HR Manager 1", "@123", 1, new DateTime(1991, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ACC0007", "staff@SpringerLink.com", "Staff", "123@", 2, new DateTime(1990, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ACC0009", "manager2@SpringerLink.com", "HR Manager 2", "@123", 1, new DateTime(1992, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ACC0055", "admin@SpringerLink.com", "Admin", "@abc", 0, new DateTime(1990, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "JournalInfo",
                columns: new[] { "JournalID", "Category", "JournalName", "ShortJournalDescription", "Telephone" },
                values: new object[,]
                {
                    { 4440, "Computer Science, AI, Data Mining", "International Journal of Computational Vision and Robotics", "IJCVR is an international refereed journal in the field of image processing, pattern recognition, machine vision and image understanding, providing an international forum for professionals, engineers and researchers.", "1880903914555" },
                    { 4441, "Data Science, Data Mining, AI", "International Journal of Data Analysis Techniques and Strategies", "IJDATS bridges three gaps: firstly, a gap between academic ivory tower and the real world; secondly, a gap between quantitative data analysis techniques and qualitative data analysis techniques;", "1880903914555" },
                    { 4450, "Information System, AI, Machine Learning", "International Journal of Information and Coding Theory", "IJICoT publishes state-of-the-art international research that significantly advances the study of information and coding theory and their applications to cryptography, ... ", "1880903914555" },
                    { 4460, "AI, Optimization Problem", "International Journal of Artificial Intelligence and Soft Computing", "IJAISC provides a new forum for dissemination of knowledge on both theoretical and applied research on artificial intelligence.", "1880903914555" },
                    { 4476, "Database, IS, AI", "International Journal of Intelligent Information and Database Systems", "IJIIDS focuses on research in applications of advanced intelligent technologies for data storing/processing in a wide-ranging context.", "1880903914555" }
                });

            migrationBuilder.InsertData(
                table: "Paper",
                columns: new[] { "PaperID", "Abstract", "Authors", "JournalID", "PaperTitle", "SubmittedDate" },
                values: new object[,]
                {
                    { "PP0015", "Plant diseases are the main cause of economic losses in the agricultural field. In India, the most significant staple food consumed is rice. Different kinds of disease of rice namely grain discoloration, sheath blight, brown spot, and blast are the main restriction on rice harvesting or production and explosion being the most demoralising disease.", "T. Gayathri Devi; P. Neelamegam; A. Srinivasan", 4441, "Rice plant disease, crop stages endemic and control measures - a survey", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "PP0020", "The efficient and effective process of extracting the useful information from high-dimensional data is worth studying. High-dimensional data is big and complex and that it becomes difficult process and classify. Dimensionality reduction (DR) is important and the key method to address these problems. This paper presents a hybrid approach for data classification constituted from the combination of principal component analysis (PCA) and enhanced extreme learning machine (EELM).", "Doaa L. El-Bably; Khaled M. Fouad", 4476, "A hybrid approach for improving data classification based on PCA and enhanced ELM", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "PP0021", "For the past decade, the utilisation of sensor devices in real world applications has increased rapidly. To meet the demand of applications, the sensor nodes are deployed in remote areas where the operation is very complex. The security of the sensor nodes may be compromised at any time. Therefore, a secure data aggregation mechanism is needed to overcome their limitations.", "A.L. Sreenivasulu; P. Chenna Reddy", 4476, "An enhanced secure data aggregation routing protocol for sensor networks", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "PP0022", "Now-a-days student absenteeism in engineering education is a most important issue of a professional institution which affects the overall performance of institutions. This is most imperative alarm in creating outstanding engineers (real engineers) to the country. The quality of education is directly proportional to student absenteeism. ", "I. Samuel Peter James; P. Ramasubramanian; D. Magdalene Delighta Angeline", 4476, "Student absenteeism in engineering college using rough set and data mining approach", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "PP0023", "In this paper, a radial basis function neural network (RBFN) model has been trained by canonical particle swarm optimisation (PSO) and improved particle swarm optimisation (IMPSO) algorithms to efficiently predict the exchange rate of Indian rupees against the exchange rate of G-7 countries for future days.", "Trilok Nath Pandey; Alok Kumar Jagadev; Satchidananda Dehuri; Sung-Bae Cho", 4476, "Prediction of exchange rate using improved particle swarm optimised radial basis function networks", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "PP0024", "Most people face the dilemma of accepting photographs as authentic or not, mainly in the case of forensics, where the images will influence judgment. Research communities are constantly providing methods to identify these kinds of forged images.", "Tarun Kumar; Gourav Khurana", 4441, "Copy-move image forgery detection using cuckoo search", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "PP0027", "Image processing is crucial in any image analysis to determine the problem. If it is a medical area, a suitable image processing method becomes even more imperative to get as accurate results as possible. Due to the widespread outbreak of coronavirus disease 2019 (COVID-19), an infectious respiratory disease, it has become quite urgent that a reliable method for identification of the disease is sought.", "Fariha Noor; Md. Rashad Tanjim; Muhammad Jawadur Rahim; Md. Naimul Islam Suvon; Faria Karim Porna;", 4441, "Application of fuzzy logic on CT-scan images of COVID-19 patients", new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paper_JournalID",
                table: "Paper",
                column: "JournalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Paper");

            migrationBuilder.DropTable(
                name: "JournalInfo");
        }
    }
}
