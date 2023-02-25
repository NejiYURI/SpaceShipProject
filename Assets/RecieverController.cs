using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieverController : InteractiveObj
{
    public Transform PlayerTargetPos;
    public Transform AimObj;
    public GameObject SearchCone;
    public float RotateSpeed;
    public float RotateLimit;

    public LayerMask Target;

    public override Vector2 targetPos => PlayerTargetPos.position;

    private void Start()
    {
        SearchCone.SetActive(IsUsing);
    }
    public override void ObjTrigger(PlayerController playerController)
    {
        if (!IsUsing)
        {
            IsUsing = true;
            playerController.SetState(new OperateState(playerController, this));
            SearchCone.SetActive(IsUsing);
        }

    }

    public override void MovementInput(Vector2 movement)
    {
        float rotM = movement.normalized.x * -1f * RotateSpeed * Time.deltaTime;
        //Debug.Log(rotM + " " + AimObj.localRotation.z);
        //if (rotM < 0 && AimObj.localRotation.z <= -1 * RotateLimit) return;
        //if (rotM > 0 && AimObj.localRotation.z >= RotateLimit) return;
        //AimObj.Rotate(new Vector3(0, 0, rotM),Space.Self);
        AimObj.GetComponent<Rigidbody2D>().AddTorque(rotM);
    }

    public override void ObjExit()
    {
        IsUsing = false;
        SearchCone.SetActive(IsUsing);
    }
}
