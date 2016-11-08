using UnityEngine;
using System.Collections;

public class SpawningBall : MonoBehaviour {

    public GameObject ball;
    public Vector3 position;
    

	// Use this for initialization
	void Start () {

        Instantiate(ball, position, Quaternion.identity);
        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
