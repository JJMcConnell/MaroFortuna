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
		int i;
		for (i = 0; i < Data.currentChars.Count; i++) {
			if (Data.currentChars[i].charName == "Espresso the Dog")
				break;
		}
		
		if (!(Data.currentChars[i].isPicked) && (Data.currentCrewSize < Data.pickedMission.squadSize)) {
			Data.activeMissionChars.Add (Data.currentChars [i]);
			Data.currentCrewSize += 1;
			Data.currentChars[i].setPicked();
		}
	}
}
