using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealingDamage : MonoBehaviour
{
    public float attackRange = 3f;
    public float distanceToPlayer;
    public GameObject prefab;

    Transform target;
    Healthbar hp;



    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        hp = GameObject.FindGameObjectWithTag("Player").GetComponent<Healthbar>();
        distanceToPlayer = Vector3.Distance(transform.position, target.position);
        if (distanceToPlayer <= attackRange)
        {
                hp.hp--;
            Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Score.enemyCount--;
        }

        

        

        

    }

}
