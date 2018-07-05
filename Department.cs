using System.Collections;
using System.Collections.Generic;
using System;

namespace MockBid
{
	public class Department :BaseLevel 
	{

		static int depNumber;
		string[] DepartmentName = new string[]{"R&D","MArketting"};


		public Department(int depthlevel)
		{
			char let = (char)('a'+depthlevel);
			id = let +"d" + (depNumber++).ToString();
			Random random = new Random();
			_name = DepartmentName [random.Next (0, DepartmentName.Length)];
			if (depthlevel< maxDepthLevel)
				FillChilds (depthlevel);
		}
	}
}