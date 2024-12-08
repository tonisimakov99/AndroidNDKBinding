namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct __android_log_message
    {
        public ulong struct_size;
        public int buffer_id;
        public int priority;
        public byte* tag;
        public byte* file;
        public uint line;
        public byte* message;
    }
}