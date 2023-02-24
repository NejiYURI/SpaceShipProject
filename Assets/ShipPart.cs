using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPart : InteractiveObj
{
    public int InteractivePriority;

    public ShipContoller shipContoller;
    public override void ObjTrigger(PlayerController playerController)
    {
        playerController.SetDriving(shipContoller, this.transform.position);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("In");
    }
}
