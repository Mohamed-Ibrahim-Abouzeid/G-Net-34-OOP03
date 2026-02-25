using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class VIPTicket :Ticket
    {
        public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; } = 50;

    public VIPTicket(string movieName, decimal price, bool loungeAccess)
        : base(movieName, price)
    {
        LoungeAccess = loungeAccess;
    }

        public override decimal PriceAfterTax
        {
            get { return (Price + ServiceFee) * 1.14m; }
        }

        public override string ToString()
    {
        return base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
    }
    }
}
