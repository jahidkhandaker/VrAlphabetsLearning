using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AlphaAudioPlay : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void PlayAlphaSound(GameObject AlpaSound)
    {
        AlpaSound.SetActive(true);
    }
    public void StopAlphaSound(GameObject AlpaSound)
    {
        AlpaSound.SetActive(false);
    }



}
