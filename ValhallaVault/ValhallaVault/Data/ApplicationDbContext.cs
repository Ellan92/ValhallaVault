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
            });



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
