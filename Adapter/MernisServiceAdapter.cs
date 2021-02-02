using Game5.Abstract;
using Game5.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Adapter
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(player.PlayerId,player.NationalityId, player.FirstName, player.LastName, player.DateOfBirth).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
