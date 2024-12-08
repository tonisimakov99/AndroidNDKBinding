using System.Runtime.InteropServices;

namespace AndroidNDKBinding
{
    public unsafe static class NativeAppGlue
    {
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte android_app_read_cmd(android_app* android_app);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void android_app_pre_exec_cmd(android_app* android_app, sbyte cmd);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void android_app_post_exec_cmd(android_app* android_app, sbyte cmd);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void app_dummy();
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void android_main(android_app* app);
    }
}