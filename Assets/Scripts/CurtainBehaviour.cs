using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CurtainBehaviour : MonoBehaviour
{
    //[SerializeField] public Sprite ClosedCurtains;
    //[SerializeField] public Sprite OpenCurtains;
    //gameObject.GetComponent<Image>().image;

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
