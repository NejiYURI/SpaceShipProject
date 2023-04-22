using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalState : PlayerState
{
    public NormalState(PlayerController p_con) : base(p_con)
    {

    }
    public override void StateStart()
    {
        p_con.SwitchInputMap("Normal");
        p_con.fixedJoint.enabled = false;
    }

    public override void FixedUpdateFunc()
    {
        p_con.rg.AddForce(p_con.transform.right* p_con.Movement.x * p_con.speed);
        if (p_con.Planet != null)
        {
           RotateCharacter(p_con.Planet.position);
        }
    }

    void RotateCharacter(Vector2 _target)
    {
        Vector2 _dir = (Vector2)p_con.transform.position - _target;
        int sign = (_dir.x >= 0) ? -1 : 1;
        int offset = (sign >= 0) ? 0 : 360;
        float angle = Vector2.Angle(_dir.normalized, Vector2.up) * sign + offset;
        p_con.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    public override void Jump()
    {
        p_con.rg.AddForce(p_con.transform.up* p_con.jumpForce);
    }
    public override void Interactive()
    {
        InteractiveObj getObj = p_con.GetFirstInteractiveObj();
        if (getObj != null)
        {
            getObj.ObjTrigger(p_con);
        }
    }
}
