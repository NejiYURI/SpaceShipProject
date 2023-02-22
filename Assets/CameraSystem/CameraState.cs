using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraState
{
    protected CameraControl camctr;
    public CameraState(CameraControl i_camctr)
    {
        this.camctr = i_camctr;
    }

    public virtual void StateStart()
    {
        
    }

    public virtual void FixedUpdateFunc()
    {

    }

    public virtual void UpdateFunc()
    {

    }

    public virtual void RotateCamera()
    {
        Vector2 _dir = (Vector2)camctr.PlanetCamera.transform.position - (Vector2)camctr.Target.Planet.position ;
        int sign = (_dir.x >= 0) ? -1 : 1;
        int offset = (sign >= 0) ? 0 : 360;
        float angle = Vector2.Angle(_dir.normalized, Vector2.up) * sign + offset;
        //camctr.transform.LeanRotateZ(angle, 0.1f);
        camctr.PlanetCamera.transform.LeanRotateZ(angle, 0.1f);
    }
}
