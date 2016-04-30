using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class PointofSale
    {
        /// <summary>
        /// this class handles the point of sale
        ///it collects the items into a list
        /// and outputs the reciept information to a file
        /// </summary>
        private List<Item> items;
        WriteFiles wf;
        const double TAX = .092;

        public PointofSale()
        {
            //initilize list
            items = new List<Item>();
            //intialize Writefiles
            wf = new WriteFiles(@"C:\temp\Receipt.txt");
        }



        public void AddItem(Item i)
        {
            //add items to list
            items.Add(i);
        }

        public void SaveReceipt()
        {
            //out put the receipt information to a file
            double sum = 0;
            wf.AddToFile("Date: " + DateTime.Now.ToString());
            wf.AddToFile("***************************");
            foreach(Item i in items)
            {
                wf.AddToFile(i.ItemName + "  " + i.Price.ToString("$###.##"));
                sum += i.Price;
            }

            wf.AddToFile("SubTotal: " + sum.ToString("$###.##"));
            double taxDue = sum * TAX;
            wf.AddToFile("TAX: " + taxDue.ToString("$###.##"));
            double total = sum + taxDue;
            wf.AddToFile("Total " + total.ToString("$###.##"));
            //it is not actually written until close file
            wf.CloseFile();
        }


    }
}
