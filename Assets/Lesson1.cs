using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Person p = new Person ();
		p.name = "test";
		Debug.Log(p.name);
		Debug.Log("aho");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Person {
	public string name;
}

