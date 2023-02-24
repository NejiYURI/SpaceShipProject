using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieverController : InteractiveObj
{

    public Transform AimObj;
    public float RotateSpeed;
    public float RotateLimit;

    public LayerMask Target;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(AimObj.position, AimObj.up, 5f, Target);
        if (hit.collider != null)
        {

            Debug.Log(hit.collider.gameObject.name);
        }
    }
    public override void ObjTrigger(PlayerController playerController)
    {
        if (!IsUsing)
        {
            IsUsing = true;
            playerController.SetState(new OperateState(playerController, this));
        }

    }

    public override void MovementInput(Vector2 movement)
    {
        AimObj.Rotate(new Vector3(0, 0, movement.normalized.x * -1f * RotateSpeed * Time.deltaTime));
    }

    public override void ObjExit()
    {
        IsUsing = false;
    }
}
