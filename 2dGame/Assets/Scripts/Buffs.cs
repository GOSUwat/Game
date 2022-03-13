using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffs : MonoBehaviour
{
    buffSpeed _buffSpeed;
    movement  _movement;
    Healthbar hp;
    public GameObject buffPick;
    GameObject ShieldBuff;

    private float buffid = 0;
    public static float buffDur;
    private float speed = 0;
    private string buffName;
    public GameObject shield;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Buff")
        {
            _movement = gameObject.GetComponent<movement>();
            hp = gameObject.GetComponent<Healthbar>();
           _buffSpeed = collision.gameObject.GetComponent<buffSpeed>();
            buffDur = _buffSpeed.buffDuration;
            buffid = _buffSpeed.buffID;
            speed = _movement.movementSpeed;
            OnBuff();
               
            Destroy(collision.gameObject);
        }
    }

    private void OnGUI()
    {
            GUI.Label(new Rect(500, 15, 75, 75), "Buff time Left is " + buffDur.ToString());
            GUI.Label(new Rect(700, 15, 75, 75), "Buff type is " + buffName);
    }

    private void Update()
    {
        if(buffDur > 0)
        {
            buffDur -= Time.deltaTime;
            Change(buffDur);
        }

        
    }

    //1 speed
    //2 +hp
    void OnBuff()
    {
         if (buffid == 0)
         {
            _movement.movementSpeed += 2;
            buffName = "Speed";
         }

         else if (buffid == 1)
         {
            hp.hp += 2;
            //buffDur = 0;
            buffName = "HEALTH";
         } 
         else if (buffid == 2)
        {
            ShieldBuff = Instantiate(shield, gameObject.transform.position,Quaternion.identity);
            buffName = "SUPER SHIELD";
        }

    }
    void Change(float time)
    {
        if(time <= 0)
        {
            _movement.movementSpeed = 4;
            Destroy(ShieldBuff);
            buffDur = 0;
        }
    }
    


}
