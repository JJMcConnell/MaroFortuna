﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScrollableList : MonoBehaviour
{
	public GameObject itemPrefab;
	public int itemCount = 10, columnCount = 1;
	public static List<Character> charList = new List<Character> ();      //list of available characters
	public List<Character> playerVar;

	void Awake(){
		//instantiate and add to list all your characters (we probably need to do this for each single one, so copy paste!)
		Character char1 = new Character (1, "Jorts Bear", Resources.Load("/Users/Craig/Documents/MaroFortuna/Assets/Textures/Captain Portrait.png") as Texture, 0, 1,
		                               "A rogue cop who doesn't play by the rules... in jorts.");
		charList.Add (char1);

		//this allows it to persist
		DontDestroyOnLoad (transform.gameObject);
	}
	
	void Start()
	{
		//can now access data of a character
		playerVar = charList;
		if (playerVar != null) {
			Debug.Log (playerVar[0].charName);
			Debug.Log (playerVar[0].profession);
		} else {
			Debug.Log ("not found");
		}
		RectTransform rowRectTransform = itemPrefab.GetComponent<RectTransform>();
		RectTransform containerRectTransform = gameObject.GetComponent<RectTransform>();
		
		//calculate the width and height of each child item.
		float width = containerRectTransform.rect.width / columnCount;
		float ratio = width / rowRectTransform.rect.width;
		float height = rowRectTransform.rect.height * ratio;
		int rowCount = itemCount / columnCount;
		if (itemCount % rowCount > 0)
			rowCount++;
		
		//adjust the height of the container so that it will just barely fit all its children
		float scrollHeight = height * rowCount;
		containerRectTransform.offsetMin = new Vector2(containerRectTransform.offsetMin.x, -scrollHeight / 2);
		containerRectTransform.offsetMax = new Vector2(containerRectTransform.offsetMax.x, scrollHeight / 2);
	
		int j = 0;
		for (int i = 0; i < itemCount; i++)
		{
			//this is used instead of a double for loop because itemCount may not fit perfectly into the rows/columns
			if (i % columnCount == 0)
				j++;
			
			//create a new item, name it, and set the parent
			GameObject newItem = Instantiate(itemPrefab) as GameObject;
			newItem.name = gameObject.name + " item at (" + i + "," + j + ")";
			newItem.transform.parent = gameObject.transform;
			
			//move and size the new item
			RectTransform rectTransform = newItem.GetComponent<RectTransform>();
			
			float x = -containerRectTransform.rect.width / 2 + width * (i % columnCount);
			float y = containerRectTransform.rect.height / 2 - height * j;
			rectTransform.offsetMin = new Vector2(x, y);
			
			x = rectTransform.offsetMin.x + width;
			y = rectTransform.offsetMin.y + height;
			rectTransform.offsetMax = new Vector2(x, y);
		}
	}

	void Update(){

	}
}
