using Game5.Adapter;
using Game5.Concrete;
using Game5.Entities;
using System;

namespace Game5
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { GameId = 1, GameName = "MarchOfEmpires", UnitPrice = 5, UnitOfStock = 72 };
            Game game2 = new Game() { GameId = 2, GameName = "Fifa2021", UnitPrice = 20, UnitOfStock = 10 };
            Game game3 = new Game() { GameId = 3, GameName = "PUBG", UnitPrice = 36, UnitOfStock = 9 };
            Game game4 = new Game() { GameId = 4, GameName = "SimCity", UnitPrice = 8, UnitOfStock = 46 };
            Game game5 = new Game() { GameId = 5, GameName = "PES2020", UnitPrice = 12, UnitOfStock = 23 };

            Campaing campaing1 = new Campaing() { CampaingId = 21, CampaingName = "Yılbaşı İndirimleri", RateOfDiscount = 10 };
            Campaing campaing2 = new Campaing() { CampaingId = 22, CampaingName = "Yarıtıl Tatil İndirimleri", RateOfDiscount = 15 };
            Campaing campaing3 = new Campaing() { CampaingId = 23, CampaingName = "Black Friday indirimleri", RateOfDiscount = 35 };

            Player player1 = new Player() { PlayerId = 11, NationalityId = 20220322666, FirstName = "Ali", LastName = "Öntürk", DateOfBirth = 1989 };
            Player player2 = new Player() { PlayerId = 12, NationalityId = 18853253394, FirstName = "Ayşe", LastName = "Arık", DateOfBirth = 1998 };
            Player player3 = new Player() { PlayerId = 13, NationalityId = 25862922115, FirstName = "Fatma", LastName = "Özat", DateOfBirth = 1992 };
            Player player4 = new Player() { PlayerId = 14, NationalityId = 45726972305, FirstName = "Ahmet", LastName = "Akın", DateOfBirth = 1981 };
            Player player5 = new Player() { PlayerId = 15, NationalityId = 30482576060, FirstName = "Atilla", LastName = "Berk", DateOfBirth = 1995 };
            Player player6 = new Player() { PlayerId = 16, NationalityId = 74829253053, FirstName = "Asya", LastName = "Şeker", DateOfBirth = 1976 };

            CampaingService campaingService = new CampaingService();
            campaingService.Add(campaing3);
            campaingService.Update(campaing2);

            Sales sales1 = new Sales() { Game = game1.GameName, Player = player3.FirstName };
            SalesService salesService = new SalesService();
            salesService.Buy(game3, player6);
            salesService.Buy(game2, player5);

            BaseCustomerService customerService = new PlayerService(new MernisServiceAdapter());
            customerService.Update(player2);
            customerService.Delete(player6);
            customerService.Save(player1);

        }
    }
}
