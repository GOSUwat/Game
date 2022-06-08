using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MaxEnemies : MonoBehaviour
{
    public static int enemyMax = 100;
    public Text text;
    public Text inputText;


    private void Start()
    {
        inputText.text = enemyMax.ToString();
    }
    private void Update()
    {
        text.text = "ћаксимальное количество противников = "+ enemyMax.ToString();
        
    }

    public void EnemyChange(string enemies)
    {
        try
        {
            enemyMax = System.Int32.Parse(enemies);

        }
        catch (System.Exception)
        {

        }
        
    }
    public void ButtonPressed(int x)
    {
        SceneManager.LoadScene(x);
    }


}
