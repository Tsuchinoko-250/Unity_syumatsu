using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyRoomOpen : MonoBehaviour
{

    [SerializeField]
    private GameObject MoneyManageWindow;

    public bool AlreadyPermission = false;

    public void OnClick()
    {
        if (FlagTerminal.isProcessing == false)
        {
                MoneyManageWindow.SetActive(true);
        }
    }

    private void InitializeCheckBox()
    {

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