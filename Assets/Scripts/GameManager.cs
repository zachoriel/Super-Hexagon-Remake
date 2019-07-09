using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Camera mainCam;

	// Use this for initialization
	void Start ()
    {
		if (mainCam == null)
        {
            mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        }

        StartCoroutine(ChangeBackground());
	}

    IEnumerator ChangeBackground()
    {
        while (true)
        {
            mainCam.backgroundColor = new Color(Random.value, Random.value, Random.value, 0f);
            yield return new WaitForSeconds(5f);
        }
    }
}
