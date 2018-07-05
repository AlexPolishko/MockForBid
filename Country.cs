using System.Collections;
using System.Collections.Generic;
using System;

namespace MockBid
{
	public class Country  : BaseLevel
	{
		static int countryNumber;
		string[] CountryName = new string[]{"USA","UK"};


		public Country(int depthlevel)
		{
			char let = (char)('a'+depthlevel);
			id = let +"c" + (countryNumber++).ToString();
			Random random = new Random();
			_name = CountryName [random.Next (0, CountryName.Length)];
			if (depthlevel< maxDepthLevel)
				FillChilds (depthlevel);
		}
	}
}