using Master_of_Fishing.Components;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_of_Fishing.CommandPattern
{
    class MoveCommand : ICommand
    {
        private Vector2 velocity;

        public MoveCommand(Vector2 velocity)
        {
            this.velocity = velocity;
        }

        public void Execute(Player player)
        {
            player.Move(velocity);
        }
    }
}
