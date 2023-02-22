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

    /// <summary>
    /// The focus target
    /// </summary>
    public PlayerController Target;

    public Transform Planet;

    [Tooltip("The offset position for following target")]
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    [Tooltip("The size when zoom in")]
    public float ZoomoutSize;

    [Tooltip("Camera move speed")]
    public float MoveSpeed;

    [Tooltip("Camera zoom speed")]
    public float ZoomSpeed;

    [Tooltip("Camera position: the ratio between planet and player when focusing")]
    [Range(0, 100)]
    public float FocusRatio;

    [Tooltip("Camera field of view minimum")]
    [Range(1, 20)]
    public float minZoom;
    [Tooltip("Camera field of view Maximum")]
    [Range(1, 20)]
    public float MaxZoom;
    [Tooltip("Camera field of view Limit")]
    [Range(1, 50)]
    public float ZoomLimit;

    private void Awake()
    {
        this.m_Camera = gameObject.GetComponent<Camera>();
    }

    private void Start()
    {
        SetState(new Camera_Normal(this));
    }

    private void Update()
    {
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
