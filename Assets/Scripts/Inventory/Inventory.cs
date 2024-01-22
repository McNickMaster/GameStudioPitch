using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<ItemName> inventory = new List<ItemName>();
    public List<Image> inventoryUISlots = new List<Image>();

    private Vector2 mousePos;

    public GameObject baseItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup(ItemInfo item)
    {
        inventory.Add(item.item);
        inventoryUISlots[inventory.IndexOf(item.item)].sprite = item.itemImage;
        inventoryUISlots[inventory.IndexOf(item.item)].transform.GetChild(0).GetComponent<Image>().sprite = item.itemImage;
    }
    void Remove(ItemName item)
    {
        inventory.Remove(item);
    }


}

public enum ItemName
{
    SCISSORS, PENCIL
}
