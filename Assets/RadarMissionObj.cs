using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarMissionObj : MonoBehaviour
{
    public float RotateSpeed = 5f;

    private void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0, 0, RotateSpeed * Time.deltaTime));
    }
}
