using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour {
	float speed = 5f;
	Vector3 carMove;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);
	}
}
