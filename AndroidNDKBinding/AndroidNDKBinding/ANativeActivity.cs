namespace AndroidNDKBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ANativeActivity
    {
        public ANativeActivityCallbacks* callbacks;
        public _JavaVM* vm;
        public _JNIEnv* env;
        public _jobject* clazz;
        public byte* internalDataPath;
        public byte* externalDataPath;
        public int sdkVersion;
        public void* instance;
        public AAssetManager* assetManager;
        public byte* obbPath;
    }
}