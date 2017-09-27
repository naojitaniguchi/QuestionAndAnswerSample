using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour {
    public string[] question_sentence;
    public string[] result_string;
    public GameObject buttonYes;
    public GameObject buttonNo;
    bool[] answer;
    int index = 0;

	// Use this for initialization
	void Start () {
        answer = new bool[question_sentence.Length];

        gameObject.GetComponent<Text>().text = question_sentence[index];
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    int getResult()
    {
        int result = 0;

        for (int i = 0;  i < question_sentence.Length ; i ++ ){
            if(answer[i])
            {
                result++;
            }
        }

        return result;
    }

    public void YesPushed()
    {
        index++;
        if (index == question_sentence.Length)
        {
            int resultIndex = getResult();
            gameObject.GetComponent<Text>().text = result_string[resultIndex];
            buttonYes.SetActive(false);
            buttonNo.SetActive(false);
        }
        else
        {
            gameObject.GetComponent<Text>().text = question_sentence[index];
            answer[index - 1] = true;
        }
    }

    public void NoPushed()
    {
        index++;
        if (index == question_sentence.Length)
        {
            int resultIndex = getResult();
            gameObject.GetComponent<Text>().text = result_string[resultIndex];

            buttonYes.SetActive(false);
            buttonNo.SetActive(false);
        }
        else
        {
            gameObject.GetComponent<Text>().text = question_sentence[index];
            answer[index - 1] = false;
        }
    }
}
