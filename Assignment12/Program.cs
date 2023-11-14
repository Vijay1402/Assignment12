using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the one of the FileHandling options ");
            Console.WriteLine("1.Create file\n2.Read file\n3.Append to file\n4.Delete file");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the file name");
                        string fileName = Console.ReadLine();
                        Console.WriteLine("Enter the content of the file");
                        string content = Console.ReadLine();
                        createFile(fileName, content);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter the file name");
                        string fileName = Console.ReadLine();
                        readFile(fileName);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Enter the file name");
                        string fileName = Console.ReadLine();
                        Console.WriteLine("Enter the content to be added to the file");
                        string content = Console.ReadLine();
                        appendToFile(fileName, content);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Enter the file name");
                        string fileName = Console.ReadLine();
                        deleteFile(fileName);
                    } break;
                default: Console.WriteLine("Invalid Input"); Console.ReadKey(); ; break;
            }
        }

        static void createFile(string fileName, string content)
        {
            try
            {
                string path = "G:\\SimpliLearn\\Phase 1\\Day 7\\Assignment12\\";
                string fPath = path + fileName;
                if (File.Exists(fPath))
                {
                    Console.WriteLine("File Already there");
                }
                else
                {
                    StreamWriter sw = File.AppendText(fPath);
                    sw.WriteLine(content);
                    sw.Dispose();
                    sw.Close();
                    Console.WriteLine("Created and text is written");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errror!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void readFile(string fileName)
        {
            StreamReader sr;
            try
            {
                string path = "G:\\SimpliLearn\\Phase 1\\Day 7\\Assignment12\\";
                string fPath = path + fileName;
                sr = new StreamReader(fPath); 
                string text = "";
                while ((text = sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void appendToFile(string fileName, string content) 
        {
            try
            {
                string path = "G:\\SimpliLearn\\Phase 1\\Day 7\\Assignment12\\";
                string fPath = path + fileName;
                if (!File.Exists(fPath))
                {
                    Console.WriteLine("File does not exist");
                }
                else
                {
                    StreamWriter sw = File.AppendText(fPath);
                    sw.WriteLine(content);
                    sw.Dispose();
                    sw.Close();
                    Console.WriteLine("Text added to the file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errror!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }

        static void deleteFile(string fileName) 
        {
            try
            {
                string path = "G:\\SimpliLearn\\Phase 1\\Day 7\\Assignment12\\";
                string fpath = path + fileName;
                if (File.Exists(fpath))
                {
                    File.Delete(fpath);
                    Console.WriteLine($"File {fileName} delted successfully");
                }
                else
                {
                    Console.WriteLine($"This file {fileName} does not exists");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errror!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finish");
                Console.ReadKey();
            }
        }
    }
}
