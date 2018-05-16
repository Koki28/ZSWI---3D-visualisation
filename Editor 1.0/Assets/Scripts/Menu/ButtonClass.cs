using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonClass : MonoBehaviour
{

    public GameObject buttonPrefab;
    public GameObject hierarchyPanel;
    private GameObject pree;
    int bubla = 0;

    public void MakeButt(GameObject pref)//Creates a button and sets it up
    {
        GameObject button = (GameObject)Instantiate(buttonPrefab);
        button.transform.SetParent(hierarchyPanel.transform);//Setting button parent
        button.transform.position = new Vector3(43.0f, 354.0f + bubla, 0.0f);
        button.GetComponent<Button>().onClick.AddListener(OnClick);//Setting what button does when clicked
                                                                   //Next line assumes button has child with text as first gameobject like button created from GameObject->UI->Button
        button.transform.GetChild(0).GetComponent<Text>().text = pref.name;//Changing text
        bubla = bubla - 18;
        pree = pref;
    }
    void OnClick()
    {

        Debug.Log(pree.name + " j");

    }
}