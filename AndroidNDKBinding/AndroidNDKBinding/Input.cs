using System.Runtime.InteropServices;

namespace AndroidNDKBinding
{
    public unsafe static class Input
    {
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AInputEvent_getType(AInputEvent* _event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AInputEvent_getDeviceId(AInputEvent* _event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AInputEvent_getSource(AInputEvent* _event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AInputEvent_release(AInputEvent* _event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AKeyEvent_getAction(AInputEvent* key_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AKeyEvent_getFlags(AInputEvent* key_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AKeyEvent_getKeyCode(AInputEvent* key_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AKeyEvent_getScanCode(AInputEvent* key_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AKeyEvent_getMetaState(AInputEvent* key_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AKeyEvent_getRepeatCount(AInputEvent* key_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern long AKeyEvent_getDownTime(AInputEvent* key_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern long AKeyEvent_getEventTime(AInputEvent* key_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern AInputEvent* AKeyEvent_fromJava(_JNIEnv* env, _jobject* keyEvent);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getAction(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getFlags(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getMetaState(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getButtonState(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getEdgeFlags(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern long AMotionEvent_getDownTime(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern long AMotionEvent_getEventTime(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getXOffset(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getYOffset(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getXPrecision(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getYPrecision(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong AMotionEvent_getPointerCount(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getPointerId(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getToolType(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getRawX(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getRawY(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getX(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getY(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getPressure(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getSize(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getTouchMajor(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getTouchMinor(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getToolMajor(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getToolMinor(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getOrientation(AInputEvent* motion_event, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getAxisValue(AInputEvent* motion_event, int axis, ulong pointer_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong AMotionEvent_getHistorySize(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern long AMotionEvent_getHistoricalEventTime(AInputEvent* motion_event, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalRawX(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalRawY(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalX(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalY(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalPressure(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalSize(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalTouchMajor(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalTouchMinor(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalToolMajor(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalToolMinor(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalOrientation(AInputEvent* motion_event, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float AMotionEvent_getHistoricalAxisValue(AInputEvent* motion_event, int axis, ulong pointer_index, ulong history_index);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getActionButton(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AMotionEvent_getClassification(AInputEvent* motion_event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern AInputEvent* AMotionEvent_fromJava(_JNIEnv* env, _jobject* motionEvent);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AInputQueue_attachLooper(AInputQueue* queue, ALooper* looper, int ident, delegate* unmanaged<int, int, void*, int> * callback, void* data);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AInputQueue_detachLooper(AInputQueue* queue);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AInputQueue_hasEvents(AInputQueue* queue);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AInputQueue_getEvent(AInputQueue* queue, AInputEvent** outEvent);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AInputQueue_preDispatchEvent(AInputQueue* queue, AInputEvent* _event);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AInputQueue_finishEvent(AInputQueue* queue, AInputEvent* _event, int handled);
        [DllImport("libandroid.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern AInputQueue* AInputQueue_fromJava(_JNIEnv* env, _jobject* inputQueue);
    }
}