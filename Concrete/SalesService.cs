using Game5.Abstract;
using Game5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Concrete
{
    public class SalesService : ISalesService
    {
        public void Buy(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + " bought " + game.GameName);
        }
    }
}
