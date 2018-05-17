using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using SimpleJSON;
using UnityEditor;


public class loadScene : MonoBehaviour {

   // list of prefabs
    public GameObject belt;
    public GameObject shelf;
    public GameObject table;
    public GameObject forklift;
    public GameObject truck;
    public GameObject floor;

    string path;            // path to file
    int objectCount;        // object count in the file

    public GameObject active;

    public List<GameObject> objects;        // list of prefabs used
    public List<Vector3> vectors;           // list of vectors of objects
    public List<Vector3> rotates;           // list of vectord for rotation
    public List<GameObject> list;           // list of actual objects

    public int objCount = 0;                // increments when object is added

    public CallingPrefabs cp;


    // Use this for initialization
    void Start () {
        objects = new List<GameObject>();
        vectors = new List<Vector3>();
        list = new List<GameObject>();

        cp = FindObjectOfType(typeof(CallingPrefabs)) as CallingPrefabs;
    }

    // load from file
    public void loadFromJson() {

        // open file panel
        path = EditorUtility.OpenFilePanel("Open your json file", "", "json");

        if(path != null) {

            List<GameObject> objectList = new List<GameObject>() {belt, shelf, table, forklift, truck, floor };
            string fileData = "";

            try {
                fileData = File.ReadAllText(path);
                Debug.Log(fileData);
            }
            catch (IOException e) {
                Debug.Log("File not found");
                Debug.Log(e.Message);
            }

            // default active model
            active = table;

            // counting number of objects
            objectCount = 0;
            for(int i = 0; i < fileData.Length; i++) {
                if(fileData[i].Equals('}')) {
                    objectCount++;
                }
            }
            
            // parse Json file
            var data = JSON.Parse(fileData);

            var nameString = data["models"][0]["name"].Value;
            var x = data["models"][0]["x"].AsFloat;
            var y = data["models"][0]["y"].AsFloat;
            var z = data["models"][0]["z"].AsFloat;
            var rx = data["models"][0]["rx"].AsFloat;
            var ry = data["models"][0]["ry"].AsFloat;
            var rz = data["models"][0]["rz"].AsFloat;

            for (int j = 0; j < objectCount-1; j++) {                // for the number of objects in file

                for(int i = 0; i < objectList.Count; i++) {                   
                    if (nameString.Equals(objectList[i].name)) {    // decides type of the object
                        active = objectList[i];
                        break;
                    }
                }

                // instantiate new object
                Vector3 vector = new Vector3(x, y, z);
                Vector3 rotate = new Vector3(rx, ry, rz);
                GameObject newObject = Instantiate(active, vector, Quaternion.Euler(rotate));
                newObject.name = objCount.ToString();
                
                cp.MakeButt(active.name, newObject.name);
                objects.Add(active);
                vectors.Add(vector);
                list.Add(newObject);

                newObject.AddComponent<moveObjectScript>();
                objCount++;

                // parse next item
                nameString = data["models"][j+1]["name"].Value;
                x = data["models"][j + 1]["x"].AsFloat;
                y = data["models"][j + 1]["y"].AsFloat;
                z = data["models"][j + 1]["z"].AsFloat;
                rx = data["models"][j + 1]["rx"].AsFloat;
                ry = data["models"][j + 1]["ry"].AsFloat;
                rz = data["models"][j + 1]["rz"].AsFloat;

            }
        }
    }

    // save to file
    public void saveAs() {

        // save new postitions
        vectors.Clear();
        for(int i = 0; i < list.Count; i++) {
            vectors.Add(list[i].transform.position);           
        }

        // save new rotations
        rotates.Clear();
        for (int i = 0; i < list.Count; i++) {
            rotates.Add(list[i].transform.rotation.eulerAngles);
        }

        String data = "{@models: [@";

        Debug.Log(list.Count);
        Debug.Log(objects.Count);
        Debug.Log(vectors.Count);

        for(int i = 0; i < objects.Count; i++) {
            data += "{@";
            data += "\"name\": " + "\"" + objects[i].name + "\"" + ",@";
            data += "\"x\": " + "\"" + vectors[i].x + "\"" + ",@";
            data += "\"y\": " + "\"" + vectors[i].y + "\"" + ",@";
            data += "\"z\": " + "\"" + vectors[i].z + "\"" + ",@";
            data += "\"rx\": " + "\"" + rotates[i].x + "\"" + ",@";
            data += "\"ry\": " + "\"" + rotates[i].y + "\"" + ",@";
            data += "\"rz\": " + "\"" + rotates[i].z + "\"" + "@";

            if (i == objectCount - 2) {
                data += "}@";
            }
            else {
                data += "},@";
            }
            
        }

        data += "]@}";

        data = data.Replace("@", System.Environment.NewLine);

        var path = EditorUtility.SaveFilePanel( "Save your scene", "", "scene1.json", "json");

        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(data);
        writer.Close();

    }


    // Update is called once per frame
    void Update () {
		
	}

 


}
