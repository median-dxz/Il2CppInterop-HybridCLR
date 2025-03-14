using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo;

public interface INativeParameterInfoStructHandler : INativeStructHandler {
    unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount);
    unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoPointer);
    unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoListBegin, int index);
    bool HasNamePosToken { get; }
#if DEBUG
    string GetName();
#endif
}

public interface INativeParameterInfoStruct : INativeStruct {
    unsafe Il2CppParameterInfo* ParameterInfoPointer { get; }
    bool HasNamePosToken { get; }
    ref IntPtr Name { get; }
    ref int Position { get; }
    ref uint Token { get; }
    unsafe ref Il2CppTypeStruct* ParameterType { get; }
}
