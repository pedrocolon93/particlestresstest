using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveParticles : MonoBehaviour {
    public float x, y, z;
	// Use this for initialization
	void Start () {
		
	}
    float period = 0.0f;
    public float timeInterval = 2;
    // Update is called once per frame
    void Update ()
	{
	    
        if (period > timeInterval)
        {
            //Do Stuff
            period = 0;
            transform.position = transform.position + new Vector3(x, y, z);
        }
        period += UnityEngine.Time.deltaTime;
    }
}
