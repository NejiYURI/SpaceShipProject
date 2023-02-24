using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class GunnerPart : InteractiveObj
{

    public ShipContoller shipContoller;

    public override void ObjTrigger(PlayerController playerController)
    {
        playerController.SetGunner(shipContoller, this.transform.position);
    }
}
