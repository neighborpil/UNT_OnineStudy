using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Monster myMonster = new Monster(100);
        Animal myAnimal = new Animal(50);

        GameObject monster = GameObject.Find("Monster");
        monster.GetComponent<EnemyScript>().SetParam(myMonster);

        GameObject animal = GameObject.Find("Animal");
        animal.GetComponent<EnemyScript>().SetParam(myAnimal);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
