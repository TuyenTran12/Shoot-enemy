using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameController m_controller;
    // Start is called before the first frame update
    void Start()
    {
        m_controller = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            m_controller.CountPoint();
        }
        if (collision.gameObject.tag == "DeadPoint")
        {
            m_controller.LoseGame();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            m_controller.LoseGame();
        }
    }
}
