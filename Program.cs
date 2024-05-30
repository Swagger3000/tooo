namespace pubes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik");
            Console.WriteLine("1. Skip");
            Console.WriteLine("2. Join");
            Console.WriteLine("3. if else");
            Console.WriteLine("4. forloop");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    esimene();
                    break;
                case "2":
                    teine();
                    break;
                case "3":
                    kolmas();
                    break;
                case "4":
                    neljas();
                    break;
                default:
                    Console.WriteLine("TRA VALI YKS VIIEST YLESANDEST");
                    break;
            }
        }

        static void esimene()
        {
            {
                Console.WriteLine("\n\n----------------Skip------------");
                var skip = PeopleList.people.Skip(3);

                foreach (var item in skip)
                {
                    Console.WriteLine(item.Id);
                }
            }
        }

        static void teine()
        {
            var innerJoin = PeopleList.people
            .Join
            (
                GenderList.genderList,
                humans => humans.GenderId,
                gender => gender.Id,
                (humans, gender) => new
                {
                    Name = humans.Name,
                    GenderName = gender.GenderName,
                }
            );

            foreach (var item in innerJoin)
            {
                Console.WriteLine("{0} - {1}", item.Name, item.GenderName);
            }
        }

        static void kolmas()
        {
            Console.WriteLine("mis? tahad kirjutada v?");
            string kiri = Console.ReadLine();
            

            if (kiri == "ja")
            {
                Console.WriteLine("Kirjuta faili läbi konsooli");

                string filePath = @"C:\Users\opilane\source\repos\kakka.txt";
                string inputText = Console.ReadLine();

                File.WriteAllText(filePath, inputText);
            }

            else
            {
                Console.WriteLine("TÕMBA UTTU :D");
            }


        }
        static void neljas()
        {
            Console.WriteLine("kirjuta number");
            int i, j, n;
            int t = 1;
            Console.Write("loo püramid **");
            Console.WriteLine("sisesta suurus");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 1; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 1 * i + 1; j++)
                {
                    Console.Write("{0} ", t++);
                }
                Console.Write("\n");
            }
        }
    }
}


