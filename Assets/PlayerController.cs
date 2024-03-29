using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : PlayerStateMachine, IF_CharacterObj
{
    public Transform Planet;
    Transform IF_CharacterObj.Planet
    {
        get
        {
            return Planet;
        }

    }
    public bool IsInShip;
    bool IF_CharacterObj.IsInShip
    {
        get
        {
            return IsInShip;
        }
    }

    public Vector2 Movement;
    [HideInInspector]
    public Rigidbody2D rg;
    public float speed = 10f;
    public float jumpForce = 100f;

    [HideInInspector]
    public FixedJoint2D fixedJoint;
    private Dictionary<GameObject, InteractiveObj> interactiveObjs;
    public PlayerInput playerInput;

    private bool IsJoycon;
    private void Start()
    {
        fixedJoint = GetComponent<FixedJoint2D>();
        interactiveObjs = new Dictionary<GameObject, InteractiveObj>();
        this.rg = GetComponent<Rigidbody2D>();
        if (GameEventManager.instance) GameEventManager.instance.GameClear.AddListener(GameOver);
        if (GameSettingScript.instance) IsJoycon = GameSettingScript.instance.IsJoycon;
        playerInput.enabled = !IsJoycon;
        SetState(new NormalState(this));
    }


    public void OnMoveInput(InputAction.CallbackContext context)
    {
        Movement = context.ReadValue<Vector2>();
    }

    public void OnMoveInput(Vector2 _input)
    {
        Movement = _input;
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {
        //state.Jump();
    }

    public void OnInteractionInput(InputAction.CallbackContext context)
    {
        if (context.performed)
            state.Interactive();
        else if (context.canceled)
            state.InteractiveCancel();
    }
    public void OnInteractionInput(bool IsPress)
    {
        Debug.Log(IsPress);
        if (IsPress)
            state.Interactive();
        else
            state.InteractiveCancel();
    }

    public void OnExitInput(InputAction.CallbackContext context)
    {
        if (context.performed)
            state.Exit();
    }

    public void OnExitInput()
    {
        state.Exit();
    }


    private void FixedUpdate()
    {
        state.FixedUpdateFunc();
    }

    public InteractiveObj GetFirstInteractiveObj()
    {
        InteractiveObj rslt = null;
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

    public void SetGunner(ShipContoller ship, Vector2 i_pos)
    {

    }

    public Vector3 GetPlanetDiff()
    {
        return transform.position - Planet.position;
    }
    public Vector2 ObjPosition()
    {
        return this.transform.position;
    }


    void GameOver()
    {
        playerInput.enabled = false;
    }

    public void SwitchInputMap(string MapName)
    {
        if (!IsJoycon)
            playerInput.SwitchCurrentActionMap(MapName);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<InteractiveObj>() != null && !interactiveObjs.ContainsKey(col.gameObject))
        {
            //Debug.Log(this.name + " in " + col.name);
            interactiveObjs.Add(col.gameObject, col.GetComponent<InteractiveObj>());
        }
        if (col.tag.Equals("PlanetGravity"))
        {
            this.Planet = col.transform.parent;
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.GetComponent<InteractiveObj>() != null && interactiveObjs.ContainsKey(col.gameObject))
        {
            interactiveObjs.Remove(col.gameObject);
        }
        if (col.tag.Equals("PlanetGravity") && col.transform.parent == this.Planet)
        {
            this.Planet = null;
        }
    }
}
