using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Passcode : MonoBehaviour
{
    public string passkey = "1001";
    public TMP_InputField passcodeText;

    public bool unlocked = false;

    private int one = 0, two = 0, three = 0, four = 0;
    
    // Start is called before the first frame update
    void Awake()
    {
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateText()
    {
        if(one > 9)
        {
            one = 0;
        }
        
        if(two > 9)
        {
            two = 0;
        }
        
        if(three > 9)
        {
            three = 0;
        }
        
        if(four > 9)
        {
            four = 0;
        }
        
        passcodeText.text = ""+ one + two + three + four;
    }

    public void Submit()
    {
        if(passcodeText.text.Equals(passkey))
        {
            unlocked = true;
            Debug.Log("Yippie!");
        }
    }

    public void One()
    {
        one++;
        UpdateText();
    }
    
    public void Two()
    {
        two++;
        UpdateText();
        
    }
    
    public void Three()
    {
        three++;
        UpdateText();
        
    }
    
    public void Four()
    {
        four++;
        UpdateText();
        
    }

}
