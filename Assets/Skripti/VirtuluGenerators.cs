using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtuluGenerators : MonoBehaviour
{
	public GameObject[] virtuluSagataves;
	public float laikaintervals = 1f;
	float minX, maxX;
	private Transform krasnsTranform;


	// Use this for initialization
	void Start()
	{
        krasnsTranform = GetComponent<Transform>();

	}
	public void SagatavotVirtulus(bool stavoklis)
	{
		if (stavoklis)
			StartCoroutine(Generet());
		else
			StopAllCoroutines();

		
	}
	IEnumerator Generet()
	{
		while (true)
		{
			minX = krasnsTranform.position.x - 15;
			maxX = krasnsTranform.position.x +15;
			var cipars = Random.Range(minX, maxX);
			var pozicija =new Vector2(cipars,transform.position.y);
			Instantiate(virtuluSagataves[Random.Range(0, virtuluSagataves.Length)], pozicija, Quaternion.identity, krasnsTranform);
            yield return new WaitForSeconds(laikaintervals);
		}
	}



}
