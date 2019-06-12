using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor{
    string name_;
    int hp_;
    int power_;
    int defence_;


	public void Attack(int p)
    {
    }

    public void SetUp(string name,int hp,int power, int defence)
    {
        name_ = name;

        hp_ = hp;
        power_ = power;
        defence_ = defence;


    }
}
