namespace SingletonDesignPattern
{
    public class Sample
    {
        private static Sample mp_Smp;
        private int m_Data;

        protected Sample()
        {
            
        }
        public static Sample CreateObject(){
            if(mp_Smp == null){
                mp_Smp = new Sample();
            }
            return mp_Smp;
        }

        public int GetData(){
            return m_Data;
        }
        public void SetData(int val){
            m_Data = val;
        }
    }
}