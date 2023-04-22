using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingState : PlayerState
{
    private ShipPart ship;
    public DrivingState(PlayerController p_con, ShipPart i_part) : base(p_con)
    {
        ship = i_part;
        p_con.rg.velocity = Vector2.zero;
        p_con.rg.simulated = false;
        p_con.transform.position = i_part.targetPos;
        p_con.transform.SetParent(i_part.trans);
        p_con.Movement = Vector2.zero;
        ship.shipContoller.DrivignSitIn(p_con);
    }
    public override void StateStart()
    {
        p_con.IsInShip = true;
        if (ship != null && p_con.fixedJoint != null)
        {
            //p_con.fixedJoint.connectedBody = ship.rg;
            //p_con.fixedJoint.enabled = true;
            p_con.SwitchInputMap("Drive");
        }
       
    }
    public override void Interactive()
    {
       // Debug.Log("Drive");
    }

    public override void FixedUpdateFunc()
    {
        float pushF = p_con.Movement.y > 0f ? 1f : 0f;
        float rot = p_con.Movement.x == 0f ? 0f : (p_con.Movement.x > 0 ? -1f : 1f);
        ship.shipContoller.ShipMove(pushF, rot);
    }

    public override void Exit()
    {
        p_con.transform.SetParent(null);
        ship.shipContoller.DrivignSitOut();
        ship.ObjExit();
        ship = null;
        p_con.rg.simulated = true;
        p_con.IsInShip = false;
        p_con.SetState(new NormalState(p_con));
    }
}
