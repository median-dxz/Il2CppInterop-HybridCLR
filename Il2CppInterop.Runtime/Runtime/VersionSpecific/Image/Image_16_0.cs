using System;
using System.Runtime.InteropServices;
namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image {
    [ApplicableToUnityVersionsSince("5.2.2")]
    public unsafe class NativeImageStructHandler_16_0 : INativeImageStructHandler {
        public int Size() => sizeof(Il2CppImage_16_0);
        public INativeImageStruct CreateNewStruct() {
            IntPtr ptr = Marshal.AllocHGlobal(Size());
            Il2CppImage_16_0* _ = (Il2CppImage_16_0*)ptr;
            *_ = default;
            return new NativeStructWrapper(ptr);
        }
        public INativeImageStruct? Wrap(Il2CppImage* ptr) {
            if (ptr == null) return null;
            return new NativeStructWrapper((IntPtr)ptr);
        }
        internal unsafe struct Il2CppImage_16_0 {
            public byte* name;
            public int assemblyIndex;
            public int typeStart;
            public uint typeCount;
            public int entryPointIndex;
            public void* nameToClassHashTable;
        }

        internal class NativeStructWrapper : INativeImageStruct {
            public NativeStructWrapper(IntPtr ptr) => Pointer = ptr;
            private byte _dynamicDummy;
            public IntPtr Pointer { get; }
            private Il2CppImage_16_0* _ => (Il2CppImage_16_0*)Pointer;
            public Il2CppImage* ImagePointer => (Il2CppImage*)Pointer;
            public bool HasNameNoExt => false;
            public ref Il2CppAssembly* Assembly => throw new NotSupportedException();
            public ref byte Dynamic => ref _dynamicDummy;
            public ref IntPtr Name => ref *(IntPtr*)&_->name;
            public ref IntPtr NameNoExt => throw new NotSupportedException();
        }

    }

}
