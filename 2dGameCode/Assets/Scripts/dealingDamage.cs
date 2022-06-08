using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealingDamage : MonoBehaviour
{
    public GameObject prefab;
    Healthbar hp;


    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if(collision.gameObject.tag == "Player")
        {
            hp = GameObject.FindGameObjectWithTag("Player").GetComponent<Healthbar>();
            hp.hp--;
            Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Score.enemyCount--;
        }
        
    }

}
