using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProjectName;
            string ActivityName;
            bool again = true;
            string choice;

            while (again)
            {
                Console.Out.Write("What is the project name?: ");
                ProjectName = Console.ReadLine();

                for (int i = 0; i < ProjectName.Length; i++)
                {
                    while (Char.IsControl(ProjectName, i))
                    {
                        Console.WriteLine("Control character found in position {0}. Please try another name.", i);
                        Console.Out.Write("What is the project name?: ");
                        ProjectName = Console.ReadLine();
                        i = 0;
                    }
                }

                Console.Out.Write("What is the activity name?: ");
                ActivityName = Console.ReadLine();

                for (int i = 0; i < ActivityName.Length; i++)
                {
                    while (Char.IsControl(ProjectName, i))
                    {
                        Console.WriteLine("Control character found in position {0}. Please try another name.", i);
                        Console.Out.Write("What is the activity name?: ");
                        ActivityName = Console.ReadLine();
                        i = 0;
                    }
                }

                foreach (char input in ProjectName)
                {
                    switch (input)
                    {
                        case ' ':
                            {
                                return "%20";
                            }
                        case '>':
                            {
                                return "%3E";
                            }
                        case '<':
                            {
                                return "%3C";
                            }
                        case '#':
                            {
                                return "%23";
                            }
                        case '%':
                            {
                                return "%25";
                            }
                        case '"':
                            {
                                return "%22";
                            }
                        case ';':
                            {
                                return "%3B";
                            }
                        case '/':
                            {
                                return "%2F";
                            }
                        case '?':
                            {
                                return "%3F";
                            }
                        case ':':
                            {
                                return "%3A";
                            }
                        case '@':
                            {
                                return "%40";
                            }
                        case '&':
                            {
                                return "%26";
                            }
                        case '-':
                            {
                                return "%2D";
                            }
                        case '+':
                            {
                                return "%2B";
                            }
                        case '$':
                            {
                                return "%24";
                            }
                        case '{':
                            {
                                return "%7B";
                            }
                        case '}':
                            {
                                return "%7D";
                            }
                        case '|':
                            {
                                return "%7C";
                            }
                        case '\':
                            {
                                return "%5C";
                            }
                        case '^':
                            {
                                return "%5E";
                            }
                        case '[':
                            {
                                return "%5B";
                            }
                        case ']':
                            {
                                return "%5D";
                            }
                    }
                }

                foreach (char input in ActivityName)
                {
                    switch (input)
                    {
                        case ' ':
                            {
                                return "%20";
                            }
                        case '>':
                            {
                                return "%3E";
                            }
                        case '<':
                            {
                                return "%3C";
                            }
                        case '#':
                            {
                                return "%23";
                            }
                        case '%':
                            {
                                return "%25";
                            }
                        case '"':
                            {
                                return "%22";
                            }
                        case ';':
                            {
                                return "%3B";
                            }
                        case '/':
                            {
                                return "%2F";
                            }
                        case '?':
                            {
                                return "%3F";
                            }
                        case ':':
                            {
                                return "%3A";
                            }
                        case '@':
                            {
                                return "%40";
                            }
                        case '&':
                            {
                                return "%26";
                            }
                        case '-':
                            {
                                return "%2D";
                            }
                        case '+':
                            {
                                return "%2B";
                            }
                        case '$':
                            {
                                return "%24";
                            }
                        case '{':
                            {
                                return "%7B";
                            }
                        case '}':
                            {
                                return "%7D";
                            }
                        case '|':
                            {
                                return "%7C";
                            }
                        case '\':
                            {
                                return "%5C";
                            }
                        case '^':
                            {
                                return "%5E";
                            }
                        case '[':
                            {
                                return "%5B";
                            }
                        case ']':
                            {
                                return "%5D";
                            }
                    }

                }
                Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", ProjectName, ActivityName);
                Console.WriteLine("Would you like to create anther URL? (y/n): ");
                choice = Console.ReadLine().ToLower();
                if (choice == "y")
                {
                    again = true;
                }
                else
                {
                    again = false;
                }
            }
        }
    }
}
