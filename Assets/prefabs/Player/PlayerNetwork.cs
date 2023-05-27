using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNetwork : NetworkBehaviour
{
    private InputActions inputActions;
    bool rmbHolding = false;
    bool lmbHolding = false;

    private void Awake()
    {
        inputActions = new InputActions();
    }


    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Start()
    {
        inputActions.Gameplay.HoldToMoveCam.performed += HoldToMoveCam;
        inputActions.Gameplay.HoldToMoveCam.canceled += HoldToMoveCam;
        
        inputActions.Gameplay.HoldToShoot.performed += HoldToShoot;
        inputActions.Gameplay.HoldToShoot.canceled += HoldToShoot;

        inputActions.Gameplay.CamMovementShootPower.performed += MoveMouse;
    }

    private void MoveMouse(InputAction.CallbackContext context)
    {
        if (rmbHolding)
        {//camera movement handled here

        }
        if(lmbHolding)
        {//shooting mechanics go here
         //The next 3 can be done in the HoldToShoot Function
         //Check to see if where the mouse is clicked is within a certain distance of the ball
         //if not then don't do anything (lmbHolding = false)
         //if it is then as the mouse is being moved back (mouse position y is negative)
         // then increase the power that will be applied to the ball
         //if that power is too close to 0 and the shoot is released, then do nothing

        }
    }

    private void HoldToShoot(InputAction.CallbackContext ctx)
    {
        lmbHolding = ctx.ReadValueAsButton();
        Debug.Log(lmbHolding);
    }

    private void HoldToMoveCam(InputAction.CallbackContext ctx)
    {
        rmbHolding = ctx.ReadValueAsButton();
        Debug.Log(rmbHolding);
    }


}
