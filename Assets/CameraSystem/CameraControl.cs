using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : CameraStateMachine
{
    /// <summary>
    /// camera on this gameobject
    /// </summary>
    private Camera m_Camera;
    public CinemachineVirtualCamera NormalCamera;
    public CinemachineVirtualCamera PlanetCamera;
    public CinemachineTargetGroup targetGroup;

    public GameObject TargetObj;
    /// <summary>
    /// The focus target
    /// </summary>
    public IF_CharacterObj Target;

    public Transform Planet;

    public LayerMask InShipLayer;
    public LayerMask OutShipLayer;

    [Tooltip("The offset position for following target")]
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    [Tooltip("The size when zoom in")]
    public float ZoomoutSize;

    [Tooltip("Camera move speed")]
    public float MoveSpeed;

    [Tooltip("Camera zoom speed")]
    public float ZoomSpeed;

    private void Awake()
    {
        this.m_Camera = gameObject.GetComponent<Camera>();
    }

    private void Start()
    {
        Target = TargetObj.GetComponent<IF_CharacterObj>();
        SetState(new Camera_Normal(this));
    }

    private void Update()
    {
        if (Target != null)
        {
            if (Target.IsInShip)
            {
                this.m_Camera.cullingMask = InShipLayer;
            }
            else
            {
                this.m_Camera.cullingMask = OutShipLayer;
            }
        }
        state.UpdateFunc();
    }

    private void FixedUpdate()
    {
        state.FixedUpdateFunc();
    }

    public void SetCameraViewField(float i_target)
    {
        this.m_Camera.orthographicSize = Mathf.Lerp(this.m_Camera.orthographicSize, i_target, ZoomSpeed * Time.deltaTime);
    }

}
