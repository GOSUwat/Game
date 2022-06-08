using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnim : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.tag == "Bullet")
        {
            Instantiate(hitEffect, transform.position, transform.rotation);
            Destroy(hitEffect, 3f);

        }
    }
}
