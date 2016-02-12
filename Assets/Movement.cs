using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float moveL;
    public float moveR;
    public Rigidbody2D sbody;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            sbody.AddForce(new Vector2(-moveL, 0f));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            sbody.AddForce(new Vector2(moveR, 0f));
        }
	}
}
