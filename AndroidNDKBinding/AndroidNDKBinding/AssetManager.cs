using System.Runtime.InteropServices;

namespace AndroidNDKBinding
{
    public unsafe static class AssetManager
    {
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern AAssetDir* AAssetManager_openDir(AAssetManager* mgr, byte* dirName);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern AAsset* AAssetManager_open(AAssetManager* mgr, byte* filename, int mode);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* AAssetDir_getNextFileName(AAssetDir* assetDir);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AAssetDir_rewind(AAssetDir* assetDir);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AAssetDir_close(AAssetDir* assetDir);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AAsset_read(AAsset* asset, void* buf, ulong count);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AAsset_seek(AAsset* asset, int offset, int whence);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern long AAsset_seek64(AAsset* asset, long offset, int whence);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AAsset_close(AAsset* asset);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* AAsset_getBuffer(AAsset* asset);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AAsset_getLength(AAsset* asset);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern long AAsset_getLength64(AAsset* asset);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AAsset_getRemainingLength(AAsset* asset);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern long AAsset_getRemainingLength64(AAsset* asset);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AAsset_openFileDescriptor(AAsset* asset, int* outStart, int* outLength);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AAsset_openFileDescriptor64(AAsset* asset, long* outStart, long* outLength);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AAsset_isAllocated(AAsset* asset);
    }
}