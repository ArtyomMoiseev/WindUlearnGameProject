namespace Wind.Models
{
    public static class Game
    {
        private const string mapWithPlayerTerrain = @"";

        private const string mapWithPlayerTerrainSackGold = @"";

        private const string mapWithPlayerTerrainSackGoldMonster = @"";

        public static ICreature[,] Map;
        public static int Scores;
        public static bool IsOver;

        public static Keys KeyPressed;
        public static int MapWidth => Map.GetLength(0);
        public static int MapHeight => Map.GetLength(1);

        public static void CreateMap()
        {
            Map = CreatureMapCreator.CreateMap();
        }
    }
}