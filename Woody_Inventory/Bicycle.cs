using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Bicycle : IShippable
    {
        public decimal ShipCost { get; } = 9.50m;

        public string Product { get; } = "bicycle";

    }
}
