using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossKill : MonoBehaviour
{
    public int hp;

    void OnTriggerEnter2D(Collider2D collision)
    {
        hp -= 1;

        if(hp<=0)
        {
            Destroy(gameObject);
        }
    }
}
