using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDownController : MonoBehaviour
{
    public float speed = 1f;


    Vector3 inputMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(inputMovement * Time.deltaTime * speed);
    }

    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log("onMove!");
        inputMovement = context.ReadValue<Vector2>();
    }

    public void MoveRight() {
        inputMovement = Vector3.right;
    }

    public void MoveLeft() {
        inputMovement = Vector3.left;
    }

    public void Stop() {
        inputMovement = Vector3.zero;
    }
}
