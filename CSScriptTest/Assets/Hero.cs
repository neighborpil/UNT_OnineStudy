using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public GameObject[] enemies;
    int count = 0;

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseDown()
    {
        if(enemies[count].GetComponent<Renderer>().material.color != Color.red)
        {
            enemies[count].GetComponent<Renderer>().material.color = Color.red;
            count++;
        }
        else
        {
            enemies[count].GetComponent<Renderer>().material.color = Color.green;
            count++;
        }
        if (count > enemies.Length - 1)
            count = 0;
    }


    // Update is called once per frame
    void Update () {
		
	}
}
