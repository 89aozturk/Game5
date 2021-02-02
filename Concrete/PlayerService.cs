using Game5.Abstract;
using Game5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Concrete
{
    public class PlayerService:BaseCustomerService
    {

        private IPlayerCheckService _playerCheckService;

        public PlayerService(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Save(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Save(player);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
            
        }
        

    }

}

