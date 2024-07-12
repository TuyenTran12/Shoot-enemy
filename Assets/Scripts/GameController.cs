using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    public GameObject bullet;

    public GameObject Enemy;

    public float timeSwap;

    float m_SwapTime;

    int point = 0;
    public Text TxtPoint;

    public bool isEndGame;

    // Start is called before the first frame update
    void Start()
    {
        m_SwapTime = 0;
        Destroy(bullet, 3);
        isEndGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        m_SwapTime -= Time.deltaTime;
        if(m_SwapTime <= 0)
        {
            SwapTime();
            m_SwapTime = timeSwap;
        }    
    }
    public void SwapTime()
    {
        Vector2 vector2 = new Vector2(Random.Range(5.1f, -5.2f), 6);

        if(Enemy)
        {
            Instantiate(Enemy, vector2, Quaternion.identity);
        }    
    }  
    public void CountPoint()
    {
        point++;
        TxtPoint.text = "POINT: " + point.ToString();
    }    

    public void LoseGame()
    {
        Time.timeScale = 0;
        isEndGame = true;
    }    
}
