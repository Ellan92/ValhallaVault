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
                    CategoryName = "Att skydda sig mot bedr�gerier",
                    Description = "Syftar p� att ta f�rsiktighets�tg�rder f�r att undvika att bli lurad eller manipulerad av bedr�gliga aktiviteter eller m�nniskor. Det inneb�r att vara medveten om potentiella risker, att vara f�rsiktig med personlig information och att utveckla strategier f�r att identifiera och undvika bedr�gerier",
                },

            new CategoryModel
            {
                Id = 2,
                CategoryName = "Cybers�kerhet f�r f�retag",
                Description = "Detta inneb�r att implementera en serie av s�kerhets�tg�rder och b�sta praxis f�r att skydda f�retagets digitala tillg�ngar, information och system fr�n cyberhot och attacker. Det omfattar vanligtvis anv�ndningen av tekniska l�sningar som brandv�ggar, antivirusprogram, kryptering och s�kerhetskopiering, samt etablering av s�kerhetspolicyer och rutiner f�r att hantera risker och incidenter."
            },

            new CategoryModel
            {
                Id = 3,
                CategoryName = "Cyberspionage",
                Description = "Cyberspionage �r en form av spionage d�r angripare anv�nder digitala metoder f�r att infiltrera och stj�la konfidentiell information fr�n organisationer, myndigheter eller enskilda individer. Det inneb�r vanligtvis anv�ndning av avancerade tekniker s�som malware, phishing och social engineering f�r att f� tillg�ng till k�nslig data utan att uppt�ckas."
            });

            builder.Entity<SegmentModel>().HasData(
                new SegmentModel
                {
                    Id = 1,
                    SegmentName = "Kreditkortsbedr�geri",
                    CategoryId = 1,
                },
            new SegmentModel
            {
                Id = 2,
                SegmentName = "Romansbedr�geri",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 3,
                SegmentName = "Investeringsbedr�geri",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 4,
                SegmentName = "Telefonbedr�geri",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 5,
                SegmentName = "Bedr�gerier i hemmet",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 6,
                SegmentName = "Identitetsst�ld",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 7,
                SegmentName = "N�tfiske och bluffmejl",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 8,
                SegmentName = "Investeringsbedr�geri p� n�tet",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 9,
                SegmentName = "Abonnemangsf�llor och falska fakturor",
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
                SegmentName = "Statistik och f�rh�llningss�tt",
                CategoryId = 1,
            },
            new SegmentModel
            {
                Id = 13,
                SegmentName = "Digital s�kerhet p� f�retag",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 14,
                SegmentName = "Akt�rer inom cyberbrott",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 15,
                SegmentName = "�kad digital n�rvaro och distansarbete",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 16,
                SegmentName = "Cyberangrepp mot k�nsliga sektorer",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 17,
                SegmentName = "Cyberr�net mot Mersk",
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
                SegmentName = "N�tfiske och skr�ppost",
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
                SegmentName = "Varning f�r vishing",
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
                SegmentName = "�neangrepp och presentkortsbluffar",
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
                SegmentName = "S� kan det g� till",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 26,
                SegmentName = "N�tverksintr�ng",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 27,
                SegmentName = "Dataintr�ng",
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
                SegmentName = "Mirai, Wannacry och fallet D�sseldorf",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 34,
                SegmentName = "De s�rbara molnen",
                CategoryId = 2,
            },
            new SegmentModel
            {
                Id = 35,
                SegmentName = "Allm�nt om cyberspionage",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 36,
                SegmentName = "Metoder f�r cyberspionage",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 37,
                SegmentName = "S�kerhetsskyddslagen",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 38,
                SegmentName = "Cyberspionagets akt�rer",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 39,
                SegmentName = "V�rvningsf�rs�k",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 40,
                SegmentName = "Aff�rsspionage",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 41,
                SegmentName = "P�verkanskampanjer",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 42,
                SegmentName = "Svensk underr�ttelsetj�nst och cyberf�rsvar",
                CategoryId = 3,
            },
            new SegmentModel
            {
                Id = 43,
                SegmentName = "Signalspaning, informationss�kerhet och 5G",
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
                Question = "Du f�r ett ov�ntat telefonsamtal fr�n n�gon som p�st�r sig vara fr�n din bank. Personen ber dig bekr�fta ditt kontonummer och l�senord f�r att s�kerst�lla din kontos s�kerhet efter en p�st�dd s�kerhetsincident. Hur b�r du tolka denna situation?",
                SubcategoryId = 1,
            },
            new QuestionModel
            {
                Id = 2,
                Question = "Efter flera m�nader av daglig kommunikation med n�gon du tr�ffade p� en datingsida, b�rjar personen ber�tta om en pl�tslig finansiell kris och ber om din hj�lp genom att �verf�ra pengar. Vad indikerar detta mest sannolikt?",
                SubcategoryId = 2,
            },
            new QuestionModel
            {
                Id = 3,
                Question = "Du f�r ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-f�retag som p�st�s ha en revolutionerande ny teknologi, med garantier om exceptionellt h�g avkastning p� mycket kort tid. Hur b�r du f�rh�lla dig till erbjudandet?",
                SubcategoryId = 3,
            },
            new QuestionModel
            {
                Id = 4,
                Question = "Efter en online-shoppingrunda m�rker du oidentifierade transaktioner p� ditt kreditkortsutdrag fr�n f�retag du aldrig handlat fr�n. Vad indikerar detta mest sannolikt?",
                SubcategoryId = 4,
            },
            new QuestionModel
            {
                Id = 5,
                Question = "Inom f�retaget m�rker man att konfidentiella dokument regelbundet l�cker ut till konkurrenter. Efter en intern granskning uppt�cks det att en anst�lld omedvetet har installerat skadlig programvara genom att klicka p� en l�nk i ett phishing-e-postmeddelande. Vilken �tg�rd b�r prioriteras f�r att f�rhindra framtida incidenter?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 6,
                Question = "Inom f�retaget uppt�ckts det en s�rbarhet i v�r programvara som kunde m�jligg�ra obeh�rig �tkomst till anv�ndardata. F�retaget har inte omedelbart en l�sning. Vilken �r den mest l�mpliga f�rsta �tg�rden?",
                SubcategoryId = 13,
            },
            new QuestionModel
            {
                Id = 7,
                Question = "V�rt f�retag blir m�ltavla f�r en DDoS-attack som �verv�ldigar v�ra servers och g�r v�ra tj�nster otillg�ngliga f�r kunder. Vilken typ av akt�r �r mest sannolikt ansvarig f�r denna typ av attack?",
                SubcategoryId = 14,
            },
            new QuestionModel
            {
                Id = 8,
                Question = "Med �verg�ngen till distansarbete uppt�cker v�rt f�retag en �kning av s�kerhetsincidenter, inklusive obeh�rig �tkomst till f�retagsdata. Vilken �tg�rd b�r f�retaget vidta f�r att adressera denna nya riskmilj�?",
                SubcategoryId = 15,
            },
            new QuestionModel
            {
                Id = 9,
                Question = "H�lsov�rdsmyndigheten uts�tts f�r ett cyberangrepp som krypterar patientdata och kr�ver l�sen f�r att �terst�lla �tkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta f�r?",
                SubcategoryId = 16,
            },
            new QuestionModel
            {
                Id = 10,
                Question = "Det globala fraktbolaget Maersk blev offer f�r ett omfattande cyberangrepp som avsev�rt st�rde deras verksamhet v�rlden �ver. Vilken typ av malware var prim�rt ansvarig f�r denna incident?",
                SubcategoryId = 17,
            },
            new QuestionModel
            {
                Id = 11,
                Question = "Regeringen uppt�cker att k�nslig politisk kommunikation har l�ckt och misst�nker elektronisk �vervakning. Vilket fenomen beskriver b�st denna situation?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 12,
                Question = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day s�rbarheter f�r att infiltrera deras n�tverk och stj�la oerh�rt viktig data. Vilken metod f�r cyberspionage anv�nds sannolikt h�r?",
                SubcategoryId = 37,
            },
            new QuestionModel
            {
                Id = 13,
                Question = "Regeringen i Sverige �kar sitt interna s�kerhetsprotokoll f�r att skydda sig mot utl�ndska underr�ttelsetj�nsters infiltration. Vilken lagstiftning ger ramverket f�r detta skydd?",
                SubcategoryId = 38,
            },
            new QuestionModel
            {
                Id = 14,
                Question = "Lunds universitet uppt�cker att forskningsdata om ny teknologi har stulits. Unders�kningar tyder p� en v�lorganiserad grupp med kopplingar till en utl�ndsk stat. Vilken typ av akt�r ligger sannolikt bakom detta?",
                SubcategoryId = 39,
            });


            builder.Entity<ResponseModel>().HasData(
                new ResponseModel
                {
                    Id = 1,
                    IsCorrect = false,
                    Answer = "Ett legitimt f�rs�k fr�n banken att skydda ditt konto",

                },
                new ResponseModel
                {
                    Id = 2,
                    IsCorrect = false,
                    Answer = "En informationsinsamling f�r en marknadsunders�kning"
                },
                new ResponseModel
                {
                    Id = 3,
                    IsCorrect = true,
                    Answer = "Ett potentiellt telefonbedr�geri",
                    Explanation = "Banker och andra finansiella institutioner beg�r aldrig k�nslig information s�som kontonummer eller l�senord via telefon. Detta �r ett klassiskt tecken p� telefonbedr�geri."
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
