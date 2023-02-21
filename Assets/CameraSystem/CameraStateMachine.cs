using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStateMachine : MonoBehaviour
{
    protected CameraState state;

    public void SetState(CameraState _state)
    {
        this.state = _state;
        this.state.StateStart();
    }
}
