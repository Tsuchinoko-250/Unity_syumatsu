using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BudgetManageState : MonoBehaviour
{
    [SerializeField]
    private Text budgetstate;

    [SerializeField]
    private Image[] Check;

    private int changenum = 1;

    public static int AmountOfBudget = 0;
    public static int NowBudgetCheck = 0;
    public static bool IsBudgetChanging = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsBudgetChanging == false)
        {
            switch (NowBudgetCheck)
            {
                case 0:
                    Check[0].enabled = false;
                    Check[1].enabled = false;
                    Check[2].enabled = false;
                    StartCoroutine(BudgetShift(0));
                    break;
                case 1:
                    Check[0].enabled = true;
                    Check[1].enabled = false;
                    Check[2].enabled = false;
                    StartCoroutine(BudgetShift(FlagTerminal.OrphanBaseBudget[0]));
                    break;
                case 2:
                    Check[0].enabled = true;
                    Check[1].enabled = true;
                    Check[2].enabled = false;
                    StartCoroutine(BudgetShift(FlagTerminal.OrphanBaseBudget[0] + FlagTerminal.OrphanBaseBudget[1]));
                    break;
                case 3:
                    Check[0].enabled = true;
                    Check[1].enabled = true;
                    Check[2].enabled = true;
                    StartCoroutine(BudgetShift(FlagTerminal.OrphanBaseBudget[0] + FlagTerminal.OrphanBaseBudget[1] + FlagTerminal.OrphanBaseBudget[2]));
                    break;
                default:
                    budgetstate.text = 0.ToString();
                    break;

            }
        }
        
    }

    IEnumerator BudgetShift(int DestinationBudget)
    {
        IsBudgetChanging = true;
        FlagTerminal.isProcessing = true;
        if (AmountOfBudget != DestinationBudget)
        {
            if (AmountOfBudget - DestinationBudget > 100 || AmountOfBudget - DestinationBudget < -100)
            {
                if(changenum < 200)
                {
                    changenum++;

                }
            }
            else
            {
                changenum = 1;
            }

            if (AmountOfBudget < DestinationBudget)
            {
                AmountOfBudget += changenum;
            }
            else
            {
                AmountOfBudget -= changenum;
            }
            yield return new WaitForSeconds(0.01f);
            budgetstate.text = AmountOfBudget.ToString();
            StartCoroutine(BudgetShift(DestinationBudget));
        }
        else
        {
            IsBudgetChanging = false;
            FlagTerminal.isProcessing = false;

        }

    }
}
