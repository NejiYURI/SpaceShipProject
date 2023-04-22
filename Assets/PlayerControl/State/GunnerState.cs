using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerState : PlayerState
{
    private GunnerPart ship;
    public GunnerState(PlayerController p_con, GunnerPart i_ship) : base(p_con)
    {
        ship = i_ship;
        p_con.rg.velocity = Vector2.zero;
        p_con.rg.simulated = false;
        p_con.transform.position = i_ship.targetPos;
        p_con.Movement = Vector2.zero;
        p_con.transform.SetParent(i_ship.transform);
        ship.shipContoller.GunnerSitIn(p_con);
    }
    public override void StateStart()
    {
        p_con.IsInShip = true;
        if (ship != null && p_con.fixedJoint != null)
        {
            //p_con.fixedJoint.connectedBody = ship.rg;
            //p_con.fixedJoint.enabled = true;
            p_con.SwitchInputMap("Shoot");
        }
    }
    public override void Interactive()
    {
        ship.shipContoller.FireWeapon(true);
    }
    public override void InteractiveCancel()
    {
        Debug.Log("Cancel");
        ship.shipContoller.FireWeapon(false);
    }

    public override void FixedUpdateFunc()
    {
        ship.shipContoller.RotateGun(-1f * p_con.Movement.x);
    }

    public override void Exit()
    {
        p_con.transform.SetParent(null);
        ship.shipContoller.GunnerSitOut();
        ship.ObjExit();
        ship = null;
        p_con.rg.simulated = true;
        p_con.IsInShip = false;
        p_con.SetState(new NormalState(p_con));
    }
}
