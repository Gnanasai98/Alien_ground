using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ManualInput : MonoBehaviour
{

    public MasterInputs playerInputs;
    PlayerController player;

    private void Awake()
    {
        playerInputs = new MasterInputs();
        player = GetComponent<PlayerController>();

    }
    //private void OnEnable()
    //{
    //    playerInputs.Enable();
    //}

    //private void OnDisable()
    //{
    //    playerInputs.Disable();
    //}
    private void Update()
    {
        UserInputData();
    }

    private void UserInputData()
    {
        //checking the user input sending the raw input data to player controller
        if (Keyboard.current.aKey.isPressed)
        {
            player.leftThrust = true;
        }
        else
        {
            player.leftThrust = false;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            player.rightThrust = true;
        }
        else
        {
            player.rightThrust = false;
        }
        if (Keyboard.current.wKey.isPressed)
        {
            player.upwardThrust = true;
        }
        else
        {
            player.upwardThrust = false;
        }
        // hook needs to be added here
    }
}
