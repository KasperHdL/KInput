using UnityEngine;
using System.Collections;

public class KInputTest : MonoBehaviour {
    KInput.Controller controller;

	// Use this for initialization
	void Start () {
        controller = new KInput.Xbox360();
	}
	
	// Update is called once per frame
    void Update () {
        for(int i = 0; i < (int) KInput.Button.Count; i++){
            Debug.Log("Button " + i + " - " + ((KInput.Button)i) + " :" + controller.GetButton((KInput.Button)i));
        }
        
        for(int i = 0; i < (int) KInput.Axis.Count; i++){
            Debug.Log("Axis " + i + " - " + ((KInput.Axis)i) + " :" + controller.GetAxis((KInput.Axis)i));
        }
    }
}
