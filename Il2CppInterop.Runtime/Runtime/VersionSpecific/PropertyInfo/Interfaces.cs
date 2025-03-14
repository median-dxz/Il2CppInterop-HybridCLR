﻿using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo;

public interface INativePropertyInfoStructHandler : INativeStructHandler {
    INativePropertyInfoStruct CreateNewStruct();
    unsafe INativePropertyInfoStruct Wrap(Il2CppPropertyInfo* propertyInfoPointer);
}

public interface INativePropertyInfoStruct : INativeStruct {
    unsafe Il2CppPropertyInfo* PropertyInfoPointer { get; }

    ref IntPtr Name { get; }

    unsafe ref Il2CppClass* Parent { get; }

    unsafe ref Il2CppMethodInfo* Get { get; }

    unsafe ref Il2CppMethodInfo* Set { get; }

    ref uint Attrs { get; }
}
