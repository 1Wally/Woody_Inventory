using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class crackers : IShippable
    {
        public decimal ShipCost { get; } = 0.57m;

        public string Product { get; } = "crackers";

    }
}
