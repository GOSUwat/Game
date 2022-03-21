using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffSpeed : MonoBehaviour
{
    public float buffDuration = 10f;
    public int buffID = 0;
    public int buffChangingTime = 1;
    private SpriteRenderer spriteRenderer;
    public Sprite[] newSprite;

    // Start is called before the first frame update
    private void Awake()
    {
    }
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        InvokeRepeating("ChangeSprite",buffChangingTime, buffChangingTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSprite()
    {
        buffID = Random.Range(0, 3);
        spriteRenderer.size += new Vector2(5, 5);
        spriteRenderer.sprite = newSprite[buffID];
        
    }
    
}
