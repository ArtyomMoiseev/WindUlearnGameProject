using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Wind.Models
{
    public class Level
    {
        public readonly IGameMapObject[,] CurrentLevel;
        public readonly Point InitialPosition;
        public readonly Point Exit;
        public readonly Point[] Chests;

        private GameField(IGameMapObject[,] currentLevel, Point initialPosition, Point exit, Point[] chests)
        {
            CurrentLevel = currentLevel;
            InitialPosition = initialPosition;
            Exit = exit;
            Chests = chests;
        }

        public static GameField FromText(string text)
        {
            var lines = text.Split(new[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            return FromLines(lines);
        }

        public static GameField FromLines(string[] lines)
        {
            var dungeon = new GameField[lines[0].Length, lines.Length];
            var initialPosition = Point.Empty;
            var exit = Point.Empty;
            var chests = new List<Point>();
            for (var y = 0; y < lines.Length; y++)
            {
                for (var x = 0; x < lines[0].Length; x++)
                {
                    switch (lines[y][x])
                    {
                        case '#':
                            dungeon[x, y] = StaticObject;
                            break;
                        case 'P':
                            dungeon[x, y] = MapCell.Empty;
                            initialPosition = new Point(x, y);
                            break;
                        case 'C':
                            dungeon[x, y] = MapCell.Empty;
                            chests.Add(new Point(x, y));
                            break;
                        case 'E':
                            dungeon[x, y] = MapCell.Empty;
                            exit = new Point(x, y);
                            break;
                        default:
                            dungeon[x, y] = MapCell.Empty;
                            break;
                    }
                }
            }
            return new Level(Current, initialPosition, exit, chests.ToArray());
        }

        public bool InBounds(Point point)
        {
            var bounds = new Rectangle(0, 0, CurrentLevel.GetLength(0), CurrentLevel.GetLength(1));
            return bounds.Contains(point);
        }
    }
}