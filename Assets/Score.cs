using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private GameObject scoreText;

    private int pinbollscore;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
        pinbollscore = 0;
        SetScore();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SmallStarTag"))
        {
            pinbollscore += 10;
        }
        else if (other.gameObject.CompareTag("LargeStarTag"))
        {
            pinbollscore += 20;
        }
        else if (other.gameObject.CompareTag("SmallCloudTag"))
        {
            pinbollscore += 50;
        }
        else if (other.gameObject.CompareTag("LargeCloudTag"))
        {
            pinbollscore += 100;
        }
        SetScore();
    }

    private void SetScore()
    {
        this.scoreText.GetComponent<Text>().text = string.Format("Score:{0}", pinbollscore);
    }

    // Update is called once per frame
    void Update()
    {

    }
}