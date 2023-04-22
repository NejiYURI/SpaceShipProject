using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OperateState : PlayerState
{
    InteractiveObj OperateObj;
    public OperateState(PlayerController p_con, InteractiveObj obj) : base(p_con)
    {
        this.OperateObj = obj;
        p_con.rg.velocity = Vector2.zero;
        p_con.rg.simulated = false;
        p_con.transform.position = obj.targetPos;
        p_con.transform.SetParent(obj.trans);
        p_con.Movement = Vector2.zero;
    }
    public override void StateStart()
    {
        p_con.SwitchInputMap("Operating");
    }
    public override void Interactive()
    {
       // Debug.Log("Drive");
    }

    public override void FixedUpdateFunc()
    {
        OperateObj.MovementInput(p_con.Movement);
    }

    public override void Exit()
    {
        p_con.transform.SetParent(null);
        OperateObj.ObjExit();
        OperateObj = null;
        p_con.rg.simulated = true;
        p_con.SetState(new NormalState(p_con));
    }
}
