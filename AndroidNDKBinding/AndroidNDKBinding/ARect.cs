namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ARect
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }
}