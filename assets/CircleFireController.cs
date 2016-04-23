using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Renderer))]
public class CircleFireController : MonoBehaviour {

	public HeroTransform heroTransform;
	Material material;

	void Awake(){
		material = GetComponent<Renderer> ().material;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
		material.SetTextureOffset ("_EmissionMap", -Vector2.one * .1f * Time.time);
		material.SetTextureOffset ("_DetailMap", Vector2.one * .05f * Time.time);
	}

	void OnCollisionEnter2D(Collision2D other){
		Debug.Log ("Collision!!!");
		if (other.gameObject.tag == "PlayerSnow") {
			// health decrease
			heroTransform.OnClick ();
		}
			//GameManager.Instance.RestartGame ();
		//else currentState.OnTriggerEnter(other);
	}


}
