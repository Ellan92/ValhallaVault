using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<SegmentModel> Segments { get; set; }
        public DbSet<SubcategoryModel> Subcategories { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ResponseModel> Responses { get; set; }

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
                    SegmentName = "Kreditkortsbedrägeri",
                    CategoryId = 1,
                },
            new SegmentModel
            {
                Id = 2,
                SegmentName = "Romansbedrägeri",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 3,
                SegmentName = "Investeringsbedrägeri",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 4,
                SegmentName = "Telefonbedrägeri",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 5,
                SegmentName = "Bedrägerier i hemmet",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 6,
                SegmentName = "Identitetsstöld",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 7,
                SegmentName = "Nätfiske och bluffmejl",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 8,
                SegmentName = "Investeringsbedrägeri på nätet",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 9,
                SegmentName = "Abonnemangsfällor och falska fakturor",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 11,
                SegmentName = "Ransomware",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 12,
                SegmentName = "Statistik och förhållningssätt",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 13,
                SegmentName = "Digital säkerhet på företag",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 14,
                SegmentName = "Aktörer inom cyberbrott",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 15,
                SegmentName = "Ökad digital närvaro och distansarbete",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 16,
                SegmentName = "Cyberangrepp mot känsliga sektorer",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 17,
                SegmentName = "Cyberrånet mot Mersk",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 18,
                SegmentName = "Social engineering",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 19,
                SegmentName = "Nätfiske och skräppost",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 20,
                SegmentName = "Vishing",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 21,
                SegmentName = "Varning för vishing",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 22,
                SegmentName = "Identifiera VD-mejl",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 23,
                SegmentName = "Öneangrepp och presentkortsbluffar",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 24,
                SegmentName = "Virus, maskar och trojaner",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 25,
                SegmentName = "Så kan det gå till",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 26,
                SegmentName = "Nätverksintrång",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 27,
                SegmentName = "Dataintrång",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 28,
                SegmentName = "Hackad!",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 29,
                SegmentName = "Utpressningsvirus",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 30,
                SegmentName = "Attacker mot servrar",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 31,
                SegmentName = "Cyberangrepp i Norden",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 32,
                SegmentName = "It-brottslingarnas verktyg",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 33,
                SegmentName = "Mirai, Wannacry och fallet Düsseldorf",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 34,
                SegmentName = "De sårbara molnen",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 35,
                SegmentName = "Allmänt om cyberspionage",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 36,
                SegmentName = "Metoder för cyberspionage",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 37,
                SegmentName = "Säkerhetsskyddslagen",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 38,
                SegmentName = "Cyberspionagets aktörer",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 39,
                SegmentName = "Värvningsförsök",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 40,
                SegmentName = "Affärsspionage",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 41,
                SegmentName = "Påverkanskampanjer",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 42,
                SegmentName = "Svensk underrättelsetjänst och cyberförsvar",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 43,
                SegmentName = "Signalspaning, informationssäkerhet och 5G",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 44,
                SegmentName = "Samverkan mot cyberspionage",
                CategoryId = 3,
            });



            builder.Entity<QuestionModel>().HasData(
            new QuestionModel
            {
                Id = 1,
                Question = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att säkerställa din kontos säkerhet efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                SubcategoryId = 1,
            },
            new QuestionModel
            {
                Id = 2,
                Question = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                SubcategoryId = 2,
            },
            new QuestionModel
            {
                Id = 3,
                Question = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                SubcategoryId = 3,
            },
            new QuestionModel
            {
                Id = 4,
                Question = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                SubcategoryId = 4,
            },
            new QuestionModel
            {
                Id = 5,
                Question = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 6,
                Question = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",
                SubcategoryId = 13,
            },
            new QuestionModel
            {
                Id = 7,
                Question = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",
                SubcategoryId = 14,
            },
            new QuestionModel
            {
                Id = 8,
                Question = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",
                SubcategoryId = 15,
            },
            new QuestionModel
            {
                Id = 9,
                Question = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",
                SubcategoryId = 16,
            },
            new QuestionModel
            {
                Id = 10,
                Question = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",
                SubcategoryId = 17,
            },
            new QuestionModel
            {
                Id = 11,
                Question = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 12,
                Question = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",
                SubcategoryId = 37,
            },
            new QuestionModel
            {
                Id = 13,
                Question = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",
                SubcategoryId = 38,
            },
            new QuestionModel
            {
                Id = 14,
                Question = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",
                SubcategoryId = 39,
            });


            builder.Entity<ResponseModel>().HasData(
                new ResponseModel
                {
                    Id = 1,
                    IsCorrect = false,
                    Answer = "Ett legitimt försök från banken att skydda ditt konto",

                },
                new ResponseModel
                {
                    Id = 2,
                    IsCorrect = false,
                    Answer = "En informationsinsamling för en marknadsundersökning"
                },
                new ResponseModel
                {
                    Id = 3,
                    IsCorrect = true,
                    Answer = "Ett potentiellt telefonbedrägeri",
                    Explanation = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri."
                });

            builder.Entity<CategoryModel>()
                .HasMany(x => x.Segments)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId);

            builder.Entity<SegmentModel>()
                .HasMany(x => x.Questions)
                .WithOne(c => c.Segment)
                .HasForeignKey(c => c.SegmentId);

            builder.Entity<ApplicationUser>()
                .HasMany(x => x.Questions)
                .WithMany(c => c.Users);

        }
    }
}
