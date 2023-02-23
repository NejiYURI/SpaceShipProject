using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IF_CharacterObj
{
    Transform Planet { get; }
    bool IsInShip { get; }

    Vector3 GetPlanetDiff();

    Vector2 ObjPosition();
}
