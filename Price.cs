using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Price
    {
        public int getColumn(UIInfo info)
        {
            int tableColumn;
            // First based on class
            switch (info.Class)
            {
                case UIClass.FirstClass:
                    tableColumn = 3;
                    break;
                default:
                    tableColumn = 0;
                    break;
            }
            //compute the column in the table based on choices
            switch (info.Discount)
            {
                case UIDiscount.TwentyDiscount:
                    tableColumn += 1;
                    break;
                case UIDiscount.FortyDiscount:
                    tableColumn += 2;
                    break;
            }
            return tableColumn;
        }

        public float getPrice(UIInfo info)
        {
            int tableColumn =  getColumn(info);
            int tariefeenheden = Tariefeenheden.getTariefeenheden(info.From, info.To);
            float price = PricingTable.getPrice(tariefeenheden, tableColumn);
            if (info.Way == UIWay.Return)
            {
                price *= 2;
            }
            // Add 50 cent if paying with credit card
            if (info.Payment == UIPayment.CreditCard)
            {
                price += 0.50f;
            }

            return price;
        }
    }
}
