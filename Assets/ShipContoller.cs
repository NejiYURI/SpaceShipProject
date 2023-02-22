using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipContoller : MonoBehaviour
{
    public Rigidbody2D rg;

    public Transform Gun;
    public Transform FirePoint;

    public GameObject Bullet;

    public float PushForce = 10f;
    public float RotSpeed = 10f;
    public float GunRotSpeed = 10f;

    public float FireFreq;
    private bool Firing;
    private Coroutine FireCoroutine;

    public void ShipMove(float pushF, float Rot)
    {
        this.rg.AddForce(this.transform.up * pushF * PushForce);
        this.rg.AddTorque(Rot * RotSpeed);
    }

    public void RotateGun(float Dir)
    {
        Gun.Rotate(new Vector3(0, 0, Dir * GunRotSpeed * Time.deltaTime));
    }

    public void FireWeapon(bool i_fire)
    {
        if (i_fire)
        {
            FireCoroutine = StartCoroutine(FireFunction());
        }
        else
        {
            if (FireCoroutine != null) StopCoroutine(FireCoroutine);
        }
    }

    IEnumerator FireFunction()
    {
        while (true)
        {
            if (!Firing)
            {
                Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
                StartCoroutine(FireCooldown());
            }
           yield return null;
        }
    }

    IEnumerator FireCooldown()
    {
        Firing = true;
        yield return new WaitForSeconds(FireFreq);
        Firing = false;
    }
}
