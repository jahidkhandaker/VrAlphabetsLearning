using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject HomePage;
    
    public GameObject BtnLearning;
    public GameObject BtnQuiz;
    public GameObject BtnReset;
    public GameObject BtnQuizStart;
    
    public GameObject Alphabet;
    public GameObject QuizAlphabet;

    Player player;

    float gazeTime = 2f;
    float timer;
    bool gazedAt = false;
    bool doCall = false;

    void Start()
    {
        Alphabet.SetActive(false);
        QuizAlphabet.SetActive(false);
        BtnReset.SetActive(false);
        BtnQuizStart.SetActive(false);
               
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
           
            if (hit.transform.gameObject.tag == "LearningBtn")
            {
                    Debug.Log("Wow...................... Xoss");
                Alphabet.SetActive(true);

            }

           

        }

        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                doCall = true;
                timer = 0f;
                gazedAt = false;
            }
        }

    }

    public void LearningBtn()
    {
        gazedAt = true;
        if (doCall) 
        {
            HomePage.SetActive(false);
            BtnReset.SetActive(true);
            Alphabet.SetActive(true);
        }  
    }

    public void QuizBtn()
    {
        gazedAt = true;
        if (doCall)
        {
            HomePage.SetActive(false);
            BtnReset.SetActive(true);
            BtnQuizStart.SetActive(true);
            QuizAlphabet.SetActive(true);
        }
   
    }

    public void ResetBtn()
    {
        /* BtnLearning.SetActive(true);
         BtnQuiz.SetActive(true);
         BtnReset.SetActive(false);
         BtnQuizStart.SetActive(false);

         Alphabet.SetActive(false);
         QuizAlphabet.SetActive(false);*/

        gazedAt = true;
       if(doCall)
        SceneManager.LoadScene("TestScene");
        
    }

}
