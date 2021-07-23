using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFB_DemonessCameraSpot : MonoBehaviour {

    public Transform pelvis;
    public float height = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        height = pelvis.transform.position.y;
        Vector3 tposition = transform.position;
        tposition = new Vector3(tposition.x, height, tposition.z);
        transform.position = tposition;
	}
}
