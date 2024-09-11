using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float chargeSpeed = 10f;
    public float chargeTime = 0f;
    public float baseBulletSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Fire1"))
        {
            BulletComponent bulletComp = bulletPrefab.GetComponent<BulletComponent>();
            bulletComp.bulletSpeed = chargeTime * baseBulletSpeed;

            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            chargeTime = 0f;
        }

        if(Input.GetButton("Fire1")) {
            chargeTime += Time.deltaTime * chargeSpeed;
            chargeTime = Mathf.Clamp(chargeTime, 0, 3);
        }
    }
}
