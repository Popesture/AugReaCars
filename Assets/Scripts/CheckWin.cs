﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckWin : MonoBehaviour {

	public bool noWinner = false;
	public bool enemyWin = false;
	DragRaceScript DRS;
	public GameObject winLoseText;
	Text winlosetext;

	Vector2 initialRes;
	public GameObject resButton;

	// Use this for initialization
	void Start () {
		DRS = GameObject.FindWithTag("enemyCar").GetComponent<DragRaceScript>();
		winlosetext = winLoseText.GetComponent<Text>();
		initialRes = resButton.transform.position;
		resButton.GetComponent<Button> ().transform.position = new Vector2(-1000,-1000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		DRS.finished = true;
		if (noWinner == false && enemyWin == false) {
			if (col.gameObject.tag == "Model") {
				winlosetext.text = "!!!!!YOU WIN!!!!!";
				noWinner = true;
				resButton.GetComponent<Button> ().transform.position = initialRes;
			}
			if (col.gameObject.tag == "enemyCar") {
				winlosetext.text = "YOU LOST";
				enemyWin = true;
				noWinner = true;
				resButton.GetComponent<Button> ().transform.position = initialRes;
			}
		}
	}
}