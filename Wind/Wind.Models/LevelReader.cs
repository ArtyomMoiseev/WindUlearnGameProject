using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Wind.Models
{
    public class LevelReader
    {
        private readonly Dictionary<char, IGameMapObject> objectsDictionary = new Dictionary<char, IGameMapObject>()
        {
            {'t', new StaticObject("Terrain",0,0)},
            {'u', 
                new FanMapObject(Direction.Up, new List<FanMode>()
            {
                new FanMode(0,"FanU"),
                new FanMode(30,"FanUo")
            })
            },
            {'d', DefaultGameObjects.FanD},
            {'l', DefaultGameObjects.FanL},
            {'r', DefaultGameObjects.FanR},
            {'e',DefaultGameObjects.End}
        };

        public IGameMapObject[,] ReadLevel(string fileName)
        {
            var levelText = File.ReadAllLines(fileName);
            var level = new IGameMapObject[levelText.GetLength(0),levelText[0].Length];
            for (var i = 0; i < levelText.GetLength(0); i++)
            {
                var str = levelText[i].ToCharArray();
                for (var j = 0; j < str.Length; j++)
                {
                    if (!objectsDictionary.ContainsKey(str[j]))
                        level[i, j] = null;
                    else
                        level[i, j] = objectsDictionary[str[j]];
                }

            }

            return level;
        }

        public Point FindSphere(string fileName)
        {
            var levelText = File.ReadAllLines(fileName);
            for (var i = 0; i < levelText.GetLength(0); i++)
            {
                var str = levelText[i].ToCharArray();
                for (var j = 0; j < str.Length; j++)
                {
                    if (str[j] == 's')
                        return new Point(i, j);
                }

            }
            throw new Exception("Sphere not exist on level");
        }

    }
}