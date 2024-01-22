using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    	public GameObject currentScreen;
    	public GameObject[] screens;

	public GameObject initPanel;

    	// Start is called before the first frame update
    	void Awake()
    	{
        	//SetActivePanel(initPanel);
    	}

    	// Update is called once per frame
    	void Update()
    	{

    	}


	public void SetActivePanel(ThisPanel panel)
	{
		currentScreen.SetActive(false);
		currentScreen = screens[(int)panel.myPanel];
		currentScreen.SetActive(true);

		//Debug.Log("panel has been swapped");
	}

	
}


public enum Panels
{
	CLASS_1, CLASS_2, CLASS_BOARD, CLASS_CLOCK, CLASS_DOOR, CLASS_3, CLASS_GRID
}
