using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

delegate void EventHandler(Color color);

class OrcParams
{
    public event Action<Color> OnColorChange;

    int _hp = 100;

    public int HP
    {
        get { return _hp; }
        set
        {
            _hp = value;

            if (_hp < 50)
                OnColorChange(Color.red);
        }
    }
}

public class Orc : MonoBehaviour {

    void ChangeColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }

    void ShowColorValue(Color color)
    {
        print(color);
    }

    OrcParams myParam;

	// Use this for initialization
	void Start () {
        myParam = new OrcParams();
        myParam.OnColorChange += ChangeColor;
        myParam.OnColorChange += ShowColorValue;

    }

    private void OnMouseDown()
    {
        myParam.HP -= 10;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
