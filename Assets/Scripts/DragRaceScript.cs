using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DragRaceScript : MonoBehaviour {

	public int Speed;
	float t;
	public float ellapsed;
	public bool finished;

	public Canvas theCanvas;
	public GameObject theText;
	public GameObject goButton;

	Text thetext;
	Vector2 initialGo;


	// Use this for initialization
	void Start () {
		theCanvas = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		thetext = theText.GetComponent<Text>();

		Speed = Random.Range(150,300);
		t = Time.time;

		thetext.enabled = false;
		finished = false;

		initialGo = goButton.transform.position;
		goButton.GetComponent<Button> ().transform.position = new Vector2(-1000,-1000);
	}
			
	// Update is called once per frame
	void Update () 
	{
		countTime ();
		if (finished == false){
			if (ellapsed >= 6) {
				Speed = Random.Range (100, 400);
				transform.Translate (Vector3.right * Speed * Time.deltaTime);
				}
		} 
		else 
		{
			Speed = 0;
		}
	}


	void countTime()
	{
		ellapsed=Time.time-t;

		if (ellapsed >= 1) {
			thetext.enabled = true;
			thetext.text = "5";
		}
		if (ellapsed >= 2) {
			thetext.text = "4";
		}
		if (ellapsed >= 3) {
			thetext.text = "3";
		}
		if (ellapsed >= 4) {
			thetext.text = "2";
		}
		if (ellapsed >= 5) {
			thetext.text = "1";
		}
		if (ellapsed >= 6) {
			goButton.GetComponent<Button> ().transform.position = initialGo;
			thetext.text = "!!!GO!!!";
		}
	}
}
