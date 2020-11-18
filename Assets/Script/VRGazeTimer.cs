using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRGazeTimer : MonoBehaviour
{
    // Game Manager Start
    
     public GameObject HomePage;
    
    public GameObject BtnLearning;
    public GameObject BtnQuiz;
    public GameObject BtnReset;
    public GameObject BtnQuizStart;
    
    public GameObject Alphabet;
    public GameObject QuizAlphabet;
    int btnNo;
    // Game Manager End

    public Image imageGaze;
    float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    // Start is called before the first frame update
    void Start()
    {

        btnNo = 0;
        Alphabet.SetActive(false);
        QuizAlphabet.SetActive(false);
        BtnReset.SetActive(false);
        BtnQuizStart.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imageGaze.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer >= totalTime)
        {
            GVROff();
            switch (btnNo)
            {   
                case 1:
                    // code block
                    LearningBtn();
                    break;
                case 2:
                    // code block
                    QuizBtn();
                    break;
                case 3:
                    // code block
                    ResetBtn();
                    break;
                default:
                    btnNo = 0;
                    break;
            }
        }
            
    }

    public void SetBtnNo(int n)
    {
        btnNo = n;
    }
    public void GVROn()
    {
        gvrStatus = true;
        
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imageGaze.fillAmount = 0;
    }

    public void LearningBtn()
    {
       
        HomePage.SetActive(false);
        BtnReset.SetActive(true);
        Alphabet.SetActive(true);
        
    }

    public void QuizBtn()
    {
       
        HomePage.SetActive(false);
        BtnReset.SetActive(true);
        BtnQuizStart.SetActive(true);
        QuizAlphabet.SetActive(true);  

    }

    public void ResetBtn()
    {
        SceneManager.LoadScene("TestScene");

    }

}
