using Game5.Abstract;
using Game5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Concrete
{
    public class BaseCustomerService : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine("User Deleted!!!");
        }

        public virtual void Save(Player player)
        {
            Console.WriteLine("Saved to db : " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Date of Birth : " + player.DateOfBirth);
        }

    }
}
