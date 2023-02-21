using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Camera_Planet : CameraState
{
    private Transform Planet_Tmp;
    public Camera_Planet(CameraControl camctr) : base(camctr)
    {

    }

    public override void StateStart()
    {
        camctr.targetGroup.AddMember(camctr.Target.Planet,3f,0f);
        Planet_Tmp = camctr.Target.Planet;
    }

    public override void UpdateFunc()
    {
        if (camctr.Target.Planet == null)
        {
            camctr.targetGroup.RemoveMember(Planet_Tmp);
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
