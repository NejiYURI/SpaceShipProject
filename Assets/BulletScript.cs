using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed;
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        this.rb.velocity = transform.up * Speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
