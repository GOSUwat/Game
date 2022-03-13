using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBuff : MonoBehaviour
{
    public GameObject prefab;

    private void Update()
    {
        if (Buffs.buffDur == 0)
        {
            Destroy(gameObject);
        

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.tag == "Enemy")
        {
            // GameObject effect =  Instantiate(hitEffect, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            //Destroy(effect, 2f);
            Score.score += 10;
            Score.enemyCount--;
            GameObject corpse = Instantiate(prefab, collision.transform.position, Quaternion.identity);
            Destroy(corpse, 10f);

        }


    }
}
