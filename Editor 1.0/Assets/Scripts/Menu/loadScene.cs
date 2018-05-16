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
    int objCount;

    public GameObject active;

    public List<GameObject> objects;
    public List<Vector3> vectors;


    // Use this for initialization
    void Start () {
        objects = new List<GameObject>();
        vectors = new List<Vector3>();
    }

    public void loadFromJson() {

        // open file panel
        path = EditorUtility.OpenFilePanel("Open your json file", "", "json");

        if(path != null) {

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


            //string input = "{models: [{name: \"belt_prefab\", \"x\": \"0.0f\", \"y\": \"0.0f\", \"z\": \"-5.0f\"},{id: \"shelf\",\"x\": \"0.0f\", \"y\": \"0.0f\", \"z\": \"500.0f\"}]}";

            // default active model
            active = table;

            // counting number of objects
            objCount = 0;
            for(int i = 0; i < fileData.Length; i++) {
                if(fileData[i].Equals('}')) {
                    objCount++;
                }
            }
            Debug.Log("objCount: " + objCount);

            var data = JSON.Parse(fileData);

            var nameString = data["models"][0]["name"].Value;
            var x = data["models"][0]["x"].AsFloat;
            var y = data["models"][0]["y"].AsFloat;
            var z = data["models"][0]["z"].AsFloat;

            for(int j = 0; j < objCount-1; j++) {

                Debug.Log(nameString + x + y + z);

                for(int i = 0; i < list.Count; i++) {

                    Debug.Log("nameString" + nameString);
                    Debug.Log("list name" + list[i].name);


                    if (nameString.Equals(list[i].name)) {
                        active = list[i];
                        break;
                    }
                }

                Vector3 vector = new Vector3(x, y, z);
                Instantiate(active, vector, transform.rotation);
                objects.Add(active);
                vectors.Add(vector);
                //MakeButt(active.name);

                nameString = data["models"][j+1]["name"].Value;
                x = data["models"][j+1]["x"].AsFloat;
                y = data["models"][j+1]["y"].AsFloat;
                z = data["models"][j+1]["z"].AsFloat;
                
            }


        }
    }


    public void saveAs() {

        String data = "{@models: [@";

        for(int i = 0; i < objects.Count; i++) {
            data += "{@";
            data += "\"name\": " + "\"" + objects[i].name + "\"" + ",@";
            data += "\"x\": " + "\"" + vectors[i].x + "\"" + ",@";
            data += "\"y\": " + "\"" + vectors[i].y + "\"" + ",@";
            data += "\"z\": " + "\"" + vectors[i].z + "\"" + "@";

            if(i == objCount - 2) {
                data += "}@";
            }
            else {
                data += "},@";
            }
            
        }

        data += "]@}";

        data = data.Replace("@", System.Environment.NewLine);

        var path = EditorUtility.SaveFilePanel( "Save your scene", "", "scene1.json", "json");

        //System.IO.File.WriteAllText("path", firstnameGUI + ", " + lastnameGUI);

        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(data);
        writer.Close();



    }


    // Update is called once per frame
    void Update () {
		
	}
}
