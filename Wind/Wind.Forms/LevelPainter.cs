using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using Wind.Models;

namespace Wind.Forms
{
    public class LevelPainter
    {
		public SizeF Size => new SizeF(DefaultGameObjects.Field.Width, DefaultGameObjects.Field.Height);
		public Size LevelSize => new Size(DefaultGameObjects.Field.Width, DefaultGameObjects.Field.Width);

		private readonly Dictionary<IGameMapObject, Point[]> paths;
		private GameField currentMap;
		private int mainIteration;
		private Bitmap mapImage;

		private Point? lastMouseClick;

        public void ScenePainter(IGameMapObject[] maps)
		{
			//paths = maps.ToDictionary(x => x, x => TransformPath(x, DungeonTask.FindShortestPath(x)).ToArray());

			currentMap = maps[0];
			mainIteration = 0;
			CreateMap();
		}

		public void ChangeLevel(GameField newMap)
		{
			currentMap = newMap;
			CreateMap();
			mainIteration = 0;
			lastMouseClick = null;
        }

		public void Update()
		{
			mainIteration = Math.Min(mainIteration + 1, paths[currentMap].Length - 1);
		}




		//private void DrawLevel(Graphics graphics)
		//{
		//	graphics.DrawImage(mapImage, new Rectangle(0, 0, LevelSize.Width, LevelSize.Height));
		//	foreach (var chest in currentMap.Chests)
		//		graphics.DrawImage(Properties.Resources.Chest, new Rectangle(chest.X, chest.Y, 1, 1));
		//	graphics.DrawImage(Properties.Resources.Castle, new Rectangle(currentMap.Exit.X, currentMap.Exit.Y, 1, 1));
		//}



		private void CreateMap()
		{
			var cellWidth = 512;
			var cellHeight = 512;
			mapImage = new Bitmap(LevelSize.Width * cellWidth, LevelSize.Height * cellHeight);
			using (var graphics = Graphics.FromImage(mapImage))
			{
				for (var x = 0; x < DefaultGameObjects.Field.Width; x++)
				{
					for (var y = 0; y < DefaultGameObjects.Field.Height; y++)
                    {
                        var image = DefaultGameObjects.Field.Map[x, y] == IGameMapObject.IsWall ? DefaultGameObjects.Terrain : DefaultGameObjects.Terrain.ObjectImage;
						graphics.DrawImage(image, new Rectangle(x * cellWidth, y * cellHeight, cellWidth, cellHeight));
					}
				}
			}
		}
	}
}
}