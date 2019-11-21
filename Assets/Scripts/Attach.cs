using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour
{

    public Bullet bullet;
    public Transform player;

    public float speed = 3;
    public float bulletXSpeed = 0;
    public float bulletYSpeed = 0;
    public float time = 1;
    public Vector3 bulletVector = new Vector3(0, 0, 0);

    private bool isShooting = false;

    void Start()
    {
        bulletYSpeed = speed;
    }

    void Update()
    {
        updateFaceDirection();

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!isShooting)
                StartCoroutine(shoot());
        }
    }

    IEnumerator shoot()
    {
        isShooting = true;
        Vector3 initPosition = getPlayerPosition();
        Bullet p = Instantiate(bullet, initPosition, Quaternion.identity);
        p.velocity = new Vector3(bulletXSpeed, bulletYSpeed, 0);
        yield return new WaitForSeconds(time);
        isShooting = false;
    }

    private void updateFaceDirection() {
        if (Input.GetKey(KeyCode.RightArrow)) 
            setBulletSpeed(speed, 0);

        if (Input.GetKey(KeyCode.LeftArrow)) 
            setBulletSpeed(-speed, 0);

        if (Input.GetKey(KeyCode.UpArrow)) 
            setBulletSpeed(0, speed);
        
        if (Input.GetKey(KeyCode.DownArrow)) 
            setBulletSpeed(0, -speed);

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow)) 
            setBulletSpeed(speed, speed);

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)) 
            setBulletSpeed(speed, -speed);

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow)) 
            setBulletSpeed(-speed, speed);

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow)) 
            setBulletSpeed(-speed, -speed);

    }


    private void setBulletSpeed(float x, float y) {
        bulletXSpeed = x;
        bulletYSpeed = y;
    }

    private Vector3 getPlayerPosition() {
        return player.transform.position;
    }
}
