using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ManualInput : MonoBehaviour
{

    public MasterInputs playerInputs;
    PlayerAttributes rawDataReceiver;

    private void Awake()
    {
        playerInputs = new MasterInputs();
        rawDataReceiver = GetComponent<PlayerAttributes>();

    }
    private void OnEnable()
    {
        playerInputs.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Disable();
    }
    private void Update()
    {
        UserInputData();
    }

    private void UserInputData()
    {
        //checking the user input sending the raw input data to player controller
        Vector2 movementInput = playerInputs.PlayerActions.Move.ReadValue<Vector2>();

        rawDataReceiver.linearThrust = movementInput.x;
        
        if (Keyboard.current.wKey.isPressed)
        {
            rawDataReceiver.upwardThrust = true;
        }
        else
        {
            rawDataReceiver.upwardThrust = false;
        }

        // hook needs to be added here
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rawDataReceiver.shoot = true;
        }
        else if(Mouse.current.leftButton.wasReleasedThisFrame)
        {
            rawDataReceiver.shoot = false;
        }
        else
        {
            rawDataReceiver.shoot = false;
        }
    }
}
