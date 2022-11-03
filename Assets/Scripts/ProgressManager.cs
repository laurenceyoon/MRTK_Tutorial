using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressManager : MonoBehaviour
{
    public float progress = 0f;

    [SerializeField]
    Text progressUI;

    public GameObject[] scoreList;
    private int index = 0;

    public void updateProgress(float value)
    {
        progress = value;
        Debug.Log(progress);
        progressUI.text = "Progress : " + progress.ToString();

        index = (int) value / 10;

        setScore();
    }
    public void addProgress(float value)
    {
        progress += value;
        Debug.Log(progress);
        progressUI.text = "Progress : " + progress.ToString();
        index = (int)(progress / 10);

        setScore();
    }

    void setScore()
    {
        Debug.Log(index.ToString() + progress.ToString());
        //print(index);
        for (int i=0; i < scoreList.Length; i++)
        {
            if (i == index)
            {
                scoreList[i].SetActive(true);
            }
            else
            {
                scoreList[i].SetActive(false);
            }
        }   
    }
}
