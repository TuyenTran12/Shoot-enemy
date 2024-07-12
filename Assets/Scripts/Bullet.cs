using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;

    public float timeToDestroy;

    Rigidbody2D m_rb;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        m_rb.velocity = Vector2.up * speed;
    }
    
}
