using System;
// read or write contects from a flatfile - use system.io -  stream reader class
using System.IO;

class ExceptionHandling
{
    public static void Main()
    {
        StreamReader stream = null;
        try
        {
            stream = new StreamReader(@"C:\SampleFiles\data.txt");
            Console.WriteLine(stream.ReadToEnd());

        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("check for file location", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // the resources are not released without closing the stream reader
        // irrespective of if there is an exception or not, finally block is always executed
        finally
        {
            if
                (stream != null)
            {
                stream.Close();
            }
        }
    }
} 