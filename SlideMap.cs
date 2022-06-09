using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideMap : MonoBehaviour
{
    
    [SerializeField]
    private GameObject CurrentPoint;
    [SerializeField]
    private GameObject ArrivalPoint;


    public void OnClick()
    {
        if(FlagTerminal.isProcessing == false)
        {
            FlagTerminal.isProcessing = true;
            //Debug.Log("a");
            CurrentPoint.SetActive(false);
            ArrivalPoint.SetActive(true);
            FlagTerminal.isProcessing = false;
        }
       
    }
  
}
