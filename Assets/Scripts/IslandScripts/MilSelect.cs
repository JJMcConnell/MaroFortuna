using UnityEngine;
using System.Collections;

public class MilSelect : MonoBehaviour {

    //public GameObject loadingImage;

    public void LoadScene(string level)
    {
        System.Random r = new System.Random();
        int randomIndex = r.Next(0, Data.militaryList.Count);
        Data.pickedMission = Data.militaryList[randomIndex];
        int count = 0; //to prevent possible infinite loop

        while (Data.pickedMission.difficulty != Data.currentDifficulty || count < 100)
        {
            randomIndex = r.Next(0, Data.militaryList.Count);
            Data.pickedMission = Data.militaryList[randomIndex];
            count++;
        }

        //loadingImage.SetActive(true);
        Application.LoadLevel(level);
    }
}
