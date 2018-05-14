using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using SimpleJSON;
using UnityEditor;


public class loadScene : MonoBehaviour {


    public GameObject belt;
    public GameObject shelf;
    public GameObject table;
    public GameObject forklift;
    public GameObject truck;
    public GameObject floor;

    string path;

    public GameObject active;


    // Use this for initialization
    void Start () {

    }

    public void onClickGo() {

        // open file panel
        path = EditorUtility.OpenFilePanel("Open your json file", "", "json");


        List<GameObject> list = new List<GameObject>() {belt, shelf, table, forklift, truck, floor };
        string fileData = "";

        try {

            fileData = File.ReadAllText(path);
            Debug.Log(fileData);

        }
        catch (IOException e) {
            Debug.Log("File not found");
            Debug.Log(e.Message);

        }

        Console.Read();


        //string input = "{models: [{name: \"belt_prefab\", \"x\": \"0.0f\", \"y\": \"0.0f\", \"z\": \"-5.0f\"},{id: \"shelf\",\"x\": \"0.0f\", \"y\": \"0.0f\", \"z\": \"500.0f\"}]}";

        // default active model
        active = table;

        // counting number of objects
        int objCount = 0;
        for(int i = 0; i < fileData.Length; i++) {
            if(fileData[i].Equals('}')) {
                objCount++;
            }
        }

        var data = JSON.Parse(fileData);

        var nameString = data["models"][0]["name"].Value;
        var x = data["models"][0]["x"].AsFloat;
        var y = data["models"][0]["y"].AsFloat;
        var z = data["models"][0]["z"].AsFloat;

        for(int j = 0; j < objCount; j++) {

            Debug.Log(nameString + x + y + z);

            for(int i = 0; i < list.Count; i++) {
                if (nameString.Equals(list[i].name)) {
                    active = list[i];
                    break;
                }
            }

            Instantiate(active, new Vector3(x, y, z), transform.rotation);
            //MakeButt(active.name);

            nameString = data["models"][j]["name"].Value;
            x = data["models"][j]["x"].AsFloat;
            y = data["models"][j]["y"].AsFloat;
            z = data["models"][j]["z"].AsFloat;

        }


    }



    // Update is called once per frame
    void Update () {
		
	}
}
