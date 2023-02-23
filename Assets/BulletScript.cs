using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed;
    public float LifeTime=5f;
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        this.rb.velocity = transform.up * Speed;
        Destroy(gameObject, LifeTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<EnemyScript>()!=null)
        {
            col.GetComponent<EnemyScript>().GetDamage(1);
        }
    }
}
