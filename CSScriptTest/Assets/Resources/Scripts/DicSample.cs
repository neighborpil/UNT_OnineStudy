using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicSample : MonoBehaviour {

    Dictionary<string, int> dicGrade = new Dictionary<string, int>();

	// Use this for initialization
	void Start () {
        dicGrade["A+"] = 95;
        dicGrade["A0"] = 90;
        dicGrade["B+"] = 85;
        dicGrade["B0"] = 80;

        print(dicGrade["A+"]);

        foreach (var key in dicGrade.Keys)
        {
            print(dicGrade[key]);
        }

        foreach (var kv in dicGrade)
        {
            print(kv.Key + ", " + dicGrade[kv.Key]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
