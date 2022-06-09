using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BudgetCheckBox : MonoBehaviour
{
    [SerializeField]
    private Image Check;

    [SerializeField]
    private int BudgetNum;

    public void OnClick()
    {
        if(DecideBudget.AlreadyStamp == false && BudgetManageState.IsBudgetChanging == false)
        {
            if (Check.enabled == false)
            {
                BudgetManageState.NowBudgetCheck = BudgetNum;
            }
            else
            {
                BudgetManageState.NowBudgetCheck = BudgetNum - 1;
            }
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
