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
                name: "CompletedSegments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SegmentId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubcategoryIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedSegments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletedSegments_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompletedSubcategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SegmentId = table.Column<int>(type: "int", nullable: false),
                    SubcategoryId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedSubcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletedSubcategories_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
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
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 4, "[\"Installera en app som blockerar misst\\u00E4nkta samtal\",\"Aldrig svara p\\u00E5 samtal fr\\u00E5n ok\\u00E4nda nummer\",\"Uppr\\u00E4tta starka s\\u00E4kerhetsfr\\u00E5gor med din bank som kr\\u00E4vs f\\u00F6r att identifiera dig \\u00F6ver telefon\"]", "Hur kan du bäst skydda dig mot telefonbedrägerier", 1 },
                    { 5, "[\"En legitim beg\\u00E4ran om hj\\u00E4lp fr\\u00E5n en person i n\\u00F6d\",\"Ett romansbedr\\u00E4geri\",\"En tillf\\u00E4llig ekonomisk sv\\u00E5righet\"]", "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?", 2 },
                    { 6, "[\"Genomf\\u00F6ra omedelbar investering f\\u00F6r att inte missa m\\u00F6jligheten\",\"Investeringsbedr\\u00E4geri\",\"Beg\\u00E4ra mer information f\\u00F6r att utf\\u00F6ra en noggrann \\u2018\\u2019due diligence\\u2019\"]", "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?", 3 },
                    { 7, "[\"Ett misstag av kreditkortsf\\u00F6retaget\",\"Kreditkortsbedr\\u00E4geri\",\"Obeh\\u00F6riga k\\u00F6p av en familjemedlem\"]", "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?", 4 },
                    { 8, "[\"Utbildning i digital s\\u00E4kerhet f\\u00F6r alla anst\\u00E4llda\",\"Installera en starkare brandv\\u00E4gg\",\"Byta ut all IT-utrustning\"]", "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?", 12 },
                    { 9, "[\"Manuellt kontrollera varje anst\\u00E4llds l\\u00F6senord en g\\u00E5ng per \\u00E5r\",\"Implementera en policy f\\u00F6r l\\u00F6senordskomplexitet som kr\\u00E4ver automatiska l\\u00F6senords\\u00E4ndringar var 90:e dag\",\"Uppmana anst\\u00E4llda att v\\u00E4lja l\\u00E4ttih\\u00E5gda l\\u00F6senord f\\u00F6r att undvika att skriva ner dem\"]", "Vilken åtgärd är mest effektiv för att säkerställa att anställda regelbundet uppdaterar sina lösenord till starkare och mer komplexa versioner?", 12 },
                    { 10, "[\"F\\u00F6rbjuda anv\\u00E4ndning av offentliga Wi-Fi-n\\u00E4tverk helt och h\\u00E5llet\",\"Utrusta alla anst\\u00E4lldas enheter med VPN (Virtual Private Network)-tj\\u00E4nster\",\"Endast till\\u00E5ta anst\\u00E4llda att arbeta offline n\\u00E4r de inte \\u00E4r p\\u00E5 kontoret\"]", "Hur kan företaget effektivt minska risken för att anställda oavsiktligt exponerar företagsdata via otrygga Wi-Fi-nätverk?", 12 },
                    { 11, "[\"Blockera all inkommande e-post fr\\u00E5n externa k\\u00E4llor\",\"Installera och uppdatera regelbundet e-posts\\u00E4kerhetsl\\u00F6sningar som filtrerar bort skadlig programvara och misst\\u00E4nkta l\\u00E4nkar\",\"L\\u00E5ta anst\\u00E4llda anv\\u00E4nda personliga e-postkonton f\\u00F6r arbete f\\u00F6r att minska risken f\\u00F6r f\\u00F6retagets e-postservers s\\u00E4kerhet\"]", "Vilken åtgärd bör ett företag ta för att skydda sig mot intrång via e-postbaserade hot som phishing?", 12 },
                    { 12, "[\"Informera alla anv\\u00E4ndare om s\\u00E5rbarheten och rekommendera tempor\\u00E4ra skydds\\u00E5tg\\u00E4rder\",\"Ignorera problemet tills en patch kan utvecklas\",\"St\\u00E4nga ner tj\\u00E4nsten tillf\\u00E4lligt\"]", "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?", 13 },
                    { 13, "[\"En enskild hackare med ett personligt vendetta\",\"En konkurrerande f\\u00F6retagsentitet\",\"Organiserade cyberbrottsliga grupper\"]", "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?", 14 },
                    { 14, "[\"\\u00C5terg\\u00E5 till kontorsarbete\",\"Inf\\u00F6ra striktare l\\u00F6senordspolicyer och tv\\u00E5faktorsautentisering f\\u00F6r fj\\u00E4rr\\u00E5tkomst\",\"F\\u00F6rbjuda anv\\u00E4ndning av personliga enheter f\\u00F6r arbete\"]", "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?", 15 },
                    { 15, "[\"Phishing\",\"Ransomware\",\"Spyware\"]", "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?", 16 },
                    { 16, "[\"Spyware\",\"Ransomware\",\"Adware\"]", "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?", 17 },
                    { 17, "[\"Cyberkriminalitet\",\"Cyberspionage\",\"Cyberterrorism\"]", "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?", 36 },
                    { 18, "[\"\\u00D6ka anv\\u00E4ndningen av kryptering f\\u00F6r all intern och extern kommunikation\",\"F\\u00F6rbjuda all anv\\u00E4ndning av e-post och \\u00E5terg\\u00E5 till fysisk korrespondens\",\"Installera antivirusprogram p\\u00E5 alla datorer\"]", "Vilken försvarsstrategi är mest effektiv mot cyberspionage som riktar sig mot känslig kommunikation?", 36 },
                    { 19, "[\"Genomf\\u00F6ra strikta bakgrundskontroller av alla anst\\u00E4llda\",\"Implementera ett omfattande program f\\u00F6r beteendeanalys och anomalidetektering\",\"Begr\\u00E4nsa internetanv\\u00E4ndningen p\\u00E5 arbetsplatsen till arbetsrelaterade aktiviteter\"]", "Hur kan organisationer bäst upptäcka och motverka insiderhot som bidrar till cyberspionage?", 36 },
                    { 20, "[\"Genomf\\u00F6ra regelbundna medvetenhetstr\\u00E4ningar f\\u00F6r alla anst\\u00E4llda om cybers\\u00E4kerhet\",\"H\\u00E5lla all mjukvara och operativsystem uppdaterade med de senaste s\\u00E4kerhetspatcharna\",\"Endast anv\\u00E4nda egenutvecklad mjukvara f\\u00F6r alla verksamhetsprocesser\"]", "Vilken åtgärd är viktigast för att skydda sig mot cyberspionage genom utnyttjande av mjukvarusårbarheter?", 36 },
                    { 21, "[\"Social ingenj\\u00F6rskonst\",\"Mass\\u00F6vervakning\",\"Riktade cyberattacker\"]", "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?", 37 },
                    { 22, "[\"GDPR\",\"S\\u00E4kerhetsskyddslagen\",\"IT-s\\u00E4kerhetslagen\"]", "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?", 38 },
                    { 23, "[\"Oberoende hackare\",\"Aktivistgrupper\",\"Statssponsrade hackers\"]", "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?", 39 }
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "CorrectAnswer", "Explanation", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Ett potentiellt telefonbedrägeri", "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.", 1 },
                    { 2, "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt.", "Det säkraste sättet att hantera potentiella telefonbedrägerier är att avsluta samtalet och sedan själv ringa upp din bank via ett telefonnummer du vet är korrekt (till exempel från deras officiella webbplats eller ditt bankkort) för att verifiera om samtalet var legitimt.", 2 },
                    { 3, "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post.", "Kommunikationen från banker och finansiella institutioner innehåller aldrig förfrågningar om känslig information som lösenord eller kontonummer via osäkra kanaler som telefon eller e-post. Detta är en grundläggande säkerhetsprincip.", 3 },
                    { 4, "Upprätta starka säkerhetsfrågor med din bank som krävs för att identifiera dig över telefon", "Genom att ha förutbestämda säkerhetsfrågor med din bank kan du och banken ha en säker metod för att bekräfta varandras identitet under telefonsamtal. Detta minskar risken för att bli lurad av bedragare som inte kan svara på dessa frågor.\r\n", 4 },
                    { 5, "Ett romansbedrägeri", "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri", 5 },
                    { 6, "Investeringsbedrägeri", "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier.", 6 },
                    { 7, "Kreditkortsbedrägeri", "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri.", 7 },
                    { 8, "Utbildning i digital säkerhet för alla anställda", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor", 8 },
                    { 9, "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag", "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst.", 9 },
                    { 10, "Utrusta alla anställdas enheter med VPN (Virtual Private Network)-tjänster", "Genom att använda VPN kan anställda säkert ansluta till företagets nätverk även från otrygga Wi-Fi-nätverk, vilket krypterar dataöverföring och skyddar mot avlyssning och andra cyberhot.", 10 },
                    { 11, "Installera och uppdatera regelbundet e-postsäkerhetslösningar som filtrerar bort skadlig programvara och misstänkta länkar", "Avancerade e-postsäkerhetslösningar kan effektivt identifiera och blockera skadlig programvara och phishing-försök, vilket minskar risken för att anställda oavsiktligt exponerar företagets system och data för cyberhot.", 11 },
                    { 12, "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder", "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.", 12 },
                    { 13, "Organiserade cyberbrottsliga grupper", "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.", 13 },
                    { 14, "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst", "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.", 14 },
                    { 15, "Ransomware", "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.", 15 },
                    { 16, "Ransomware", "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system.Maersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.", 16 },
                    { 17, "Cyberspionage", "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar. I takt med att cyberspionage blir allt mer sofistikerat, krävs det starkare skyddsmekanismer för att säkra känslig information. Ett av de mest effektiva sätten att skydda data är genom kryptering. Denna teknik säkerställer att informationen förblir privat, även om den skulle hamna i fel händer.", 17 },
                    { 18, "Öka användningen av kryptering för all intern och extern kommunikation", "Kryptering är en kraftfull metod för att skydda känslig information under överföring och lagring, vilket gör det extremt svårt för obehöriga att få tillgång till och förstå informationen, även om de lyckas avlyssna kommunikationen.", 18 },
                    { 19, "Implementera ett omfattande program för beteendeanalys och anomalidetektering", "Program för beteendeanalys och anomalidetektering kan effektivt identifiera ovanligt beteende eller aktiviteter som kan tyda på insiderhot eller obehörig åtkomst till känslig information, vilket är ett kritiskt steg för att förhindra cyberspionage. Mjukvarusårbarheter är ofta den svaga länken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna säkerhetsuppdateringar och patchar, kan dessa sårbarheter lämna dörrarna vidöppna för angripare. Att hålla programvara och system uppdaterade är en grundläggande men kritisk del av ett effektivt cybersäkerhetsförsvar.", 19 },
                    { 20, "Hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna", "Regelbundna uppdateringar och patchning av mjukvara och operativsystem är avgörande för att stänga säkerhetshål som annars kan utnyttjas av cyberspioner. Detta minskar risken för intrång och dataläckor avsevärt.", 20 },
                    { 21, "Riktade cyberattacker", "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.", 21 },
                    { 22, "Säkerhetsskyddslagen", "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.", 22 },
                    { 23, "Statssponsrade hackers", "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.", 23 }
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
                name: "IX_CompletedSegments_ApplicationUserId",
                table: "CompletedSegments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedSubcategories_ApplicationUserId",
                table: "CompletedSubcategories",
                column: "ApplicationUserId");

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
                name: "CompletedSegments");

            migrationBuilder.DropTable(
                name: "CompletedSubcategories");

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
