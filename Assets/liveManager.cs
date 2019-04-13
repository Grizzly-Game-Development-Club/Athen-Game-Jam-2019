using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liveManager : MonoBehaviour {

    public GameObject livesPrefabs;
    public lifePickup lifePickup;
    private int iframe = 0;
    public int iframeSec = 2;
	// Use this for initialization
	void Start () {
        for (int i=0;i< 3; i++)
        {
            addLive();
        }
    }

	void Update () {
        if (iframe > 0)
        {
            iframe = iframe - 1;
        }
    }

    public void addLive()
    {
        GameObject newLives = Instantiate(livesPrefabs, this.transform) as GameObject;
    }

    public void removeLive()
    {
        if (iframe <= 0)
        {
            if (transform.childCount > 0)
            {
                GameObject lastChild = transform.GetChild(transform.childCount - 1).gameObject;
                Destroy(lastChild);
                iframe = iframeSec * (int)Time.deltaTime;
            }
        }

    }
}
