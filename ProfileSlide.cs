using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileSlide : MonoBehaviour
{
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
    [SerializeField]
    public slideto SlideTo;

    private int i;
    private int MaxNumberOfPeople = 2;

    public void Onclick()
    {
        FlagTerminal.isProcessing = true;
        i = TeacherRoomOpen.NowPageNumber;

        ArriveCheck();

    }

    private void ArriveCheck()
    {
        do
        {
            PageChange();

            if (FlagTerminal.LivingOrphan[i] == true)
            {
                Name.text = orphanBases[i].name;
                YearsOld.text = orphanBases[i].YearsOld.ToString();
                Gender.text = orphanBases[i].Gender.ToString();
                PageNumber.text = (i + 1).ToString();
                Comment.text = orphanBases[i].Comment;

                TeacherRoomOpen.NowPageNumber = i;

                break;
            }
            else if(TeacherRoomOpen.NowPageNumber == i)
            {
                break;
            }

        }
        while (i > -2);
    }

    private void PageChange()
    {
        if (SlideTo == slideto.back && i == 0)
        {
            i = MaxNumberOfPeople - 1;
        }
        else if (SlideTo == slideto.next && i == MaxNumberOfPeople - 1)
        {
            i = 0;
        }
        else if (SlideTo == slideto.next)
        {
            i++;
        }
        else if (SlideTo == slideto.back)
        {
            i--;
        }
    }

    public enum slideto
    {
        next,
        back,
        none,
    }
}
