using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyState : MonoBehaviour
{
    [SerializeField]
    private Text moneystate;

    private int NowMoneyState = 10000;

    private bool IsStateChanging = false;

    private int changenum = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NowMoneyState != FlagTerminal.AmountOfMoney && IsStateChanging == false)
        {
            IsStateChanging = true;
            StartCoroutine(DelayUpdate());
        }
    }

    IEnumerator DelayUpdate()
    {
        if (NowMoneyState != FlagTerminal.AmountOfMoney)
        {
            if(NowMoneyState - FlagTerminal.AmountOfMoney > 100 || NowMoneyState - FlagTerminal.AmountOfMoney < -100)
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

            if (NowMoneyState < FlagTerminal.AmountOfMoney)
            {
                NowMoneyState += changenum;
            }
            else
            {
                NowMoneyState -= changenum;
            }

            yield return new WaitForSeconds(0.01f);
            moneystate.text = NowMoneyState.ToString();
            StartCoroutine(DelayUpdate());
        }
        else
        {
            IsStateChanging = false;
        }

    }
}
