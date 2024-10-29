using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setsound : MonoBehaviour
{
    public AudioSource Sound;
    public void clickslider(float valueslider)
    {
        Sound.volume = valueslider;
    }
}
