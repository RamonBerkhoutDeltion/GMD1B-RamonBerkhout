using UnityEngine;
using System.Collections;

public class SpawningBall : MonoBehaviour {

    public GameObject ball;
    public Vector3 position;
    public float power;
    

	// Use this for initialization
	void Start () {


        position = transform.position;
        

       
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(ball, position, Quaternion.identity);
            ball.GetComponent<Rigidbody>().velocity = transform.up * power;
        }
    }
}
