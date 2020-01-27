using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{
    public GameObject soundBtn;
    public Sprite audioOff, audioOn;
    
    // Start is called before the first frame update
    void Start()
    {
        
        if (AudioListener.pause == false)
        {
            soundBtn.GetComponent<Image>().sprite = audioOn;         
        }
        else
        {
            soundBtn.GetComponent<Image>().sprite = audioOff;         
        }
    }
    public void ControlSound()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
            soundBtn.GetComponent<Image>().sprite = audioOn;
           
        }
        else
        {
            AudioListener.pause = true;
            soundBtn.GetComponent<Image>().sprite = audioOff;
           
        }

    }
}
