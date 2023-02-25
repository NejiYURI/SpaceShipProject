using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPart : InteractiveObj
{
    public int InteractivePriority;

    public ShipContoller shipContoller;
    public override void ObjTrigger(PlayerController playerController)
    {
        if (!IsUsing)
        {
            IsUsing = true;
            playerController.SetState(new DrivingState(playerController,this));
        }
    }

    public override void ObjExit()
    {
        IsUsing = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("In");
    }
}
