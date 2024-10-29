using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrucThink : MonoBehaviour
{
    public GameObject Home;
    public GameObject MenuAbout;
    public GameObject MenuHelp;
    public GameObject Sound;
    public GameObject MenuStart;
    public GameObject LearnNow;
    public GameObject ContohSoal;
    public GameObject Jawaban;
    public GameObject ContohSoal2;
    public GameObject Jawaban2;
    public GameObject ContohSoal3;
    public GameObject Jawaban3;
    public GameObject LN1;
    public GameObject LN2;
    public GameObject LN3;
    public GameObject LN4;
    public GameObject LN5;

    // Start is called before the first frame update
    void Start()
    {
        Home.SetActive(true);
    }

    public void btnaboutClicked()
    {
        Home.SetActive(false);
        MenuAbout.SetActive(true);
    }
    public void btnhelpClicked()
    {
        Home.SetActive(false);
        MenuHelp.SetActive(true);
    }
    public void btnvolumeClicked()
    {
        Home.SetActive(false);
        Sound.SetActive(true);
    }
    public void btnstartClicked()
    {
        Home.SetActive(false);
        MenuStart.SetActive(true);
    }
    public void backhomeClicked()
    {
        Home.SetActive(true);
        MenuAbout.SetActive(false);
        MenuHelp.SetActive(false);
        Sound.SetActive(false);
        MenuStart.SetActive(false);
        LearnNow.SetActive(false);
    }

    public void backMenuClicked()
    {
        MenuStart.SetActive(true);
        LearnNow.SetActive(false);
        ContohSoal.SetActive(false);
        Jawaban3.SetActive(false);
    }

    public void backLNClicked()
    {
        LearnNow.SetActive(true);
        LN1.SetActive(false);
        LN2.SetActive(false);
        LN3.SetActive(false);
        LN4.SetActive(false);
        LN5.SetActive(false);
    }
    public void btnlearnnowClicked()
    {
        MenuStart.SetActive(false);
        LearnNow.SetActive(true);
    }

    public void btncontohsoalClicked()
    {
        MenuStart.SetActive(false);
        ContohSoal.SetActive(true);
    }

    public void btnnextJawabanClicked()
    {
        ContohSoal.SetActive(false);
        Jawaban.SetActive(true);
    }

    public void btnnextC2Clicked()
    {
        Jawaban.SetActive(false);
        ContohSoal2.SetActive(true);
    }

    public void btnnextJawaban2Clicked()
    {
        ContohSoal2.SetActive(false);
        Jawaban2.SetActive(true);
    }

    public void btnnextC3Clicked()
    {
        Jawaban2.SetActive(false);
        ContohSoal3.SetActive(true);
    }

    public void btnnextJawaban3Clicked()
    {
        ContohSoal3.SetActive(false);
        Jawaban3.SetActive(true);
    }

    public void btnbackC1Clicked()
    {
        Jawaban.SetActive(false);
        ContohSoal.SetActive(true);
    }

    public void btnbackJawabanClicked()
    {
        ContohSoal2.SetActive(false);
        Jawaban.SetActive(true);
    }

    public void btnbackC2Clicked()
    {
        Jawaban2.SetActive(false);
        ContohSoal2.SetActive(true);
    }

    public void btnbackJawaban2Clicked()
    {
        ContohSoal3.SetActive(false);
        Jawaban2.SetActive(true);
    }

    public void btnbackC3Clicked()
    {
        Jawaban3.SetActive(false);
        ContohSoal3.SetActive(true);
    }

    public void btnLN1Clicked()
    {
        LearnNow.SetActive(false);
        LN1.SetActive(true);
    }

    public void btnLN2Clicked()
    {
        LearnNow.SetActive(false);
        LN2.SetActive(true);
    }

    public void btnLN3Clicked()
    {
        LearnNow.SetActive(false);
        LN3.SetActive(true);
    }

    public void btnLN4Clicked()
    {
        LearnNow.SetActive(false);
        LN4.SetActive(true);
    }

    public void btnLN5Clicked()
    {
        LearnNow.SetActive(false);
        LN5.SetActive(true);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
