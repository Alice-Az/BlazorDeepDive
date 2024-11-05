namespace ServerManagement.StateStore
{
    public class MontrealOnlineServersStore : Observer
    {
        private int _numServersOnline;

        public int GetNumServersOnline()
        {
            return _numServersOnline;
        }

        public void SetNumServersOnline(int number)
        {
            _numServersOnline = number;
            base.BroadcastStateChange();
        }
    }
}
