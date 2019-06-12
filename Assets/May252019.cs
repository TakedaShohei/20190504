using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class May252019 : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        numbers(3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void numbers(int a)
    {
        int[] number = new int[a];
        for (int i = 0; i < number.Length; i++)
        {
            Debug.Log(number);
        }
    }
}
