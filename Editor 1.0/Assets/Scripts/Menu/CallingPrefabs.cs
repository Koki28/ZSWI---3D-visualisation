using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallingPrefabs : MonoBehaviour
{

    public GameObject buttonPrefab;
    public GameObject panelToAttachButtonsTo;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject cube;
=======
    public GameObject belt;
>>>>>>> a1db976bc2f3b34fc3d45fb10600a5c39acc2f20
=======
    public GameObject belt;
>>>>>>> 5ea65a855431b962930a973f98e80895e0da6014
=======
    public GameObject prefab;
>>>>>>> parent of f6cdfc6... butTry
    public GameObject shelf;
    int bubla = 0;

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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        Instantiate(cube, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);
       // ButtonClass bpc = new ButtonClass();
        //bpc.MakeButt(cube);
        MakeButt(cube);

=======
=======
>>>>>>> 5ea65a855431b962930a973f98e80895e0da6014
        Vector3 vector = new Vector3(0, 0, -5);
        GameObject beltObject = Instantiate(belt, vector, transform.rotation);
        MakeButt(belt.name);
        ls.objects.Add(belt);
        ls.vectors.Add(vector);

        beltObject.AddComponent<NewBehaviourScript>();

=======
        Instantiate(prefab, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);
        MakeButt(prefab.name);
>>>>>>> parent of f6cdfc6... butTry
        //createRef(prefab.name);
        //listGO.Add((GameObject)Instantiate(prefab, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

    public void OnClickShelf()
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);
        //ButtonClass bpc = new ButtonClass();
        //bpc.MakeButt(shelf);
        MakeButt(shelf);
=======
=======
>>>>>>> 5ea65a855431b962930a973f98e80895e0da6014
        Vector3 vector = new Vector3(0, 0, 500);
        Instantiate(shelf, vector, transform.rotation);
        MakeButt(shelf.name);

        ls.objects.Add(shelf);
        ls.vectors.Add(vector);
        // createRef(shelf.name);
<<<<<<< HEAD
=======
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
>>>>>>> 5ea65a855431b962930a973f98e80895e0da6014
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
=======
        Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), transform.rotation);
        MakeButt(shelf.name);
       // createRef(shelf.name);
>>>>>>> parent of f6cdfc6... butTry
        //listGO.Add((GameObject)Instantiate(shelf, new Vector3(0.0f, 0.0f, -5.0f), Quaternion.identity));
        // CreateA();
    }

    public static List<GameObject> getGOList()
    {
        return listGO;
    }
<<<<<<< HEAD
    void OnClick()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        
        Debug.Log(" clicked ");

=======
=======
>>>>>>> 5ea65a855431b962930a973f98e80895e0da6014
        GameObject a = (GameObject)Instantiate(belt);
=======

    void CreateA()
    {
        GameObject a = (GameObject)Instantiate(prefab);
>>>>>>> parent of f6cdfc6... butTry
        a.transform.SetParent(hierarchyPanel.transform, false);
    }

    void MakeButt(string nameGO)//Creates a button and sets it up
    {
        GameObject button = (GameObject)Instantiate(buttonPrefab);
        button.transform.SetParent(hierarchyPanel.transform);//Setting button parent
        button.transform.position = new Vector3(43.0f, 354.0f + bubla, 0.0f);
        button.GetComponent<Button>().onClick.AddListener(OnClick);//Setting what button does when clicked
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                                                                   //Next line assumes button has child with text as first gameobject like button created from GameObject->UI->Button
        button.transform.GetChild(0).GetComponent<Text>().text = pref.name;//Changing text
        bubla = bubla - 18;
        pree = pref;
=======
=======
>>>>>>> 5ea65a855431b962930a973f98e80895e0da6014
                                                                               //Next line assumes button has child with text as first gameobject like button created from GameObject->UI->Button

        button.transform.GetChild(0).GetComponent<Text>().text = nameGO;//Changing text
        tmp = tmp - 18;

        buttons.Add(button);

        buttonIndex++;
<<<<<<< HEAD
>>>>>>> a1db976bc2f3b34fc3d45fb10600a5c39acc2f20
=======
>>>>>>> 5ea65a855431b962930a973f98e80895e0da6014
    }

    void makeButton() {







=======
                                                                   //Next line assumes button has child with text as first gameobject like button created from GameObject->UI->Button
        button.transform.GetChild(0).GetComponent<Text>().text = nameGO;//Changing text
        bubla = bubla - 18;
>>>>>>> parent of f6cdfc6... butTry
    }
    void OnClick()
    {
        Debug.Log("clicked!");
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
        newText.transform.position = new Vector3(55.0f, 354.0f + bubla, 0.0f);
        bubla = bubla - 10;
        //GameObject a = (GameObject)Instantiate(newText);
        // a.transform.SetParent(transform, false);
    }
}