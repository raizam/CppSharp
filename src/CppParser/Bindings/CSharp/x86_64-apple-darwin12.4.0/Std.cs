//----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CppSharp.Parser.CSharp")]

[assembly:InternalsVisibleTo("CppSharp.CppParser")]

namespace Std
{
}

namespace Std
{
    namespace __1
    {
    }
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
    namespace __1
    {
    }
}

namespace Std
{
    public unsafe partial class ExceptionPtr
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public global::System.IntPtr __ptr_;
        }
    }
}

namespace Std
{
}

public unsafe partial class Sbuf
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public global::System.IntPtr _base;

        [FieldOffset(8)]
        public int _size;
    }
}

public unsafe partial class DarwinSigaltstack
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public global::System.IntPtr ss_sp;

        [FieldOffset(8)]
        public ulong ss_size;

        [FieldOffset(16)]
        public int ss_flags;
    }
}

public unsafe partial class Timeval
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public long tv_sec;

        [FieldOffset(8)]
        public int tv_usec;
    }
}

public unsafe partial class RuneRange
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public int __nranges;

        [FieldOffset(8)]
        public global::System.IntPtr __ranges;
    }
}

namespace Std
{
    namespace __1
    {
    }
}

namespace Std
{
    namespace __1
    {
    }
}

namespace Std
{
}

namespace Std
{
    namespace __1
    {
        namespace Tuple
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public unsafe partial struct __Internal
            {
            }
        }
    }
}

namespace Std
{
    namespace __1
    {
        public unsafe partial class Allocator : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public unsafe partial struct __Internal
            {
                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSt3__19allocatorIcEC2Ev")]
                internal static extern void ctor_0(global::System.IntPtr instance);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            protected int __PointerAdjustment;
            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Allocator> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Allocator>();
            protected void*[] __OriginalVTables;

            protected bool __ownsNativeInstance;

            internal static Allocator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
            {
                return new Allocator(native.ToPointer(), skipVTables);
            }

            internal static Allocator __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new Allocator(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(0);
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private Allocator(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected Allocator(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new global::System.IntPtr(native);
            }

            public Allocator()
            {
                __Instance = Marshal.AllocHGlobal(0);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                global::Std.__1.Allocator.__Internal.ctor_0((__Instance + __PointerAdjustment));
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            public virtual void Dispose(bool disposing)
            {
                global::Std.__1.Allocator __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }
        }


        public unsafe partial class Rebind
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }
        namespace CompressedPair
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::Std.__1.BasicString.Rep.__Internal __first_;
            }
        }

        public unsafe partial class PointerSafety
        {
            [StructLayout(LayoutKind.Explicit, Size = 4)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::Std.__1.PointerSafety.Lx __v_;
            }

            public enum Lx : uint
            {
                relaxed = 0,
                preferred = 1,
                strict = 2
            }
        }
    }
}

public unsafe partial struct Sigval
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public int sival_int;

        [FieldOffset(0)]
        public global::System.IntPtr sival_ptr;
    }
}

public unsafe partial struct SigactionU
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public global::System.IntPtr __sa_handler;

        [FieldOffset(0)]
        public global::System.IntPtr __sa_sigaction;
    }
}

public unsafe partial class DarwinI386ThreadState
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public uint __eax;

        [FieldOffset(4)]
        public uint __ebx;

        [FieldOffset(8)]
        public uint __ecx;

        [FieldOffset(12)]
        public uint __edx;

        [FieldOffset(16)]
        public uint __edi;

        [FieldOffset(20)]
        public uint __esi;

        [FieldOffset(24)]
        public uint __ebp;

        [FieldOffset(28)]
        public uint __esp;

        [FieldOffset(32)]
        public uint __ss;

        [FieldOffset(36)]
        public uint __eflags;

        [FieldOffset(40)]
        public uint __eip;

        [FieldOffset(44)]
        public uint __cs;

        [FieldOffset(48)]
        public uint __ds;

        [FieldOffset(52)]
        public uint __es;

        [FieldOffset(56)]
        public uint __fs;

        [FieldOffset(60)]
        public uint __gs;
    }
}

