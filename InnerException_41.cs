using System;
using System.IO;

public class InnerException
{
    public static void Main()
    {
        try {
            try
            {
                Console.WriteLine("Enter i value");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter j value");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = a / b;
                Console.WriteLine("result is {0)", result);
            }
            catch (Exception ex)
            {
                string filepath = @"C:/Logs/log.txt";
                if (File.Exists(filepath))
                {
                    StreamWriter SW = new StreamWriter(filepath);
                    SW.Write(ex.GetType().Name);
                    SW.Close();
                    Console.WriteLine("Exception occured -{0}", ex.Message);
                }
                else
                {
                    throw new FileNotFoundException("file not found", ex);
                }
            }
            }
        catch (Exception except)
        {
            Console.WriteLine(except.GetType().Name);
            if (except.InnerException != null)
            {

            }
            Console.WriteLine(except.InnerException.GetType().Name);
        }
        
        }

    }
