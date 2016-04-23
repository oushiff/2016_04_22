using UnityEngine;
using System.Collections;

public class NonFloatCoin : MonoBehaviour {
	[SerializeField]
	private float rotateSpeed = 1.0f;

	private float startingY;

	/*
	[SerializeField]
	private float floatSpeed = 0.5f; // In cycles (up and down) per second

	[SerializeField]
	private float movementDistance = 0.5f; // The maximum distance the coin can move up and down.


	
	private bool isMovingUp = true;

	*/
	void OnTriggerEnter2D(Collider2D collider2d)
	{
		if (collider2d.gameObject.tag == "PlayerSnow" || collider2d.gameObject.tag == "PlayerCloud")
		{
			Pickup();
		}
	}

	private void Pickup()
	{
		GameManager.Instance.NumCoins++;
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		startingY = transform.position.y;
		transform.Rotate (transform.up, Random.Range (0f, 360f));
		StartCoroutine (Spin ());
	}


	private IEnumerator Spin()
	{
		while (true) 
		{
			transform.Rotate (transform.up, 360 * rotateSpeed * Time.deltaTime);
			yield return 0;
		}
	}
}
