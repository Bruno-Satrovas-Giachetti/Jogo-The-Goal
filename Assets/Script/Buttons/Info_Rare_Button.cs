using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Info_Rare_Button : MonoBehaviour
{
    [SerializeField] GameObject Rare1Info, Rare2Info;
    [SerializeField] AudioSource ButtonOpen, ButtonClose;

    public void OpenInfoButton1()
    {
        ButtonOpen.Play();
        Rare1Info.SetActive(true);
    }

    public void OpenInfoButton2()
    {
        ButtonOpen.Play();
        Rare2Info.SetActive(true);
    }

    public void CloseInfoButton1()
    {
        ButtonClose.Play();
        Rare1Info.SetActive(false);
    }

    public void CloseInfoButton2()
    {
        ButtonClose.Play();
        Rare2Info.SetActive(false);
    }
}
