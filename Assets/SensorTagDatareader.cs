using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Assets;

public class SensorTagDatareader : MonoBehaviour {

    public InputField fileName;
    public Text textMessage;

	// Use this for initialization
	void Start () {
        fileName.text = "センサータグのログファイルをフルパスで指定してください。";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonClick()
    {
        string text = "";
        List<SensorTagData> sensorTagDataList = new List<SensorTagData>();
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
                    sensorTagDataList.Add(new SensorTagData(text));
                }
                textMessage.text = "読み込み完了。" + sensorTagDataList.Count.ToString() + "オブジェクト生成。";
            }
        }
        else
        {
            textMessage.text = "指定されたファイルが存在しません。";
        }
    }
}
