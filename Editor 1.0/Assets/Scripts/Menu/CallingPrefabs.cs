using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallingPrefabs : MonoBehaviour
{

    public GameObject buttonPrefab;
    public GameObject panelToAttachButtonsTo;

    public GameObject belt;
    public GameObject shelf;
	public GameObject table;
	public GameObject forklift;
	public GameObject truck;
	public GameObject floor;

	public GameObject active;

    int tmp = 0;

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
        Instantiate(belt, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);
        MakeButt(belt.name);
        //createRef(prefab.name);
        //listGO.Add((GameObject)Instantiate(prefab, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

    public void OnClickShelf()
    {
        Instantiate(shelf, new Vector3(0.0f, 0.0f, 500.0f), transform.rotation);
        MakeButt(shelf.name);
       // createRef(shelf.name);
        //listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

	public void OnClickTable()
	{
		Instantiate(table, new Vector3(0.0f, 0.0f, 100.0f), transform.rotation);
		MakeButt(table.name);
		// createRef(shelf.name);
		//listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
		// CreateA();
	}

	public void OnClickForklift()
	{
		Instantiate(forklift, new Vector3(0.0f, 0.0f, 0.0f), transform.rotation);
		MakeButt(forklift.name);
		// createRef(shelf.name);
		//listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
		// CreateA();
	}

	public void OnClickTruck()
	{
		Instantiate(truck, new Vector3(0.0f, 0.0f, 10.0f), transform.rotation);
		MakeButt(truck.name);
		// createRef(shelf.name);
		//listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
		// CreateA();
	}

	public void OnClickFloor()
	{
		Instantiate(floor, new Vector3(0.0f, 0.0f, 10.0f), transform.rotation);
		MakeButt(floor.name);
		// createRef(shelf.name);
		//listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
		// CreateA();
	}

    public static List<GameObject> getGOList()
    {
        return listGO;
    }

    void CreateA()
    {
        GameObject a = (GameObject)Instantiate(belt);
        a.transform.SetParent(hierarchyPanel.transform, false);
    }

    void MakeButt(string nameGO)//Creates a button and sets it up
    {
        GameObject button = (GameObject)Instantiate(buttonPrefab);
        button.transform.SetParent(hierarchyPanel.transform);//Setting button parent
        button.transform.position = new Vector3(43.0f, 354.0f + tmp, 0.0f);
        button.GetComponent<Button>().onClick.AddListener(OnClick);//Setting what button does when clicked
                                                                   //Next line assumes button has child with text as first gameobject like button created from GameObject->UI->Button
        button.transform.GetChild(0).GetComponent<Text>().text = nameGO;//Changing text
        tmp = tmp - 18;
    }
    void OnClick()
    {
        Debug.Log("clicked!");
		active = belt;
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
        newTextComp.alignment = TextAnchor.MiddleLeft;
        newTextComp.fontSize = 10;

        newText.transform.SetParent(hierarchyPanel.transform);
        newText.transform.position = new Vector3(55.0f, 354.0f + tmp, 0.0f);
        tmp = tmp - 10;
        //GameObject a = (GameObject)Instantiate(newText);
        // a.transform.SetParent(transform, false);
    }
}