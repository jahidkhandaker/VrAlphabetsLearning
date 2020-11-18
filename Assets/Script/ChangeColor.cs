using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{


    public AudioSource asource;
    public AudioClip aclip;
    // Start is called before the first frame update



    public void playAudio()
    {

        asource.PlayOneShot(aclip);
    }
    public void red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }



}
