using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class create_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TickerId = table.Column<int>(nullable: false),
                    SourceId = table.Column<int>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    PriceTag = table.Column<double>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ticker",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticker", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Price",
                columns: new[] { "Id", "Active", "PriceTag", "SourceId", "TickerId", "Time" },
                values: new object[,]
                {
                    { 1, true, 131.31386595454248, 1, 1, new DateTime(2022, 6, 20, 9, 49, 39, 751, DateTimeKind.Local).AddTicks(6434) },
                    { 31, true, 161.25107814696668, 2, 1, new DateTime(2022, 6, 20, 5, 17, 39, 751, DateTimeKind.Local).AddTicks(8848) },
                    { 32, true, 151.77435503970102, 2, 2, new DateTime(2022, 6, 20, 8, 36, 39, 751, DateTimeKind.Local).AddTicks(8850) },
                    { 33, true, 157.13629252224521, 2, 3, new DateTime(2022, 6, 20, 8, 37, 39, 751, DateTimeKind.Local).AddTicks(8853) },
                    { 34, true, 168.29602944200209, 3, 1, new DateTime(2022, 6, 20, 3, 58, 39, 751, DateTimeKind.Local).AddTicks(8857) },
                    { 35, true, 161.67753523374327, 3, 2, new DateTime(2022, 6, 20, 5, 1, 39, 751, DateTimeKind.Local).AddTicks(8860) },
                    { 36, true, 160.54767777318028, 3, 3, new DateTime(2022, 6, 20, 4, 38, 39, 751, DateTimeKind.Local).AddTicks(8862) },
                    { 37, true, 148.37247486696694, 1, 1, new DateTime(2022, 6, 20, 10, 2, 39, 751, DateTimeKind.Local).AddTicks(8865) },
                    { 38, true, 133.13593984342458, 1, 2, new DateTime(2022, 6, 20, 9, 50, 39, 751, DateTimeKind.Local).AddTicks(8868) },
                    { 39, true, 133.90394395945313, 1, 3, new DateTime(2022, 6, 20, 7, 1, 39, 751, DateTimeKind.Local).AddTicks(8870) },
                    { 40, true, 141.48426321484814, 2, 1, new DateTime(2022, 6, 20, 7, 19, 39, 751, DateTimeKind.Local).AddTicks(8873) },
                    { 41, true, 149.81513666526655, 2, 2, new DateTime(2022, 6, 20, 8, 44, 39, 751, DateTimeKind.Local).AddTicks(8876) },
                    { 29, true, 156.34658773805788, 1, 2, new DateTime(2022, 6, 20, 8, 49, 39, 751, DateTimeKind.Local).AddTicks(8837) },
                    { 42, true, 133.82900936322241, 2, 3, new DateTime(2022, 6, 20, 9, 9, 39, 751, DateTimeKind.Local).AddTicks(8879) },
                    { 44, true, 142.71706721486854, 3, 2, new DateTime(2022, 6, 20, 9, 13, 39, 751, DateTimeKind.Local).AddTicks(8884) },
                    { 45, true, 147.1288085816702, 3, 3, new DateTime(2022, 6, 20, 9, 41, 39, 751, DateTimeKind.Local).AddTicks(8887) },
                    { 46, true, 156.41619675240767, 1, 1, new DateTime(2022, 6, 20, 9, 46, 39, 751, DateTimeKind.Local).AddTicks(8890) },
                    { 47, true, 152.34162784371136, 1, 2, new DateTime(2022, 6, 20, 10, 6, 39, 751, DateTimeKind.Local).AddTicks(8892) },
                    { 48, true, 154.81323877654188, 1, 3, new DateTime(2022, 6, 20, 8, 33, 39, 751, DateTimeKind.Local).AddTicks(8895) },
                    { 49, true, 165.27423602855032, 2, 1, new DateTime(2022, 6, 20, 5, 43, 39, 751, DateTimeKind.Local).AddTicks(8898) },
                    { 50, true, 162.40215829765989, 2, 2, new DateTime(2022, 6, 20, 8, 45, 39, 751, DateTimeKind.Local).AddTicks(8901) },
                    { 51, true, 157.21082490819546, 2, 3, new DateTime(2022, 6, 20, 5, 5, 39, 751, DateTimeKind.Local).AddTicks(8904) },
                    { 52, true, 165.55151789788226, 3, 1, new DateTime(2022, 6, 20, 3, 38, 39, 751, DateTimeKind.Local).AddTicks(8906) },
                    { 53, true, 162.47609874429466, 3, 2, new DateTime(2022, 6, 20, 9, 13, 39, 751, DateTimeKind.Local).AddTicks(8909) },
                    { 54, true, 161.65598993347305, 3, 3, new DateTime(2022, 6, 20, 4, 40, 39, 751, DateTimeKind.Local).AddTicks(8912) },
                    { 43, true, 159.27255671052382, 3, 1, new DateTime(2022, 6, 20, 8, 31, 39, 751, DateTimeKind.Local).AddTicks(8881) },
                    { 28, true, 151.15128850698531, 1, 1, new DateTime(2022, 6, 20, 9, 32, 39, 751, DateTimeKind.Local).AddTicks(8832) },
                    { 30, true, 159.96585849285864, 1, 3, new DateTime(2022, 6, 20, 5, 46, 39, 751, DateTimeKind.Local).AddTicks(8845) },
                    { 26, true, 142.14083366741932, 3, 2, new DateTime(2022, 6, 20, 9, 31, 39, 751, DateTimeKind.Local).AddTicks(8824) },
                    { 2, true, 146.20859177221479, 1, 2, new DateTime(2022, 6, 20, 9, 5, 39, 751, DateTimeKind.Local).AddTicks(8691) },
                    { 3, true, 138.99798161384089, 1, 3, new DateTime(2022, 6, 20, 8, 46, 39, 751, DateTimeKind.Local).AddTicks(8732) },
                    { 4, true, 143.07399778850564, 2, 1, new DateTime(2022, 6, 20, 10, 6, 39, 751, DateTimeKind.Local).AddTicks(8737) },
                    { 5, true, 146.49737605276863, 2, 2, new DateTime(2022, 6, 20, 7, 47, 39, 751, DateTimeKind.Local).AddTicks(8741) },
                    { 6, true, 150.47869721064748, 2, 3, new DateTime(2022, 6, 20, 9, 46, 39, 751, DateTimeKind.Local).AddTicks(8745) },
                    { 7, true, 160.39145526109331, 3, 1, new DateTime(2022, 6, 20, 4, 3, 39, 751, DateTimeKind.Local).AddTicks(8749) },
                    { 8, true, 155.48085744828492, 3, 2, new DateTime(2022, 6, 20, 9, 5, 39, 751, DateTimeKind.Local).AddTicks(8753) },
                    { 9, true, 156.28058332391578, 3, 3, new DateTime(2022, 6, 20, 8, 4, 39, 751, DateTimeKind.Local).AddTicks(8756) },
                    { 10, true, 143.56959137846698, 1, 1, new DateTime(2022, 6, 20, 7, 5, 39, 751, DateTimeKind.Local).AddTicks(8760) },
                    { 11, true, 153.50659426545565, 1, 2, new DateTime(2022, 6, 20, 6, 57, 39, 751, DateTimeKind.Local).AddTicks(8764) },
                    { 27, true, 143.33110280104964, 3, 3, new DateTime(2022, 6, 20, 9, 52, 39, 751, DateTimeKind.Local).AddTicks(8828) },
                    { 13, true, 161.24729167808653, 2, 1, new DateTime(2022, 6, 20, 5, 40, 39, 751, DateTimeKind.Local).AddTicks(8772) },
                    { 12, true, 159.04792691151516, 1, 3, new DateTime(2022, 6, 20, 5, 32, 39, 751, DateTimeKind.Local).AddTicks(8768) },
                    { 15, true, 169.18029039674917, 2, 3, new DateTime(2022, 6, 20, 4, 5, 39, 751, DateTimeKind.Local).AddTicks(8780) },
                    { 25, true, 145.66511094448862, 3, 1, new DateTime(2022, 6, 20, 3, 40, 39, 751, DateTimeKind.Local).AddTicks(8821) },
                    { 24, true, 136.78740818915767, 2, 3, new DateTime(2022, 6, 20, 5, 52, 39, 751, DateTimeKind.Local).AddTicks(8817) },
                    { 14, true, 151.14005629572554, 2, 2, new DateTime(2022, 6, 20, 5, 58, 39, 751, DateTimeKind.Local).AddTicks(8776) },
                    { 22, true, 131.84585339090594, 2, 1, new DateTime(2022, 6, 20, 9, 48, 39, 751, DateTimeKind.Local).AddTicks(8808) },
                    { 21, true, 148.57504089842786, 1, 3, new DateTime(2022, 6, 20, 9, 30, 39, 751, DateTimeKind.Local).AddTicks(8804) },
                    { 23, true, 141.7283985221099, 2, 2, new DateTime(2022, 6, 20, 6, 7, 39, 751, DateTimeKind.Local).AddTicks(8813) },
                    { 19, true, 141.82134033346145, 1, 1, new DateTime(2022, 6, 20, 9, 38, 39, 751, DateTimeKind.Local).AddTicks(8796) },
                    { 18, true, 162.41520505591538, 3, 3, new DateTime(2022, 6, 20, 7, 8, 39, 751, DateTimeKind.Local).AddTicks(8792) },
                    { 17, true, 151.68495841949013, 3, 2, new DateTime(2022, 6, 20, 9, 15, 39, 751, DateTimeKind.Local).AddTicks(8788) },
                    { 16, true, 154.88768958329115, 3, 1, new DateTime(2022, 6, 20, 4, 45, 39, 751, DateTimeKind.Local).AddTicks(8784) },
                    { 20, true, 133.33804441386278, 1, 2, new DateTime(2022, 6, 20, 8, 32, 39, 751, DateTimeKind.Local).AddTicks(8800) }
                });

            migrationBuilder.InsertData(
                table: "Source",
                columns: new[] { "Id", "Active", "SourceName" },
                values: new object[,]
                {
                    { 1, true, "SRC1" },
                    { 2, true, "SRC2" },
                    { 3, true, "TBK1" }
                });

            migrationBuilder.InsertData(
                table: "Ticker",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[,]
                {
                    { 2, true, "IDM UK" },
                    { 1, true, "IBM UN" },
                    { 3, true, "NIPM DA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Ticker");
        }
    }
}
