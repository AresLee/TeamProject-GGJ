using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	float positionX,positionY;
	public static bool isShot=false;
	public Texture attackRocket;

	float shotSpeed=5f;
	float reboundPower;
	float calmDownSpeed;


	// Use this for initialization
	void Start () {
		//transform.position = Camera.main.gameObject.transform.position + new Vector3 (0, 0, -5);
	}


	void dropItems(){

		transform.Translate(new Vector3(0,positionY,0)*Time.deltaTime);

	}

	void adjustSpeed(float offsetX){
		transform.Translate(new Vector3(offsetX,0,0)*Time.deltaTime);

	}

	void SetTransformX(float positionX,float offset){
		
		transform.position = new Vector3(positionX+offset, transform.position.y, transform.position.z);
		
	}

	// Update is called once per frame
	void Update () {



//		if (!isShot) {
//			if (positionY<=Screen.height*(2/3)) {
//				positionY += 0.1f;
//				dropItems();
//			}
//			if (positionY>Screen.height*(2/3)) {
//				positionX -= 0.1f;
//				shotItems();
//			}
//
//				}


		if (isShot) {
			if (transform.position.y > 4) {
				SetTransformX (Camera.main.gameObject.transform.position.x,6);
				positionY -= 0.05f;
				dropItems ();
				
			} else if (transform.position.y <= 4) {
				
				adjustSpeed (shotSpeed);
			}
		}










	}
}
