namespace AndroidNDKBinding
{
    public enum jobjectRefType : int
    {
        JNIInvalidRefType = 0,
        JNILocalRefType = 1,
        JNIGlobalRefType = 2,
        JNIWeakGlobalRefType = 3
    }
}