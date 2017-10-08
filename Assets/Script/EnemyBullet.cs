using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float Speed;

	void Update ()
    {
        transform.Translate(0.0f, -Speed * Time.deltaTime, 0.0f);
    }
}
