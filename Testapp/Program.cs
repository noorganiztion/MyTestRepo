using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement;

namespace Testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder userName = new StringBuilder();
            string name = "";
            do
            {
                Console.WriteLine("Enter your name");
                name = Console.ReadLine();

                Console.WriteLine("Enter your age");

                if (name.ToUpper() != "NO")
                {
                    userName.AppendLine(" Goodluck ");
                    userName.AppendFormat(" Person name is {0} and age= {1}.", name, Console.ReadLine());
                }
            } while (name.ToUpper() != "NO");

            Console.WriteLine("Enter your status");
            int status = Convert.ToInt16(Console.ReadLine());

            UserBE objProp = new UserBE();
            objProp.Status = status;
            objProp.UserName = userName.ToString();

            User objUser = new User();
            Console.WriteLine(objUser.SaveUserInfo(objProp));

            Console.ReadLine();
        }
    }
}
