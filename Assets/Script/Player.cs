using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Player : MonoBehaviour
{
    float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    bool isSection = false;
    bool isQuiz = true;
    bool isProcessing = true;
    

    public GameObject[] QuizAlphabets;
    public GameObject[] AudioAlpha;

    public AudioSource[] Signal; 

    List<int> alphaList = new List<int>();
    
    int rnd = 7;
    int sig;

    public void SetSection(bool b)
    {
        isQuiz = b;
        isSection = b;
    } 
    public void SetStartBtn(GameObject startBtn)
    {
        startBtn.SetActive(false);
       
    }
    void Update()
    {
   
        if (isSection)
        {
            if (isQuiz)
            {
                if (alphaList.Count < AudioAlpha.Length - 1)
                {
                    rnd = Random.Range(0, AudioAlpha.Length);

                    if (!alphaList.Contains(rnd))
                    {
                        AudioAlpha[rnd].SetActive(true);
                        alphaList.Add(rnd);                      
                        isQuiz = false;
                    }


                }
                else { Debug.Log("Quiz Complete:" + alphaList.Count); }
            }
        }

        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
        }
        if (gvrTimer >= totalTime)
        {
            gvrTimer = 0;
            gvrStatus = false;
            Signal[sig].Play();
            if (sig == 1)
                isQuiz = true;

            isProcessing = true;
        }
    }

    public void WrongSound(GameObject Alpha)
    {
        if (isProcessing)
        {
            gvrStatus = true;
            isProcessing = false;
            if (Alpha != QuizAlphabets[rnd])
            {
                sig = 0;
            }
            else
            {
                sig = 1;
            }
        }    
          
    }
  
   


}
