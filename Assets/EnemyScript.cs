using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public string MissionId;

    public int Health = 2;

    private void Start()
    {
        
    }
    public void Death()
    {
        if (GameEventManager.instance != null) GameEventManager.instance.MissionTrigger.Invoke(this.MissionId);
        Destroy(gameObject);
    }

    public void GetDamage(int i_damage)
    {
        Health-=i_damage;
        if (Health <= 0) Death();
    }
}
