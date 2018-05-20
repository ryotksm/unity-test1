using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmFileSelect : Form
    {
        public frmFileSelect()
        {
            InitializeComponent();
        }

        private void BtnSensorTagFileSelect_Click(object sender, EventArgs e)
        {
            if (txtSensorTagFile.Text != "")
            {
                openFileDialog1.FileName = txtSensorTagFile.Text;
            }
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSensorTagFile.Text = openFileDialog1.FileName;
            }
        }

        private void BtnGpsPosFileSelect_Click(object sender, EventArgs e)
        {
            if (txtGpsPosFile.Text != "")
            {
                openFileDialog1.FileName = txtGpsPosFile.Text;
            }
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtGpsPosFile.Text = openFileDialog1.FileName;
            }
        }

        private void BtnSensorTagFileProceed_Click(object sender, EventArgs e)
        {
            string text = "";
            List<SensorTagData> sensorTagDataList = new List<SensorTagData>();

            using (StreamReader sr = new StreamReader(txtSensorTagFile.Text, Encoding.GetEncoding("Shift_JIS")))
            {
                // 先頭の2行を読み飛ばす
                text = sr.ReadLine();
                text = sr.ReadLine();
                // データオブジェクト生成
                while ((text = sr.ReadLine()) != null)
                {
                    sensorTagDataList.Add(new SensorTagData(text));
                }
            }
        }

        private void BtnGpsPosFileProceed_Click(object sender, EventArgs e)
        {
            string text = "";
            List<GpsPosData> gpsPosDataList = new List<GpsPosData>();

            using (StreamReader sr = new StreamReader(txtGpsPosFile.Text, Encoding.GetEncoding("Shift_JIS")))
            {
                // 先頭の2行を読み飛ばす
                text = sr.ReadLine();
                text = sr.ReadLine();
                // データオブジェクト生成
                while ((text = sr.ReadLine()) != null)
                {
                    gpsPosDataList.Add(new GpsPosData(text));
                }
            }
        }
    }
}
