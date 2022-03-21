using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject particle;
    
    void Start()
    {
        GameObject particleInstance = Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(particleInstance, 1f);
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
