using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Camera_Normal : CameraState
{
    public Camera_Normal(CameraControl camctr) : base(camctr)
    {

    }

    public override void UpdateFunc()
    {
        if (camctr.Target.Planet != null) camctr.SetState(new Camera_Planet(camctr));
    }

    public override void FixedUpdateFunc()
    {
        //camctr.transform.position = Vector3.Lerp(camctr.transform.position, camctr.Target.transform.position + camctr.offset, camctr.MoveSpeed);
        //camctr.SetCameraViewField(camctr.ZoomoutSize);
        //RotateCamera();
    }

    public override void RotateCamera()
    {
        if (camctr.Target == null) return;
        //camctr.transform.rotation = camctr.Target.transform.rotation;
        camctr.VCamera.rotation = camctr.Target.transform.rotation;
    }
}
