using System.Collections;
using System.Collections.Generic;
using System;
using MockBid;
using System.Reflection;

public class BaseLevel : MonoBehaviour 
{
	public string id;
	public string _name;
	public object[] childs;

	public static int childcount = 5;
	public static int maxDepthLevel =3;

	public static Type[] levelstype = new Type[]{ typeof(Country), typeof(City), typeof(Department) };

	public void FillChilds(int depthLevel)
	{
		System.Random random = new System.Random();
		var typechilds = levelstype [random.Next (0, levelstype.Length)];

		var ctors = typechilds.GetConstructors(BindingFlags.Public);

		var increasedDepthLevel = depthLevel+1;
		childs = new object[childcount];

		for (int i = 0; i < childcount; i++) 
		{
			ConstructorInfo ctor = typechilds.GetConstructor(new[] { typeof(int) });
			childs[i] =  ctor.Invoke(new object[] { increasedDepthLevel });

		}
	}
}
