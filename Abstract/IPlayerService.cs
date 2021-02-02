using Game5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Abstract
{
    public interface IPlayerService
    {
        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
