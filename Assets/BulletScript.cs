using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed;
    public float LifeTime=5f;
    public LayerMask TargetLayer;
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        this.rb.velocity = transform.up * Speed;
        Destroy(gameObject, LifeTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if ((TargetLayer.value & 1 << col.gameObject.layer) == 1 << col.gameObject.layer)
        {
            if (col.GetComponent<EnemyScript>() != null)
            {
                col.GetComponent<EnemyScript>().GetDamage(1);
            }
            Destroy(gameObject);
        }
        
    }
}
