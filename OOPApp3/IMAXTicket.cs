using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp3
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D)
            : base(movieName, is3D ? price + 30 : price)
        {
            Is3D = is3D;
        }

        public override string ToString()
        {
            string mode = Is3D ? "Yes" : "No";
            return base.ToString() + $" | IMAX 3D: {mode}";
        }
    }
}
