namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JNINativeMethod
    {
        public byte* name;
        public byte* signature;
        public void* fnPtr;
    }
}