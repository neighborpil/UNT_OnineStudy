using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    public GameObject[] enemies;
    List<GameObject> orcs = new List<GameObject>();

	// Use this for initialization
	void Start () {
        foreach (var enemy in enemies)
        {
            if (enemy.tag == "Orc")
            {
                orcs.Add(enemy);

            }
        }
	}

    private void OnMouseDown()
    {
        AllGreen();
        orcs.ForEach(o => o.GetComponent<Renderer>().material.color = Color.blue);
    }

    void AllGreen()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].GetComponent<Renderer>().material.color = Color.green;
        }
    }

    // Update is called once per frame
    void Update () {
	}
}
