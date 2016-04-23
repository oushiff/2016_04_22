using UnityEngine;
using System.Collections;

public class Blinking : MonoBehaviour {

	public int maxTime = 10;
	public int counting = 0;
	public float blinkTime = 0.2f;

	// Use this for initialization
	void Start () {

		counting = 0;
		StartCoroutine(DoBlinks());
	}

	IEnumerator DoBlinks() {
		while (counting < maxTime) {
			counting++;

			//toggle renderer
			GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

			//wait for a bit
			yield return new WaitForSeconds(blinkTime);
		}

		//make sure renderer is enabled when we exit
		GetComponent<Renderer>().enabled = true;
	}


	// Update is called once per frame
	void Update () {
	
	}
}
