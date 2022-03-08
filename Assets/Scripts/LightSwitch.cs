using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LightSwitch : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    public Sprite oldSprite;
    private bool isOriginal = true;

    void Start()
    {
        oldSprite = original.sprite;
    }

    public void NewImage()
    {

        if (isOriginal == true)
        {
            original.sprite = newSprite;
            isOriginal = false;
        }
        else
        {
            original.sprite = oldSprite;
            isOriginal = true;
        }
    }
}
