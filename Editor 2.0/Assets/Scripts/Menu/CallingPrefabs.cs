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
    public GameObject unactive;

    int tmp = 0;

    private static List<GameObject> listGO;
    public Font textFont;
    public GameObject hierarchyPanel;
    public List<GameObject> buttons = new List<GameObject>();
    int buttonIndex = 0;

    public loadScene ls;


    // Use this for initialization
    void Start() 
    {
        listGO = new List<GameObject>();

        ls = FindObjectOfType(typeof(loadScene)) as loadScene;
        active.AddComponent<NewBehaviourScript>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void OnClickCube()
    {
        Vector3 vector = new Vector3(0, 0, -5);
        GameObject beltObject = Instantiate(belt, vector, transform.rotation);
        MakeButt(belt.name);
        ls.objects.Add(belt);
        ls.vectors.Add(vector);

        beltObject.AddComponent<NewBehaviourScript>();

        //createRef(prefab.name);
        //listGO.Add((GameObject)Instantiate(prefab, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

    public void OnClickShelf()
    {
        Vector3 vector = new Vector3(0, 0, 500);
        Instantiate(shelf, vector, transform.rotation);
        MakeButt(shelf.name);

        ls.objects.Add(shelf);
        ls.vectors.Add(vector);
        // createRef(shelf.name);
        //listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

	public void OnClickTable()
	{
        Vector3 vector = new Vector3(0, 0, 100);
        Instantiate(table, new Vector3(0.0f, 0.0f, 100.0f), transform.rotation);
		MakeButt(table.name);

        ls.objects.Add(table);
        ls.vectors.Add(vector);

        // createRef(shelf.name);
        //listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

	public void OnClickForklift()
	{
        Vector3 vector = new Vector3(0, 0, 0);
        Instantiate(forklift, vector, transform.rotation);
		MakeButt(forklift.name);

        ls.objects.Add(forklift);
        ls.vectors.Add(vector);
        // createRef(shelf.name);
        //listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

	public void OnClickTruck()
	{
        Vector3 vector = new Vector3(0, 0, 10);
        Instantiate(truck, vector, transform.rotation);
		MakeButt(truck.name);

        ls.objects.Add(truck);
        ls.vectors.Add(vector);
        // createRef(shelf.name);
        //listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

	public void OnClickFloor()
	{
        Vector3 vector = new Vector3(0, 0, 10);
        Instantiate(floor, vector, transform.rotation);
		MakeButt(floor.name);

        ls.objects.Add(floor);
        ls.vectors.Add(vector);
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

        buttons.Add(button);

        buttonIndex++;
    }

    void makeButton() {







    }

    void OnClick()
    {
        Debug.Log("clicked!");
		active = belt;
        Debug.Log(active.name);
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