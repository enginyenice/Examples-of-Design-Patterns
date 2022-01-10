namespace SingletonDesignPattern
{
    public class MultiThreadSample
    {

        private static MultiThreadSample mp_Smp;
        private static object lock_obj = new object();
        private int m_Data;

        protected MultiThreadSample()
        {

        }
        public static MultiThreadSample CreateObject()
        {
            lock (lock_obj)
            {
                if (mp_Smp == null)
                {
                    mp_Smp = new MultiThreadSample();
                }
            }
            return mp_Smp;
        }

        public int GetData()
        {
            return m_Data;
        }
        public void SetData(int val)
        {
            m_Data = val;
        }

    }
}