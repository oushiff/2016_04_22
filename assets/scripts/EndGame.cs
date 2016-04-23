using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

    /*
	void OnCollisionEnter2D(Collision2D object){
        if(object.gameObject.tag
		Debug.Log ("hit the bottom");
		//transform.parent.gameObject.AddComponent<GameOver>();
        //Application.LoadLevel (Application.loadedLevel);
        //GameManager.Instance.RestartGame ();
	}
    */
    void OnCollisionEnter2D(Collision2D collider2d)
	{
		if (collider2d.gameObject.tag == "PlayerSnow" )
		{
            GameManager.Instance.RestartGame();
		}
    }
}
