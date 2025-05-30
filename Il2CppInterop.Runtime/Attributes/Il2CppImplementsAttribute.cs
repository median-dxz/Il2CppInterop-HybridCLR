﻿using System;

namespace Il2CppInterop.Runtime.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class Il2CppImplementsAttribute : Attribute {
    public Il2CppImplementsAttribute(params Type[] interfaces) {
        Interfaces = interfaces;
    }

    public Type[] Interfaces { get; }
}
