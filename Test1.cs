using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MockBid;

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		var bid = new MockBid.BiD ();
		Debug.Log(bid.childs.Length);
		Debug.Log(bid.childs[0]==null);
		Debug.Log(JsonUtility.ToJson(bid));
	}
	

}
