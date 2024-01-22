using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Item : MonoBehaviour
{
    public ItemName item;
    public GameObject baseItem;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrabItem()
    {
        ItemInfo info = GetComponent<ItemInfo>();
        GameObject newItem = Instantiate(baseItem, CalcMousePos(), Quaternion.identity);
        newItem.GetComponent<Image>().sprite = info.itemImage;
    }


    Vector2 CalcMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }





}
