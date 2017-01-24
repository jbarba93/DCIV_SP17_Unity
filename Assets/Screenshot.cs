using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Debug.Log("Hello!");

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {
        Debug.Log("Hello!");
        //Application.CaptureScreenshot("Screenshot.png");
    }
}
