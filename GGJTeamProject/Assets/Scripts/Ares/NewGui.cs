using UnityEngine;
using System.Collections;

public class NewGui : MonoBehaviour {
	public GUISkin mySkin;
	int min=0,second=0;
	int offsetX,offsetY=100;
	int cardWidth=70,cardHeight=90;
	public Texture2D itemTexture1,itemTexture2,itemTexture3,itemTexture4,itemTexture5,itemTexture6;



	// Use this for initialization
	void Start () {
//		GUI.matrix = Matrix4x4.TRS (Vector3(0, 0, 0), Quaternion.identity, Vector3 (horizRatio, vertRatio, 1));
	}
	
	// Update is called once per frame
	void Update () {


						second = (int)Time.realtimeSinceStartup%60;
						min = (int)(Time.realtimeSinceStartup / 60);



	}

public void OnGUI () {

		GUI.skin = mySkin;


		GUI.Label (new Rect (Screen.width-80,0,200,100), "Time:"+min+":"+second, "label");
	//	GUI.Box (new Rect (Screen.width / 8, Screen.height - offsetY, cardWidth, cardHeight), itemTexture1, "box");
		//GUI.DrawTexture (new Rect (Screen.width / 8, Screen.height - offsetY + 200, cardWidth, cardHeight), itemTexture1);
	//	GUI.DrawTexture(new Rect(10, 10, 60, 60), itemTexture1, ScaleMode.ScaleToFit, true, 10.0F);
		if ((GUI.Button(new Rect(Screen.width/8,Screen.height-offsetY,cardWidth,cardHeight),itemTexture1,"Button"))) {
//			print("Selected ITEM1!!!!");
			Attack.isShot=true;

		}

//
//		if (GUI.Button(new Rect(Screen.width/8,Screen.height-offsetY,cardWidth,cardHeight),"ITEM1","Button")) {
//			print("Selected ITEM2!!!!");
//				}

		if (GUI.Button(new Rect(Screen.width*2/8,Screen.height-offsetY,cardWidth,cardHeight),itemTexture2,"Button")) {
			print("Selected ITEM2!!!!");
				}

		if (GUI.Button(new Rect(Screen.width*3/8,Screen.height-offsetY,cardWidth,cardHeight),itemTexture3,"Button")) {
			print("Selected ITEM3!!!!");
				}

		if (GUI.Button(new Rect(Screen.width*4/8,Screen.height-offsetY,cardWidth,cardHeight),itemTexture4,"Button")) {
			print("Selected ITEM4!!!!");
				}

		if (GUI.Button(new Rect(Screen.width*5/8,Screen.height-offsetY,cardWidth,cardHeight),itemTexture5,"Button")) {
			print("Selected ITEM5!!!!");
				}
		if (GUI.Button(new Rect(Screen.width*6/8,Screen.height-offsetY,cardWidth,cardHeight),itemTexture6,"Button")) {
			print("Selected ITEM6!!!!");


				}


	}
}
