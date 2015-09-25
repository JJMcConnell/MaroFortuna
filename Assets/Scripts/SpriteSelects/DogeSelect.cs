﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DogeSelect : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		
		bool available = false;
		int i;
		for (i = 0; i < Data.currentChars.Count; i++) {
			if (Data.currentChars[i].charName == "Espresso the Dog"){
				available = true;
				break;
			}
		}
		
		if (available) {
			if (!(Data.currentChars [i].isPicked) && (Data.currentCrewSize < Data.pickedMission.squadSize)) {
				GameObject.Find("Espresso the Dog").GetComponent<SpriteRenderer>().color = Color.green;
				Data.activeMissionChars.Add (Data.currentChars [i]);
				Data.currentCrewSize += 1;
				Data.currentChars [i].setPicked ();
			}
            else if (Data.currentChars[i].isPicked)
            {
                GameObject.Find("Espresso the Dog").GetComponent<SpriteRenderer>().color = Color.white;
                Data.activeMissionChars.Remove(Data.currentChars[i]);
                Data.currentCrewSize -= 1;
                Data.currentChars[i].setPicked();
            }
        }
	}
}
