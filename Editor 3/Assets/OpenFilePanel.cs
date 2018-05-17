using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class OpenFilePanel : EditorWindow {

 
    static void Apply() {


        string path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
        if (path.Length != 0) {
            var fileContent = File.ReadAllBytes(path);
           // texture.LoadImage(fileContent);
            
        }
    }
}
