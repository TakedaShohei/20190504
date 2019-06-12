using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public static bool goal;
	// Use this for initialization
	void Start () {
        goal = false;
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            goal = true;
        }
    }
}
