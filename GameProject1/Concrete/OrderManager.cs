using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject1
{
    class OrderManager : IOrderService
    {
       

        public void Sale(Gamer gamer,Game game,Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + "adlı oyuncu" + game.Name + "adlı oyunu" + campaign.CampaignName + "adlı yeni kampanyayla almıştır");
        }

        
    }
}
