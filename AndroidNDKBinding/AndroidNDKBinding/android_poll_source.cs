namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct android_poll_source
    {
        public int id;
        public android_app* app;
        public delegate* unmanaged<android_app*, android_poll_source*, void> * process;
    }
}