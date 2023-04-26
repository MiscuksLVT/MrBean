using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AinuParsledzejs : MonoBehaviour {
    //Metode lauj parslegtiues no UI ainas un sakuma ainu

    public void Uzaskums()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    //Metode,kura aizver programmu, ja ta ir izveidota ka .exe

    public void Apturet()
    {
        Application.Quit();
    }

    //Pasiem jauztaisa metode,kas parsledzno sakuma uz UI ainu
    public void UIelem()
    {
        SceneManager.LoadScene("UI elementi", LoadSceneMode.Additive);

    }
}
