using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject monster = GameObject.Find("Cube"); 
        GameObject thisMon = GameObject.Find("Cube");
        GameObject yourMon = GameObject.Find("Cube");
        GameObject tempMon = GameObject.Find("Cube");

        monster.name = "Orc";

        print(monster.name);
        print(thisMon.name);
        print(yourMon.name);
        print(tempMon.name);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
