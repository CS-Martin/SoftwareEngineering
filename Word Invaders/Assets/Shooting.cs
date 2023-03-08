using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class Shooting : MonoBehaviour
{

    public Transform bulletPoint;
    public GameObject bulletPrefab;

    public float bulletForce = 10f;

    void Update() {
        for (char c = 'A'; c <= 'Z'; c++) {
            KeyCode keyCode = (KeyCode)Enum.Parse(typeof(KeyCode), c.ToString());
            if (Input.GetKeyDown(keyCode)) {
                Shoot();
            }
        }
    }

    void Shoot() {
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bullet.transform.up * bulletForce, ForceMode2D.Impulse);
    }
}
