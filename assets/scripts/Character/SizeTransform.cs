using UnityEngine;
using System.Collections;

public class SizeTransform : MonoBehaviour {

	private Vector3 originalScale = new Vector3 (0.55f, 0.55f, 0.55f); 
	// Use this for initialization
	void Start () {
		originalScale = transform.localScale;
	}

	// Update is called once per frame
	void Update () {
		
		float multiplier = GameManager.Instance.Health / 100f;
		Debug.Log (multiplier);
		if (multiplier > 0.2f) {
			Vector3 velocity = Vector3.zero;
			transform.localScale = Vector3.SmoothDamp(gameObject.transform.localScale, originalScale * multiplier, ref velocity, 0.1f);
		}
	}
}
