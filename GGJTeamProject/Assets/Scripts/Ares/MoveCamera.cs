using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	//Vector3 cameraPosition=(0,0,-10);
	float xPosition=10f;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(xPosition,0,0)*Time.deltaTime);
//		xPosition+=0.1f;
//
//		if(Input.GetKey(KeyCode.RightArrow))
//			xPosition += 1;
//
//
//		if(Input.GetKey(KeyCode.LeftArrow))
//			xPosition -= 1;



	}
}
