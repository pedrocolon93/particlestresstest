using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitParticles : MonoBehaviour
{
    public int particleamount = 20000000;
    private List<Vector3> plist;
	// Use this for initialization
	void Start ()
	{
	    plist = new List<Vector3>();
	    for (int i = 0; i < particleamount; i++)
	    {
	        plist.Add(new Vector3(i,i,i));
	    }
        GetComponent<TCParticleSystem>().Emitter.Emit(plist.ToArray());
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
