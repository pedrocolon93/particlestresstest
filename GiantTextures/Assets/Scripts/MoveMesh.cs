using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMesh : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public int x = 1, y = 0, z = 0;
	// Update is called once per frame
	void Update ()
	{
	    transform.position = transform.position + new Vector3(x, y, z);
	}
}
