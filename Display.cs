using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Display
    {
        /// <summary>
        /// This class allows the user to enter items
        /// It also returns the reciept information
        /// from the file
        /// </summary>
        public Display()
        {
            //constructor calls the two methods
            AddItems();
            GetReceipt();
        }

        private void AddItems()
        {
            //initialize the point of sale
            PointofSale pos = new PointofSale();
            string quit = "no";

            //loop for all the items to enter
            while (quit.Equals("no"))
            {
                //create an new instance item
                Item i = new Item();
                Console.WriteLine("Enter the Item Name");
                i.ItemName = Console.ReadLine();
                Console.WriteLine("Enter the Item Price");
                i.Price = double.Parse(Console.ReadLine());

                // Add item to list in pos
                pos.AddItem(i);
                Console.WriteLine("Quit? yes/no");
                quit = Console.ReadLine();
                quit = quit.ToLower();

            }
            //write the reciept
            pos.SaveReceipt();

        }

        private void GetReceipt()
        {
            //get the file and display it
            ReadFile rf = new ReadFile(@"C:\temp\Receipt.txt");
            Console.WriteLine(rf.GetFile());

        }


    }
}
