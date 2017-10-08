using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Speed;
    public float ShootDelay;
    float Delay;

    public GameObject SomePrefab;
    public GameObject BulletStart;

    void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0.0f, Speed * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, -Speed * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.Space) && Delay >= ShootDelay)
        {
            GameObject Instance = Instantiate(SomePrefab);
            Instance.transform.position = BulletStart.transform.position;
            Delay = 0.0f;
        }
        Delay += Time.deltaTime;

        float minY = -Camera.main.orthographicSize;
        float maxY = -minY;
        float minX = minY * Camera.main.aspect;
        float maxX = -minX;

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        position.y = Mathf.Clamp(position.y, minY, maxY);

        transform.position = position;
    }
}
