namespace Lõputöö
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
1 > 
    -  LINQ


2 > 
    -   File Writer/Reader


3 > 
    -   Pyramid

-   -   -   -   -   -   -   -   -   -");
            int SELECT_THING = Convert.ToInt32(Console.ReadLine());

            switch (SELECT_THING)
            {
                case 1:
                Console.WriteLine(@"
1   >   Sisesta milline LINQ
        1 - SkipWhile
        2 - Take");
                int SELECT_ORDER_1 = Convert.ToInt32(Console.ReadLine());
                switch (SELECT_ORDER_1)
                {
                    case 1:
                    Console.WriteLine(@"
        1   >   SKIP WHILE LINQ");
                    SW_LINQ();
                    break;


                    case 2:
                    Console.WriteLine(@"
        2   >   TAKE LINQ
                -   Vali Kogus");
                    TAKE_LINQ();
                    break;



                    default:
                    break;
                }
                break;


                case 2:
                Console.WriteLine(@"STREAM WRITER/READER");
                FileThing.IF_A_ELSE();
                break;


                case 3:
                Pyramid.Sisyphus();
                break;



                default:
                break;
            }
        }

        public static void SW_LINQ()
        {

            var and = Muutjate_Andmed.andmed.SkipWhile(x => x.ID > 2);

            foreach (var OUT1 in and) { 
                Console.WriteLine("             " + OUT1.ID + " " + OUT1.COOKIES);
            }
        }

        public static void TAKE_LINQ()
        {
            int SELECT = Convert.ToInt32(Console.ReadLine());
            var and = Muutjate_Andmed.andmed.Take(SELECT);

            foreach (var OUT1 in and)
            {
                Console.WriteLine("                 " + OUT1.ID + " " + OUT1.COOKIES);
            }
        }
    }


    public class Muutjate_Andmed: Program
    {
        internal int ID { get; set; }
        internal string COOKIES { get; set; }
        public static new List<Muutjate_Andmed> andmed = new List<Muutjate_Andmed>()
        {
            new Muutjate_Andmed()
            {
                ID = 0,
                COOKIES = "Cookies"
            },
            new Muutjate_Andmed()
            {
                ID = 1,
                COOKIES = "Choclate Chip Cookies"
            },
            new Muutjate_Andmed()
            {
                ID = 2,
                COOKIES = "Dark Choclate Chip Cookies"
            },
            new Muutjate_Andmed()
            {
                ID = 3,
                COOKIES = "White Choclate Chip Cookies"
            },
            new Muutjate_Andmed()
            {
                ID = 4,
                COOKIES = "Choclate Cookies"
            },
            new Muutjate_Andmed()
            {
                ID = 5,
                COOKIES = "Dark Choclate Cookies"
            }
        };
    }

    public class FileThing: Program
    {
        public static void IF_A_ELSE()
        {
            var LOC_1 = "C:/Users/opilane/Downloads/Generated.txt";
            var LOC_2 = "C:/Users/opilane/eeeeeeeeeeee/Baha.txt";
            try {
                using (StreamWriter SW = new StreamWriter(LOC_1, true))
                {
                    Console.WriteLine(@"
Kirjuta midagi siia
- - - - - - - - - -");
                    string WRITE = Console.ReadLine();
                    if (WRITE != "" && WRITE != null)
                    {  
                       SW.Write(WRITE);
                       SW.Close();
                    }
                    else
                    {
                       StreamWriter SWN = new StreamWriter(LOC_2, true);
                       string NULLED_WRITE = Console.ReadLine();
                       SWN.Write(NULLED_WRITE);
                       SWN.Close();
                       Console.WriteLine("baha");
                    }        
                }
                using (StreamReader SR = new StreamReader("C:/Users/opilane/Downloads/Generated.txt"))
                {
                    string READ = SR.ReadToEnd();
                    Console.WriteLine(READ);

                }
            }
            catch (Exception TNE)
            {
                Console.WriteLine("Midagi läks valesti");
                Console.WriteLine(TNE.Message);
            }
        }
    }

    public class Pyramid: Program
    {
        public static void Sisyphus()
        {
            Console.WriteLine(@"
Sisesta püramiidi suurus
- - - - - - - - - -");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write("{0}", j);
                }

                Console.Write("\n");
            }
        }
    }
}
