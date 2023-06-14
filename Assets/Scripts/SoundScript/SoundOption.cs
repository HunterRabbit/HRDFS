using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundOption : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider BGMSlider;
    public Slider SESlider;

    private void Start()
    {
        BGMSlider.value = PlayerPrefs.GetFloat("BGM", 0.5f);
        SESlider.value = PlayerPrefs.GetFloat("SE", 0.5f);
    }

    public void SetBgmVolume()
    {
        audioMixer.SetFloat("BGM", Mathf.Log10(BGMSlider.value) * 20);
    }

    public void SetSeVolume()
    {
        audioMixer.SetFloat("SE", Mathf.Log10(SESlider.value) * 20);
    }
}
