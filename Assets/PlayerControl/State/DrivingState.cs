using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingState : PlayerState
{
    private ShipContoller ship;
    public DrivingState(PlayerController p_con, ShipContoller i_ship, Vector2 pos) : base(p_con)
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
            p_con.playerInput.SwitchCurrentActionMap("Drive");
        }
    }
    public override void Interactive()
    {
        Debug.Log("Drive");
    }

    public override void FixedUpdateFunc()
    {
        float pushF = p_con.Movement.y > 0f ? 1f : 0f;
        float rot = p_con.Movement.x == 0f ? 0f : (p_con.Movement.x > 0 ? -1f : 1f);
        ship.ShipMove(pushF, rot);
    }
}
