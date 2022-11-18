using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Projectile : MonoBehaviour
{
    public float life = 0.5f;
    // Start is called before the first frame update
    void awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }

        else if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
