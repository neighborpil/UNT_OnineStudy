using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string Name { get; set; }
    public float Speed { get; set; }
    public int HP { get; set; }
    //private int hp;
    //public int HP
    //{
    //    get { return hp; }
    //    private set
    //    {
    //        if (value > 50)
    //            hp = 50;
    //        else
    //            hp = value;
    //    }
    //}

    public Enemy(int hp)
    {
        this.HP = hp;
        this.Speed = 1.0F;
        this.Name = "Orcc";

    }

    public void Hit()
    {
        int hitDamage = Random.Range(5, 11);
        HP -= hitDamage;

        Shout();
    }

    protected virtual void Shout() { }
}
