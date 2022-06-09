using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChaser : MonoBehaviour
{

    private Vector3 BubblePosition;

    [SerializeField]
    private Vector3 OriginalPos;

   
    public void GoHomeBubble()
    {
        gameObject.transform.position = OriginalPos;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        BubblePosition.x = Input.mousePosition.x;

        BubblePosition.y = Input.mousePosition.y;

        gameObject.transform.position = BubblePosition;


    }
}
