using UnityEngine;
using System.Collections;

public class FlipperLeft : MonoBehaviour {

    public float flipperStrenght;
    public float pushForce;
    private HingeJoint hinge;

	// Use this for initialization
	void Start () {

        hinge = GetComponent<HingeJoint>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Left"))
        {
            Vector3 f = transform.up * flipperStrenght;
            Vector3 p = (transform.right) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }
	
	}
}