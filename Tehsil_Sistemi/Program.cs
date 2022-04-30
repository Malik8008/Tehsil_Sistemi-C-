using System;

namespace Tehsil_Sistemi
{
    internal class Program
    {
        public static bool PasswordChecker(string pw)
        {
            bool HasDigit = false;
            bool HasUpper = false;
            bool HasLower = false;

            foreach (var item in pw)
            {
                if (char.IsDigit(item))
                {
                    HasDigit = true;
                }
                if (char.IsUpper(item))
                {
                    HasUpper = true;
                }
                if (char.IsLower(item))
                {
                    HasLower = true;
                }
            }
            bool result = HasDigit && HasUpper && HasLower;
            return result;

        }

        public static bool CheckLimit(int  limit)
        {
            if (limit>=5 && limit<=18)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Group group = null;

            Console.WriteLine("Please enter Name");
            string fullname = Console.ReadLine();
            Console.WriteLine("Please enter Email");
            string email = Console.ReadLine();
            string password;

            do
            {
                Console.WriteLine("Please enter password");
                password = Console.ReadLine();
            } while (!PasswordChecker(password));
            User user = new User(fullname, email, password);

            bool result=true;
            do
            {
                Console.WriteLine("1.Show Info");
                Console.WriteLine("2.Create new group");
                Console.WriteLine("3.Menu");
                
            } while (!result);
            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    user.ShowInfo();
                    break;
                case 2:
                    string groupno;
                    byte studentlimit;

                    do
                    {
                        Console.WriteLine("Please enter groupNO");
                        groupno = Console.ReadLine();

                    } while (!Group.CheckGroupNo(groupno));

                    do
                    {
                        Console.WriteLine("Please enter StudentLimit");
                        studentlimit = Convert.ToByte(Console.ReadLine());
                    } while (!CheckLimit(studentlimit));
                    group = new Group(groupno, studentlimit);
                    break;
                    
                case 3:

                    Console.WriteLine("1.Show All Students");
                    Console.WriteLine("2.Get Students by ID");
                    Console.WriteLine("3.Add Student");
                    Console.WriteLine("0.Quit");
                    int asnwer=Convert.ToInt32(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            group.GetAllStudent();
                            break;
                        default:
                            break;
                    }
                    break;
                    default:
                    break;
            }




        }
    }
}
