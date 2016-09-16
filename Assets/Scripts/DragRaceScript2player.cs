using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DragRaceScript2player : MonoBehaviour {

	public int Speed;
	float t;
	public float ellapsed;
	public bool finished;

	public Canvas theCanvas;
	public GameObject theText;
	public GameObject goButton;
    public GameObject goButton2;

    Text thetext;
	Vector2 initialGo;
    Vector2 initialGo2;

    // Use this for initialization
    void Start () {
		theCanvas = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		thetext = theText.GetComponent<Text>();

		Speed = Random.Range(150,300);
		t = Time.time;

		thetext.enabled = false;
		finished = false;

		initialGo = goButton.transform.position;
        initialGo2 = goButton2.transform.position;
        goButton.GetComponent<Button> ().transform.position = new Vector2(-1000,-1000);       
        goButton2.GetComponent<Button>().transform.position = new Vector2(-1000, -1000);
    }
			
	// Update is called once per frame
	void Update () 
	{
        countTime();
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
            goButton2.GetComponent<Button>().transform.position = initialGo2;
            thetext.text = "!!!GO!!!";
		}
	}
}
