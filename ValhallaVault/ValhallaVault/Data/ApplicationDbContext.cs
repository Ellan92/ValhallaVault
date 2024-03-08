using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<SegmentModel> Segments { get; set; }
        public DbSet<UserResult> UserResults { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<SubcategoryModel> Subcategories { get; set; }
        public DbSet<SolutionModel> Solutions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    Id = 1,
                    CategoryName = "Att skydda sig mot bedrägerier",
                    Description = "Syftar på att ta försiktighetsåtgärder för att undvika att bli lurad eller manipulerad av bedrägliga aktiviteter eller människor. Det innebär att vara medveten om potentiella risker, att vara försiktig med personlig information och att utveckla strategier för att identifiera och undvika bedrägerier",
                },

            new CategoryModel
            {
                Id = 2,
                CategoryName = "Cybersäkerhet för företag",
                Description = "Detta innebär att implementera en serie av säkerhetsåtgärder och bästa praxis för att skydda företagets digitala tillgångar, information och system från cyberhot och attacker. Det omfattar vanligtvis användningen av tekniska lösningar som brandväggar, antivirusprogram, kryptering och säkerhetskopiering, samt etablering av säkerhetspolicyer och rutiner för att hantera risker och incidenter."
            },

            new CategoryModel
            {
                Id = 3,
                CategoryName = "Cyberspionage",
                Description = "Cyberspionage är en form av spionage där angripare använder digitala metoder för att infiltrera och stjäla konfidentiell information från organisationer, myndigheter eller enskilda individer. Det innebär vanligtvis användning av avancerade tekniker såsom malware, phishing och social engineering för att få tillgång till känslig data utan att upptäckas."
            });

            builder.Entity<SegmentModel>().HasData(
                new SegmentModel
                {
                    Id = 1,
                    SegmentName = "Del 1",
                    CategoryId = 1,
                },
            new SegmentModel
            {
                Id = 2,
                SegmentName = "Del 2",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 3,
                SegmentName = "Del 3",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 4,
                SegmentName = "Del 1",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 5,
                SegmentName = "Del 2",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 6,
                SegmentName = "Del 3",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 7,
                SegmentName = "Del 4",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 8,
                SegmentName = "Del 1",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 9,
                SegmentName = "Del 2",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 10,
                SegmentName = "Del 3",
                CategoryId = 3,
            });

            builder.Entity<SubcategoryModel>().HasData(
                new SubcategoryModel
                {
                    Id = 1,
                    SubCategoryName = "Kreditkortsbedrägeri",
                    SegmentId = 1,
                },
            new SubcategoryModel
            {
                Id = 2,
                SubCategoryName = "Romansbedrägeri",
                SegmentId = 1,
            },
            new SubcategoryModel
            {
                Id = 3,
                SubCategoryName = "Investeringsbedrägeri",
                SegmentId = 1,
            },
            new SubcategoryModel
            {
                Id = 4,
                SubCategoryName = "Telefonbedrägeri",
                SegmentId = 1,
            },
            new SubcategoryModel
            {
                Id = 5,
                SubCategoryName = "Bedrägerier i hemmet",
                SegmentId = 2,
            },
            new SubcategoryModel
            {
                Id = 6,
                SubCategoryName = "Identitetsstöld",
                SegmentId = 2,
            },
            new SubcategoryModel
            {
                Id = 7,
                SubCategoryName = "Nätfiske och bluffmejl",
                SegmentId = 2,
            },
            new SubcategoryModel
            {
                Id = 8,
                SubCategoryName = "Investeringsbedrägeri på nätet",
                SegmentId = 2,
            },
            new SubcategoryModel
            {
                Id = 9,
                SubCategoryName = "Abonnemangsfällor och falska fakturor",
                SegmentId = 3,
            },
            new SubcategoryModel
            {
                Id = 10,
                SubCategoryName = "Ransomware",
                SegmentId = 3,
            },
            new SubcategoryModel
            {
                Id = 11,
                SubCategoryName = "Statistik och förhållningssätt",
                SegmentId = 3,
            },
            new SubcategoryModel
            {
                Id = 12,
                SubCategoryName = "Digital säkerhet på företag",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 13,
                SubCategoryName = "Risker och beredskap",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 14,
                SubCategoryName = "Aktörer inom cyberbrott",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 15,
                SubCategoryName = "Ökad digital närvaro och distansarbete",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 16,
                SubCategoryName = "Cyberangrepp mot känsliga sektorer",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 17,
                SubCategoryName = "Cyberrånet mot Mersk ",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 18,
                SubCategoryName = "Social engineering",
                SegmentId = 5,
            },
            new SubcategoryModel
            {
                Id = 19,
                SubCategoryName = "Nätfiske och skräppost",
                SegmentId = 5,
            },
            new SubcategoryModel
            {
                Id = 20,
                SubCategoryName = "Vishing",
                SegmentId = 5,
            },
            new SubcategoryModel
            {
                Id = 21,
                SubCategoryName = "Varning för vishing",
                SegmentId = 5,
            },
            new SubcategoryModel
            {
                Id = 22,
                SubCategoryName = "Identifiera VD-mejl",
                SegmentId = 5,
            },
            new SubcategoryModel
            {
                Id = 23,
                SubCategoryName = "Öneangrepp och presentkortsbluffar",
                SegmentId = 5,
            },
            new SubcategoryModel
            {
                Id = 24,
                SubCategoryName = "Virus, maskar och trojaner",
                SegmentId = 6,
            },
            new SubcategoryModel
            {
                Id = 25,
                SubCategoryName = "Så kan det gå till",
                SegmentId = 6,
            },
            new SubcategoryModel
            {
                Id = 26,
                SubCategoryName = "Nätverksintrång",
                SegmentId = 6,
            },
            new SubcategoryModel
            {
                Id = 27,
                SubCategoryName = "Dataintrång",
                SegmentId = 6,
            },
            new SubcategoryModel
            {
                Id = 28,
                SubCategoryName = "Hackad!",
                SegmentId = 6,
            },
            new SubcategoryModel
            {
                Id = 29,
                SubCategoryName = "Vägarna in",
                SegmentId = 6,
            },
            new SubcategoryModel
            {
                Id = 30,
                SubCategoryName = "Utpressningsvirus",
                SegmentId = 7,
            },
            new SubcategoryModel
            {
                Id = 31,
                SubCategoryName = "Attacker mot servrar",
                SegmentId = 7,
            },
            new SubcategoryModel
            {
                Id = 32,
                SubCategoryName = "Cyberangrepp i Norden",
                SegmentId = 7,
            },
            new SubcategoryModel
            {
                Id = 33,
                SubCategoryName = "It-brottslingarnas verktyg",
                SegmentId = 7,
            },
            new SubcategoryModel
            {
                Id = 34,
                SubCategoryName = "Mirai, Wannacry och fallet Düsseldorf",
                SegmentId = 7,
            },
            new SubcategoryModel
            {
                Id = 35,
                SubCategoryName = "De sårbara molnen",
                SegmentId = 7,
            },
            new SubcategoryModel
            {
                Id = 36,
                SubCategoryName = "Allmänt om cyberspionage",
                SegmentId = 8,
            },
            new SubcategoryModel
            {
                Id = 37,
                SubCategoryName = "Metoder för cyberspionage",
                SegmentId = 8,
            },
            new SubcategoryModel
            {
                Id = 38,
                SubCategoryName = "Säkerhetsskyddslagen",
                SegmentId = 8,
            },
            new SubcategoryModel
            {
                Id = 39,
                SubCategoryName = "Cyberspionagets aktörer",
                SegmentId = 8,
            },
            new SubcategoryModel
            {
                Id = 40,
                SubCategoryName = "Värvningsförsök",
                SegmentId = 9,
            },
            new SubcategoryModel
            {
                Id = 41,
                SubCategoryName = "Affärsspionage",
                SegmentId = 9,
            },
            new SubcategoryModel
            {
                Id = 42,
                SubCategoryName = "Påverkanskampanjer",
                SegmentId = 9,
            },
            new SubcategoryModel
            {
                Id = 43,
                SubCategoryName = "Svensk underrättelsetjänst och cyberförsvar",
                SegmentId = 10,
            },
            new SubcategoryModel
            {
                Id = 44,
                SubCategoryName = "Signalspaning, informationssäkerhet och 5G",
                SegmentId = 10,
            },
            new SubcategoryModel
            {
                Id = 45,
                SubCategoryName = "Samverkan mot cyberspionage",
                SegmentId = 10,
            });

            builder.Entity<QuestionModel>().HasData(
                new QuestionModel
                {
                    Id = 1,
                    Options = new List<string>
                {
                    "Ett legitimt försök från banken att skydda ditt konto",
                    "En informationsinsamling för en marknadsundersökning",
                    "Ett potentiellt telefonbedrägeri"
                },
                    Question = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att säkerställa din kontos säkerhet efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                    SubcategoryId = 1,
                },
            new QuestionModel
            {
                Id = 2,
                Options = new List<string>
                {
                    "Ge dem informationen de ber om, för säkerhets skull",
                    "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt",
                    "Vänta på att de ska ringa tillbaka för att bekräfta deras legitimitet"
                },
                Question = "Vad bör du göra omedelbart efter att ha mottagit ett misstänkt telefonsamtal där någon frågar efter personlig finansiell information?",
                SubcategoryId = 1,
            },
            new QuestionModel
            {
                Id = 3,
                Options = new List<string>
                {
                    "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange lösenord och kontonummer för verifiering.",
                    "Banker ringer regelbundet sina kunder för att be dem upprepa sina kontouppgifter för säkerhetsuppdateringar.",
                    "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post."
                },
                Question = "Vilket av följande påståenden är sant angående hur finansiella institutioner kommunicerar med sina kunder?",
                SubcategoryId = 1,
            },
            new QuestionModel
            {
                Id = 4,
                Options = new List<string>
                {
                    "Installera en app som blockerar misstänkta samtal",
                    "Aldrig svara på samtal från okända nummer",
                    "Upprätta starka säkerhetsfrågor med din bank som krävs för att identifiera dig över telefon"
                },
                Question = "Hur kan du bäst skydda dig mot telefonbedrägerier",
                SubcategoryId = 1,
            },
            new QuestionModel
            {
                Id = 5,
                Options = new List<string>
                {
                    "En legitim begäran om hjälp från en person i nöd",
                    "Ett romansbedrägeri",
                    "En tillfällig ekonomisk svårighet"
                },
                Question = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                SubcategoryId = 2,
            },
            new QuestionModel
            {
                Id = 6,
                Options = new List<string>
                {
                    "Genomföra omedelbar investering för att inte missa möjligheten",
                    "Investeringsbedrägeri",
                    "Begära mer information för att utföra en noggrann ‘’due diligence’"
                },
                Question = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                SubcategoryId = 3,
            },
            new QuestionModel
            {
                Id = 7,
                Options = new List<string>
                {
                    "Ett misstag av kreditkortsföretaget",
                    "Kreditkortsbedrägeri",
                    "Obehöriga köp av en familjemedlem"
                },
                Question = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                SubcategoryId = 4,
            },
            new QuestionModel
            {
                Id = 8,
                Options = new List<string>
                {
                    "Utbildning i digital säkerhet för alla anställda",
                    "Installera en starkare brandvägg",
                    "Byta ut all IT-utrustning"
                },
                Question = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 9,
                Options = new List<string>
                {
                    "Manuellt kontrollera varje anställds lösenord en gång per år",
                    "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag",
                    "Uppmana anställda att välja lättihågda lösenord för att undvika att skriva ner dem"
                },
                Question = "Vilken åtgärd är mest effektiv för att säkerställa att anställda regelbundet uppdaterar sina lösenord till starkare och mer komplexa versioner?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 10,
                Options = new List<string>
                {
                    "Förbjuda användning av offentliga Wi-Fi-nätverk helt och hållet",
                    "Utrusta alla anställdas enheter med VPN (Virtual Private Network)-tjänster",
                    "Endast tillåta anställda att arbeta offline när de inte är på kontoret"
                },
                Question = "Hur kan företaget effektivt minska risken för att anställda oavsiktligt exponerar företagsdata via otrygga Wi-Fi-nätverk?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 11,
                Options = new List<string>
                {
                    "Blockera all inkommande e-post från externa källor",
                    "Installera och uppdatera regelbundet e-postsäkerhetslösningar som filtrerar bort skadlig programvara och misstänkta länkar",
                    "Låta anställda använda personliga e-postkonton för arbete för att minska risken för företagets e-postservers säkerhet"
                },
                Question = "Vilken åtgärd bör ett företag ta för att skydda sig mot intrång via e-postbaserade hot som phishing?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 12,
                Options = new List<string>
                {
                    "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
                    "Ignorera problemet tills en patch kan utvecklas",
                    "Stänga ner tjänsten tillfälligt"
                },
                Question = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",
                SubcategoryId = 13,
            },
            new QuestionModel
            {
                Id = 13,
                Options = new List<string>
                {
                    "En enskild hackare med ett personligt vendetta",
                    "En konkurrerande företagsentitet",
                    "Organiserade cyberbrottsliga grupper"
                },
                Question = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",
                SubcategoryId = 14,
            },
            new QuestionModel
            {
                Id = 14,
                Options = new List<string>
                {
                    "Återgå till kontorsarbete",
                    "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                    "Förbjuda användning av personliga enheter för arbete"
                },
                Question = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",
                SubcategoryId = 15,
            },
            new QuestionModel
            {
                Id = 15,
                Options = new List<string>
                {
                    "Phishing",
                    "Ransomware",
                    "Spyware"
                },
                Question = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",
                SubcategoryId = 16,
            },
            new QuestionModel
            {
                Id = 16,
                Options = new List<string>
                {
                    "Spyware",
                    "Ransomware",
                    "Adware"
                },
                Question = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",
                SubcategoryId = 17,
            },
            new QuestionModel
            {
                Id = 17,
                Options = new List<string>
                {
                    "Cyberkriminalitet",
                    "Cyberspionage",
                    "Cyberterrorism"
                },
                Question = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 18,
                Options = new List<string>
                {
                    "Öka användningen av kryptering för all intern och extern kommunikation",
                    "Förbjuda all användning av e-post och återgå till fysisk korrespondens",
                    "Installera antivirusprogram på alla datorer"
                },
                Question = "Vilken försvarsstrategi är mest effektiv mot cyberspionage som riktar sig mot känslig kommunikation?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 19,
                Options = new List<string>
                {
                    "Genomföra strikta bakgrundskontroller av alla anställda",
                    "Implementera ett omfattande program för beteendeanalys och anomalidetektering",
                    "Begränsa internetanvändningen på arbetsplatsen till arbetsrelaterade aktiviteter"
                },
                Question = "Hur kan organisationer bäst upptäcka och motverka insiderhot som bidrar till cyberspionage?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 20,
                Options = new List<string>
                {
                    "Genomföra regelbundna medvetenhetsträningar för alla anställda om cybersäkerhet",
                    "Hålla all mjukvara och operativsystem uppdaterade med de senaste säkerhetspatcharna",
                    "Endast använda egenutvecklad mjukvara för alla verksamhetsprocesser"
                },
                Question = "Vilken åtgärd är viktigast för att skydda sig mot cyberspionage genom utnyttjande av mjukvarusårbarheter?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 21,
                Options = new List<string>
                {
                    "Social ingenjörskonst",
                    "Massövervakning",
                    "Riktade cyberattacker"
                },
                Question = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",
                SubcategoryId = 37,
            },
            new QuestionModel
            {
                Id = 22,
                Options = new List<string>
                {
                    "GDPR",
                    "Säkerhetsskyddslagen",
                    "IT-säkerhetslagen"
                },
                Question = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",
                SubcategoryId = 38,
            },
            new QuestionModel
            {
                Id = 23,
                Options = new List<string>
                {
                    "Oberoende hackare",
                    "Aktivistgrupper",
                    "Statssponsrade hackers"
                },
                Question = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",
                SubcategoryId = 39,
            });



            builder.Entity<SolutionModel>().HasData(
                new SolutionModel
                {
                    Id = 1,
                    CorrectAnswer = "Ett potentiellt telefonbedrägeri",
                    QuestionId = 1,
                    Explanation = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri."

                }, new SolutionModel
                {
                    Id = 2,
                    CorrectAnswer = "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet är korrekt.",
                    QuestionId = 2,
                    Explanation = "Det säkraste sättet att hantera potentiella telefonbedrägerier är att avsluta samtalet och sedan själv ringa upp din bank via ett telefonnummer du vet är korrekt (till exempel från deras officiella webbplats eller ditt bankkort) för att verifiera om samtalet var legitimt."
                },
                new SolutionModel
                {
                    Id = 3,
                    CorrectAnswer = "Banker och finansiella institutioner kommer aldrig att be dig om ditt lösenord eller kontonummer via telefon eller e-post.",
                    QuestionId = 3,
                    Explanation = "Kommunikationen från banker och finansiella institutioner innehåller aldrig förfrågningar om känslig information som lösenord eller kontonummer via osäkra kanaler som telefon eller e-post. Detta är en grundläggande säkerhetsprincip."

                },
                new SolutionModel
                {
                    Id = 4,
                    CorrectAnswer = "Upprätta starka säkerhetsfrågor med din bank som krävs för att identifiera dig över telefon",
                    QuestionId = 4,
                    Explanation = "Genom att ha förutbestämda säkerhetsfrågor med din bank kan du och banken ha en säker metod för att bekräfta varandras identitet under telefonsamtal. Detta minskar risken för att bli lurad av bedragare som inte kan svara på dessa frågor.\r\n"

                },
                new SolutionModel
                {
                    Id = 5,
                    CorrectAnswer = "Ett romansbedrägeri",
                    QuestionId = 5,
                    Explanation = "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri",

                },
                new SolutionModel
                {
                    Id = 4,
                    CorrectAnswer = "Investeringsbedrägeri",
                    QuestionId = 4,
                    Explanation = "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier."

                },
                new SolutionModel
                {
                    Id = 5,
                    CorrectAnswer = "Kreditkortsbedrägeri",
                    QuestionId = 5,
                    Explanation = "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri."

                },
                new SolutionModel
                {
                    Id = 6,
                    CorrectAnswer = "Utbildning i digital säkerhet för alla anställda",
                    QuestionId = 6,
                    Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor"

                },
                new SolutionModel
                {
                    Id = 7,
                    CorrectAnswer = "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag",
                    QuestionId = 7,
                    Explanation = "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst."

                },
                new SolutionModel
                {
                    Id = 8,
                    CorrectAnswer = "Implementera en policy för lösenordskomplexitet som kräver automatiska lösenordsändringar var 90:e dag",
                    QuestionId = 7,
                    Explanation = "En automatisk policy för lösenordsändring tvingar fram regelbundna uppdateringar och säkerställer att lösenorden hålls starka och svåra att knäcka, vilket minskar risken för obehörig åtkomst."

                }
                ); 


            // Beskrivning: en kategori innehåller flera segment men ett segment tillhör bara en kategori. 
            // 1:N mellan category och segment:
            builder.Entity<SegmentModel>()
            .HasOne(s => s.Category)
            .WithMany(c => c.Segments)
            .HasForeignKey(s => s.CategoryId);

            // Beskrivning: en subkategori tillhör ett segment men ett segment innehåller flera subkategorier. 
            // 1:N mellan segment och subcategory:
            builder.Entity<SubcategoryModel>()
            .HasOne(s => s.Segment)
            .WithMany(c => c.Subcategories)
            .HasForeignKey(s => s.SegmentId);

            // Beskrivning: En subkategori innehåller flera frågor men en fråga tillhör bara en subkategori. 
            // 1:N mellan subcategory och question:
            builder.Entity<QuestionModel>()
            .HasOne(s => s.SubCategory)
            .WithMany(c => c.Questions)
            .HasForeignKey(s => s.SubcategoryId);

            // Beskrivning: En fråga har bara en solution och en solution tillhör bara en fråga. 
            // 1:1 mellan question och solution:
            builder.Entity<QuestionModel>()
           .HasOne(q => q.Solution)
           .WithOne(s => s.Question)
           .HasForeignKey<SolutionModel>(s => s.QuestionId);

            // Beskrivning: Ett svarsresultat tillhör bara en fråga men en fråga kan ha många svarsresultat
            //  1:N mellan result och question:
            builder.Entity<ResultModel>()
           .HasOne(r => r.Question)
           .WithMany(q => q.Results)
           .HasForeignKey(s => s.QuestionId);

            // Beskrivning: en user kan ha många svarsresultat och ett svarsresultat kan has av många users 
            // M:N mellan user och result
            // Beskrivning: en user kan ha många svarsresultat och ett svarsresultat kan has av många users 
            // M:N mellan user och result
            builder.Entity<UserResult>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserResults)
                .HasForeignKey(ur => ur.UserId);

            builder.Entity<UserResult>()
                .HasOne(u => u.Result)
                .WithMany(t => t.UserResults)
                .HasForeignKey(tt => tt.ResultId);
        }
    }
}
