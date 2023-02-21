using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    protected PlayerState state;

    public void SetState(PlayerState _state)
    {
        this.state = _state;
        this.state.StateStart();
    }
}
