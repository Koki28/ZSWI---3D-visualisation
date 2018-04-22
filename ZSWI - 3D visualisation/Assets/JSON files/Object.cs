using System;
using UnityEngine;
using System.Collections;

public class Object {

	GameObject cube = new GameObject ();

	//drag prefab here in editor
	public Transform InstantiateMe;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//you don't have to instantiate at the transform's positio nand rotation, swap these for what suits your needs
			var go = Instantiate(InstantiateMe, transform.position, transform.rotation);
		}
	}
}