using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Wind.Models
{
    public class LevelReader
    {
        private Dictionary<char, IGameMapObject> objectsDictionary = new Dictionary<char, IGameMapObject>()
        {
            {'t', new StaticObject("Terrain",0,0)}
        };

        public IGameMapObject[,] ReadLevel(string fileName)
        {
            var levelText = File.ReadAllLines(fileName).Select(a => a.ToCharArray()).T;
            var level = new IGameMapObject[levelText.GetLength(0),levelText.GetLength(1)];
            for (var i = 0; i <=levelText.GetLength(0); i++)
            for (var j = 0; j <=levelText.GetLength(1); j++)
            {
                if (!objectsDictionary.ContainsKey(levelText[i,j]))
                    level[i, j] = null;
                level[i, j] = objectsDictionary[levelText[i, j]];
            }

            return level;
        }

    }
}