using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liveManager : MonoBehaviour {

    public GameObject livesPrefabs;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void addLive()
    {
        GameObject newLives = Instantiate(livesPrefabs, this.transform) as GameObject;

    }

    public void removeLive()
    {
        if (transform.childCount > 0)
        {
            GameObject lastChild = transform.GetChild(transform.childCount - 1).gameObject;
            Destroy(lastChild);
        }
    }
}
