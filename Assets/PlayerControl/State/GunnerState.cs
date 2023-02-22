using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerState : PlayerState
{
    private ShipContoller ship;
    public GunnerState(PlayerController p_con, ShipContoller i_ship, Vector2 pos) : base(p_con)
    {
        ship = i_ship;
        p_con.rg.velocity = Vector2.zero;
        p_con.transform.position = pos;
        p_con.Movement = Vector2.zero;
    }
    public override void StateStart()
    {
        if (ship != null && p_con.fixedJoint != null)
        {
            p_con.fixedJoint.connectedBody = ship.rg;
            p_con.fixedJoint.enabled = true;
            p_con.playerInput.SwitchCurrentActionMap("Shoot");
        }
    }
    public override void Interactive()
    {
        Debug.Log("EEE");
        ship.FireWeapon(true);
    }
    public override void InteractiveCancel()
    {
        Debug.Log("CancelFire");
        ship.FireWeapon(false);
    }

    public override void FixedUpdateFunc()
    {
        ship.RotateGun(-1f * p_con.Movement.x);
    }
}
