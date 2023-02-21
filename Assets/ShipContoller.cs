using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipContoller : MonoBehaviour
{
    public Rigidbody2D rg;

    public float PushForce = 10f;
    public float RotSpeed = 10f;

    public void ShipMove(float pushF, float Rot)
    {
        this.rg.AddForce(this.transform.up * pushF * PushForce);
        this.rg.AddTorque(Rot* RotSpeed);
    }
}
