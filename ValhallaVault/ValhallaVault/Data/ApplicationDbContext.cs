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
        public DbSet<CompletedSubcategoryModel> CompletedSubcategories { get; set; }

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
                    SubCategoryName = "Kreditkortsbedr�geri",
                    SegmentId = 1,
                },
            new SubcategoryModel
            {
                Id = 2,
                SubCategoryName = "Romansbedr�geri",
                SegmentId = 1,
            },
            new SubcategoryModel
            {
                Id = 3,
                SubCategoryName = "Investeringsbedr�geri",
                SegmentId = 1,
            },
            new SubcategoryModel
            {
                Id = 4,
                SubCategoryName = "Telefonbedr�geri",
                SegmentId = 1,
            },
            new SubcategoryModel
            {
                Id = 5,
                SubCategoryName = "Bedr�gerier i hemmet",
                SegmentId = 2,
            },
            new SubcategoryModel
            {
                Id = 6,
                SubCategoryName = "Identitetsst�ld",
                SegmentId = 2,
            },
            new SubcategoryModel
            {
                Id = 7,
                SubCategoryName = "N�tfiske och bluffmejl",
                SegmentId = 2,
            },
            new SubcategoryModel
            {
                Id = 8,
                SubCategoryName = "Investeringsbedr�geri p� n�tet",
                SegmentId = 2,
            },
            new SubcategoryModel
            {
                Id = 9,
                SubCategoryName = "Abonnemangsf�llor och falska fakturor",
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
                SubCategoryName = "Statistik och f�rh�llningss�tt",
                SegmentId = 3,
            },
            new SubcategoryModel
            {
                Id = 12,
                SubCategoryName = "Digital s�kerhet p� f�retag",
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
                SubCategoryName = "Akt�rer inom cyberbrott",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 15,
                SubCategoryName = "�kad digital n�rvaro och distansarbete",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 16,
                SubCategoryName = "Cyberangrepp mot k�nsliga sektorer",
                SegmentId = 4,
            },
            new SubcategoryModel
            {
                Id = 17,
                SubCategoryName = "Cyberr�net mot Mersk ",
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
                SubCategoryName = "N�tfiske och skr�ppost",
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
                SubCategoryName = "Varning f�r vishing",
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
                SubCategoryName = "�neangrepp och presentkortsbluffar",
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
                SubCategoryName = "S� kan det g� till",
                SegmentId = 6,
            },
            new SubcategoryModel
            {
                Id = 26,
                SubCategoryName = "N�tverksintr�ng",
                SegmentId = 6,
            },
            new SubcategoryModel
            {
                Id = 27,
                SubCategoryName = "Dataintr�ng",
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
                SubCategoryName = "V�garna in",
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
                SubCategoryName = "Mirai, Wannacry och fallet D�sseldorf",
                SegmentId = 7,
            },
            new SubcategoryModel
            {
                Id = 35,
                SubCategoryName = "De s�rbara molnen",
                SegmentId = 7,
            },
            new SubcategoryModel
            {
                Id = 36,
                SubCategoryName = "Allm�nt om cyberspionage",
                SegmentId = 8,
            },
            new SubcategoryModel
            {
                Id = 37,
                SubCategoryName = "Metoder f�r cyberspionage",
                SegmentId = 8,
            },
            new SubcategoryModel
            {
                Id = 38,
                SubCategoryName = "S�kerhetsskyddslagen",
                SegmentId = 8,
            },
            new SubcategoryModel
            {
                Id = 39,
                SubCategoryName = "Cyberspionagets akt�rer",
                SegmentId = 8,
            },
            new SubcategoryModel
            {
                Id = 40,
                SubCategoryName = "V�rvningsf�rs�k",
                SegmentId = 9,
            },
            new SubcategoryModel
            {
                Id = 41,
                SubCategoryName = "Aff�rsspionage",
                SegmentId = 9,
            },
            new SubcategoryModel
            {
                Id = 42,
                SubCategoryName = "P�verkanskampanjer",
                SegmentId = 9,
            },
            new SubcategoryModel
            {
                Id = 43,
                SubCategoryName = "Svensk underr�ttelsetj�nst och cyberf�rsvar",
                SegmentId = 10,
            },
            new SubcategoryModel
            {
                Id = 44,
                SubCategoryName = "Signalspaning, informationss�kerhet och 5G",
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
                    "Ett legitimt f�rs�k fr�n banken att skydda ditt konto",
                    "En informationsinsamling f�r en marknadsunders�kning",
                    "Ett potentiellt telefonbedr�geri"
                },
                    Question = "Du f�r ett ov�ntat telefonsamtal fr�n n�gon som p�st�r sig vara fr�n din bank. Personen ber dig bekr�fta ditt kontonummer och l�senord f�r att s�kerst�lla din kontos s�kerhet efter en p�st�dd s�kerhetsincident. Hur b�r du tolka denna situation?",
                    SubcategoryId = 1,
                },
            new QuestionModel
            {
                Id = 2,
                Options = new List<string>
                {
                    "Ge dem informationen de ber om, f�r s�kerhets skull",
                    "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet �r korrekt",
                    "V�nta p� att de ska ringa tillbaka f�r att bekr�fta deras legitimitet"
                },
                Question = "Vad b�r du g�ra omedelbart efter att ha mottagit ett misst�nkt telefonsamtal d�r n�gon fr�gar efter personlig finansiell information?",
                SubcategoryId = 1,
            },
            new QuestionModel
            {
                Id = 3,
                Options = new List<string>
                {
                    "Banker skickar ofta e-postmeddelanden som ber kunder att direkt ange l�senord och kontonummer f�r verifiering.",
                    "Banker ringer regelbundet sina kunder f�r att be dem upprepa sina kontouppgifter f�r s�kerhetsuppdateringar.",
                    "Banker och finansiella institutioner kommer aldrig att be dig om ditt l�senord eller kontonummer via telefon eller e-post."
                },
                Question = "Vilket av f�ljande p�st�enden �r sant ang�ende hur finansiella institutioner kommunicerar med sina kunder?",
                SubcategoryId = 1,
            },
            new QuestionModel
            {
                Id = 4,
                Options = new List<string>
                {
                    "Installera en app som blockerar misst�nkta samtal",
                    "Aldrig svara p� samtal fr�n ok�nda nummer",
                    "Uppr�tta starka s�kerhetsfr�gor med din bank som kr�vs f�r att identifiera dig �ver telefon"
                },
                Question = "Hur kan du b�st skydda dig mot telefonbedr�gerier",
                SubcategoryId = 1,
            },
            new QuestionModel
            {
                Id = 5,
                Options = new List<string>
                {
                    "En legitim beg�ran om hj�lp fr�n en person i n�d",
                    "Ett romansbedr�geri",
                    "En tillf�llig ekonomisk sv�righet"
                },
                Question = "Efter flera m�nader av daglig kommunikation med n�gon du tr�ffade p� en datingsida, b�rjar personen ber�tta om en pl�tslig finansiell kris och ber om din hj�lp genom att �verf�ra pengar. Vad indikerar detta mest sannolikt?",
                SubcategoryId = 2,
            },
            new QuestionModel
            {
                Id = 6,
                Options = new List<string>
                {
                    "Genomf�ra omedelbar investering f�r att inte missa m�jligheten",
                    "Investeringsbedr�geri",
                    "Beg�ra mer information f�r att utf�ra en noggrann ��due diligence�"
                },
                Question = "Du f�r ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-f�retag som p�st�s ha en revolutionerande ny teknologi, med garantier om exceptionellt h�g avkastning p� mycket kort tid. Hur b�r du f�rh�lla dig till erbjudandet?",
                SubcategoryId = 3,
            },
            new QuestionModel
            {
                Id = 7,
                Options = new List<string>
                {
                    "Ett misstag av kreditkortsf�retaget",
                    "Kreditkortsbedr�geri",
                    "Obeh�riga k�p av en familjemedlem"
                },
                Question = "Efter en online-shoppingrunda m�rker du oidentifierade transaktioner p� ditt kreditkortsutdrag fr�n f�retag du aldrig handlat fr�n. Vad indikerar detta mest sannolikt?",
                SubcategoryId = 4,
            },
            new QuestionModel
            {
                Id = 8,
                Options = new List<string>
                {
                    "Utbildning i digital s�kerhet f�r alla anst�llda",
                    "Installera en starkare brandv�gg",
                    "Byta ut all IT-utrustning"
                },
                Question = "Inom f�retaget m�rker man att konfidentiella dokument regelbundet l�cker ut till konkurrenter. Efter en intern granskning uppt�cks det att en anst�lld omedvetet har installerat skadlig programvara genom att klicka p� en l�nk i ett phishing-e-postmeddelande. Vilken �tg�rd b�r prioriteras f�r att f�rhindra framtida incidenter?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 9,
                Options = new List<string>
                {
                    "Manuellt kontrollera varje anst�llds l�senord en g�ng per �r",
                    "Implementera en policy f�r l�senordskomplexitet som kr�ver automatiska l�senords�ndringar var 90:e dag",
                    "Uppmana anst�llda att v�lja l�ttih�gda l�senord f�r att undvika att skriva ner dem"
                },
                Question = "Vilken �tg�rd �r mest effektiv f�r att s�kerst�lla att anst�llda regelbundet uppdaterar sina l�senord till starkare och mer komplexa versioner?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 10,
                Options = new List<string>
                {
                    "F�rbjuda anv�ndning av offentliga Wi-Fi-n�tverk helt och h�llet",
                    "Utrusta alla anst�lldas enheter med VPN (Virtual Private Network)-tj�nster",
                    "Endast till�ta anst�llda att arbeta offline n�r de inte �r p� kontoret"
                },
                Question = "Hur kan f�retaget effektivt minska risken f�r att anst�llda oavsiktligt exponerar f�retagsdata via otrygga Wi-Fi-n�tverk?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 11,
                Options = new List<string>
                {
                    "Blockera all inkommande e-post fr�n externa k�llor",
                    "Installera och uppdatera regelbundet e-posts�kerhetsl�sningar som filtrerar bort skadlig programvara och misst�nkta l�nkar",
                    "L�ta anst�llda anv�nda personliga e-postkonton f�r arbete f�r att minska risken f�r f�retagets e-postservers s�kerhet"
                },
                Question = "Vilken �tg�rd b�r ett f�retag ta f�r att skydda sig mot intr�ng via e-postbaserade hot som phishing?",
                SubcategoryId = 12,
            },
            new QuestionModel
            {
                Id = 12,
                Options = new List<string>
                {
                    "Informera alla anv�ndare om s�rbarheten och rekommendera tempor�ra skydds�tg�rder",
                    "Ignorera problemet tills en patch kan utvecklas",
                    "St�nga ner tj�nsten tillf�lligt"
                },
                Question = "Inom f�retaget uppt�ckts det en s�rbarhet i v�r programvara som kunde m�jligg�ra obeh�rig �tkomst till anv�ndardata. F�retaget har inte omedelbart en l�sning. Vilken �r den mest l�mpliga f�rsta �tg�rden?",
                SubcategoryId = 13,
            },
            new QuestionModel
            {
                Id = 13,
                Options = new List<string>
                {
                    "En enskild hackare med ett personligt vendetta",
                    "En konkurrerande f�retagsentitet",
                    "Organiserade cyberbrottsliga grupper"
                },
                Question = "V�rt f�retag blir m�ltavla f�r en DDoS-attack som �verv�ldigar v�ra servers och g�r v�ra tj�nster otillg�ngliga f�r kunder. Vilken typ av akt�r �r mest sannolikt ansvarig f�r denna typ av attack?",
                SubcategoryId = 14,
            },
            new QuestionModel
            {
                Id = 14,
                Options = new List<string>
                {
                    "�terg� till kontorsarbete",
                    "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                    "F�rbjuda anv�ndning av personliga enheter f�r arbete"
                },
                Question = "Med �verg�ngen till distansarbete uppt�cker v�rt f�retag en �kning av s�kerhetsincidenter, inklusive obeh�rig �tkomst till f�retagsdata. Vilken �tg�rd b�r f�retaget vidta f�r att adressera denna nya riskmilj�?",
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
                Question = "H�lsov�rdsmyndigheten uts�tts f�r ett cyberangrepp som krypterar patientdata och kr�ver l�sen f�r att �terst�lla �tkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta f�r?",
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
                Question = "Det globala fraktbolaget Maersk blev offer f�r ett omfattande cyberangrepp som avsev�rt st�rde deras verksamhet v�rlden �ver. Vilken typ av malware var prim�rt ansvarig f�r denna incident?",
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
                Question = "Regeringen uppt�cker att k�nslig politisk kommunikation har l�ckt och misst�nker elektronisk �vervakning. Vilket fenomen beskriver b�st denna situation?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 18,
                Options = new List<string>
                {
                    "�ka anv�ndningen av kryptering f�r all intern och extern kommunikation",
                    "F�rbjuda all anv�ndning av e-post och �terg� till fysisk korrespondens",
                    "Installera antivirusprogram p� alla datorer"
                },
                Question = "Vilken f�rsvarsstrategi �r mest effektiv mot cyberspionage som riktar sig mot k�nslig kommunikation?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 19,
                Options = new List<string>
                {
                    "Genomf�ra strikta bakgrundskontroller av alla anst�llda",
                    "Implementera ett omfattande program f�r beteendeanalys och anomalidetektering",
                    "Begr�nsa internetanv�ndningen p� arbetsplatsen till arbetsrelaterade aktiviteter"
                },
                Question = "Hur kan organisationer b�st uppt�cka och motverka insiderhot som bidrar till cyberspionage?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 20,
                Options = new List<string>
                {
                    "Genomf�ra regelbundna medvetenhetstr�ningar f�r alla anst�llda om cybers�kerhet",
                    "H�lla all mjukvara och operativsystem uppdaterade med de senaste s�kerhetspatcharna",
                    "Endast anv�nda egenutvecklad mjukvara f�r alla verksamhetsprocesser"
                },
                Question = "Vilken �tg�rd �r viktigast f�r att skydda sig mot cyberspionage genom utnyttjande av mjukvarus�rbarheter?",
                SubcategoryId = 36,
            },
            new QuestionModel
            {
                Id = 21,
                Options = new List<string>
                {
                    "Social ingenj�rskonst",
                    "Mass�vervakning",
                    "Riktade cyberattacker"
                },
                Question = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day s�rbarheter f�r att infiltrera deras n�tverk och stj�la oerh�rt viktig data. Vilken metod f�r cyberspionage anv�nds sannolikt h�r?",
                SubcategoryId = 37,
            },
            new QuestionModel
            {
                Id = 22,
                Options = new List<string>
                {
                    "GDPR",
                    "S�kerhetsskyddslagen",
                    "IT-s�kerhetslagen"
                },
                Question = "Regeringen i Sverige �kar sitt interna s�kerhetsprotokoll f�r att skydda sig mot utl�ndska underr�ttelsetj�nsters infiltration. Vilken lagstiftning ger ramverket f�r detta skydd?",
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
                Question = "Lunds universitet uppt�cker att forskningsdata om ny teknologi har stulits. Unders�kningar tyder p� en v�lorganiserad grupp med kopplingar till en utl�ndsk stat. Vilken typ av akt�r ligger sannolikt bakom detta?",
                SubcategoryId = 39,
            });



            builder.Entity<SolutionModel>().HasData(
                new SolutionModel
                {
                    Id = 1,
                    CorrectAnswer = "Ett potentiellt telefonbedr�geri",
                    QuestionId = 1,
                    Explanation = "Banker och andra finansiella institutioner beg�r aldrig k�nslig information s�som kontonummer eller l�senord via telefon. Detta �r ett klassiskt tecken p� telefonbedr�geri."

                }, new SolutionModel
                {
                    Id = 2,
                    CorrectAnswer = "Avsluta samtalet och kontakta din bank direkt via ett officiellt nummer du vet �r korrekt.",
                    QuestionId = 2,
                    Explanation = "Det s�kraste s�ttet att hantera potentiella telefonbedr�gerier �r att avsluta samtalet och sedan sj�lv ringa upp din bank via ett telefonnummer du vet �r korrekt (till exempel fr�n deras officiella webbplats eller ditt bankkort) f�r att verifiera om samtalet var legitimt."
                },
                new SolutionModel
                {
                    Id = 3,
                    CorrectAnswer = "Banker och finansiella institutioner kommer aldrig att be dig om ditt l�senord eller kontonummer via telefon eller e-post.",
                    QuestionId = 3,
                    Explanation = "Kommunikationen fr�n banker och finansiella institutioner inneh�ller aldrig f�rfr�gningar om k�nslig information som l�senord eller kontonummer via os�kra kanaler som telefon eller e-post. Detta �r en grundl�ggande s�kerhetsprincip."

                },
                new SolutionModel
                {
                    Id = 4,
                    CorrectAnswer = "Uppr�tta starka s�kerhetsfr�gor med din bank som kr�vs f�r att identifiera dig �ver telefon",
                    QuestionId = 4,
                    Explanation = "Genom att ha f�rutbest�mda s�kerhetsfr�gor med din bank kan du och banken ha en s�ker metod f�r att bekr�fta varandras identitet under telefonsamtal. Detta minskar risken f�r att bli lurad av bedragare som inte kan svara p� dessa fr�gor.\r\n"

                },
                new SolutionModel
                {
                    Id = 5,
                    CorrectAnswer = "Ett romansbedr�geri",
                    QuestionId = 5,
                    Explanation = "Beg�ran om pengar, s�rskilt under omst�ndigheter d�r tv� personer aldrig har tr�ffats fysiskt, �r ett vanligt tecken p� romansbedr�geri",

                },
                new SolutionModel
                {
                    Id = 6,
                    CorrectAnswer = "Investeringsbedr�geri",
                    QuestionId = 6,
                    Explanation = "Erbjudanden som lovar h�g avkastning med liten eller ingen risk, s�rskilt via o�nskade e-postmeddelanden, �r ofta tecken p� investeringsbedr�gerier."

                },
                new SolutionModel
                {
                    Id = 7,
                    CorrectAnswer = "Kreditkortsbedr�geri",
                    QuestionId = 7,
                    Explanation = "Oidentifierade transaktioner p� ditt kreditkortsutdrag �r en stark indikation p� att ditt kortnummer har komprometterats och anv�nts f�r obeh�riga k�p, vilket �r typiskt f�r kreditkortsbedr�geri."

                },
                new SolutionModel
                {
                    Id = 8,
                    CorrectAnswer = "Utbildning i digital s�kerhet f�r alla anst�llda",
                    QuestionId = 8,
                    Explanation = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor"

                },
                new SolutionModel
                {
                    Id = 9,
                    CorrectAnswer = "Implementera en policy f�r l�senordskomplexitet som kr�ver automatiska l�senords�ndringar var 90:e dag",
                    QuestionId = 9,
                    Explanation = "En automatisk policy f�r l�senords�ndring tvingar fram regelbundna uppdateringar och s�kerst�ller att l�senorden h�lls starka och sv�ra att kn�cka, vilket minskar risken f�r obeh�rig �tkomst."

                },
                new SolutionModel
                {
                    Id = 10,
                    CorrectAnswer = "Utrusta alla anst�lldas enheter med VPN (Virtual Private Network)-tj�nster",
                    QuestionId = 10,
                    Explanation = "Genom att anv�nda VPN kan anst�llda s�kert ansluta till f�retagets n�tverk �ven fr�n otrygga Wi-Fi-n�tverk, vilket krypterar data�verf�ring och skyddar mot avlyssning och andra cyberhot."

                },
                new SolutionModel
                {
                    Id = 11,
                    CorrectAnswer = "Installera och uppdatera regelbundet e-posts�kerhetsl�sningar som filtrerar bort skadlig programvara och misst�nkta l�nkar",
                    QuestionId = 11,
                    Explanation = "Avancerade e-posts�kerhetsl�sningar kan effektivt identifiera och blockera skadlig programvara och phishing-f�rs�k, vilket minskar risken f�r att anst�llda oavsiktligt exponerar f�retagets system och data f�r cyberhot."
                },
                new SolutionModel
                {
                    Id = 12,
                    CorrectAnswer = "Informera alla anv�ndare om s�rbarheten och rekommendera tempor�ra skydds�tg�rder",
                    QuestionId = 12,
                    Explanation = "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas."
                },
                new SolutionModel
                {
                    Id = 13,
                    CorrectAnswer = "Organiserade cyberbrottsliga grupper",
                    QuestionId = 13,
                    Explanation = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper."
                },
                new SolutionModel
                {
                    Id = 14,
                    CorrectAnswer = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
                    QuestionId = 14,
                    Explanation = "St�rkt autentisering �r kritisk f�r att s�kra fj�rr�tkomst och skydda mot obeh�rig �tkomst i en distribuerad arbetsmilj�."
                },
                new SolutionModel
                {
                    Id = 15,
                    CorrectAnswer = "Ransomware",
                    QuestionId = 15,
                    Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd."
                },
                new SolutionModel
                {
                    Id = 16,
                    CorrectAnswer = "Ransomware",
                    QuestionId = 16,
                    Explanation = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system.Maersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot."
                },
                new SolutionModel
                {
                    Id = 17,
                    CorrectAnswer = "Cyberspionage",
                    QuestionId = 17,
                    Explanation = "Cyberspionage avser aktiviteter d�r akt�rer, ofta statliga, engagerar sig i �vervakning och datainsamling genom cybermedel f�r att erh�lla hemlig information utan m�lets medgivande, typiskt f�r politiska, milit�ra eller ekonomiska f�rdelar. I takt med att cyberspionage blir allt mer sofistikerat, kr�vs det starkare skyddsmekanismer f�r att s�kra k�nslig information. Ett av de mest effektiva s�tten att skydda data �r genom kryptering. Denna teknik s�kerst�ller att informationen f�rblir privat, �ven om den skulle hamna i fel h�nder."
                }, new SolutionModel
                {
                    Id = 18,
                    CorrectAnswer = "�ka anv�ndningen av kryptering f�r all intern och extern kommunikation",
                    QuestionId = 18,
                    Explanation = "Kryptering �r en kraftfull metod f�r att skydda k�nslig information under �verf�ring och lagring, vilket g�r det extremt sv�rt f�r obeh�riga att f� tillg�ng till och f�rst� informationen, �ven om de lyckas avlyssna kommunikationen."
                },
                new SolutionModel
                {
                    Id = 19,
                    CorrectAnswer = "Implementera ett omfattande program f�r beteendeanalys och anomalidetektering",
                    QuestionId = 19,
                    Explanation = "Program f�r beteendeanalys och anomalidetektering kan effektivt identifiera ovanligt beteende eller aktiviteter som kan tyda p� insiderhot eller obeh�rig �tkomst till k�nslig information, vilket �r ett kritiskt steg f�r att f�rhindra cyberspionage. Mjukvarus�rbarheter �r ofta den svaga l�nken som utnyttjas i cyberspionageattacker. Utan snabba och regelbundna s�kerhetsuppdateringar och patchar, kan dessa s�rbarheter l�mna d�rrarna vid�ppna f�r angripare. Att h�lla programvara och system uppdaterade �r en grundl�ggande men kritisk del av ett effektivt cybers�kerhetsf�rsvar."
                },
                new SolutionModel
                {
                    Id = 20,
                    CorrectAnswer = "H�lla all mjukvara och operativsystem uppdaterade med de senaste s�kerhetspatcharna",
                    QuestionId = 20,
                    Explanation = "Regelbundna uppdateringar och patchning av mjukvara och operativsystem �r avg�rande f�r att st�nga s�kerhetsh�l som annars kan utnyttjas av cyberspioner. Detta minskar risken f�r intr�ng och datal�ckor avsev�rt."
                },
                new SolutionModel
                {
                    Id = 21,
                    CorrectAnswer = "Riktade cyberattacker",
                    QuestionId = 21,
                    Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day s�rbarheter �r en avancerad metod f�r cyberspionage d�r angriparen specifikt riktar in sig p� ett m�l f�r att komma �t k�nslig information eller data genom att utnyttja tidigare ok�nda s�rbarheter i programvara."
                },
                new SolutionModel
                {
                    Id = 22,
                    CorrectAnswer = "S�kerhetsskyddslagen",
                    QuestionId = 22,
                    Explanation = "S�kerhetsskyddslagen �r en svensk lagstiftning som syftar till att skydda nationellt k�nslig information fr�n spioneri, sabotage, terroristbrott och andra s�kerhetshot. Lagen st�ller krav p� s�kerhetsskydds�tg�rder f�r verksamheter av betydelse f�r Sveriges s�kerhet."
                },
                new SolutionModel
                {
                    Id = 23,
                    CorrectAnswer = "Statssponsrade hackers",
                    QuestionId = 23,
                    Explanation = "Statssponsrade hackers �r akt�rer som arbetar p� uppdrag av eller med st�d fr�n en regering f�r att genomf�ra cyberspionage, ofta riktat mot utl�ndska intressen, organisationer eller regeringar f�r att f� strategiska f�rdelar."
                });




            // Beskrivning: en kategori inneh�ller flera segment men ett segment tillh�r bara en kategori. 
            // 1:N mellan category och segment:
            builder.Entity<SegmentModel>()
            .HasOne(s => s.Category)
            .WithMany(c => c.Segments)
            .HasForeignKey(s => s.CategoryId);

            // Beskrivning: en subkategori tillh�r ett segment men ett segment inneh�ller flera subkategorier. 
            // 1:N mellan segment och subcategory:
            builder.Entity<SubcategoryModel>()
            .HasOne(s => s.Segment)
            .WithMany(c => c.Subcategories)
            .HasForeignKey(s => s.SegmentId);

            // Beskrivning: En subkategori inneh�ller flera fr�gor men en fr�ga tillh�r bara en subkategori. 
            // 1:N mellan subcategory och question:
            builder.Entity<QuestionModel>()
            .HasOne(s => s.SubCategory)
            .WithMany(c => c.Questions)
            .HasForeignKey(s => s.SubcategoryId);

            // Beskrivning: En fr�ga har bara en solution och en solution tillh�r bara en fr�ga. 
            // 1:1 mellan question och solution:
            builder.Entity<QuestionModel>()
           .HasOne(q => q.Solution)
           .WithOne(s => s.Question)
           .HasForeignKey<SolutionModel>(s => s.QuestionId);

            // Beskrivning: Ett svarsresultat tillh�r bara en fr�ga men en fr�ga kan ha m�nga svarsresultat
            //  1:N mellan result och question:
            builder.Entity<ResultModel>()
           .HasOne(r => r.Question)
           .WithMany(q => q.Results)
           .HasForeignKey(s => s.QuestionId);

            // Beskrivning: en user kan ha m�nga svarsresultat och ett svarsresultat kan has av m�nga users 
            // M:N mellan user och result
            // Beskrivning: en user kan ha m�nga svarsresultat och ett svarsresultat kan has av m�nga users 
            // M:N mellan user och result
            builder.Entity<UserResult>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserResults)
                .HasForeignKey(ur => ur.UserId);

            builder.Entity<UserResult>()
                .HasOne(u => u.Result)
                .WithMany(t => t.UserResults)
            .HasForeignKey(tt => tt.ResultId);

            // one to many mellan user och completedsubcategories 
            builder.Entity<CompletedSubcategoryModel>()
              .HasOne(c => c.ApplicationUser)
              .WithMany(u => u.CompletedSubcategories)
              .HasForeignKey(c => c.ApplicationUserId);

        }
    }
}
