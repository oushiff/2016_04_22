using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("hit the bottom");
		transform.parent.gameObject.AddComponent<GameOver>();
//		Application.LoadLevel (Application.loadedLevel);
//		GameManager.Instance.RestartGame ();
	}
}
