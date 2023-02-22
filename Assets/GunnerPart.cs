using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerPart : MonoBehaviour, IF_InteractiveObj
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
        playerController.SetGunner(shipContoller, this.transform.position);
    }
}
