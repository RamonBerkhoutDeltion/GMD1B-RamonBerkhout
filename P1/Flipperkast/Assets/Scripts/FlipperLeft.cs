using UnityEngine;
using System.Collections;

public class FlipperLeft : MonoBehaviour
{

    public float flipperStrenght;
    public float pushForce;


    // Use this for initialization
    void Start()
    {

        GetComponent<Rigidbody>().centerOfMass = Vector3.zero;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Left"))
        {
            Vector3 f = -transform.up * flipperStrenght;
            Vector3 p = transform.right + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }

    }
}