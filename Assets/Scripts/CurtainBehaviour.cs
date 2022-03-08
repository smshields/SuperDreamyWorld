using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//-https://www.youtube.com/watch?v=2VTHLNivveg&ab_channel=UnityMechanics

public class CurtainBehaviour : MonoBehaviour
{

    public Image original;
    public Sprite newSprite;
    public Sprite oldSprite;
    private bool isOriginal = true;

    //public Button but;

    void Start()
    {
        oldSprite = original.sprite;
    }

    
    void Update()
    {
        
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
