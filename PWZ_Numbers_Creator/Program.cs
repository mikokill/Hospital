namespace PWZ_Numbers_Creator
{
    class PWZ_Numbers_Creator
    {
        static void Main(string[] args)
        {
            List<string> list = new();
            for (int i = 0; i < 9999999; i++)
            {
                string str = i.ToString();
                switch (str.Length)
                {
                    case 1:
                        str = "000000" + str;
                        break;
                    case 2:
                        str = "00000" + str;
                        break;
                    case 3:
                        str = "0000" + str;
                        break;
                    case 4:
                        str = "000" + str;
                        break;
                    case 5:
                        str = "00" + str;
                        break;
                    case 6:
                        str = "0" + str;
                        break;
                }
                int a = str[0] - '0';
                int b = str[1] - '0';
                int c = str[2] - '0';
                int d = str[3] - '0';
                int e = str[4] - '0';
                int f = str[5] - '0';
                int g = str[6] - '0';
                if ((b + c * 2 + d * 3 + e * 4 + f * 5 + g * 6) % 11 == a && a != 0)
                {
                    list.Add(str);
                }
            }
            int j = 0;
            while (j < list.Count)
            {
                Console.WriteLine("Czy pokazać następny numer PWZ? (y/n)");
                ConsoleKeyInfo x = Console.ReadKey(true);
                if (x.KeyChar == 'y')
                {
                    Console.WriteLine(list[new Random().Next(list.Count)]);
                    j++;
                }
                else if (x.KeyChar == 'n')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wybrano zły przycisk. Spróbuj ponownie.");
                }
            }
        }
    }
}