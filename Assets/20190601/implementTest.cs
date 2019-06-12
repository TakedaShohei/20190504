using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class implementTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        TestChild test = new TestChild();
        test.Kansu();
        Debug.Log(test.sum(5, 6));
        TestChild test2 = new TestChild();
        test2.number = 20;
        test2.Kansu();



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
