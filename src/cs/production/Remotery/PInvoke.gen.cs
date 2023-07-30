
// <auto-generated>
//  This code was generated by the following tool on 2023-07-30 03:19:30 GMT-04:00:
//      https://github.com/bottlenoselabs/c2cs (v6.1.2.0)
//
//  Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ReSharper disable All

#region Template
#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS8981
using bottlenoselabs.C2CS.Runtime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
#endregion

using System.Numerics;
using static Remotery.PInvoke;

namespace Remotery;

public static unsafe partial class PInvoke
{
    private const string LibraryName = "Remotery";

    #region API

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "dummy")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void Dummy();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_BeginCPUSample")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtBeginCPUSample(RmtPStr name, RmtU32 flags, RmtU32* hashCache);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_CreateGlobalInstance")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtError RmtCreateGlobalInstance(Remotery** remotery);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_DestroyGlobalInstance")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtDestroyGlobalInstance(Remotery* remotery);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_EndCPUSample")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtEndCPUSample();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_GetGlobalInstance")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial Remotery* RmtGetGlobalInstance();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "rmt_GetLastErrorMessage")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtPStr RmtGetLastErrorMessage();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_HashString32")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtU32 RmtHashString32(CString s, int len, RmtU32 seed);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_IterateChildren")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtIterateChildren(RmtSampleIterator* iter, RmtSample* sample);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_IterateNext")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtBool RmtIterateNext(RmtSampleIterator* iter);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_LogText")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtLogText(RmtPStr text);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_MarkFrame")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtError RmtMarkFrame();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyAddValue")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtPropertyAddValue(RmtProperty* property, RmtPropertyValue addValue);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyFrameResetAll")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtPropertyFrameResetAll();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyGetDescription")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CString RmtPropertyGetDescription(RmtProperty* property);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyGetName")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CString RmtPropertyGetName(RmtProperty* property);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyGetNameHash")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtU32 RmtPropertyGetNameHash(RmtProperty* property);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyGetType")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtPropertyType RmtPropertyGetType(RmtProperty* property);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyGetValue")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtPropertyValue RmtPropertyGetValue(RmtProperty* property);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyIterateChildren")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtPropertyIterateChildren(RmtPropertyIterator* iter, RmtProperty* property);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertyIterateNext")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtBool RmtPropertyIterateNext(RmtPropertyIterator* iter);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertySetValue")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtPropertySetValue(RmtProperty* property);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_PropertySnapshotAll")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtError RmtPropertySnapshotAll();

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleGetCallCount")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtU32 RmtSampleGetCallCount(RmtSample* sample);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleGetColour")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtSampleGetColour(RmtSample* sample, RmtU8* r, RmtU8* g, RmtU8* b);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleGetName")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CString RmtSampleGetName(RmtSample* sample);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleGetNameHash")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtU32 RmtSampleGetNameHash(RmtSample* sample);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleGetSelfTime")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtU64 RmtSampleGetSelfTime(RmtSample* sample);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleGetStart")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtU64 RmtSampleGetStart(RmtSample* sample);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleGetTime")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtU64 RmtSampleGetTime(RmtSample* sample);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleGetType")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtSampleType RmtSampleGetType(RmtSample* sample);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleTreeGetRootSample")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial RmtSample* RmtSampleTreeGetRootSample(RmtSampleTree* sampleTree);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SampleTreeGetThreadName")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial CString RmtSampleTreeGetThreadName(RmtSampleTree* sampleTree);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SetCurrentThreadName")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtSetCurrentThreadName(RmtPStr threadName);

    [CNode(Kind = "Function")]
    [LibraryImport(LibraryName, EntryPoint = "_rmt_SetGlobalInstance")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RmtSetGlobalInstance(Remotery* remotery);

    // [CNode(Kind = "Function")]
    // [LibraryImport(LibraryName, EntryPoint = "_rmt_Settings")]
    // [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    // public static partial RmtSettings* RmtSettings();

    #endregion

    #region Types

    [CNode(Kind = "FunctionPointer")]
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_CString_VoidPtr_Void
    {
        public delegate* unmanaged<CString, void*, void> Pointer;
    }

    [CNode(Kind = "FunctionPointer")]
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_VoidPtr_RmtPropertyPtr_Void
    {
        public delegate* unmanaged<void*, RmtProperty*, void> Pointer;
    }

    [CNode(Kind = "FunctionPointer")]
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_VoidPtr_RmtSampleTreePtr_Void
    {
        public delegate* unmanaged<void*, RmtSampleTree*, void> Pointer;
    }

    [CNode(Kind = "FunctionPointer")]
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_VoidPtr_RmtU32_VoidPtr
    {
        public delegate* unmanaged<void*, RmtU32, void*> Pointer;
    }

    [CNode(Kind = "FunctionPointer")]
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_VoidPtr_VoidPtr_RmtU32_VoidPtr
    {
        public delegate* unmanaged<void*, void*, RmtU32, void*> Pointer;
    }

    [CNode(Kind = "FunctionPointer")]
    [StructLayout(LayoutKind.Sequential)]
    public struct FnPtr_VoidPtr_VoidPtr_Void
    {
        public delegate* unmanaged<void*, void*, void> Pointer;
    }

    [CNode(Kind = "Struct")]
    [StructLayout(LayoutKind.Explicit, Size = 64, Pack = 8)]
    public struct RmtCUDABind
    {
        [FieldOffset(0)] // size = 8
        public void* Context;

        [FieldOffset(8)] // size = 8
        public void* CtxSetCurrent;

        [FieldOffset(16)] // size = 8
        public void* CtxGetCurrent;

        [FieldOffset(24)] // size = 8
        public void* EventCreate;

        [FieldOffset(32)] // size = 8
        public void* EventDestroy;

        [FieldOffset(40)] // size = 8
        public void* EventRecord;

        [FieldOffset(48)] // size = 8
        public void* EventQuery;

        [FieldOffset(56)] // size = 8
        public void* EventElapsedTime;
    }

    [CNode(Kind = "Struct")]
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct RmtD3D12Bind
    {
        [FieldOffset(0)] // size = 8
        public void* Device;

        [FieldOffset(8)] // size = 8
        public void* Queue;
    }

    [CNode(Kind = "Struct")]
    [StructLayout(LayoutKind.Explicit, Size = 112, Pack = 8)]
    public struct RmtProperty
    {
        [FieldOffset(0)] // size = 4
        public RmtBool Initialised;

        [FieldOffset(4)] // size = 4
        public RmtPropertyType Type;

        [FieldOffset(8)] // size = 4
        public RmtPropertyFlags Flags;

        [FieldOffset(16)] // size = 8
        public RmtPropertyValue Value;

        [FieldOffset(24)] // size = 8
        public RmtPropertyValue LastFrameValue;

        [FieldOffset(32)] // size = 8
        public RmtPropertyValue PrevValue;

        [FieldOffset(40)] // size = 4
        public RmtU32 PrevValueFrame;

        [FieldOffset(48)] // size = 8
        public CString _Name;

        public string Name
        {
            get
            {
                return CString.ToString(_Name);
            }
            set
            {
                _Name = CString.FromString(value);
            }
        }

        [FieldOffset(56)] // size = 8
        public CString _Description;

        public string Description
        {
            get
            {
                return CString.ToString(_Description);
            }
            set
            {
                _Description = CString.FromString(value);
            }
        }

        [FieldOffset(64)] // size = 8
        public RmtPropertyValue DefaultValue;

        [FieldOffset(72)] // size = 8
        public RmtProperty* Parent;

        [FieldOffset(80)] // size = 8
        public RmtProperty* FirstChild;

        [FieldOffset(88)] // size = 8
        public RmtProperty* LastChild;

        [FieldOffset(96)] // size = 8
        public RmtProperty* NextSibling;

        [FieldOffset(104)] // size = 4
        public RmtU32 NameHash;

        [FieldOffset(108)] // size = 4
        public RmtU32 UniqueID;
    }

    [CNode(Kind = "Struct")]
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct RmtPropertyIterator
    {
        [FieldOffset(0)] // size = 8
        public RmtProperty* Property;

        [FieldOffset(8)] // size = 8
        public RmtProperty* Initial;
    }

    [CNode(Kind = "Union")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtPropertyValue
    {
        [FieldOffset(0)] // size = 4
        public RmtBool Bool;

        [FieldOffset(0)] // size = 4
        public RmtS32 S32;

        [FieldOffset(0)] // size = 4
        public RmtU32 U32;

        [FieldOffset(0)] // size = 4
        public RmtF32 F32;

        [FieldOffset(0)] // size = 8
        public RmtS64 S64;

        [FieldOffset(0)] // size = 8
        public RmtU64 U64;

        [FieldOffset(0)] // size = 8
        public RmtF64 F64;
    }

    [CNode(Kind = "Struct")]
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public struct RmtSampleIterator
    {
        [FieldOffset(0)] // size = 8
        public RmtSample* Sample;

        [FieldOffset(8)] // size = 8
        public RmtSample* Initial;
    }

    [CNode(Kind = "Struct")]
    [StructLayout(LayoutKind.Explicit, Size = 120, Pack = 8)]
    public struct RmtSettings
    {
        [FieldOffset(0)] // size = 2
        public RmtU16 Port;

        [FieldOffset(4)] // size = 4
        public RmtBool ReuseOpenPort;

        [FieldOffset(8)] // size = 4
        public RmtBool LimitConnectionsToLocalhost;

        [FieldOffset(12)] // size = 4
        public RmtBool EnableThreadSampler;

        [FieldOffset(16)] // size = 4
        public RmtU32 MsSleepBetweenServerUpdates;

        [FieldOffset(20)] // size = 4
        public RmtU32 MessageQueueSizeInBytes;

        [FieldOffset(24)] // size = 4
        public RmtU32 MaxNbMessagesPerUpdate;

        [FieldOffset(32)] // size = 8
        public RmtMallocPtr Malloc;

        [FieldOffset(40)] // size = 8
        public RmtReallocPtr Realloc;

        [FieldOffset(48)] // size = 8
        public RmtFreePtr Free;

        [FieldOffset(56)] // size = 8
        public void* MmContext;

        [FieldOffset(64)] // size = 8
        public RmtInputHandlerPtr InputHandler;

        [FieldOffset(72)] // size = 8
        public RmtSampleTreeHandlerPtr SampletreeHandler;

        [FieldOffset(80)] // size = 8
        public void* SampletreeContext;

        [FieldOffset(88)] // size = 8
        public RmtPropertyHandlerPtr SnapshotCallback;

        [FieldOffset(96)] // size = 8
        public void* SnapshotContext;

        [FieldOffset(104)] // size = 8
        public void* InputHandlerContext;

        [FieldOffset(112)] // size = 8
        public RmtPStr LogPath;
    }

    [CNode(Kind = "Enum")]
    public enum RmtError : int
    {
        RMTERRORNONE = 0,
        RMTERRORRECURSIVESAMPLE = 1,
        RMTERRORUNKNOWN = 2,
        RMTERRORINVALIDINPUT = 3,
        RMTERRORRESOURCECREATEFAIL = 4,
        RMTERRORRESOURCEACCESSFAIL = 5,
        RMTERRORTIMEOUT = 6,
        RMTERRORMALLOCFAIL = 7,
        RMTERRORTLSALLOCFAIL = 8,
        RMTERRORVIRTUALMEMORYBUFFERFAIL = 9,
        RMTERRORCREATETHREADFAIL = 10,
        RMTERROROPENTHREADHANDLEFAIL = 11,
        RMTERRORSOCKETINVALIDPOLL = 12,
        RMTERRORSOCKETSELECTFAIL = 13,
        RMTERRORSOCKETPOLLERRORS = 14,
        RMTERRORSOCKETSENDFAIL = 15,
        RMTERRORSOCKETRECVNODATA = 16,
        RMTERRORSOCKETRECVTIMEOUT = 17,
        RMTERRORSOCKETRECVFAILED = 18,
        RMTERRORWEBSOCKETHANDSHAKENOTGET = 19,
        RMTERRORWEBSOCKETHANDSHAKENOVERSION = 20,
        RMTERRORWEBSOCKETHANDSHAKEBADVERSION = 21,
        RMTERRORWEBSOCKETHANDSHAKENOHOST = 22,
        RMTERRORWEBSOCKETHANDSHAKEBADHOST = 23,
        RMTERRORWEBSOCKETHANDSHAKENOKEY = 24,
        RMTERRORWEBSOCKETHANDSHAKEBADKEY = 25,
        RMTERRORWEBSOCKETHANDSHAKESTRINGFAIL = 26,
        RMTERRORWEBSOCKETDISCONNECTED = 27,
        RMTERRORWEBSOCKETBADFRAMEHEADER = 28,
        RMTERRORWEBSOCKETBADFRAMEHEADERSIZE = 29,
        RMTERRORWEBSOCKETBADFRAMEHEADERMASK = 30,
        RMTERRORWEBSOCKETRECEIVETIMEOUT = 31,
        RMTERRORREMOTERYNOTCREATED = 32,
        RMTERRORSENDONINCOMPLETEPROFILE = 33,
        RMTERRORCUDADEINITIALIZED = 34,
        RMTERRORCUDANOTINITIALIZED = 35,
        RMTERRORCUDAINVALIDCONTEXT = 36,
        RMTERRORCUDAINVALIDVALUE = 37,
        RMTERRORCUDAINVALIDHANDLE = 38,
        RMTERRORCUDAOUTOFMEMORY = 39,
        RMTERRORERRORNOTREADY = 40,
        RMTERRORD3D11FAILEDTOCREATEQUERY = 41,
        RMTERROROPENGLERROR = 42,
        RMTERRORCUDAUNKNOWN = 43
    }

    [CNode(Kind = "Enum")]
    public enum RmtPropertyFlags : int
    {
        RMTPropertyFlagsNoFlags = 0,
        RMTPropertyFlagsFrameReset = 1
    }

    [CNode(Kind = "Enum")]
    public enum RmtPropertyType : int
    {
        RMTPropertyTypeRmtGroup = 0,
        RMTPropertyTypeRmtBool = 1,
        RMTPropertyTypeRmtS32 = 2,
        RMTPropertyTypeRmtU32 = 3,
        RMTPropertyTypeRmtF32 = 4,
        RMTPropertyTypeRmtS64 = 5,
        RMTPropertyTypeRmtU64 = 6,
        RMTPropertyTypeRmtF64 = 7
    }

    [CNode(Kind = "Enum")]
    public enum RmtSampleFlags : int
    {
        RMTSFNone = 0,
        RMTSFAggregate = 1,
        RMTSFRecursive = 2,
        RMTSFRoot = 4,
        RMTSFSendOnClose = 8
    }

    [CNode(Kind = "Enum")]
    public enum RmtSampleType : int
    {
        RMTSampleTypeCPU = 0,
        RMTSampleTypeCUDA = 1,
        RMTSampleTypeD3D11 = 2,
        RMTSampleTypeD3D12 = 3,
        RMTSampleTypeOpenGL = 4,
        RMTSampleTypeMetal = 5,
        RMTSampleTypeCount = 6
    }

    [CNode(Kind = "OpaqueType")]
    [StructLayout(LayoutKind.Sequential)]
    public struct Remotery
    {
    }

    [CNode(Kind = "OpaqueType")]
    [StructLayout(LayoutKind.Sequential)]
    public struct RmtSample
    {
    }

    [CNode(Kind = "OpaqueType")]
    [StructLayout(LayoutKind.Sequential)]
    public struct RmtSampleTree
    {
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct RmtBool
    {
        [FieldOffset(0)]
        public uint Data;

        public static implicit operator uint(RmtBool data) => data.Data;
        public static implicit operator RmtBool(uint data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct RmtF32
    {
        [FieldOffset(0)]
        public float Data;

        public static implicit operator float(RmtF32 data) => data.Data;
        public static implicit operator RmtF32(float data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtF64
    {
        [FieldOffset(0)]
        public Double Data;

        public static implicit operator Double(RmtF64 data) => data.Data;
        public static implicit operator RmtF64(Double data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtFreePtr
    {
        [FieldOffset(0)]
        public FnPtr_VoidPtr_VoidPtr_Void Data;

        public static implicit operator FnPtr_VoidPtr_VoidPtr_Void(RmtFreePtr data) => data.Data;
        public static implicit operator RmtFreePtr(FnPtr_VoidPtr_VoidPtr_Void data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtInputHandlerPtr
    {
        [FieldOffset(0)]
        public FnPtr_CString_VoidPtr_Void Data;

        public static implicit operator FnPtr_CString_VoidPtr_Void(RmtInputHandlerPtr data) => data.Data;
        public static implicit operator RmtInputHandlerPtr(FnPtr_CString_VoidPtr_Void data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtMallocPtr
    {
        [FieldOffset(0)]
        public FnPtr_VoidPtr_RmtU32_VoidPtr Data;

        public static implicit operator FnPtr_VoidPtr_RmtU32_VoidPtr(RmtMallocPtr data) => data.Data;
        public static implicit operator RmtMallocPtr(FnPtr_VoidPtr_RmtU32_VoidPtr data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtPStr
    {
        [FieldOffset(0)]
        public CString Data;

        public static implicit operator CString(RmtPStr data) => data.Data;
        public static implicit operator RmtPStr(CString data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtPropertyHandlerPtr
    {
        [FieldOffset(0)]
        public FnPtr_VoidPtr_RmtPropertyPtr_Void Data;

        public static implicit operator FnPtr_VoidPtr_RmtPropertyPtr_Void(RmtPropertyHandlerPtr data) => data.Data;
        public static implicit operator RmtPropertyHandlerPtr(FnPtr_VoidPtr_RmtPropertyPtr_Void data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtReallocPtr
    {
        [FieldOffset(0)]
        public FnPtr_VoidPtr_VoidPtr_RmtU32_VoidPtr Data;

        public static implicit operator FnPtr_VoidPtr_VoidPtr_RmtU32_VoidPtr(RmtReallocPtr data) => data.Data;
        public static implicit operator RmtReallocPtr(FnPtr_VoidPtr_VoidPtr_RmtU32_VoidPtr data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct RmtS32
    {
        [FieldOffset(0)]
        public int Data;

        public static implicit operator int(RmtS32 data) => data.Data;
        public static implicit operator RmtS32(int data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtS64
    {
        [FieldOffset(0)]
        public long Data;

        public static implicit operator long(RmtS64 data) => data.Data;
        public static implicit operator RmtS64(long data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtSampleTreeHandlerPtr
    {
        [FieldOffset(0)]
        public FnPtr_VoidPtr_RmtSampleTreePtr_Void Data;

        public static implicit operator FnPtr_VoidPtr_RmtSampleTreePtr_Void(RmtSampleTreeHandlerPtr data) => data.Data;
        public static implicit operator RmtSampleTreeHandlerPtr(FnPtr_VoidPtr_RmtSampleTreePtr_Void data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 2, Pack = 2)]
    public struct RmtU16
    {
        [FieldOffset(0)]
        public ushort Data;

        public static implicit operator ushort(RmtU16 data) => data.Data;
        public static implicit operator RmtU16(ushort data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 4, Pack = 4)]
    public struct RmtU32
    {
        [FieldOffset(0)]
        public uint Data;

        public static implicit operator uint(RmtU32 data) => data.Data;
        public static implicit operator RmtU32(uint data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 8)]
    public struct RmtU64
    {
        [FieldOffset(0)]
        public ulong Data;

        public static implicit operator ulong(RmtU64 data) => data.Data;
        public static implicit operator RmtU64(ulong data) => new() { Data = data };
    }

    [CNode(Kind = "TypeAlias")]
    [StructLayout(LayoutKind.Explicit, Size = 1, Pack = 1)]
    public struct RmtU8
    {
        [FieldOffset(0)]
        public byte Data;

        public static implicit operator byte(RmtU8 data) => data.Data;
        public static implicit operator RmtU8(byte data) => new() { Data = data };
    }

    [CNode(Kind = "MacroObject")]
    public const int RmtAssumeLittleEndian = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtD3d11ResyncOnDisjoint = 1;

    [CNode(Kind = "MacroObject")]
    public const int RmtEnabled = 1;

    [CNode(Kind = "MacroObject")]
    public static RmtBool RmtFalse = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtGpuCpuSyncNumIterations = 16;

    [CNode(Kind = "MacroObject")]
    public const int RmtGpuCpuSyncSeconds = 30;

    [CNode(Kind = "MacroObject")]
    public static RmtBool RmtTrue = 1;

    [CNode(Kind = "MacroObject")]
    public const int RmtUseCuda = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtUseD3d11 = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtUseD3d12 = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtUseInternalHashFunction = 1;

    [CNode(Kind = "MacroObject")]
    public const int RmtUseLegacyAtomics = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtUseMetal = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtUseOpengl = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtUsePosixThreadnames = 0;

    [CNode(Kind = "MacroObject")]
    public const int RmtUseTinycrt = 0;

    #endregion
}
