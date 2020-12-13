﻿using System;

public class EventBroker
{
    public static Action GameOver,win, RetryLevel;
    public static Action<int> updateLifeInUi;

    public static void CallGameOver()
    {
        GameOver?.Invoke();
    }

    public static void CallWin()
    {
        win?.Invoke();
    }

    public static void CallUpdateLifeInUi(int life)
    {
        updateLifeInUi?.Invoke(life);
    }

    public static void CallRetryLevel()
    {
        RetryLevel?.Invoke();
    }

}
