using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Price
    {
        public UI uitje;

        public float getPrice(UIInfo info)
        {
            int tableColumn = uitje.getColumn(info);
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
