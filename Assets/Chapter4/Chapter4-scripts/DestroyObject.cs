﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {
    public float speed = 2.0f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject,speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
