using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_of_Fishing.Builder
{
	public class Director
	{
		private IBuilder builder;

		public Director(IBuilder builder)
		{
			this.builder = builder;
		}

		public GameObject Construct()
		{
			builder.BuildGameObject();

			return builder.GetResult();
		}
	}
}
