using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorInput : MonoBehaviour
{

    public List<Color> key = new List<Color>();
    [SerializeField]
    private List<Color> input = new List<Color>();
    [SerializeField]
    private List<Image> colorInputImages = new List<Image>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Check();
        }
    }

    public void Check()
    {
        bool flag = true;
        if(key.Count != input.Count)
        {

        } else 
        {
            for(int i = 0; i < key.Count; i++)
            {
                /*
                if(IsColorEqualTo(key[i], input[i]))
                {
                    Debug.Log("true");
                } else 
                {
                    Debug.Log("false");
                    //flag = false;
                }
                */
                if(key[i].Equals(input[i]))
                {
                    Debug.Log("true");
                } else 
                {
                    Debug.Log("false");
                    flag = false;
                }
            }
        }

        Clear();
        Debug.Log("Color check was: " + flag);
    }

    private void UpdateImages()
    {
        for(int i = 0; i < colorInputImages.Count; i++)
        {
            colorInputImages[i].color = Color.white;
        }

        for(int i = 0; i < input.Count; i++)
        {
            colorInputImages[i].color = input[i];
        }
    }

    public void AddColor(ThisColor color)
    {
        if(input.Count >= 4)
        {
            Clear();
        }
        input.Add(color.color);
        UpdateImages();
    }

    private bool IsColorEqualTo(Color me, Color other)
    {//Debug.Log("Comparing: " + me + " " + other);
        return me.r == other.r && me.g == other.g && me.b == other.b && me.a == other.a;
    }

    public void Clear()
    {
        input.Clear();
        UpdateImages();
    }
}
