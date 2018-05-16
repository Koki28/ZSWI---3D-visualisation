using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {

    public float moveSpeed;

	// Use this for initializations
	void Start () {
        moveSpeed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
