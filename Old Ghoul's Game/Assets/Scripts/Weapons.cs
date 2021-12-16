using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 0.0F;
    private float nextFire = 0.0F;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") & Time.time > nextFire)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        nextFire = Time.time + fireRate;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
