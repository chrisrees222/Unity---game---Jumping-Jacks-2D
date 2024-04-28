using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Right_Move : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool buttonPressed = false;
    public GameObject player;
        

    // Update is called once per frame
    void Update()
    {
        if(buttonPressed)
        {

        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
}
