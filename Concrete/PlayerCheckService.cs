using Game5.Abstract;
using Game5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Concrete
{
    public class PlayerCheckService : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
