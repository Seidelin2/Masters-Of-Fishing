using Master_of_Fishing.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_of_Fishing.Builder
{
	public class PlayerBuilder : IBuilder
	{
		private GameObject go;

		public void BuildGameObject()
		{
			go = new GameObject();
			Player player = new Player();

			go.AddComponent(player);
			SpriteRenderer sr = new SpriteRenderer("Sprites/Player/playerPixel");

			go.AddComponent(sr);
		}

		public GameObject GetResult()
		{
			return go;
		}
	}
}
