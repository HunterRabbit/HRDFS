using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject[] soundoption;

    public bool SaveLoad = true; // �ε����

    private void Awake()
    {
        soundoption = GameObject.FindGameObjectsWithTag("option");
        if (soundoption.Length >= 2)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Update()
    {
        
    }

    public void SoundOptionOn()
    {
        GameObject.Find("OptionCanvas").transform.Find("SoundPanel").gameObject.SetActive(true);
    }
    public void SoundOptionOff()
    {
        GameObject.Find("OptionCanvas").transform.Find("SoundPanel").gameObject.SetActive(false);
    }
}
