using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroOption : MonoBehaviour
{
    public bool MusicOnOff = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(MusicOnOff == false)
            {
                
                GameObject.Find("OptionCanvas").transform.Find("SoundPanel").gameObject.SetActive(true);
                MusicOnOff = true;
            }
            else
            {
                
                GameObject.Find("OptionCanvas").transform.Find("SoundPanel").gameObject.SetActive(false);
                MusicOnOff = false;
            }
            
        }
    }
}
