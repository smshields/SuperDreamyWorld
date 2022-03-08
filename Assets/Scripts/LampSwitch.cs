using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//-https://www.youtube.com/watch?v=OAXc5iMH5n8&ab_channel=UnityAdventures 

public class LampSwitch : MonoBehaviour
{
   private bool LampSwitches;
   [SerializeField] private GameObject _gameObject;

    private void OnMouseDown()
    {
        LampSwitches = !LampSwitches;
        print("click");

        if (LampSwitches)
            TurnOffLight();
            
        else 
            TurnOnLight();
             
    }

    void TurnOffLight()
    {
        _gameObject.SetActive(false);
       

    }

    void TurnOnLight()
    {
        _gameObject.SetActive(true);
    }
}
