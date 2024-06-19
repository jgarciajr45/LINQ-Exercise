namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Madden",
                "FIFA",
                "NHL",
                "Fortnite",
                "WarZone",
                "Fall Guys"

            };
            List<string> sortedGames = videoGames.OrderBy(game => game.Length).ToList();

            foreach (string game in sortedGames)
            {
                Console.WriteLine(game);
            }
        }

    }
}