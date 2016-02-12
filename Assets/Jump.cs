using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {


    public float jumpForce;
    public Rigidbody2D sbody;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown( KeyCode.Space ) )
        {
            sbody.AddForce( new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
	}
}
