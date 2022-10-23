using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Rot13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("test"));
            Console.ReadKey();
        }

        public static string Rot13(string message)
        {
            char[] chars = message.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                int number = (int)chars[i];
                if (number >= 'a' && number < 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                chars[i] = (char)number;
            }

            return new string(chars);
        }

        public static string Rot131(string message)
        {
            string result = "";
            foreach (var s in message)
            {
                if ((s >= 'a' && s <= 'm') || (s >= 'A' && s <= 'M'))
                    result += Convert.ToChar((s + 13)).ToString();
                else if ((s >= 'n' && s <= 'z') || (s >= 'N' && s <= 'Z'))
                    result += Convert.ToChar((s - 13)).ToString();
                else result += s;
            }
            return result;
        }

        public static string Rot132(string message)
        {
            string r = "";
            string cap = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < message.Length; i++)
            {
                if (cap.Contains(message.Substring(i, 1)))
                {
                    r += Encrypt(message.Substring(i, 1)).ToUpper();
                }
                else
                {
                    r += Encrypt(message.Substring(i, 1));
                }
            }
            return r;
        }
        public static string Encrypt(string letter)
        {
            switch (letter.ToLower())
            {
                case "a":
                    return "n";
                case "b":
                    return "o";
                case "c":
                    return "p";
                case "d":
                    return "q";
                case "e":
                    return "r";
                case "f":
                    return "s";
                case "g":
                    return "t";
                case "h":
                    return "u";
                case "i":
                    return "v";
                case "j":
                    return "w";
                case "k":
                    return "x";
                case "l":
                    return "y";
                case "m":
                    return "z";
                case "n":
                    return "a";
                case "o":
                    return "b";
                case "p":
                    return "c";
                case "q":
                    return "d";
                case "r":
                    return "e";
                case "s":
                    return "f";
                case "t":
                    return "g";
                case "u":
                    return "h";
                case "v":
                    return "i";
                case "w":
                    return "j";
                case "x":
                    return "k";
                case "y":
                    return "l";
                case "z":
                    return "m";
                default:
                    return letter;
            }
        }

        public static string Rot133(string message)
        {
            return string.Concat(message.Select(s =>
            {
                if (s >= 'a' && s <= 'z')
                    return (char)((s - 'a' + 13) % 26 + 'a');
                if (s >= 'A' && s <= 'Z')
                    return (char)((s - 'A' + 13) % 26 + 'A');
                return s;
            }));
        }

        public static string Rot134(string message)
        {
            return String.Join("", message.Select(x => char.IsLetter(x) ? (x >= 65 && x <= 77) || (x >= 97 && x <= 109) ? (char)(x + 13) : (char)(x - 13) : x));
        }
    }
}
