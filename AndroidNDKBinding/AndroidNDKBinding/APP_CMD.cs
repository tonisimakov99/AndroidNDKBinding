namespace AndroidNDKBinding
{
    public enum APP_CMD : int
    {
        APP_CMD_INPUT_CHANGED = 0,
        APP_CMD_INIT_WINDOW = 1,
        APP_CMD_TERM_WINDOW = 2,
        APP_CMD_WINDOW_RESIZED = 3,
        APP_CMD_WINDOW_REDRAW_NEEDED = 4,
        APP_CMD_CONTENT_RECT_CHANGED = 5,
        APP_CMD_GAINED_FOCUS = 6,
        APP_CMD_LOST_FOCUS = 7,
        APP_CMD_CONFIG_CHANGED = 8,
        APP_CMD_LOW_MEMORY = 9,
        APP_CMD_START = 10,
        APP_CMD_RESUME = 11,
        APP_CMD_SAVE_STATE = 12,
        APP_CMD_PAUSE = 13,
        APP_CMD_STOP = 14,
        APP_CMD_DESTROY = 15
    }
}