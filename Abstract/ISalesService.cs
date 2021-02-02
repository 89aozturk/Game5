using Game5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Abstract
{
    public interface ISalesService
    {
        void Buy(Game game, Player player);
    }
}
