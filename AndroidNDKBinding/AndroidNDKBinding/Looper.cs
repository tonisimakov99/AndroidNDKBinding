using System.Runtime.InteropServices;

namespace AndroidNDKBinding
{
    public unsafe static class Looper
    {
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern ALooper* ALooper_forThread();
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern ALooper* ALooper_prepare(int opts);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ALooper_acquire(ALooper* looper);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ALooper_release(ALooper* looper);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ALooper_pollOnce(int timeoutMillis, int* outFd, int* outEvents, void** outData);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ALooper_pollAll(int timeoutMillis, int* outFd, int* outEvents, void** outData);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ALooper_wake(ALooper* looper);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ALooper_addFd(ALooper* looper, int fd, int ident, int events, delegate* unmanaged<int, int, void*, int> * callback, void* data);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ALooper_removeFd(ALooper* looper, int fd);
    }
}