using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DecideBudget : MonoBehaviour
{
    [SerializeField]
    private Image Stamp;

    public static bool AlreadyStamp = false;


    public void OnClick()
    {
        if(AlreadyStamp == false && BudgetManageState.AmountOfBudget <= FlagTerminal.AmountOfMoney && FlagTerminal.isProcessing == false)
        {
            FlagTerminal.AmountOfMoney -= BudgetManageState.AmountOfBudget;
            AlreadyStamp = true;
            Stamp.enabled = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
