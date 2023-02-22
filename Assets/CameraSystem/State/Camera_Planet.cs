using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Camera_Planet : CameraState
{
    public Camera_Planet(CameraControl camctr) : base(camctr)
    {

    }

    public override void StateStart()
    {
        if(camctr.Planet!=null && camctr.targetGroup.FindMember(camctr.Planet)>0) camctr.targetGroup.RemoveMember(camctr.Planet);
        camctr.targetGroup.AddMember(camctr.Target.Planet,3f,0f);
        camctr.Planet = camctr.Target.Planet;
        camctr.NormalCamera.Priority = 0;
        camctr.PlanetCamera.Priority = 1;
    }

    public override void UpdateFunc()
    {
        if (camctr.Target.Planet == null)
        {
            camctr.SetState(new Camera_Normal(camctr));
        } 
    }

    public override void FixedUpdateFunc()
    {
        Vector3 diff = camctr.Target.GetPlanetDiff();
        Vector3 _Fpos = camctr.Target.Planet.position + diff* (camctr.FocusRatio/100f);
        _Fpos.z = camctr.offset.z;
        _Fpos += diff / 8f;
        float _dis = Vector2.Distance(_Fpos, camctr.Target.transform.position);
        float newZoom = Mathf.Lerp(camctr.minZoom, camctr.MaxZoom, _dis / camctr.ZoomLimit);
        camctr.SetCameraViewField(newZoom);
        //this.m_Camera.fieldOfView = Mathf.Lerp(m_Camera.fieldOfView, newZoom, Time.deltaTime * ZoomSpeed);
        camctr.transform.position = Vector3.Lerp(camctr.transform.position, _Fpos, camctr.MoveSpeed);
        RotateCamera();
    }
}
