using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagementFinal
{
    public  class StockLogic
    {
        public static List<StockDemo> stockList = new List<StockDemo>();
  
        public static void addStock()
        {
            StockDemo stockdemo=new StockDemo();
            Console.WriteLine("Enter Stock Name : ");
            stockdemo.stockName = Console.ReadLine();
            Console.WriteLine("Enter Stock Price : ");
            stockdemo.stockPrice =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Shares Quantity");
            stockdemo.totalAvailableShare=int.Parse(Console.ReadLine());
            stockList.Add(stockdemo);
        }
        public static void Dispaly()
        {
            if(stockList.Count > 0)
            {
                foreach (var stock in stockList)
                {
                    Console.WriteLine("Stock Name:\t" + stock.stockName + "\n Stock Price:\t" + stock.stockPrice +"\n Available Shares:\t"+stock.totalAvailableShare);
                }
            }
            else
            {
                Console.WriteLine("Stock Is Not Available");
            }
            
        }
        public static void DeleteStock()
        {
            
            Console.WriteLine("Enter the Stock Name : ");
            string name = Console.ReadLine();
            if (stockList.Count <= 1)
            {
                stockList.Clear();
            }
            else
            {
                foreach (var stock in stockList)
                {

                    if (stock.stockName == name)
                    {
                        try
                        {
                            stockList.Remove(stock);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name does not exists");
                    }

                }
            }
            
        }

        public static void EditStock()
        {
            StockDemo stockdemo=new StockDemo();
            Console.WriteLine("Enter Stock Name Which You Want To Modify");

            string name = Console.ReadLine();
            foreach(var stock in stockList)
            {
                if (stock.stockName == name)
                {
                    Console.WriteLine("Edit a Contact\n 1.Stock Name\n 2.Stock Price ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter New Name Of Stock");
                            string Name = Console.ReadLine();
                            stock.stockName = Name;
                            break;
                        case 2:
                            Console.WriteLine("Enter Updated Price Of Stock");
                            double price = double.Parse(Console.ReadLine());
                            stock.stockPrice = price;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Name is not Exist");
                }
            }
            
        }

    }
}
