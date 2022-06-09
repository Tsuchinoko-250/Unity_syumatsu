using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeacherRoomOpen : MonoBehaviour
{

    [SerializeField]
    private GameObject ProfileWindow;
    [SerializeField]
    OrphanBase[] orphanBases;

    [SerializeField]
    private Text Name;
    [SerializeField]
    private Text YearsOld;
    [SerializeField]
    private Text Gender;
    [SerializeField]
    private Text Comment;
    [SerializeField]
    private Text PageNumber;

    public static int NowPageNumber;
    private int MaxNumberOfPeople = 10;

    //private GameObject windowstateObject;
    //private DevelopmentManager NowWindowState;


    public void OnClick()
    {
        //windowstateObject = GameObject.Find("DevelopmentManager");
        //NowWindowState = windowstateObject.GetComponent<DevelopmentManager>();

        if (FlagTerminal.isProcessing == false /*&& NowWindowState.windowstate == DevelopmentManager.WindowState.OrpF1*/)
        {
            //NowWindowState.windowstate = DevelopmentManager.WindowState.OrpProfile;
            FlagTerminal.isProcessing = true;
            ArriveChack();
            ProfileWindow.SetActive(true);
        }
    }

    private void ArriveChack()
    {
        FlagTerminal.isProcessing = true;
        for (NowPageNumber = 0; NowPageNumber <= MaxNumberOfPeople - 1; NowPageNumber++)
        {
            if (FlagTerminal.LivingOrphan[NowPageNumber] == true)
            {
                Name.text = orphanBases[NowPageNumber].name;
                YearsOld.text = orphanBases[NowPageNumber].YearsOld.ToString();
                Gender.text = orphanBases[NowPageNumber].Gender.ToString();
                PageNumber.text = (NowPageNumber + 1).ToString();
                Comment.text = orphanBases[NowPageNumber].Comment;

                FlagTerminal.isProcessing = false;
                break;
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
