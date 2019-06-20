using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAround : MonoBehaviour {
    public Transform vcam;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool mforward;
    private CharacterController c;
	// Use this for initialization
	void Start () {
        c = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(vcam.eulerAngles.x <= toggleAngle && vcam.eulerAngles.x < 90.0f)
        {
            mforward = true;
        }
        else
        {
            mforward = false;
        }
        if (mforward)
        {
            Vector3 forward = vcam.TransformDirection(Vector3.forward);
            c.SimpleMove(forward * speed);
        }
	}
}
