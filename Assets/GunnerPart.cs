using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class GunnerPart : InteractiveObj
{

    public ShipContoller shipContoller;

    public override void ObjTrigger(PlayerController playerController)
    {
        if (!IsUsing)
        {
            IsUsing = true;
            playerController.SetState(new GunnerState(playerController, this));
        }
    }

    public override void ObjExit()
    {
        IsUsing = false;
    }
}
