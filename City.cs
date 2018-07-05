using System.Collections;
using System.Collections.Generic;
using System;

namespace MockBid
{
	public class City  : BaseLevel
	{
		string[] CityName = new string[]{"Kyiv","Lviv"};
		static int cityNumber;

		public City(int depthlevel)
		{
			char let = (char)('a'+depthlevel);
			id = let +"city" + (cityNumber++).ToString();
			Random random = new Random();
			_name = CityName [random.Next (0, CityName.Length)];
			if (depthlevel< maxDepthLevel)
				FillChilds (depthlevel);
		}
	}
}