public unsafe partial class DarwinFpControl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public ushort __invalid;

        [FieldOffset(0)]
        public ushort __denorm;

        [FieldOffset(0)]
        public ushort __zdiv;

        [FieldOffset(0)]
        public ushort __ovrfl;

        [FieldOffset(0)]
        public ushort __undfl;

        [FieldOffset(0)]
        public ushort __precis;

        [FieldOffset(0)]
        public ushort _;

        [FieldOffset(1)]
        public ushort __pc;

        [FieldOffset(1)]
        public ushort __rc;

        [FieldOffset(1)]
        public ushort _1;

        [FieldOffset(1)]
        public ushort _2;
    }
}

public unsafe partial class DarwinFpStatus
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public ushort __invalid;

        [FieldOffset(0)]
        public ushort __denorm;

        [FieldOffset(0)]
        public ushort __zdiv;

        [FieldOffset(0)]
        public ushort __ovrfl;

        [FieldOffset(0)]
        public ushort __undfl;

        [FieldOffset(0)]
        public ushort __precis;

        [FieldOffset(0)]
        public ushort __stkflt;

        [FieldOffset(0)]
        public ushort __errsumm;

        [FieldOffset(1)]
        public ushort __c0;

        [FieldOffset(1)]
        public ushort __c1;

        [FieldOffset(1)]
        public ushort __c2;

        [FieldOffset(1)]
        public ushort __tos;

        [FieldOffset(1)]
        public ushort __c3;

        [FieldOffset(1)]
        public ushort __busy;
    }
}

public unsafe partial class DarwinMmstReg
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public fixed sbyte __mmst_reg[10];

        [FieldOffset(10)]
        public fixed sbyte __mmst_rsrv[6];
    }
}

public unsafe partial class DarwinXmmReg
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public fixed sbyte __xmm_reg[16];
    }
}

