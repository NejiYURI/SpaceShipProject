using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : PlayerStateMachine
{
    public Transform Planet;

    public Vector2 Movement;
    [HideInInspector]
    public Rigidbody2D rg;
    public float speed = 10f;
    public float jumpForce = 100f;

    [HideInInspector]
    public FixedJoint2D fixedJoint;
    private Dictionary<GameObject, IF_InteractiveObj> interactiveObjs;
    public PlayerInput playerInput;
    private void Start()
    {
        fixedJoint = GetComponent<FixedJoint2D>();
        interactiveObjs = new Dictionary<GameObject, IF_InteractiveObj>();
        this.rg = GetComponent<Rigidbody2D>();
        SetState(new NormalState(this));
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        Movement = context.ReadValue<Vector2>();
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {
        state.Jump();
    }

    public void OnInteractionInput(InputAction.CallbackContext context)
    {
        state.Interactive();
    }


    private void FixedUpdate()
    {
        state.FixedUpdateFunc();
    }

    public IF_InteractiveObj GetFirstInteractiveObj()
    {
        IF_InteractiveObj rslt = null;
        int p_value = -1;
        foreach (var item in interactiveObjs)
        {
            if (item.Value.Priority > p_value)
            {
                rslt = item.Value;
                p_value = item.Value.Priority;
            }
        }
        return rslt;
    }

    public void SetDriving(ShipContoller ship,Vector2 i_pos)
    {
        SetState(new DrivingState(this,ship, i_pos));
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<IF_InteractiveObj>() != null && !interactiveObjs.ContainsKey(col.gameObject))
        {
            Debug.Log(this.name + " in " + col.name);
            interactiveObjs.Add(col.gameObject, col.GetComponent<IF_InteractiveObj>());
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.GetComponent<IF_InteractiveObj>() != null && interactiveObjs.ContainsKey(col.gameObject))
        {
            Debug.Log(this.name + " out " + col.name);
            interactiveObjs.Remove(col.gameObject);
        }
    }
}
