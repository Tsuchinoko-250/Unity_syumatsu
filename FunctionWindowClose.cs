using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FunctionWindowClose : MonoBehaviour
{
    [SerializeField]
    private GameObject FunctionWindow;

    public void OnClick()
    {
        if (FlagTerminal.isProcessing == false)
        {
            FunctionWindow.SetActive(false);
            FlagTerminal.isProcessing = false;
        }
        
    }
}
