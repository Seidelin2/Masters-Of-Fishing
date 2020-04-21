using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_of_Fishing.Builder
{
	public interface IBuilder
	{
		GameObject GetResult();

		void BuildGameObject();
	}
}
