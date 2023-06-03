﻿namespace NxEditor.Models;

public class ReactiveSingleton<T> : ReactiveObject where T : new()
{
    public static T Shared { get; } = new();
}