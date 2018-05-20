using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SensorTagDatareader : MonoBehaviour {

    public InputField fileName;

	// Use this for initialization
	void Start () {
        fileName.text = "センサータグのログファイルをフルパスで指定してください。";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonClick()
    {
        fileName.text = "SensorTag!";
    }

}
