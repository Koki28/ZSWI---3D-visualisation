using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallingPrefabs : MonoBehaviour
{

    public GameObject prefab;
    public GameObject shelf;
    int bubla = 0;

    public Transform hiearchyPanel;
    private static List<GameObject> listGO;
    public Font textFont;
    public GameObject hierarchyPanel;

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
        createRef(prefab.name);
        //listGO.Add((GameObject)Instantiate(prefab, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

    public void OnClickShelf()
    {
        Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);
        createRef(shelf.name);
        //listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
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
    public void createRef(string text)
    {
        if (text == null)
        {
            text = "";
        }

        GameObject newText = new GameObject(text.Replace(" ", "-"), typeof(RectTransform));

        var newTextComp = newText.AddComponent<Text>();
        //newText.AddComponent<CanvasRenderer>();

        //Text newText = transform.gameObject.AddComponent<Text>();
        newTextComp.text = text;
        newTextComp.color = Color.black;
        newTextComp.font = textFont;
        newTextComp.alignment = TextAnchor.MiddleCenter;
        newTextComp.fontSize = 10;

        newText.transform.SetParent(hierarchyPanel.transform);
        newText.transform.position = new Vector3(52.36487f, 354.2687f + bubla, 0.0f);
        bubla = bubla - 10;
        //GameObject a = (GameObject)Instantiate(newText);
        // a.transform.SetParent(transform, false);
    }
}