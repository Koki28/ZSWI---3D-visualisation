using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HierarchyView : MonoBehaviour {
    public Text myText;
    public string display;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        List<GameObject> listGO = CallingPrefabs.getGOList();
        myText.text = "This is my text";
        //display = display.ToString() + myText.ToString() + "\n";
        foreach (GameObject prefab in listGO) {
            
           }
	}


}
