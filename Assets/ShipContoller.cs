using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipContoller : MonoBehaviour, IF_CharacterObj
{
    public Transform Planet;
    Transform IF_CharacterObj.Planet
    {
        get
        {
            return Planet;
        }
    }
    bool IF_CharacterObj.IsInShip
    {
        get
        {
            return false;
        }
    }
    public Rigidbody2D rg;
    public GameObject Fire;

    public Transform Gun;
    public Transform FirePoint;

    public GameObject Bullet;

    public float PushForce = 10f;
    public float SpeedLimit = 2000f;
    public float RotSpeed = 10f;
    public float GunRotSpeed = 10f;

    public float FireFreq;
    private bool Firing;
    private Coroutine FireCoroutine;

    private PlayerController DriverSit_P;
    private PlayerController GunnerSit_P;

    public Camera ShipCamera;
    private void Start()
    {
        if (GameEventManager.instance) GameEventManager.instance.GameClear.AddListener(GameOver);
    }

    private void Update()
    {
        SetPlayerPlanet();
        if (DriverSit_P != null && GunnerSit_P != null)
        {
            ShipCamera.depth = 1;
        }
        else
        {
            ShipCamera.depth = -2;
        }
        if (DriverSit_P == null && GunnerSit_P == null)
        {
            if (Planet)
            {
                RotateShip(Planet.position);
            }
        }
    }

    void GameOver()
    {
        rg.bodyType = RigidbodyType2D.Static;
    }

    public void DrivignSitIn(PlayerController player)
    {
        DriverSit_P = player;
    }

    public void DrivignSitOut()
    {
        DriverSit_P = null;
    }

    public void GunnerSitIn(PlayerController player)
    {
        GunnerSit_P = player;
    }

    public void GunnerSitOut()
    {
        GunnerSit_P = null;
    }

    public void SetPlayerPlanet()
    {
        if (DriverSit_P != null) DriverSit_P.Planet = this.Planet;
        if (GunnerSit_P != null) GunnerSit_P.Planet = this.Planet;
    }

    public void ShipMove(float pushF, float Rot)
    {
        Fire.SetActive(pushF != 0);
        this.rg.AddForce(this.transform.up * pushF * PushForce);
        //this.rg.AddTorque(Rot * RotSpeed);
        this.rg.rotation += Rot * RotSpeed * Time.deltaTime;
        if (this.rg.velocity.magnitude > SpeedLimit)
        {
            this.rg.velocity = this.rg.velocity.normalized * SpeedLimit;
        }
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

    public Vector3 GetPlanetDiff()
    {
        return transform.position - Planet.position;
    }
    public Vector2 ObjPosition()
    {
        return this.transform.position;
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

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("PlanetGravity"))
        {
            Debug.Log("In Planet");
            this.Planet = col.transform.parent;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag.Equals("PlanetGravity") && col.transform.parent == this.Planet)
        {
            Debug.Log("out Planet");
            this.Planet = null;
        }
    }

    void RotateShip(Vector2 _target)
    {
        Vector2 _dir = (Vector2)transform.position - _target;
        int sign = (_dir.x >= 0) ? -1 : 1;
        int offset = (sign >= 0) ? 0 : 360;
        float angle = Vector2.Angle(_dir.normalized, Vector2.up) * sign + offset;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, angle), Time.deltaTime * 30f);
    }
}
