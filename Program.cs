using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcustomexcep
{
    public class Custom : Exception
    {
        public Custom(string msg):base (msg) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string email;
            string password;
            try
            {
                Console.WriteLine("Enter user name,email and password");
                name = (Console.ReadLine());
                email = Console.ReadLine();
                password=(Console.ReadLine());
                if (name.Length<6)
                {
                    throw new Custom("Length of name should be greater than 6 ");
                }
                else if (password.Length<6)
                {
                    Console.WriteLine("Length of password should be greater than 6");
                }
                else
                {
                    Console.WriteLine("Your Values are corect");
                }
            }
            catch(Custom ex)
            {
                Console.WriteLine("Custom exception"+ex.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Format exception"+fe.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Error"+e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
