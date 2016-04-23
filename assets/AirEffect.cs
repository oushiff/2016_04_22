using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Renderer))]
public class AirEffect : MonoBehaviour {

	Material material;

	void Awake(){
		material = GetComponent<Renderer> ().material;
	}
	
	// Update is called once per frame
	void Update () {
		material.SetTextureOffset ("_MainTex", Vector2.down * Time.time);
	}
}
