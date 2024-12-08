namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JNIInvokeInterface
    {
        public void* reserved0;
        public void* reserved1;
        public void* reserved2;
        public delegate* unmanaged<_JavaVM*, int> * DestroyJavaVM;
        public delegate* unmanaged<_JavaVM*, _JNIEnv**, void*, int> * AttachCurrentThread;
        public delegate* unmanaged<_JavaVM*, int> * DetachCurrentThread;
        public delegate* unmanaged<_JavaVM*, void**, int, int> * GetEnv;
        public delegate* unmanaged<_JavaVM*, _JNIEnv**, void*, int> * AttachCurrentThreadAsDaemon;
    }
}