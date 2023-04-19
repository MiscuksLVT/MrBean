using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameInput : MonoBehaviour {
	public int kadruSk = 0;
	// Use this for initialization
	void Start () {
		Debug.Log("Uzsaka programma! Tu esi "+kadruSk+" kadra");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Kadrs: "+kadruSk);
		kadruSk++;
	}
}
