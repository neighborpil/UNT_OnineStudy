using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : MonoBehaviour {

    Monster mySelf;

	// Use this for initialization
	void Start () {
        this.mySelf = new Monster(100);

	}
	
    void OnMouseDown()
    {
        mySelf.Hit();
        print("HP : " + this.mySelf.HP);
        print("Speed : " + this.mySelf.Speed);
        print("Name : " + this.mySelf.Name);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
