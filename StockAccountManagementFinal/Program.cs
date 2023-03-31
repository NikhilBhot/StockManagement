namespace StockAccountManagementFinal
{
    public class Program
    {
        public static void MainMenu() 
        {
            while (true)
            {
                Console.WriteLine("\n 1:ADMIN LOGIN \n  2:CUSTOMER LOGIN \n 3:NEW CUSTOMER RESTITRATION");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Admin User Name");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter Admin PassWord");
                        string password = Console.ReadLine();
                        Login.admimLogin(username, password);
                        break;

                    case 2:
                        Console.WriteLine("Enter Customer User Name");
                        string cUserName = Console.ReadLine();
                        Console.WriteLine("Enter Customer PassWord");
                        string cPassword = Console.ReadLine();
                        Login.customerLogin(cUserName, cPassword);
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come To Stock Account Management");
            MainMenu();

            
           
        }
    }
}