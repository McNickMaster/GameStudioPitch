using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Item : MonoBehaviour
{
    public ItemInfo info;
    public GameObject grabbableItem;

    private bool grabbed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(grabbed)
        {
            grabbableItem.transform.position = CalcMousePos();

        } else 
        {
            grabbableItem.transform.localPosition = Vector3.zero;
        }
    }

    public void GrabItem()
    {
        
    }

    public void ToggleGrab()
    {
        grabbed = !grabbed;
    }


    Vector2 CalcMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }





}
