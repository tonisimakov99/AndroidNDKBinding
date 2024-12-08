namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct pthread_mutex_t
    {
        public int __private;
    }
}