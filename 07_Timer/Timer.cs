namespace _07_Timer
{
    public class Timer
    {
        
        private int seconds = 0;
        public int Seconds {
            get { return seconds; }
            set { seconds = value; }
        }
        public override string ToString()
        {
            int hours = seconds / (60 * 60);
            string h = "";
            if(hours <= 9)
            {
                h = "0" + hours;
            }
            else
            {
                h = hours + "";
            }
            int min = (seconds % (60 * 60)) / 60;
            string m = "";
            if (min <= 9)
            {
                m = "0" + min;
            }
            else
            {
                m = min + "";
            }
            int sec = seconds - ((hours*60*60) + (min*60));
            string s = "";
            if (sec <= 9)
            {
                s = "0" + sec;
            }
            else
            {
                s = sec + "";
            }
            string result = "";
            return result = h + ":" + m + ":" + s;
        }
        
    }
}