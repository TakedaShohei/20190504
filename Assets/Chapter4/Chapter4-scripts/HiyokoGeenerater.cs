using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGeenerater : MonoBehaviour {
    public float interval = 3.0f;
    public GameObject obj;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnObj", 0.1f, interval);
	}
    void SpawnObj()
    {
        Instantiate(obj, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
