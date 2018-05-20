using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GpsPosDataReader : MonoBehaviour {

    public InputField fileName;

    // Use this for initialization
    void Start () {
        fileName.text = "GPSのPOSファイルをフルパスで指定してください。";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonClick()
    {
        fileName.text = "GPS!";
    }
}
