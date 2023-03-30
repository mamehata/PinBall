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
        SetScore(0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SmallStarTag"))
        {
            SetScore(10);
        }
        else if (other.gameObject.CompareTag("LargeStarTag"))
        {
            SetScore(20);
        }
        else if (other.gameObject.CompareTag("SmallCloudTag"))
        {
            SetScore(50);
        }
        else if (other.gameObject.CompareTag("LargeCloudTag"))
        {
            SetScore(100);
        }  
    }

    private void SetScore(int num)
    {
        pinbollscore += num;
        this.scoreText.GetComponent<Text>().text = string.Format("Score:{0}", pinbollscore);
    }

    // Update is called once per frame
    void Update()
    {

    }
}