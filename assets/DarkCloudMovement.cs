using UnityEngine;
using System.Collections;

public class DarkCloudMovement : MonoBehaviour {

	public Rigidbody2D rb2d;
	public bool isActive = true;
	public float delay = 1.0f;
	public float maxSpeed = 5f;
	public Vector2 moveVec;

	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();
		moveVec.x = Random.Range (-maxSpeed, maxSpeed);
		moveVec.y = Random.Range (-maxSpeed, maxSpeed);
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (Cloudmove ());
	}

	IEnumerator Cloudmove (){

		yield return new WaitForSeconds (delay);

		if (isActive) {
			
			delay = Random.Range (1f, 2.8f);
			moveVec.x = Random.Range (-maxSpeed, maxSpeed);
			moveVec.y = Random.Range (-maxSpeed, maxSpeed);

			//rb2d.velocity = moveVec;
			//rb2d.AddForce(new Vector2(moveX,moveY));
		}

		StartCoroutine (Cloudmove ());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb2d.velocity = moveVec;
	}
		
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Dark Cloud Collision!!!");
		if (other.tag == "PlayerCloud" || other.tag == "PlayerSnow") {
			// Dis-appear 
			Disappear(3.0f);
			// wait 3 seconds
			//reload
			GameManager.Instance.DecreaseHealth(30f);

		}
		//GameManager.Instance.RestartGame ();
		//else currentState.OnTriggerEnter(other);
	}

	private void Disappear(float hideTime) {
		GetComponent<Renderer> ().enabled = false;
		float duration = 0f;

		while (duration < hideTime) {
			duration += Time.deltaTime;

		}
		GetComponent<Renderer> ().enabled = true;
	}
}
