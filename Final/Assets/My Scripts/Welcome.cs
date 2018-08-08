using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChapterOne

{

public class Welcome : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		MyWelcomeMessage();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MyWelcomeMessage()
	{
		Debug.Log("Welcome");
	}
}

}
