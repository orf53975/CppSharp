//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace Parser
    {
        public enum ParserDiagnosticLevel
        {
            Ignored = 0,
            Note = 1,
            Warning = 2,
            Error = 3,
            Fatal = 4
        }

        public enum ParserResultKind
        {
            Success = 0,
            Error = 1,
            FileNotFound = 2
        }

        public enum SourceLocationKind
        {
            Invalid = 0,
            Builtin = 1,
            CommandLine = 2,
            System = 3,
            User = 4
        }

        public unsafe partial class ParserOptions : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 100)]
            public struct Internal
            {
                [FieldOffset(0)]
                internal Std.Vector Arguments;

                [FieldOffset(12)]
                internal Std.String FileName;

                [FieldOffset(24)]
                internal Std.Vector IncludeDirs;

                [FieldOffset(36)]
                internal Std.Vector SystemIncludeDirs;

                [FieldOffset(48)]
                internal Std.Vector Defines;

                [FieldOffset(60)]
                internal Std.Vector LibraryDirs;

                [FieldOffset(72)]
                internal global::System.IntPtr ASTContext;

                [FieldOffset(76)]
                internal int ToolSetToUse;

                [FieldOffset(80)]
                internal Std.String TargetTriple;

                [FieldOffset(92)]
                internal CppSharp.Parser.AST.CppAbi Abi;

                [FieldOffset(96)]
                internal bool NoStandardIncludes;

                [FieldOffset(97)]
                internal bool NoBuiltinIncludes;

                [FieldOffset(98)]
                internal bool MicrosoftMode;

                [FieldOffset(99)]
                internal bool Verbose;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptionsC2Ev")]
                internal static extern void ctor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptionsC2ERKS1_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptionsD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions12getArgumentsEj")]
                internal static extern global::System.IntPtr getArguments_0(global::System.IntPtr instance, uint i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions12addArgumentsEPKc")]
                internal static extern void addArguments_0(global::System.IntPtr instance, global::System.IntPtr s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions14getIncludeDirsEj")]
                internal static extern global::System.IntPtr getIncludeDirs_0(global::System.IntPtr instance, uint i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions14addIncludeDirsEPKc")]
                internal static extern void addIncludeDirs_0(global::System.IntPtr instance, global::System.IntPtr s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions20getSystemIncludeDirsEj")]
                internal static extern global::System.IntPtr getSystemIncludeDirs_0(global::System.IntPtr instance, uint i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions20addSystemIncludeDirsEPKc")]
                internal static extern void addSystemIncludeDirs_0(global::System.IntPtr instance, global::System.IntPtr s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions10getDefinesEj")]
                internal static extern global::System.IntPtr getDefines_0(global::System.IntPtr instance, uint i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions10addDefinesEPKc")]
                internal static extern void addDefines_0(global::System.IntPtr instance, global::System.IntPtr s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions14getLibraryDirsEj")]
                internal static extern global::System.IntPtr getLibraryDirs_0(global::System.IntPtr instance, uint i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions14addLibraryDirsEPKc")]
                internal static extern void addLibraryDirs_0(global::System.IntPtr instance, global::System.IntPtr s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions17getArgumentsCountEv")]
                internal static extern uint getArgumentsCount_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions11getFileNameEv")]
                internal static extern global::System.IntPtr getFileName_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions11setFileNameEPKc")]
                internal static extern void setFileName_0(global::System.IntPtr instance, global::System.IntPtr s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions19getIncludeDirsCountEv")]
                internal static extern uint getIncludeDirsCount_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions25getSystemIncludeDirsCountEv")]
                internal static extern uint getSystemIncludeDirsCount_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions15getDefinesCountEv")]
                internal static extern uint getDefinesCount_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions19getLibraryDirsCountEv")]
                internal static extern uint getLibraryDirsCount_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions15getTargetTripleEv")]
                internal static extern global::System.IntPtr getTargetTriple_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser13ParserOptions15setTargetTripleEPKc")]
                internal static extern void setTargetTriple_0(global::System.IntPtr instance, global::System.IntPtr s);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            internal ParserOptions(ParserOptions.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserOptions(ParserOptions.Internal native)
                : this(&native)
            {
            }

            public ParserOptions(global::System.IntPtr native, bool isInternalImpl = false)
            {
                __Instance = native;
            }

            public ParserOptions()
            {
                __Instance = Marshal.AllocHGlobal(100);
                Internal.ctor_0(__Instance);
            }

            public ParserOptions(CppSharp.Parser.ParserOptions _0)
            {
                __Instance = Marshal.AllocHGlobal(100);
                var arg0 = _0 == (CppSharp.Parser.ParserOptions) null ? global::System.IntPtr.Zero : _0.__Instance;
                Internal.cctor_2(__Instance, arg0);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Internal.dtor_0(__Instance);
                Marshal.FreeHGlobal(__Instance);
            }

            public string getArguments(uint i)
            {
                var __ret = Internal.getArguments_0(__Instance, i);
                if (__ret == global::System.IntPtr.Zero) return null;
                return Marshal.PtrToStringAnsi(__ret);
            }

            public void addArguments(string s)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(s);
                Internal.addArguments_0(__Instance, arg0);
                Marshal.FreeHGlobal(arg0);
            }

            public string getIncludeDirs(uint i)
            {
                var __ret = Internal.getIncludeDirs_0(__Instance, i);
                if (__ret == global::System.IntPtr.Zero) return null;
                return Marshal.PtrToStringAnsi(__ret);
            }

            public void addIncludeDirs(string s)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(s);
                Internal.addIncludeDirs_0(__Instance, arg0);
                Marshal.FreeHGlobal(arg0);
            }

            public string getSystemIncludeDirs(uint i)
            {
                var __ret = Internal.getSystemIncludeDirs_0(__Instance, i);
                if (__ret == global::System.IntPtr.Zero) return null;
                return Marshal.PtrToStringAnsi(__ret);
            }

            public void addSystemIncludeDirs(string s)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(s);
                Internal.addSystemIncludeDirs_0(__Instance, arg0);
                Marshal.FreeHGlobal(arg0);
            }

            public string getDefines(uint i)
            {
                var __ret = Internal.getDefines_0(__Instance, i);
                if (__ret == global::System.IntPtr.Zero) return null;
                return Marshal.PtrToStringAnsi(__ret);
            }

            public void addDefines(string s)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(s);
                Internal.addDefines_0(__Instance, arg0);
                Marshal.FreeHGlobal(arg0);
            }

            public string getLibraryDirs(uint i)
            {
                var __ret = Internal.getLibraryDirs_0(__Instance, i);
                if (__ret == global::System.IntPtr.Zero) return null;
                return Marshal.PtrToStringAnsi(__ret);
            }

            public void addLibraryDirs(string s)
            {
                var arg0 = Marshal.StringToHGlobalAnsi(s);
                Internal.addLibraryDirs_0(__Instance, arg0);
                Marshal.FreeHGlobal(arg0);
            }

            public uint ArgumentsCount
            {
                get
                {
                    var __ret = Internal.getArgumentsCount_0(__Instance);
                    return __ret;
                }
            }

            public string FileName
            {
                get
                {
                    var __ret = Internal.getFileName_0(__Instance);
                    if (__ret == global::System.IntPtr.Zero) return null;
                    return Marshal.PtrToStringAnsi(__ret);
                }

                set
                {
                    var arg0 = Marshal.StringToHGlobalAnsi(value);
                    Internal.setFileName_0(__Instance, arg0);
                    Marshal.FreeHGlobal(arg0);
                }
            }

            public uint IncludeDirsCount
            {
                get
                {
                    var __ret = Internal.getIncludeDirsCount_0(__Instance);
                    return __ret;
                }
            }

            public uint SystemIncludeDirsCount
            {
                get
                {
                    var __ret = Internal.getSystemIncludeDirsCount_0(__Instance);
                    return __ret;
                }
            }

            public uint DefinesCount
            {
                get
                {
                    var __ret = Internal.getDefinesCount_0(__Instance);
                    return __ret;
                }
            }

            public uint LibraryDirsCount
            {
                get
                {
                    var __ret = Internal.getLibraryDirsCount_0(__Instance);
                    return __ret;
                }
            }

            public string TargetTriple
            {
                get
                {
                    var __ret = Internal.getTargetTriple_0(__Instance);
                    if (__ret == global::System.IntPtr.Zero) return null;
                    return Marshal.PtrToStringAnsi(__ret);
                }

                set
                {
                    var arg0 = Marshal.StringToHGlobalAnsi(value);
                    Internal.setTargetTriple_0(__Instance, arg0);
                    Marshal.FreeHGlobal(arg0);
                }
            }

            public CppSharp.Parser.AST.ASTContext ASTContext
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return (__ptr->ASTContext == IntPtr.Zero) ? null : new CppSharp.Parser.AST.ASTContext(__ptr->ASTContext);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ASTContext = value == (CppSharp.Parser.AST.ASTContext) null ? global::System.IntPtr.Zero : value.__Instance;
                }
            }

            public int ToolSetToUse
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->ToolSetToUse;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ToolSetToUse = value;
                }
            }

            public CppSharp.Parser.AST.CppAbi Abi
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Abi;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Abi = value;
                }
            }

            public bool NoStandardIncludes
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->NoStandardIncludes;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->NoStandardIncludes = value;
                }
            }

            public bool NoBuiltinIncludes
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->NoBuiltinIncludes;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->NoBuiltinIncludes = value;
                }
            }

            public bool MicrosoftMode
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->MicrosoftMode;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->MicrosoftMode = value;
                }
            }

            public bool Verbose
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Verbose;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Verbose = value;
                }
            }
        }

        public unsafe partial class ParserDiagnostic : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 36)]
            public struct Internal
            {
                [FieldOffset(0)]
                internal Std.String FileName;

                [FieldOffset(12)]
                internal Std.String Message;

                [FieldOffset(24)]
                internal CppSharp.Parser.ParserDiagnosticLevel Level;

                [FieldOffset(28)]
                internal int LineNumber;

                [FieldOffset(32)]
                internal int ColumnNumber;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserDiagnosticC2Ev")]
                internal static extern void ctor_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserDiagnosticC2ERKS1_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserDiagnosticD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserDiagnostic11getFileNameEv")]
                internal static extern global::System.IntPtr getFileName_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserDiagnostic11setFileNameEPKc")]
                internal static extern void setFileName_0(global::System.IntPtr instance, global::System.IntPtr s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserDiagnostic10getMessageEv")]
                internal static extern global::System.IntPtr getMessage_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserDiagnostic10setMessageEPKc")]
                internal static extern void setMessage_0(global::System.IntPtr instance, global::System.IntPtr s);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            internal ParserDiagnostic(ParserDiagnostic.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserDiagnostic(ParserDiagnostic.Internal native)
                : this(&native)
            {
            }

            public ParserDiagnostic(global::System.IntPtr native, bool isInternalImpl = false)
            {
                __Instance = native;
            }

            public ParserDiagnostic()
            {
                __Instance = Marshal.AllocHGlobal(36);
                Internal.ctor_1(__Instance);
            }

            public ParserDiagnostic(CppSharp.Parser.ParserDiagnostic _0)
            {
                __Instance = Marshal.AllocHGlobal(36);
                var arg0 = _0 == (CppSharp.Parser.ParserDiagnostic) null ? global::System.IntPtr.Zero : _0.__Instance;
                Internal.cctor_2(__Instance, arg0);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Internal.dtor_0(__Instance);
                Marshal.FreeHGlobal(__Instance);
            }

            public string FileName
            {
                get
                {
                    var __ret = Internal.getFileName_0(__Instance);
                    if (__ret == global::System.IntPtr.Zero) return null;
                    return Marshal.PtrToStringAnsi(__ret);
                }

                set
                {
                    var arg0 = Marshal.StringToHGlobalAnsi(value);
                    Internal.setFileName_0(__Instance, arg0);
                    Marshal.FreeHGlobal(arg0);
                }
            }

            public string Message
            {
                get
                {
                    var __ret = Internal.getMessage_0(__Instance);
                    if (__ret == global::System.IntPtr.Zero) return null;
                    return Marshal.PtrToStringAnsi(__ret);
                }

                set
                {
                    var arg0 = Marshal.StringToHGlobalAnsi(value);
                    Internal.setMessage_0(__Instance, arg0);
                    Marshal.FreeHGlobal(arg0);
                }
            }

            public CppSharp.Parser.ParserDiagnosticLevel Level
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Level;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Level = value;
                }
            }

            public int LineNumber
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LineNumber;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LineNumber = value;
                }
            }

            public int ColumnNumber
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->ColumnNumber;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ColumnNumber = value;
                }
            }
        }

        public unsafe partial class ParserResult : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public struct Internal
            {
                [FieldOffset(0)]
                internal CppSharp.Parser.ParserResultKind Kind;

                [FieldOffset(4)]
                internal Std.Vector Diagnostics;

                [FieldOffset(16)]
                internal global::System.IntPtr ASTContext;

                [FieldOffset(20)]
                internal global::System.IntPtr Library;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser12ParserResultC2Ev")]
                internal static extern void ctor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser12ParserResultC2ERKS1_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser12ParserResultD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser12ParserResult14getDiagnosticsEj")]
                internal static extern void getDiagnostics_0(global::System.IntPtr @return, global::System.IntPtr instance, uint i);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser12ParserResult14addDiagnosticsERNS0_16ParserDiagnosticE")]
                internal static extern void addDiagnostics_0(global::System.IntPtr instance, global::System.IntPtr s);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser12ParserResult19getDiagnosticsCountEv")]
                internal static extern uint getDiagnosticsCount_0(global::System.IntPtr instance);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            internal ParserResult(ParserResult.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserResult(ParserResult.Internal native)
                : this(&native)
            {
            }

            public ParserResult(global::System.IntPtr native, bool isInternalImpl = false)
            {
                __Instance = native;
            }

            public ParserResult()
            {
                __Instance = Marshal.AllocHGlobal(24);
                Internal.ctor_0(__Instance);
            }

            public ParserResult(CppSharp.Parser.ParserResult _0)
            {
                __Instance = Marshal.AllocHGlobal(24);
                var arg0 = _0 == (CppSharp.Parser.ParserResult) null ? global::System.IntPtr.Zero : _0.__Instance;
                Internal.cctor_2(__Instance, arg0);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Internal.dtor_0(__Instance);
                Marshal.FreeHGlobal(__Instance);
            }

            public CppSharp.Parser.ParserDiagnostic getDiagnostics(uint i)
            {
                var __ret = new CppSharp.Parser.ParserDiagnostic.Internal();
                Internal.getDiagnostics_0(new IntPtr(&__ret), __Instance, i);
                var __instance = Marshal.AllocHGlobal(36);
                CppSharp.Parser.ParserDiagnostic.Internal.cctor_2(__instance, new global::System.IntPtr(&__ret));
                return (__instance == IntPtr.Zero) ? null : new CppSharp.Parser.ParserDiagnostic(__instance);
            }

            public void addDiagnostics(CppSharp.Parser.ParserDiagnostic s)
            {
                var arg0 = s == (CppSharp.Parser.ParserDiagnostic) null ? global::System.IntPtr.Zero : s.__Instance;
                Internal.addDiagnostics_0(__Instance, arg0);
            }

            public uint DiagnosticsCount
            {
                get
                {
                    var __ret = Internal.getDiagnosticsCount_0(__Instance);
                    return __ret;
                }
            }

            public CppSharp.Parser.ParserResultKind Kind
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Kind;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Kind = value;
                }
            }

            public CppSharp.Parser.AST.ASTContext ASTContext
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return (__ptr->ASTContext == IntPtr.Zero) ? null : new CppSharp.Parser.AST.ASTContext(__ptr->ASTContext);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ASTContext = value == (CppSharp.Parser.AST.ASTContext) null ? global::System.IntPtr.Zero : value.__Instance;
                }
            }

            public CppSharp.Parser.AST.NativeLibrary Library
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return (__ptr->Library == IntPtr.Zero) ? null : new CppSharp.Parser.AST.NativeLibrary(__ptr->Library);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Library = value == (CppSharp.Parser.AST.NativeLibrary) null ? global::System.IntPtr.Zero : value.__Instance;
                }
            }
        }

        public unsafe partial class ClangParser : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 1)]
            public struct Internal
            {
                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser11ClangParserC2ERKS1_")]
                internal static extern void cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser11ClangParser11ParseHeaderEPNS0_13ParserOptionsE")]
                internal static extern global::System.IntPtr ParseHeader_0(global::System.IntPtr Opts);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser11ClangParser12ParseLibraryEPNS0_13ParserOptionsE")]
                internal static extern global::System.IntPtr ParseLibrary_0(global::System.IntPtr Opts);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser11ClangParser13GetTargetInfoEPNS0_13ParserOptionsE")]
                internal static extern global::System.IntPtr GetTargetInfo_0(global::System.IntPtr Opts);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            internal ClangParser(ClangParser.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ClangParser(ClangParser.Internal native)
                : this(&native)
            {
            }

            public ClangParser(global::System.IntPtr native, bool isInternalImpl = false)
            {
                __Instance = native;
            }

            public ClangParser()
            {
                __Instance = Marshal.AllocHGlobal(1);
            }

            public ClangParser(CppSharp.Parser.ClangParser _0)
            {
                __Instance = Marshal.AllocHGlobal(1);
                *((ClangParser.Internal*) __Instance) = *((ClangParser.Internal*) _0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public static CppSharp.Parser.ParserResult ParseHeader(CppSharp.Parser.ParserOptions Opts)
            {
                var arg0 = Opts == (CppSharp.Parser.ParserOptions) null ? global::System.IntPtr.Zero : Opts.__Instance;
                var __ret = Internal.ParseHeader_0(arg0);
                if (__ret == global::System.IntPtr.Zero) return null;
                return (__ret == IntPtr.Zero) ? null : new CppSharp.Parser.ParserResult(__ret);
            }

            public static CppSharp.Parser.ParserResult ParseLibrary(CppSharp.Parser.ParserOptions Opts)
            {
                var arg0 = Opts == (CppSharp.Parser.ParserOptions) null ? global::System.IntPtr.Zero : Opts.__Instance;
                var __ret = Internal.ParseLibrary_0(arg0);
                if (__ret == global::System.IntPtr.Zero) return null;
                return (__ret == IntPtr.Zero) ? null : new CppSharp.Parser.ParserResult(__ret);
            }

            public static CppSharp.Parser.ParserTargetInfo GetTargetInfo(CppSharp.Parser.ParserOptions Opts)
            {
                var arg0 = Opts == (CppSharp.Parser.ParserOptions) null ? global::System.IntPtr.Zero : Opts.__Instance;
                var __ret = Internal.GetTargetInfo_0(arg0);
                if (__ret == global::System.IntPtr.Zero) return null;
                return (__ret == IntPtr.Zero) ? null : new CppSharp.Parser.ParserTargetInfo(__ret);
            }
        }
    }
}
