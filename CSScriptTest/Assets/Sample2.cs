using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample2 : MonoBehaviour {

    int myAge;

    public int myAge2 = 10;

	// Use this for initialization
	void Start () {
        GameObject monster = GameObject.Find("Cube");
        GameObject thisMon = GameObject.Find("Cube");
        GameObject yourMon = GameObject.Find("Cube");
        GameObject tempMon = GameObject.Find("Cube");

        print(monster.name);

        monster.name = "Orc";

        print("monster name : " + monster.name);
        print("thisMon name : " + thisMon.name);
        print("yourMon name : " + yourMon.name);
        print("tempMon name : " + tempMon.name);

        myAge = 100;

        print(myAge2);
    }

    // Update is called once per frame
    void Update () {
        myAge = 400;
	}
}
