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
            string EncodedProjectName = "";
            string EncodedActivityName = "";
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

                EncodeProject(ProjectName);
                EncodeActivity(ActivityName);

                Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", EncodedProjectName, EncodedActivityName);
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

            string EncodeProject(string value)
            {
                for (int i = 0; i < ProjectName.Length; i++)
                {
                    switch (ProjectName[i])
                    {
                        case ' ':
                            {
                                EncodedProjectName += "%20";
                                break;
                            }
                        case '>':
                            {
                                EncodedProjectName += "%3E";
                                break;
                            }
                        case '<':
                            {
                                EncodedProjectName += "%3C";
                                break;
                            }
                        case '#':
                            {
                                EncodedProjectName += "%23";
                                break;
                            }
                        case '%':
                            {
                                EncodedProjectName += "%25";
                                break;
                            }
                        case '"':
                            {
                                EncodedProjectName += "%22";
                                break;
                            }
                        case ';':
                            {
                                EncodedProjectName += "%3B";
                                break;
                            }
                        case '/':
                            {
                                EncodedProjectName += "%2F";
                                break;
                            }
                        case '?':
                            {
                                EncodedProjectName += "%3F";
                                break;
                            }
                        case ':':
                            {
                                EncodedProjectName += "%3A";
                                break;
                            }
                        case '@':
                            {
                                EncodedProjectName += "%40";
                                break;
                            }
                        case '&':
                            {
                                EncodedProjectName += "%26";
                                break;
                            }
                        case '-':
                            {
                                EncodedProjectName += "%2D";
                                break;
                            }
                        case '+':
                            {
                                EncodedProjectName += "%2B";
                                break;
                            }
                        case '$':
                            {
                                EncodedProjectName += "%24";
                                break;
                            }
                        case '{':
                            {
                                EncodedProjectName += "%7B";
                                break;
                            }
                        case '}':
                            {
                                EncodedProjectName += "%7D";
                                break;
                            }
                        case '|':
                            {
                                EncodedProjectName += "%7C";
                                break;
                            }
                        case '^':
                            {
                                EncodedProjectName += "%5E";
                                break;
                            }
                        case '[':
                            {
                                EncodedProjectName += "%5B";
                                break;
                            }
                        case ']':
                            {
                                EncodedProjectName += "%5D";
                                break;
                            }
                        default:
                            {
                                EncodedProjectName += ProjectName[i];
                                break;
                            }
                    }
                }
                return EncodedProjectName;
            }

            string EncodeActivity(string value)
            {
                for (int i = 0; i < ActivityName.Length; i++)
                {
                    switch (ActivityName[i])
                    {
                        case ' ':
                            {
                                EncodedActivityName += "%20";
                                break;
                            }
                        case '>':
                            {
                                EncodedActivityName += "%3E";
                                break;
                            }
                        case '<':
                            {
                                EncodedActivityName += "%3C";
                                break;
                            }
                        case '#':
                            {
                                EncodedActivityName += "%23";
                                break;
                            }
                        case '%':
                            {
                                EncodedActivityName += "%25";
                                break;
                            }
                        case '"':
                            {
                                EncodedActivityName += "%22";
                                break;
                            }
                        case ';':
                            {
                                EncodedActivityName += "%3B";
                                break;
                            }
                        case '/':
                            {
                                EncodedActivityName += "%2F";
                                break;
                            }
                        case '?':
                            {
                                EncodedActivityName += "%3F";
                                break;
                            }
                        case ':':
                            {
                                EncodedActivityName += "%3A";
                                break;
                            }
                        case '@':
                            {
                                EncodedActivityName += "%40";
                                break;
                            }
                        case '&':
                            {
                                EncodedActivityName += "%26";
                                break;
                            }
                        case '-':
                            {
                                EncodedActivityName += "%2D";
                                break;
                            }
                        case '+':
                            {
                                EncodedActivityName += "%2B";
                                break;
                            }
                        case '$':
                            {
                                EncodedActivityName += "%24";
                                break;
                            }
                        case '{':
                            {
                                EncodedActivityName += "%7B";
                                break;
                            }
                        case '}':
                            {
                                EncodedActivityName += "%7D";
                                break;
                            }
                        case '|':
                            {
                                EncodedActivityName += "%7C";
                                break;
                            }
                        case '^':
                            {
                                EncodedActivityName += "%5E";
                                break;
                            }
                        case '[':
                            {
                                EncodedActivityName += "%5B";
                                break;
                            }
                        case ']':
                            {
                                EncodedActivityName += "%5D";
                                break;
                            }
                        default:
                            {
                                EncodedActivityName += ActivityName[i];
                                break;
                            }
                    }
                }
                return EncodedActivityName;
            }
        }
    }
}
