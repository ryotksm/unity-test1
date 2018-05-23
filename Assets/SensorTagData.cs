using System;

namespace Assets
{
    public class SensorTagData
    {
        private DateTime time;
        private double acc_x;   // 加速度 X
        private double acc_y;   // 加速度 Y
        private double acc_z;   // 加速度 Z
        private double mag_x;   // 地磁気 X
        private double mag_y;   // 地磁気 Y
        private double mag_z;   // 地磁気 Z
        private double gyr_x;   // 回転速度 X(pitch)
        private double gyr_y;   // 回転速度 Y(roll)
        private double gyr_z;   // 回転速度 Z(yaw)

        public DateTime Time
        {
            //set { this.time = value; }
            get { return this.time; }
        }
        public double Acc_x
        {
            //set { this.acc_x = value; }
            get { return this.acc_x; }
        }
        public double Acc_y
        {
            //set { this.acc_y = value; }
            get { return this.acc_y; }
        }
        public double Acc_z
        {
            //set { this.acc_z = value; }
            get { return this.acc_z; }
        }
        public double Mag_x
        {
            //set { this.mag_x = value; }
            get { return this.mag_x; }
        }
        public double Mag_y
        {
            //set { this.mag_y = value; }
            get { return this.mag_y; }
        }
        public double Mag_z
        {
            //set { this.mag_z = value; }
            get { return this.mag_z; }
        }
        public double Gyr_x
        {
            //set { this.gyr_x = value; }
            get { return this.gyr_x; }
        }
        public double Gyr_y
        {
            //set { this.gyr_y = value; }
            get { return this.gyr_y; }
        }
        public double Gyr_z
        {
            //set { this.gyr_z = value; }
            get { return this.gyr_z; }
        }

        public SensorTagData(string text)
        {
            // time ,acc-x,acc-y,acc-z ,mag-x,mag-y,mag-z ,gyr-x,gyr-y,gyr-z 
            // 2018/05/16 12:27:11.097678 , 0.0 , 0.0 , 0.0 , 0.0 , 0.0 , 0.0 , 0.0 , 0.0 , 0.0 
            string[] t = text.Split(',');
            try
            {
                time = DateTime.ParseExact(t[0].Trim(' '), "yyyy/MM/dd HH:mm:ss.ffffff", null);
                acc_x = double.Parse(t[1].Trim(' '));
                acc_y = double.Parse(t[2].Trim(' '));
                acc_z = double.Parse(t[3].Trim(' '));
                mag_x = double.Parse(t[4].Trim(' '));
                mag_y = double.Parse(t[5].Trim(' '));
                mag_z = double.Parse(t[6].Trim(' '));
                gyr_x = double.Parse(t[7].Trim(' '));
                gyr_y = double.Parse(t[8].Trim(' '));
                gyr_z = double.Parse(t[9].Trim(' '));
            }
            catch (Exception)
            {
                time = DateTime.MinValue;
                acc_x = 0.0;
                acc_y = 0.0;
                acc_z = 0.0;
                mag_x = 0.0;
                mag_y = 0.0;
                mag_z = 0.0;
                gyr_x = 0.0;
                gyr_y = 0.0;
                gyr_z = 0.0;
            }
        }
    }
}
