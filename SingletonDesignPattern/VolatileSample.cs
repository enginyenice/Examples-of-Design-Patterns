namespace SingletonDesignPattern
{
    public class VolatileSample
    {
         private static volatile VolatileSample mp_Smp;
        private static object lock_obj = new object();
        private int m_Data;

        protected VolatileSample()
        {

        }
        public static VolatileSample CreateObject()
        {
            lock (lock_obj)
            {
                if (mp_Smp == null)
                {
                    mp_Smp = new VolatileSample();
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