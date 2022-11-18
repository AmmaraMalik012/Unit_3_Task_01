using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch_Bullet_Projectile : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectile;
    public float launchVelocity = 10f;
 
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            var _projectile = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
            _projectile.GetComponent<Rigidbody>().velocity = launchPoint.up * launchVelocity;
        }
    }
}
