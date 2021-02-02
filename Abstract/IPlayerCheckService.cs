using Game5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
