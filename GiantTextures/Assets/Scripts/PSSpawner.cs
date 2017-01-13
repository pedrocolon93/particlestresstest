using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSSpawner : MonoBehaviour
{
    public int AmountOfParticleSystems = 20;
    public int AmountOfParticlesPerSystem = 1000000;
	// Use this for initialization
	void Start () {
	    for (int index = 0; index < AmountOfParticleSystems; index++)
	    {
            GameObject monster = (GameObject)Instantiate(Resources.Load("Prefabs/ParticleSystem"));
	        monster.GetComponent<Transform>().parent = transform;
	        monster.GetComponent<EmitParticles>().particleamount = AmountOfParticlesPerSystem;
            monster.GetComponent<MoveParticles>().x = index ;
            monster.GetComponent<MoveParticles>().y = index ;
            monster.GetComponent<MoveParticles>().z = index;

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
