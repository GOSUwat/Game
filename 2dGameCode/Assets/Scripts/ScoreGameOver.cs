using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreGameOver : MonoBehaviour
{
    Text endScore;
  
    void Start()
    {
        endScore = GetComponent<Text>();
        endScore.text +=" "+ Score.score.ToString(); ;
        
        StartCoroutine(ScoreSend());
        

    }
    public IEnumerator ScoreSend()
    {
        if(Web.DBscore >= Score.score)
        {

        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("Score", Score.score);
            form.AddField("Login", Web.login);

            WWW req = new WWW("siteTest.loc", form);
            yield return req;
        }

        Score.score = 0;
  
    }

   
}
