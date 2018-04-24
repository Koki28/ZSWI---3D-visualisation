using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingPrefabs : MonoBehaviour
{

    public GameObject cube;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickCube()
    {
        //transform.position = new Vector3(508.5f, 191.5f, 5.0f);
        Instantiate(cube, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);

    }
}