using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagementFinal
{
    public class Login
    {
        public static void admimLogin(string username, string password)
        {
            if (username == "Admin" && password == "Admin")
            {
                while (true)
                {
                    Console.WriteLine("You Successfully Login To Admin Pannel");
                    Console.WriteLine("\n 1:Add Stock \n 2:Display Stock \n 3:Delete Stock \n 4: Edit Stock Detail \n 5:return to main menu");
                    Console.WriteLine("Enter Your Choice");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Add Stock");
                            StockLogic.addStock();
                            break;
                        case 2:
                            Console.WriteLine("Display  Stock");
                            StockLogic.Dispaly();
                            break;
                        case 3:
                            Console.WriteLine("Delete Stock");
                            StockLogic.DeleteStock();
                            break;
                        case 4:
                            Console.WriteLine("Edit Stock Detail");
                            StockLogic.EditStock();
                            break;
                        case 5:
                            Program.MainMenu();
                            break;
                        default:
                            Console.WriteLine("Wrong Choice");
                            break;
                    }
                }
                
            }

            else
            {
                Console.WriteLine("Username or PassWord Is InCorrect");
            }
        }

        public static void customerLogin(string cUserName,string cPassword)
        {
            if(cUserName=="Nikhil" && cPassword == "1234")
            {
                Console.WriteLine("Customer Login Successfully");
                while (true)
                {
                    Console.WriteLine("\n 1: Show Available Stock \n 2:Buy Stock \n 3:Display Buy Stock");
                    int choice=int.Parse(Console.ReadLine());
                    switch(choice) 
                    { 
                        case 1:
                            CustomerLogic.Dispaly();
                            //CustomerLogic.Dispaly();
                            break;
                        case 2:
                            CustomerLogic.buyStock();
                          

                            break;
                        case 3:
                            CustomerLogic.DiplayBuyStockList();
                            break;
                    }
                }
               

            }
            else
            {
                Console.WriteLine("Login Fail");
                
            }
           
        }

    }
}
