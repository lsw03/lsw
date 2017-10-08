using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;

    public float ShootDelay;
    float Delay;

    public GameObject SomePrefab;
    public GameObject BulletStart;

    void Update ()
    {
        if (Delay >= ShootDelay)
        {
            GameObject Instance = Instantiate(SomePrefab);
            Instance.transform.position = BulletStart.transform.position;
            Delay = 0.0f;
        }
        Delay += Time.deltaTime;

    }
}
