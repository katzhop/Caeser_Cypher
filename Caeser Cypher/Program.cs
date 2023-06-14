using System;

namespace Caeser_Cypher
{
    class Program
    {
        public static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 
            'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static int Contains(char letter)
        {
            bool stop = false;
            int i = 0;
            while (stop == false && i < alphabet.Length)
            {
                if (letter == alphabet[i])
                {
                    stop = true;
                }
                else
                {
                    i++;
                }
            }
            return i;
        }
        public static char[] Encrypt(char[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                int change = Contains(s[i]);
                if (change == alphabet.Length)
                {
                }
                else
                {
                    change -= 10;
                    if (change < 0)
                    {
                        change += alphabet.Length;
                    }
                    s[i] = alphabet[change];
                }
            }
            return s;
        }
        public static char[] Decrypt(char[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                int change = Contains(s[i]);
                if (change == alphabet.Length)
                {
                }
                else
                {
                    change += 10;
                    if (change >= alphabet.Length)
                    {
                        change -= alphabet.Length;
                    }
                    s[i] = alphabet[change];
                }
            }
            return s;
        }

        public static void Main(string[] args)
        {
            bool stop = false;
            Console.WriteLine("Enter String: ");
            string s = Console.ReadLine();
            char[] input = s.ToCharArray();
            while (stop == false)
            {
                Console.WriteLine("-----------------MAIN MENU---------------------------\n" +
                    "1. Enter String\n2. Encrypt String\n3. Decrypt String\n4. Exit program\n" +
                    "Enter option number: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter String: ");
                        s = Console.ReadLine();
                        input = s.ToCharArray();
                        break;
                    case 2:
                        input = Encrypt(input);
                        for (int i = 0; i < input.Length; i++)
                        {
                            Console.Write(input[i]);
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        input = Decrypt(input);
                        for (int i = 0; i < input.Length; i++)
                        {
                            Console.Write(input[i]);
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Enter a valid option: ");
                        break;
                }
            }
        }
    }

}
