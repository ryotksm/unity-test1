using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;

public class Heli : MonoBehaviour {

    int counter = 0;
    float plus = 0.1f;
    List<GpsPosData> gpsPosDataList = null;

    public void SetGpsPosList(List<GpsPosData> l)
    {
        gpsPosDataList = l;
        counter = 0;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gpsPosDataList == null)
        {
            Vector3 p = new Vector3(0, 0, plus);
            transform.Translate(p);
            counter++;
            if (counter == 100)
            {
                counter = 0;
                plus *= -1;
            }
        } else
        {
            Vector3 p = GpsPosConverter.GetDistance(gpsPosDataList[counter], gpsPosDataList[counter + 1]);
            transform.Translate(p);
            counter++;
            if (counter >= (gpsPosDataList.Count - 1))
            {
                counter = 0;
            }
        }
	}
}
