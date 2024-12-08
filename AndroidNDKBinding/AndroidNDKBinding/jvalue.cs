namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct jvalue
    {
        public byte z;
        public sbyte b;
        public ushort c;
        public short s;
        public int i;
        public long j;
        public float f;
        public double d;
        public _jobject* l;
    }
}