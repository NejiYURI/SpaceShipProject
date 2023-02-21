using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IF_InteractiveObj
{
    int Priority { get; set; }

    void ObjTrigger(PlayerController playerController);

}
