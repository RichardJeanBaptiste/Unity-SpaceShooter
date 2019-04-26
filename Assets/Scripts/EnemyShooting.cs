using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject EnemyBullet;

    public float fireRate;
    void Start()
    {
        InvokeRepeating("LaunchProjectile", 1.5f, fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LaunchProjectile()
    {
        Instantiate(EnemyBullet, transform.position, transform.rotation);
    }
}
