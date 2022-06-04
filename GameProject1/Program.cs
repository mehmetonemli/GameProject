// See https://aka.ms/new-console-template for more information
namespace GameProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Mehmet";
            gamer.LastName = "Önemli";
            gamer.BirthYear = 2001;
            gamer.IdentityNumber = 12345;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);

            Game game = new Game();
            game.GameId = 1;
            game.Name = "Borderlands 3";

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Yılbaşı Kampanyası";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            OrderManager orderManager = new OrderManager();
            orderManager.Sale(gamer,game,campaign);
            

        }
    }
}
