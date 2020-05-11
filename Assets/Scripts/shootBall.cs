using UnityEngine;
using System.Collections;

public class shootBall : MonoBehaviour {

    public Transform cannonBall;
    public float speed = 10.0f;
    public Transform initialPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cannonBall, initialPosition.position, Quaternion.identity);
        }
	}
}
