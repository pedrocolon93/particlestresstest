using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMeshParticles : MonoBehaviour {
    public int AmountOfParticleSystems = 20;
    public int AmountOfParticlesPerSystem = 1000000;
    // Use this for initialization
    void Start()
    {
        for (int index = 0; index < AmountOfParticleSystems; index++)
        {
            GameObject monster = new GameObject();
            monster.GetComponent<Transform>().parent = transform;
            monster.AddComponent<PointCloudManager>();
            List<Vector3> meshParticles = new List<Vector3>();
            List<Color> meshColorParticles = new List<Color>();
            for (int i = 0; i < AmountOfParticlesPerSystem;i++)
            {
                meshParticles.Add(new Vector3(i,i,i));    
                meshColorParticles.Add(Color.red);    
            }
            Vector3[] meshParticlesArray = meshParticles.ToArray();
            meshParticles.Clear();
            Color[] meshParticlesColorArray = meshColorParticles.ToArray();
            meshColorParticles.Clear();
            monster.GetComponent<PointCloudManager>().LoadDynamic(meshParticlesArray,meshParticlesColorArray);
            monster.AddComponent<MoveMesh>();
            monster.GetComponent<MoveMesh>().x = index;
            monster.GetComponent<MoveMesh>().y = index - 2;
            monster.GetComponent<MoveMesh>().z = index + 5;
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
