using System.Collections;
using System.Collections.Generic;
using System;

namespace MockBid
{
	public class BiD :BaseLevel 
	{
		
		static int staticBusinessNumber;
		string[] BusinessName = new string[]{"buy","sell"};


		public BiD()
		{
			id = "b" + (staticBusinessNumber++).ToString();
			Random random = new Random();
			_name = BusinessName [random.Next (0, BusinessName.Length)];

			FillChilds (0);
		}
	}
}