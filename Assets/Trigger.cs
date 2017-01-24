using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{

    Renderer r;

	// Use this for initialization
	void Start ()
    {
        r = GetComponent<Renderer>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter()
    {
        Debug.Log("Enter");
        r.material.color(new Color(255, 0, 0));
    }
}
