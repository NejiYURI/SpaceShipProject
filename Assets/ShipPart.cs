using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPart : MonoBehaviour,IF_InteractiveObj
{
    public int InteractivePriority;

    public ShipContoller shipContoller;
    int IF_InteractiveObj.Priority
    {
        get
        {
            return InteractivePriority;
        }
        set
        {
            InteractivePriority = value;
        }
    }

    public void ObjTrigger(PlayerController playerController)
    {
        playerController.SetDriving(shipContoller, this.transform.position);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("In");
    }
}
