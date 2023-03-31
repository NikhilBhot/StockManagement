using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagementFinal
{
    public class CustomerLogic:StockLogic
    {
         public  static  List<CustomerDemo> custDemo = new List<CustomerDemo>();
        public static double amount = 10000;
        public static int NoOfShares = 0;
        
        public static void displayAvailableStock()
        {
            Console.WriteLine("Avaialble Stock");
            StockLogic.Dispaly();

            
        }

        public static void buyStock()
        {
            Console.WriteLine("This Stock Available In The List");
            StockLogic.Dispaly();
            Console.WriteLine("Please Enter the Stock Name");
            string Name=Console.ReadLine();
            
            foreach(var stock in stockList)
            {
                if (stock.stockName.Equals(Name))
                {
                    Console.WriteLine("This Stock Is Available");
                    Console.WriteLine("How Many Shares You Want To Buy");
                    int noofShares=int.Parse(Console.ReadLine());

                    if(stock.totalAvailableShare>=noofShares && amount >noofShares*stock.stockPrice)
                    {
                        CustomerDemo demo = new CustomerDemo();
                       
                        double buyAmount =noofShares*stock.stockPrice;
                        
                        demo.NoOfSharesBuyCust=noofShares;
                        demo.stockName=stock.stockName;
                        demo.totatSharesPrice=buyAmount;
                        demo.stockPrice1 = stock.stockPrice;
                        custDemo.Add(demo);
                        amount = amount - buyAmount;
                        stock.totalAvailableShare = stock.totalAvailableShare - noofShares;


                    }
                    
                   
                }
            }

        }

        public static void DiplayBuyStockList()
        {
            Console.WriteLine("Buy Stock List");
            foreach(var demo in custDemo)
            {
                Console.WriteLine("Name Of Stock:\t"+ demo.stockName +"\nPrice Of Stock:\t"+demo.stockPrice1+
                                "\nTotal Amount:\t"+demo.totatSharesPrice+"\nQuantity Of Shares:\t"+demo.NoOfSharesBuyCust
                                 );
            }
        }
    }
}
