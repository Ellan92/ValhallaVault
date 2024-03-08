using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVault.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Segments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SegmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Segments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategories_Segments_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "Segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Options = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubcategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultModel_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Solutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Solutions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserResults",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ResultId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResults", x => new { x.UserId, x.ResultId });
                    table.ForeignKey(
                        name: "FK_UserResults_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserResults_ResultModel_ResultId",
                        column: x => x.ResultId,
                        principalTable: "ResultModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Att skydda sig mot bedrägerier", "Syftar på att ta försiktighetsåtgärder för att undvika att bli lurad eller manipulerad av bedrägliga aktiviteter eller människor. Det innebär att vara medveten om potentiella risker, att vara försiktig med personlig information och att utveckla strategier för att identifiera och undvika bedrägerier" },
                    { 2, "Cybersäkerhet för företag", "Detta innebär att implementera en serie av säkerhetsåtgärder och bästa praxis för att skydda företagets digitala tillgångar, information och system från cyberhot och attacker. Det omfattar vanligtvis användningen av tekniska lösningar som brandväggar, antivirusprogram, kryptering och säkerhetskopiering, samt etablering av säkerhetspolicyer och rutiner för att hantera risker och incidenter." },
                    { 3, "Cyberspionage", "Cyberspionage är en form av spionage där angripare använder digitala metoder för att infiltrera och stjäla konfidentiell information från organisationer, myndigheter eller enskilda individer. Det innebär vanligtvis användning av avancerade tekniker såsom malware, phishing och social engineering för att få tillgång till känslig data utan att upptäckas." }
                });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "Id", "CategoryId", "Description", "SegmentName" },
                values: new object[,]
                {
                    { 1, 1, null, "Del 1" },
                    { 2, 1, null, "Del 2" },
                    { 3, 1, null, "Del 3" },
                    { 4, 2, null, "Del 1" },
                    { 5, 2, null, "Del 2" },
                    { 6, 2, null, "Del 3" },
                    { 7, 2, null, "Del 4" },
                    { 8, 3, null, "Del 1" },
                    { 9, 3, null, "Del 2" },
                    { 10, 3, null, "Del 3" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "Description", "SegmentId", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, null, 1, "Kreditkortsbedrägeri" },
                    { 2, null, 1, "Romansbedrägeri" },
                    { 3, null, 1, "Investeringsbedrägeri" },
                    { 4, null, 1, "Telefonbedrägeri" },
                    { 5, null, 2, "Bedrägerier i hemmet" },
                    { 6, null, 2, "Identitetsstöld" },
                    { 7, null, 2, "Nätfiske och bluffmejl" },
                    { 8, null, 2, "Investeringsbedrägeri på nätet" },
                    { 9, null, 3, "Abonnemangsfällor och falska fakturor" },
                    { 10, null, 3, "Ransomware" },
                    { 11, null, 3, "Statistik och förhållningssätt" },
                    { 12, null, 4, "Digital säkerhet på företag" },
                    { 13, null, 4, "Risker och beredskap" },
                    { 14, null, 4, "Aktörer inom cyberbrott" },
                    { 15, null, 4, "Ökad digital närvaro och distansarbete" },
                    { 16, null, 4, "Cyberangrepp mot känsliga sektorer" },
                    { 17, null, 4, "Cyberrånet mot Mersk " },
                    { 18, null, 5, "Social engineering" },
                    { 19, null, 5, "Nätfiske och skräppost" },
                    { 20, null, 5, "Vishing" },
                    { 21, null, 5, "Varning för vishing" },
                    { 22, null, 5, "Identifiera VD-mejl" },
                    { 23, null, 5, "Öneangrepp och presentkortsbluffar" },
                    { 24, null, 6, "Virus, maskar och trojaner" },
                    { 25, null, 6, "Så kan det gå till" },
                    { 26, null, 6, "Nätverksintrång" },
                    { 27, null, 6, "Dataintrång" },
                    { 28, null, 6, "Hackad!" },
                    { 29, null, 6, "Vägarna in" },
                    { 30, null, 7, "Utpressningsvirus" },
                    { 31, null, 7, "Attacker mot servrar" },
                    { 32, null, 7, "Cyberangrepp i Norden" },
                    { 33, null, 7, "It-brottslingarnas verktyg" },
                    { 34, null, 7, "Mirai, Wannacry och fallet Düsseldorf" },
                    { 35, null, 7, "De sårbara molnen" },
                    { 36, null, 8, "Allmänt om cyberspionage" },
                    { 37, null, 8, "Metoder för cyberspionage" },
                    { 38, null, 8, "Säkerhetsskyddslagen" },
                    { 39, null, 8, "Cyberspionagets aktörer" },
                    { 40, null, 9, "Värvningsförsök" },
                    { 41, null, 9, "Affärsspionage" },
                    { 42, null, 9, "Påverkanskampanjer" },
                    { 43, null, 10, "Svensk underrättelsetjänst och cyberförsvar" },
                    { 44, null, 10, "Signalspaning, informationssäkerhet och 5G" },
                    { 45, null, 10, "Samverkan mot cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Options", "Question", "SubcategoryId" },
                values: new object[,]
                {
                    { 1, "[\"Ett legitimt f\\u00F6rs\\u00F6k fr\\u00E5n banken att skydda ditt konto\",\"En informationsinsamling f\\u00F6r en marknadsunders\\u00F6kning\",\"Ett potentiellt telefonbedr\\u00E4geri\"]", "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att säkerställa din kontos säkerhet efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?", 1 },
                    { 2, "[\"Ge dem informationen de ber om, f\\u00F6r s\\u00E4kerhets skull\",\"Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet \\u00E4r korrekt\",\"V\\u00E4nta p\\u00E5 att de ska ringa tillbaka f\\u00F6r att bekr\\u00E4fta deras legitimitet\"]", "Vad bör du göra omedelbart efter att ha mottagit ett misstänkt telefonsamtal där någon frågar efter personlig finansiell information?", 1 },
                    { 3, "[\"Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange l\\u00F6senord och kontonummer f\\u00F6r verifiering.\",\"Banker ringer regelbundet sina kunder f\\u00F6r att be dem upprepa sina kontouppgifter f\\u00F6r s\\u00E4kerhetsuppdateringar.\",\"Banker och finansiella institutioner kommer aldrig att be dig om ditt l\\u00F6senord eller kontonummer via telefon eller e-post.\"]", "Vilket av följande påståenden är sant angående hur finansiella institutioner kommunicerar med sina kunder?", 1 },
                    { 4, "[\"En legitim beg\\u00E4ran om hj\\u00E4lp fr\\u00E5n en person i n\\u00F6d\",\"Ett romansbedr\\u00E4geri\",\"En tillf\\u00E4llig ekonomisk sv\\u00E5righet\"]", "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?", 2 },
                    { 5, "[\"Ett misstag av kreditkortsf\\u00F6retaget\",\"Kreditkortsbedr\\u00E4geri\",\"Obeh\\u00F6riga k\\u00F6p av en familjemedlem\"]", "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?", 3 },
                    { 6, "[\"Ett misstag av kreditkortsf\\u00F6retaget\",\"Kreditkortsbedr\\u00E4geri\",\"Obeh\\u00F6riga k\\u00F6p av en familjemedlem\"]", "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?", 4 },
                    { 7, "[\"\",\"\",\"\"]", "", 4 },
                    { 8, "[\"\",\"\",\"\"]", "", 4 },
                    { 9, "[\"\",\"\",\"\"]", "", 4 },
                    { 10, "[\"\",\"\",\"\"]", "", 4 },
                    { 11, "[\"\",\"\",\"\"]", "", 4 },
                    { 12, "[\"\",\"\",\"\"]", "", 4 },
                    { 13, "[\"\",\"\",\"\"]", "", 4 },
                    { 14, "[\"\",\"\",\"\"]", "", 4 },
                    { 15, "[\"\",\"\",\"\"]", "", 4 },
                    { 16, "[\"\",\"\",\"\"]", "", 4 },
                    { 17, "[\"\",\"\",\"\"]", "", 4 },
                    { 18, "[\"\",\"\",\"\"]", "", 4 },
                    { 19, "[\"\",\"\",\"\"]", "", 4 }
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "CorrectAnswer", "Explanation", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Ett potentiellt telefonbedrägeri", "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.", 1 },
                    { 2, "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt.", "Det säkraste sättet att hantera potentiella telefonbedrägerier är att avsluta samtalet och sedan själv ringa upp din bank via ett telefonnummer du vet är korrekt (till exempel från deras officiella webbplats eller ditt bankkort) för att verifiera om samtalet var legitimt.", 2 },
                    { 3, "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post.", "Kommunikationen från banker och finansiella institutioner innehåller aldrig förfrågningar om känslig information som lösenord eller kontonummer via osäkra kanaler som telefon eller e-post. Detta är en grundläggande säkerhetsprincip.", 3 },
                    { 4, "Investeringsbedrägeri", "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier.", 4 },
                    { 5, "Kreditkortsbedrägeri", "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri.", 5 },
                    { 6, "Utbildning i digital säkerhet för alla anställda", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor", 6 },
                    { 7, "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag", "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SubcategoryId",
                table: "Questions",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultModel_QuestionId",
                table: "ResultModel",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Segments_CategoryId",
                table: "Segments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_QuestionId",
                table: "Solutions",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_SegmentId",
                table: "Subcategories",
                column: "SegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResults_ResultId",
                table: "UserResults",
                column: "ResultId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Solutions");

            migrationBuilder.DropTable(
                name: "UserResults");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ResultModel");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Segments");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
