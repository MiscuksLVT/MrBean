using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{

    public GameObject binsImg;
    public GameObject lacitisImg;
    public GameObject omeImg;
    public GameObject masinaImg;
    public GameObject paKreisiPoga;
    public GameObject paLabiPoga;
    public GameObject mainigaisAttles;
    public Sprite[] atteluMasiva;

    public void binaApttelosana(bool vertiba)
    {
        binsImg.SetActive(vertiba);
        paKreisiPoga.GetComponent<Toggle>().interactable = vertiba;
        paLabiPoga.GetComponent<Toggle>().interactable = vertiba;
    }

    public void lacitisApttelosana(bool vertiba)
    {
        lacitisImg.SetActive(vertiba);
    }
    public void omeApttelosana(bool vertiba)
    {
       omeImg.SetActive(vertiba);
    }
    public void masinaApttelosana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }


    public void paKreisiBins()
    {
        binsImg.transform.localScale = new Vector2(1,1);
    }
    public void paLaniBina ()
    {
        binsImg.transform.localScale = new Vector2(-1, 1);

    }
    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttles.GetComponent<Image>().sprite = atteluMasiva[0];
        else if (skaitlis == 1)
            mainigaisAttles.GetComponent<Image>().sprite = atteluMasiva[1];
        else if (skaitlis == 2)
            mainigaisAttles.GetComponent<Image>().sprite = atteluMasiva[2];
        else Debug.Log("Nav piesaistits attels!");
    }





}

