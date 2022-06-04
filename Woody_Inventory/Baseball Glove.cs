using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class baseballGlove : IShippable
    {
        public decimal ShipCost { get; } = 3.23m;

        public string Product { get; } = "baseball glove";

    }
}
