using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IF_InteractiveObj
{
    int Priority { get; set; }
    Vector2 targetPos { get; }
    Transform trans { get; }

    void ObjTrigger(PlayerController playerController);

    void InterActInput(bool IsPerformed);

    void MovementInput(Vector2 movement);

}
