using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;

    void Update ()
    {
        float maxY = Camera.main.orthographicSize;

        transform.Translate(0.0f, Speed * Time.deltaTime, 0.0f);

        if(maxY <= transform.position.y)
        {
            Destroy(gameObject);
        }
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
