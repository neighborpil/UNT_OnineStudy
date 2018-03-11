using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    Enemy mySelf;

	// Use this for initialization
	void Start () {
		
	}
	
    public void SetParam(Enemy srcEnemy)
    {
        mySelf = srcEnemy;
    }

    private void OnMouseDown()
    {
        if (mySelf != null)
            mySelf.Hit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
