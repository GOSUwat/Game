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



    private void OnCollisionEnter2D(Collision2D collision)
    {
        try
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
        catch (System.Exception)
        {

        }
        
    }

    private void OnGUI()
    {
            GUI.Label(new Rect(500, 15, 75, 75), "Осталось времени усиления: " + buffDur.ToString());
            GUI.Label(new Rect(700, 15, 75, 75), "На вас усиление! " + buffName);
    }

    private void Update()
    {
        if(buffDur > 0)
        {
            buffDur -= Time.deltaTime;
            Change(buffDur);
        }

        
    }

    void OnBuff()
    {
         if (buffid == 0)
         {
            _movement.movementSpeed += 2;
            buffName = "Скорость";
         }

         else if (buffid == 1)
         {
            hp.hp += 2;
            buffName = "Доп. Жизни";
         } 
         else if (buffid == 2)
        {
            ShieldBuff = Instantiate(shield, gameObject.transform.position,Quaternion.identity);
            buffName = "Супер Щит!";
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
