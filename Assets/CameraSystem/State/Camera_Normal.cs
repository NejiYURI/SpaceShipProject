using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Camera_Normal : CameraState
{
    public Camera_Normal(CameraControl camctr) : base(camctr)
    {

    }
    public override void StateStart()
    {
        camctr.NormalCamera.transform.rotation = camctr.PlanetCamera.transform.rotation;
        camctr.NormalCamera.Priority = 1;
        camctr.PlanetCamera.Priority = 0;
    }
    public override void UpdateFunc()
    {
        if (camctr.Target.Planet != null) camctr.SetState(new Camera_Planet(camctr));
    }

    public override void FixedUpdateFunc()
    {

    }

    public override void RotateCamera()
    {

    }
}
