using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseDown()
    {
        print("down");
    }


    private void OnMouseUp()
    {
        print("up");
    }

    private void OnMouseEnter()
    {
        print("Mouse Entered");
    }

    private void OnMouseExit()
    {
        print("mouse out");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
