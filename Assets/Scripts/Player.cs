using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4; 
    float vertical;

    public GameObject bullet;
    public Transform shootingPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        bool ShootBullet = Input.GetKeyDown(KeyCode.Space);
        if(ShootBullet && bullet && shootingPoint)
        {
            Instantiate(bullet, shootingPoint.position, Quaternion.identity);
        }    
    }
    void movePlayer()
    {
        vertical = Input.GetAxis("Horizontal");

        float moveStepX = vertical * moveSpeed * Time.deltaTime;

        if ((transform.position.x <= -3.53f && vertical < 0) || (transform.position.x >= 6.7f && vertical > 0))
            return;

        transform.position += new Vector3(moveStepX, 0, 0);
    }
   
}
