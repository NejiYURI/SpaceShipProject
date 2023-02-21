using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState
{
    protected PlayerController p_con;
    public PlayerState(PlayerController i_playerController)
    {
        this.p_con = i_playerController;
    }
    public virtual void StateStart()
    {

    }

    public virtual void StateEnd()
    {

    }

    public virtual void UpdateFunc()
    {
        
    }

    public virtual void FixedUpdateFunc()
    {

    }

    public virtual void Jump()
    {
        
    }

    public virtual void Interactive()
    {

    }
}
