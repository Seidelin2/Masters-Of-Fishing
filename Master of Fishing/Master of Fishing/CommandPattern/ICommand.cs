using Master_of_Fishing.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_of_Fishing.CommandPattern
{
    interface ICommand
    {
        void Execute(Player player);
    }
}
