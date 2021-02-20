using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFire : MonoBehaviour
{
    public Transform firePoint;
    public Transform enemyTarget;
    [Header("Laser Bhai")]
    public bool useLaserNow = false;
    public LineRenderer laserLine;
    public GameObject laser;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        useLaserNow = false;
        firePoint = transform;
    }

    // Update is called once per frame
    void Update()
    {
        ShootLaser();
        if (useLaserNow)
        {
            ShootLaser();
        }
        else {
            if (fireCountdown <= 0f) {
                ShootLaser();
                fireCountdown = 1f / fireRate;
            }
        }
        fireCountdown -= Time.deltaTime;
    }

    void ShootLaser() {
        laserLine.SetPosition(0, firePoint.position);
        laserLine.SetPosition(1, firePoint.position+ new Vector3(0,0,10));
    }

    void LockOnTarget() {
        if (useLaserNow) {
            laserLine.SetPosition(0, firePoint.position);
            laserLine.SetPosition(1, enemyTarget.position);
        }

    }


}
