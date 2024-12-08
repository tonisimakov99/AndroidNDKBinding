namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct android_app
    {
        public void* userData;
        public delegate* unmanaged<android_app*, int, void> * onAppCmd;
        public delegate* unmanaged<android_app*, AInputEvent*, int> * onInputEvent;
        public ANativeActivity* activity;
        public AConfiguration* config;
        public void* savedState;
        public ulong savedStateSize;
        public ALooper* looper;
        public AInputQueue* inputQueue;
        public ANativeWindow* window;
        public ARect contentRect;
        public int activityState;
        public int destroyRequested;
        public pthread_mutex_t mutex;
        public pthread_cond_t cond;
        public int msgread;
        public int msgwrite;
        public int thread;
        public android_poll_source cmdPollSource;
        public android_poll_source inputPollSource;
        public int running;
        public int stateSaved;
        public int destroyed;
        public int redrawNeeded;
        public AInputQueue* pendingInputQueue;
        public ANativeWindow* pendingWindow;
        public ARect pendingContentRect;
    }
}