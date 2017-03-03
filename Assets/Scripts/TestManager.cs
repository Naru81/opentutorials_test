using UnityEngine;
using UnityEditor;
using System.Collections;

public class TestManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
    {
        GUI.Button(new Rect(0, 0, 100, 100), "Test Button");



    }
}
