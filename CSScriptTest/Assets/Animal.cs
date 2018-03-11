using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : Enemy
{
    public Animal(int hp) : base(hp)
    {
    }

    protected override void Shout()
    {
        Debug.Log("Animal is crying");
    }
}
