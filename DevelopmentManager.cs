using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevelopmentManager : MonoBehaviour
{
    public enum WindowState
    {
        None,
        LabF1,
        LabF2,
        OrpF1,
        OrpF2,
        OrpProfile,
        BudgetManage,
        EquipmentCreate,
        MainDeveropment,
        MenuWin,
    }


    public WindowState windowstate = WindowState.OrpF1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
