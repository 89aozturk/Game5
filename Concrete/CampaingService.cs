using Game5.Abstract;
using Game5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game5.Concrete
{
    public class CampaingService : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("A new campaing " + " added " + campaing.CampaingName);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingId + " Campaing finished...");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Campaing discount " + "updated % " + campaing.RateOfDiscount );
        }
    }
}
