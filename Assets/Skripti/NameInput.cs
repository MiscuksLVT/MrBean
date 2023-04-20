using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour{
    private string text;
    public GameObject ievadesLauks;
    public GameObject tekstaAttelosana;
    private string[] fragmenti = { "Sveiks ", "Jauku dienu ", "Prieks Tevi redzet ", "Good bye!" };
    int index;


    public void UzglabatTekstu(){
        index = Random.Range(0, fragmenti.Length);
        text = ievadesLauks.GetComponent<InputField>().text;
        tekstaAttelosana.GetComponent<Text>().text = fragmenti[index] + text.ToUpper() + "!";
    }

}

