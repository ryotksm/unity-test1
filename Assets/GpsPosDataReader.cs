﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Assets;

public class GpsPosDataReader : MonoBehaviour {

    public InputField fileName;
    public Text textMessage;
    public Heli heli;

    // Use this for initialization
    void Start () {
        fileName.text = "GPSのPOSファイルをフルパスで指定してください。";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonClick()
    {
        string text = "";
        List<GpsPosData> gpsPosDataList = new List<GpsPosData>();

        if (File.Exists(fileName.text))
        {
            using (StreamReader sr = new StreamReader(fileName.text, Encoding.GetEncoding("Shift_JIS")))
            {
                // 先頭の2行を読み飛ばす
                text = sr.ReadLine();
                text = sr.ReadLine();
                // データオブジェクト生成
                while ((text = sr.ReadLine()) != null)
                {
                    gpsPosDataList.Add(new GpsPosData(text));
                }
                textMessage.text = "読み込み完了。" + gpsPosDataList.Count.ToString() + "オブジェクト生成。";
                heli.SetGpsPosList(gpsPosDataList);
            }
        } else
        {
            textMessage.text = "指定されたファイルが存在しません。";
        }
    }
}
