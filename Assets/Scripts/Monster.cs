using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        speed = 6;
    }
    private void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
        transform.localScale = new Vector3(speed > 0 ? 1 : -1f, 1f, 1f);
    }
}
