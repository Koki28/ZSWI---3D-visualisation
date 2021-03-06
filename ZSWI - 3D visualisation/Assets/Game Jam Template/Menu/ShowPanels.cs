﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ShowPanels : MonoBehaviour
{

    public GameObject optionsPanel;                         //Store a reference to the Game Object OptionsPanel 
    public GameObject optionsTint;                          //Store a reference to the Game Object OptionsTint 
    public GameObject menuPanel;							//Store a reference to the Game Object MenuPanel 
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject scenePanel;							//Store a reference to the Game Object ScenePanel 
=======
    public GameObject scenePanel;                           //Store a reference to the Game Object ScenePanel 
>>>>>>> 9a88f2abcf6d8b66247c983d9ef1dc9f1d5e8492
=======
    public GameObject scenePanel;                           //Store a reference to the Game Object ScenePanel 
>>>>>>> 9a88f2abcf6d8b66247c983d9ef1dc9f1d5e8492
    public GameObject aboutPanel;							//Store a reference to the Game Object AboutPanel 


    private GameObject activePanel;
    private MenuObject activePanelMenuObject;
    private EventSystem eventSystem;



    private void SetSelection(GameObject panelToSetSelected)
    {

        activePanel = panelToSetSelected;
        activePanelMenuObject = activePanel.GetComponent<MenuObject>();
        if (activePanelMenuObject != null)
        {
            activePanelMenuObject.SetFirstSelected();
        }
    }

    public void Start()
    {
        SetSelection(menuPanel);
    }

    //Call this function to activate and display the Options panel during the main menu
    public void ShowOptionsPanel()
    {
        optionsPanel.SetActive(true);
        optionsTint.SetActive(true);
        menuPanel.SetActive(false);
        SetSelection(optionsPanel);

    }

    //Call this function to activate and display the Scene panel during the main menu
    public void ShowScnenePanel()
    {
        scenePanel.SetActive(true);
        menuPanel.SetActive(false);
        SetSelection(scenePanel);

    }

    //Call this function to activate and display the About panel during the main menu
    public void ShowAboutPanel()
    {
        aboutPanel.SetActive(true);
        menuPanel.SetActive(false);
        SetSelection(aboutPanel);

    }

<<<<<<< HEAD
<<<<<<< HEAD
    //Call this function to deactivate and hide the About, Options and Scene panel during the main menu
=======
    //Call this function to deactivate and hide the Options, Scene and About panel during the main menu
>>>>>>> 9a88f2abcf6d8b66247c983d9ef1dc9f1d5e8492
=======
    //Call this function to deactivate and hide the Options, Scene and About panel during the main menu
>>>>>>> 9a88f2abcf6d8b66247c983d9ef1dc9f1d5e8492
    public void HideOtherPanels()
    {
        menuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        optionsTint.SetActive(false);
        scenePanel.SetActive(false);
        aboutPanel.SetActive(false);
    }

    //Call this function to activate and display the main menu panel during the main menu
    public void ShowMenu()
    {
        menuPanel.SetActive(true);
        SetSelection(menuPanel);
    }

    //Call this function to deactivate and hide the main menu panel during the main menu
    public void HideMenu()
    {
        menuPanel.SetActive(false);

    }
}