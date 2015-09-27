using UnityEngine;
using System.Collections;

public class IslandCollision : MonoBehaviour {


    public void loadIsland(string level) {
        if(level == "LavaIsland" || level =="GreenIsland" || level == "IceIsland" || level == "BeachIsland")
            Application.LoadLevel(level);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        loadIsland(coll.gameObject.name);
    }
}
