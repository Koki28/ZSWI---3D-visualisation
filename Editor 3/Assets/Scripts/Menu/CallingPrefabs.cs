using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallingPrefabs : MonoBehaviour
{
    // references to components
    public GameObject buttonPrefab;
    public GameObject hierarchyPanel;

    // prefabs
    public GameObject belt;
    public GameObject shelf;
	public GameObject table;
	public GameObject forklift;
	public GameObject truck;
	public GameObject floor;

    // gap between buttons
    public int gap = 0;

    // list of buttons
    public List<GameObject> buttons = new List<GameObject>();

    // text field for coordinates
    public InputField textFieldX;
    public InputField textFieldY;
    public InputField textFieldZ;

    public InputField textFieldRX;
    public InputField textFieldRY;
    public InputField textFieldRZ;

    //public string buttonIndex;
    public string objectIndex;

    // reference to load scene class
    public loadScene ls;


    // Use this for initialization
    void Start() 
    {
        ls = FindObjectOfType(typeof(loadScene)) as loadScene;      // reference to load scene
    }

    // Update is called once per frame
    void Update() {
        
    }

    // instantiate belt
    public void OnClickBelt()
    {
        Vector3 vector = new Vector3(0, -1.7f, 0);
        GameObject beltObject = Instantiate(belt, vector, transform.rotation);
        beltObject.name = ls.objCount.ToString();
        MakeButt(belt.name, beltObject.name);
        ls.objects.Add(belt);
        ls.vectors.Add(vector);
        ls.list.Add(beltObject);
        
        beltObject.AddComponent<moveObjectScript>();
        ls.objCount++;
    }

    public void OnClickShelf()
    {
        Vector3 vector = new Vector3(0, 1, 1);
        GameObject shelfObject = Instantiate(shelf, vector, transform.rotation);
        shelfObject.name = ls.objCount.ToString();
        MakeButt(shelf.name, shelfObject.name);
        ls.objects.Add(shelf);
        ls.vectors.Add(vector);
        ls.list.Add(shelfObject);

        shelfObject.AddComponent<moveObjectScript>();
        ls.objCount++;
    }

	public void OnClickTable()
	{
        Vector3 vector = new Vector3(0, -1, 0);
        GameObject tableObject = Instantiate(table, vector, transform.rotation);
        tableObject.name = ls.objCount.ToString();
        MakeButt(table.name, tableObject.name);
        ls.objects.Add(table);
        ls.vectors.Add(vector);
        ls.list.Add(tableObject);

        tableObject.AddComponent<moveObjectScript>();
        ls.objCount++;
    }

	public void OnClickForklift()
	{
        Vector3 vector = new Vector3(0, -3, 0);
        GameObject forkliftObject = Instantiate(forklift, vector, transform.rotation);
        forkliftObject.name = ls.objCount.ToString();
        MakeButt(forklift.name, forkliftObject.name);
        ls.objects.Add(forklift);
        ls.vectors.Add(vector);
        ls.list.Add(forkliftObject);

        forkliftObject.AddComponent<moveObjectScript>();
        ls.objCount++;
    }

	public void OnClickTruck()
	{
        Vector3 vector = new Vector3(0, -3, 0);
        GameObject truckObject = Instantiate(truck, vector, transform.rotation);
        truckObject.name = ls.objCount.ToString();
        MakeButt(truck.name, truckObject.name);
        ls.objects.Add(truck);
        ls.vectors.Add(vector);
        ls.list.Add(truckObject);

        truckObject.AddComponent<moveObjectScript>();
        ls.objCount++;
    }

	public void OnClickFloor()
	{
        Vector3 vector = new Vector3(0, -3, 0);
        GameObject floorObject = Instantiate(floor, vector, transform.rotation);
        floorObject.name = ls.objCount.ToString();
        MakeButt(floor.name, floorObject.name);
        ls.objects.Add(floor);
        ls.list.Add(floorObject);

        floorObject.AddComponent<moveObjectScript>();
        ls.objCount++;
    }

    // creates a button and sets it up
    public void MakeButt(string nameGO, string objectName)
    {
        Vector3 vector = new Vector3(45.0f, 400.0f + gap, 0.0f);

        GameObject button = (GameObject)Instantiate(buttonPrefab, vector, transform.rotation);
        button.transform.SetParent(hierarchyPanel.transform);       // setting button parent
        button.name = objectName;
                                                                        
        button.GetComponent<Button>().onClick.AddListener(() => { OnClick(objectName); });

        button.transform.GetChild(0).GetComponent<Text>().text = nameGO;    //changing text
        gap = gap - 18;

        buttons.Add(button);
    }

    // event on click
    public void OnClick(string name)
    {
        objectIndex = name;
    }

}