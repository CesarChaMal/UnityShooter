using UnityEngine;
using System.Collections;

public class rotateBarrel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
	}
	
	// Update is called once per frame
	void Update () {
        
        Debug.Log("Hello World Update");
        float verValue = Input.GetAxis("Vertical");
        float horValue = Input.GetAxis("Horizontal");
        
        Debug.Log(verValue);
        Debug.Log(horValue);

        if (verValue != 0) {
            transform.Rotate(verValue, 0, 0);
        }

        if (horValue != 0)
        {
            transform.Rotate(0, horValue, 0);
        }
        
    }
}
