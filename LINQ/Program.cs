namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>() { "shooter", "rpg", "MMOs" };


            IEnumerable<string> gameOrder = gameNames.OrderBy(x => x.Length).ThenBy(x => x);

            foreach (string game in gameOrder)
            {
                Console.WriteLine(game);

            }



            

            
        }
    }
}
