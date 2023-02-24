using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObj : MonoBehaviour
{
    public int Priority;

    public bool IsUsing;
    public virtual Vector2 targetPos
    {
        get
        {
            return this.transform.position;
        }
    }

    public virtual Transform trans
    {
        get
        {
            return this.transform;
        }
    }

    public virtual void ObjTrigger(PlayerController playerController)
    {

    }

    public virtual void ObjExit()
    {

    }

    public virtual void InterActInput(bool IsPerformed)
    {
        
    }

    public virtual void MovementInput(Vector2 movement)
    {
        
    }
}
