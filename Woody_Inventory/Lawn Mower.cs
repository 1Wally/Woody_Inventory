using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class LawnMower : IShippable
    {
        public decimal ShipCost { get; } = 24m;

        public string Product { get; } = "lawn mower";

    }
}