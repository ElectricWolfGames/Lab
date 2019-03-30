namespace Examples.BasicCode
{
    public class CachedBool
    {
        private bool? _chachedBool = null;

        public void SetCache(bool value)
        {
            _chachedBool = value;
        }

        public bool? CachedValue
        {
            get
            {
                return _chachedBool;
            }
        }
    }
}
