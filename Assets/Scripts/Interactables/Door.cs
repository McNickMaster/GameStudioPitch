using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{

    public Image bgImage;
    public Sprite door, openDoor;
    public bool open = false;

    public Passcode doorLock;

    public GameObject doorObjs, openObjs;


    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if(!open && doorLock.unlocked)
        {
            Open();
        }
    }

    private void Open()
    {
        open = true;

        bgImage.sprite = openDoor;

        doorObjs.SetActive(false);
        openObjs.SetActive(true);
    }

    


}