public unsafe partial class DarwinI386FloatState
{
    [StructLayout(LayoutKind.Explicit, Size = 524)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public fixed int __fpu_reserved[2];

        [FieldOffset(8)]
        internal global::DarwinFpControl.__Internal __fpu_fcw;

        [FieldOffset(10)]
        internal global::DarwinFpStatus.__Internal __fpu_fsw;

        [FieldOffset(12)]
        public byte __fpu_ftw;

        [FieldOffset(13)]
        public byte __fpu_rsrv1;

        [FieldOffset(14)]
        public ushort __fpu_fop;

        [FieldOffset(16)]
        public uint __fpu_ip;

        [FieldOffset(20)]
        public ushort __fpu_cs;

        [FieldOffset(22)]
        public ushort __fpu_rsrv2;

        [FieldOffset(24)]
        public uint __fpu_dp;

        [FieldOffset(28)]
        public ushort __fpu_ds;

        [FieldOffset(30)]
        public ushort __fpu_rsrv3;

        [FieldOffset(32)]
        public uint __fpu_mxcsr;

        [FieldOffset(36)]
        public uint __fpu_mxcsrmask;

        [FieldOffset(40)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm0;

        [FieldOffset(56)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm1;

        [FieldOffset(72)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm2;

        [FieldOffset(88)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm3;

        [FieldOffset(104)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm4;

        [FieldOffset(120)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm5;

        [FieldOffset(136)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm6;

        [FieldOffset(152)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm7;

        [FieldOffset(168)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm0;

        [FieldOffset(184)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm1;

        [FieldOffset(200)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm2;

        [FieldOffset(216)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm3;

        [FieldOffset(232)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm4;

        [FieldOffset(248)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm5;

        [FieldOffset(264)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm6;

        [FieldOffset(280)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm7;

        [FieldOffset(296)]
        public fixed sbyte __fpu_rsrv4[224];

        [FieldOffset(520)]
        public int __fpu_reserved1;
    }
}

public unsafe partial class DarwinI386AvxState
{
    [StructLayout(LayoutKind.Explicit, Size = 716)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public fixed int __fpu_reserved[2];

        [FieldOffset(8)]
        internal global::DarwinFpControl.__Internal __fpu_fcw;

        [FieldOffset(10)]
        internal global::DarwinFpStatus.__Internal __fpu_fsw;

        [FieldOffset(12)]
        public byte __fpu_ftw;

        [FieldOffset(13)]
        public byte __fpu_rsrv1;

        [FieldOffset(14)]
        public ushort __fpu_fop;

        [FieldOffset(16)]
        public uint __fpu_ip;

        [FieldOffset(20)]
        public ushort __fpu_cs;

        [FieldOffset(22)]
        public ushort __fpu_rsrv2;

        [FieldOffset(24)]
        public uint __fpu_dp;

        [FieldOffset(28)]
        public ushort __fpu_ds;

        [FieldOffset(30)]
        public ushort __fpu_rsrv3;

        [FieldOffset(32)]
        public uint __fpu_mxcsr;

        [FieldOffset(36)]
        public uint __fpu_mxcsrmask;

        [FieldOffset(40)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm0;

        [FieldOffset(56)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm1;

        [FieldOffset(72)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm2;

        [FieldOffset(88)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm3;

        [FieldOffset(104)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm4;

        [FieldOffset(120)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm5;

        [FieldOffset(136)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm6;

        [FieldOffset(152)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm7;

        [FieldOffset(168)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm0;

        [FieldOffset(184)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm1;

        [FieldOffset(200)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm2;

        [FieldOffset(216)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm3;

        [FieldOffset(232)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm4;

        [FieldOffset(248)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm5;

        [FieldOffset(264)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm6;

        [FieldOffset(280)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm7;

        [FieldOffset(296)]
        public fixed sbyte __fpu_rsrv4[224];

        [FieldOffset(520)]
        public int __fpu_reserved1;

        [FieldOffset(524)]
        public fixed sbyte __avx_reserved1[64];

        [FieldOffset(588)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh0;

        [FieldOffset(604)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh1;

        [FieldOffset(620)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh2;

        [FieldOffset(636)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh3;

        [FieldOffset(652)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh4;

        [FieldOffset(668)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh5;

        [FieldOffset(684)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh6;

        [FieldOffset(700)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh7;
    }
}

public unsafe partial class DarwinI386ExceptionState
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public ushort __trapno;

        [FieldOffset(2)]
        public ushort __cpu;

        [FieldOffset(4)]
        public uint __err;

        [FieldOffset(8)]
        public uint __faultvaddr;
    }
}

public unsafe partial class DarwinX86ThreadState64
{
    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public ulong __rax;

        [FieldOffset(8)]
        public ulong __rbx;

        [FieldOffset(16)]
        public ulong __rcx;

        [FieldOffset(24)]
        public ulong __rdx;

        [FieldOffset(32)]
        public ulong __rdi;

        [FieldOffset(40)]
        public ulong __rsi;

        [FieldOffset(48)]
        public ulong __rbp;

        [FieldOffset(56)]
        public ulong __rsp;

        [FieldOffset(64)]
        public ulong __r8;

        [FieldOffset(72)]
        public ulong __r9;

        [FieldOffset(80)]
        public ulong __r10;

        [FieldOffset(88)]
        public ulong __r11;

        [FieldOffset(96)]
        public ulong __r12;

        [FieldOffset(104)]
        public ulong __r13;

        [FieldOffset(112)]
        public ulong __r14;

        [FieldOffset(120)]
        public ulong __r15;

        [FieldOffset(128)]
        public ulong __rip;

        [FieldOffset(136)]
        public ulong __rflags;

        [FieldOffset(144)]
        public ulong __cs;

        [FieldOffset(152)]
        public ulong __fs;

        [FieldOffset(160)]
        public ulong __gs;
    }
}

public unsafe partial class DarwinX86FloatState64
{
    [StructLayout(LayoutKind.Explicit, Size = 524)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public fixed int __fpu_reserved[2];

        [FieldOffset(8)]
        internal global::DarwinFpControl.__Internal __fpu_fcw;

        [FieldOffset(10)]
        internal global::DarwinFpStatus.__Internal __fpu_fsw;

        [FieldOffset(12)]
        public byte __fpu_ftw;

        [FieldOffset(13)]
        public byte __fpu_rsrv1;

        [FieldOffset(14)]
        public ushort __fpu_fop;

        [FieldOffset(16)]
        public uint __fpu_ip;

        [FieldOffset(20)]
        public ushort __fpu_cs;

        [FieldOffset(22)]
        public ushort __fpu_rsrv2;

        [FieldOffset(24)]
        public uint __fpu_dp;

        [FieldOffset(28)]
        public ushort __fpu_ds;

        [FieldOffset(30)]
        public ushort __fpu_rsrv3;

        [FieldOffset(32)]
        public uint __fpu_mxcsr;

        [FieldOffset(36)]
        public uint __fpu_mxcsrmask;

        [FieldOffset(40)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm0;

        [FieldOffset(56)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm1;

        [FieldOffset(72)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm2;

        [FieldOffset(88)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm3;

        [FieldOffset(104)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm4;

        [FieldOffset(120)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm5;

        [FieldOffset(136)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm6;

        [FieldOffset(152)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm7;

        [FieldOffset(168)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm0;

        [FieldOffset(184)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm1;

        [FieldOffset(200)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm2;

        [FieldOffset(216)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm3;

        [FieldOffset(232)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm4;

        [FieldOffset(248)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm5;

        [FieldOffset(264)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm6;

        [FieldOffset(280)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm7;

        [FieldOffset(296)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm8;

        [FieldOffset(312)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm9;

        [FieldOffset(328)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm10;

        [FieldOffset(344)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm11;

        [FieldOffset(360)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm12;

        [FieldOffset(376)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm13;

        [FieldOffset(392)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm14;

        [FieldOffset(408)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm15;

        [FieldOffset(424)]
        public fixed sbyte __fpu_rsrv4[96];

        [FieldOffset(520)]
        public int __fpu_reserved1;
    }
}

public unsafe partial class DarwinX86AvxState64
{
    [StructLayout(LayoutKind.Explicit, Size = 844)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public fixed int __fpu_reserved[2];

        [FieldOffset(8)]
        internal global::DarwinFpControl.__Internal __fpu_fcw;

        [FieldOffset(10)]
        internal global::DarwinFpStatus.__Internal __fpu_fsw;

        [FieldOffset(12)]
        public byte __fpu_ftw;

        [FieldOffset(13)]
        public byte __fpu_rsrv1;

        [FieldOffset(14)]
        public ushort __fpu_fop;

        [FieldOffset(16)]
        public uint __fpu_ip;

        [FieldOffset(20)]
        public ushort __fpu_cs;

        [FieldOffset(22)]
        public ushort __fpu_rsrv2;

        [FieldOffset(24)]
        public uint __fpu_dp;

        [FieldOffset(28)]
        public ushort __fpu_ds;

        [FieldOffset(30)]
        public ushort __fpu_rsrv3;

        [FieldOffset(32)]
        public uint __fpu_mxcsr;

        [FieldOffset(36)]
        public uint __fpu_mxcsrmask;

        [FieldOffset(40)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm0;

        [FieldOffset(56)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm1;

        [FieldOffset(72)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm2;

        [FieldOffset(88)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm3;

        [FieldOffset(104)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm4;

        [FieldOffset(120)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm5;

        [FieldOffset(136)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm6;

        [FieldOffset(152)]
        internal global::DarwinMmstReg.__Internal __fpu_stmm7;

        [FieldOffset(168)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm0;

        [FieldOffset(184)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm1;

        [FieldOffset(200)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm2;

        [FieldOffset(216)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm3;

        [FieldOffset(232)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm4;

        [FieldOffset(248)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm5;

        [FieldOffset(264)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm6;

        [FieldOffset(280)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm7;

        [FieldOffset(296)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm8;

        [FieldOffset(312)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm9;

        [FieldOffset(328)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm10;

        [FieldOffset(344)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm11;

        [FieldOffset(360)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm12;

        [FieldOffset(376)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm13;

        [FieldOffset(392)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm14;

        [FieldOffset(408)]
        internal global::DarwinXmmReg.__Internal __fpu_xmm15;

        [FieldOffset(424)]
        public fixed sbyte __fpu_rsrv4[96];

        [FieldOffset(520)]
        public int __fpu_reserved1;

        [FieldOffset(524)]
        public fixed sbyte __avx_reserved1[64];

        [FieldOffset(588)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh0;

        [FieldOffset(604)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh1;

        [FieldOffset(620)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh2;

        [FieldOffset(636)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh3;

        [FieldOffset(652)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh4;

        [FieldOffset(668)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh5;

        [FieldOffset(684)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh6;

        [FieldOffset(700)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh7;

        [FieldOffset(716)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh8;

        [FieldOffset(732)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh9;

        [FieldOffset(748)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh10;

        [FieldOffset(764)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh11;

        [FieldOffset(780)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh12;

        [FieldOffset(796)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh13;

        [FieldOffset(812)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh14;

        [FieldOffset(828)]
        internal global::DarwinXmmReg.__Internal __fpu_ymmh15;
    }
}

public unsafe partial class DarwinX86ExceptionState64
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public ushort __trapno;

        [FieldOffset(2)]
        public ushort __cpu;

        [FieldOffset(4)]
        public uint __err;

        [FieldOffset(8)]
        public ulong __faultvaddr;
    }
}

public unsafe partial struct Wait
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct __Internal
    {
        [FieldOffset(0)]
        public int w_status;

        [FieldOffset(0)]
        internal global::Wait._.__Internal w_T;

        [FieldOffset(0)]
        internal global::Wait.__.__Internal w_S;
    }

    public unsafe partial class _
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public uint w_Termsig;

            [FieldOffset(0)]
            public uint w_Coredump;

            [FieldOffset(1)]
            public uint w_Retcode;

            [FieldOffset(2)]
            public uint w_Filler;
        }
    }

    public unsafe partial class __
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            public uint w_Stopval;

            [FieldOffset(1)]
            public uint w_Stopsig;

            [FieldOffset(2)]
            public uint w_Filler;
        }
    }
}

namespace Std
{
}

namespace Std
{
    namespace __1
    {
    }
}

namespace Std
{
}

namespace Std
{
}

namespace Std
{
    namespace __1
    {
        namespace Vector
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                public global::System.IntPtr __begin_;

                [FieldOffset(8)]
                public global::System.IntPtr __end_;

                [FieldOffset(16)]
                internal global::Std.__1.CompressedPair.__Internal __end_cap_;
            }
        }
    }
}

namespace Std
{
    namespace __1
    {
        namespace Tree
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                public global::System.IntPtr __begin_node_;

                [FieldOffset(8)]
                internal global::Std.__1.CompressedPair.__Internal __pair1_;

                [FieldOffset(16)]
                internal global::Std.__1.CompressedPair.__Internal __pair3_;
            }
        }

        namespace TreeEndNode
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public unsafe partial struct __Internal_Ptr
            {
                [FieldOffset(0)]
                public global::System.IntPtr __left_;
            }
        }
    }
}

namespace Std
{
    namespace __1
    {
    }
}

namespace Std
{
    namespace __1
    {
        namespace Map
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::Std.__1.Tree.__Internal __tree_;
            }


            public unsafe partial class ValueCompare
            {
                [StructLayout(LayoutKind.Explicit, Size = 0)]
                public partial struct __Internal
                {
                }
            }
        }
    }
}

namespace Std
{
}

namespace Std
{
    namespace __1
    {
        public unsafe partial class BasicString : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public unsafe partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::Std.__1.CompressedPair.__Internal __r_;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNSt3__112basic_stringIcNS_11char_traitsIcEENS_9allocatorIcEEED2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("Std-templates", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZNKSt3__112basic_stringIcNS_11char_traitsIcEENS_9allocatorIcEEE5c_strEv")]
                internal static extern global::System.IntPtr CStr_0(global::System.IntPtr instance);
            }

            internal enum ShortMask : uint
            {
                __short_mask = 0x1
            }

            internal enum LongMask : uint
            {
                __long_mask = 0x1
            }

            internal enum MinCap : uint
            {
                __min_cap = 23
            }

            internal enum NWords : uint
            {
                __n_words = 3
            }

            [Flags]
            internal enum Alignment : uint
            {
                __alignment = 16
            }

            public unsafe partial class Rep
            {
                [StructLayout(LayoutKind.Explicit, Size = 24)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::Std.__1.BasicString.Rep._.__Internal _;
                }

                public unsafe partial struct _
                {
                    [StructLayout(LayoutKind.Explicit, Size = 24)]
                    public partial struct __Internal
                    {
                        [FieldOffset(0)]
                        internal global::Std.__1.BasicString.Long.__Internal __l;

                        [FieldOffset(0)]
                        internal global::Std.__1.BasicString.Short.__Internal __s;

                        [FieldOffset(0)]
                        internal global::Std.__1.BasicString.Raw.__Internal __r;
                    }
                }
            }

            public unsafe partial class Long
            {
                [StructLayout(LayoutKind.Explicit, Size = 24)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    public ulong __cap_;

                    [FieldOffset(8)]
                    public ulong __size_;

                    [FieldOffset(16)]
                    public global::System.IntPtr __data_;
                }
            }

            public unsafe partial class Short
            {
                [StructLayout(LayoutKind.Explicit, Size = 24)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::Std.__1.BasicString.Short._.__Internal _;

                    [FieldOffset(1)]
                    public fixed sbyte __data_[23];
                }

                public unsafe partial struct _
                {
                    [StructLayout(LayoutKind.Explicit, Size = 1)]
                    public partial struct __Internal
                    {
                        [FieldOffset(0)]
                        public byte __size_;

                        [FieldOffset(0)]
                        public sbyte __lx;
                    }
                }
            }

            public unsafe partial class Raw
            {
                [StructLayout(LayoutKind.Explicit, Size = 24)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    public fixed ulong __words[3];
                }
            }

            public unsafe partial struct Ulx
            {
                [StructLayout(LayoutKind.Explicit, Size = 24)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::Std.__1.BasicString.Long.__Internal __lx;

                    [FieldOffset(0)]
                    internal global::Std.__1.BasicString.Short.__Internal __lxx;
                }
            }

            public global::System.IntPtr __Instance { get; protected set; }

            protected int __PointerAdjustment;
            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, BasicString> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, BasicString>();
            protected void*[] __OriginalVTables;

            protected bool __ownsNativeInstance;

            internal static BasicString __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
            {
                return new BasicString(native.ToPointer(), skipVTables);
            }

            internal static BasicString __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new BasicString(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(24);
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private BasicString(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected BasicString(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new global::System.IntPtr(native);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            public virtual void Dispose(bool disposing)
            {
                global::Std.__1.BasicString __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (disposing)
                    global::Std.__1.BasicString.__Internal.dtor_0((__Instance + __PointerAdjustment));
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public string CStr
            {
                get
                {
                    var __ret = global::Std.__1.BasicString.__Internal.CStr_0((__Instance + __PointerAdjustment));
                    return Marshal.PtrToStringAnsi(__ret);
                }
            }
        }


        public unsafe partial class Long
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial class Short
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial struct Ulx
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial class Raw
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }

        }

        public unsafe partial class Rep
        {
            [StructLayout(LayoutKind.Explicit, Size = 0)]
            public partial struct __Internal
            {
            }
        }
    }
}
