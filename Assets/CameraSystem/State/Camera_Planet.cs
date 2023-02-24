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
        RotateCamera();
    }
}
