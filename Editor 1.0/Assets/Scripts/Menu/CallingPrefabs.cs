using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingPrefabs : MonoBehaviour
{

    public GameObject prefab;
    public GameObject shelf;
    public Transform hiearchyPanel;
    private static List<GameObject> listGO;

    // Use this for initialization
    void Start() 
    {
        listGO = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickCube()
    {
        Instantiate(prefab, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);
        listGO.Add((GameObject)Instantiate(prefab, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

    public void OnClickShelf()
    {
        Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);
        listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

    public static List<GameObject> getGOList()
    {
        return listGO;
    }

    void CreateA()
    {
        GameObject a = (GameObject)Instantiate(prefab);
        a.transform.SetParent(hiearchyPanel.transform, false);
    }
}