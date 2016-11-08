using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Rigidbody rb;
    public float thrust;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetButton("Jump"))
        {
            rb.velocity = (transform.forward * thrust);
        }
        
    }
}
