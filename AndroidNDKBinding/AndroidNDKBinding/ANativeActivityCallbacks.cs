namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ANativeActivityCallbacks
    {
        public delegate* unmanaged<ANativeActivity*, void> * onStart;
        public delegate* unmanaged<ANativeActivity*, void> * onResume;
        public delegate* unmanaged<ANativeActivity*, ulong*, void*> * onSaveInstanceState;
        public delegate* unmanaged<ANativeActivity*, void> * onPause;
        public delegate* unmanaged<ANativeActivity*, void> * onStop;
        public delegate* unmanaged<ANativeActivity*, void> * onDestroy;
        public delegate* unmanaged<ANativeActivity*, int, void> * onWindowFocusChanged;
        public delegate* unmanaged<ANativeActivity*, ANativeWindow*, void> * onNativeWindowCreated;
        public delegate* unmanaged<ANativeActivity*, ANativeWindow*, void> * onNativeWindowResized;
        public delegate* unmanaged<ANativeActivity*, ANativeWindow*, void> * onNativeWindowRedrawNeeded;
        public delegate* unmanaged<ANativeActivity*, ANativeWindow*, void> * onNativeWindowDestroyed;
        public delegate* unmanaged<ANativeActivity*, AInputQueue*, void> * onInputQueueCreated;
        public delegate* unmanaged<ANativeActivity*, AInputQueue*, void> * onInputQueueDestroyed;
        public delegate* unmanaged<ANativeActivity*, ARect*, void> * onContentRectChanged;
        public delegate* unmanaged<ANativeActivity*, void> * onConfigurationChanged;
        public delegate* unmanaged<ANativeActivity*, void> * onLowMemory;
    }
}