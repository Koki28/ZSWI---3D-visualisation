using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject cube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void OnClickCube()
    {
		//transform.position = new Vector3(508.5f, 191.5f, 5.0f);
		Instantiate(cube, new Vector3(508.0f, 191.0f, -5.0f), transform.rotation);
    }
}