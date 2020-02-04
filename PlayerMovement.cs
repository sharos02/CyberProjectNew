using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float x;
    private float y;
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.position += (Vector3)new Vector2(x * speed * Time.deltaTime, 0);
        transform.position += (Vector3)new Vector2(0, y * speed * Time.deltaTime);
    }

}
