using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateSample : MonoBehaviour {

    void ShowMyName()
    {
        print("My name is Gom");
    }

    void ShowMyAge()
    {
        print("30 years old");
    }

    void ShowMyJob()
    {
        print("Spy");
    }
    
    // Use this for initialization
    void Start () {
        Action ShowMyInfo = new Action(ShowMyName);
        ShowMyInfo += ShowMyAge;
        ShowMyInfo += ShowMyJob;
        ShowMyInfo();

        ShowMyInfo -= ShowMyAge;
        ShowMyInfo();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
