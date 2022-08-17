using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeftDownButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public PlayerDownController playerDownController;

    bool pointerDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pointerDown) {
            Debug.Log("button pressed...");
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        playerDownController.MoveLeft();
        pointerDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        playerDownController.Stop();
        pointerDown = false;
    }
}
