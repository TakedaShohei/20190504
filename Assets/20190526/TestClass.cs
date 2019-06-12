using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        TestChildClass child = new TestChildClass();
        child.SuperMethod();

        Boss boss = new Boss();
        boss.Damage(5);
        boss.SpecialAttack();
    }

    // Update is called once per frame
    void Update()
    {

    }
}