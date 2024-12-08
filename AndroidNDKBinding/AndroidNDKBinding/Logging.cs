using System.Runtime.InteropServices;

namespace AndroidNDKBinding
{
    public unsafe static class Logging
    {
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_write(android_LogPriority prio, byte* tag, byte* text);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_print(android_LogPriority prio, byte* tag, byte* fmt);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_vprint(android_LogPriority prio, byte* tag, byte* fmt, byte* ap);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_assert(byte* cond, byte* tag, byte* fmt);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_buf_write(int bufID, android_LogPriority prio, byte* tag, byte* text);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_buf_print(int bufID, android_LogPriority prio, byte* tag, byte* fmt);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_write_log_message(__android_log_message* log_message);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_set_logger(delegate* unmanaged<__android_log_message*, void> * logger);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_logd_logger(__android_log_message* log_message);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_stderr_logger(__android_log_message* log_message);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_set_aborter(delegate* unmanaged<byte*, void> * aborter);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_call_aborter(byte* abort_message);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_default_aborter(byte* abort_message);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_is_loggable(android_LogPriority prio, byte* tag, int default_prio);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_is_loggable_len(android_LogPriority prio, byte* tag, ulong len, int default_prio);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_set_minimum_priority(int priority);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int __android_log_get_minimum_priority();
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void __android_log_set_default_tag(byte* tag);
    }
}