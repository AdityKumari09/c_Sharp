using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader str = null;

            try
            {
                str = new StreamReader(@"C:\Sample Files\Data.txt");
                Console.WriteLine(str.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (str != null)
                {
                    str.Close();
                }
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
