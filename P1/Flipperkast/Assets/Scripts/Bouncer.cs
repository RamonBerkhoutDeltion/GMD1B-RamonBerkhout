using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour {

    public Rigidbody ball;
    public float power;
    public float forceRadius;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

        
	}

    void OnCollisionEnter(Collision col)
    {

        col.gameObject.GetComponent<Rigidbody>().AddExplosionForce(power, transform.position, forceRadius);

        

    }
}
