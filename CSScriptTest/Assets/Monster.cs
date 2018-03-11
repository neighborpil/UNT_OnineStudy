using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Enemy
{
    public Monster(int hp) : base(hp)
    {
    }

    protected override void Shout()
    {
        Debug.Log("Mouster shout");
    }
}
