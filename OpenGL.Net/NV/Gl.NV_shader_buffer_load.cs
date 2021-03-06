
// Copyright (C) 2015-2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_BUFFER_GPU_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public const int BUFFER_GPU_ADDRESS_NV = 0x8F1D;

		/// <summary>
		/// Value of GL_GPU_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public const int GPU_ADDRESS_NV = 0x8F34;

		/// <summary>
		/// Value of GL_MAX_SHADER_BUFFER_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public const int MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;

		/// <summary>
		/// Binding for glMakeBufferResidentNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void MakeBufferResidentNV(Int32 target, Int32 access)
		{
			Debug.Assert(Delegates.pglMakeBufferResidentNV != null, "pglMakeBufferResidentNV not implemented");
			Delegates.pglMakeBufferResidentNV(target, access);
			LogFunction("glMakeBufferResidentNV({0}, {1})", LogEnumName(target), LogEnumName(access));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMakeBufferNonResidentNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void MakeBufferNonResidentNV(Int32 target)
		{
			Debug.Assert(Delegates.pglMakeBufferNonResidentNV != null, "pglMakeBufferNonResidentNV not implemented");
			Delegates.pglMakeBufferNonResidentNV(target);
			LogFunction("glMakeBufferNonResidentNV({0})", LogEnumName(target));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsBufferResidentNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static bool IsBufferResidentNV(Int32 target)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsBufferResidentNV != null, "pglIsBufferResidentNV not implemented");
			retValue = Delegates.pglIsBufferResidentNV(target);
			LogFunction("glIsBufferResidentNV({0}) = {1}", LogEnumName(target), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeNamedBufferResidentNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void MakeNamedBufferResidentNV(UInt32 buffer, Int32 access)
		{
			Debug.Assert(Delegates.pglMakeNamedBufferResidentNV != null, "pglMakeNamedBufferResidentNV not implemented");
			Delegates.pglMakeNamedBufferResidentNV(buffer, access);
			LogFunction("glMakeNamedBufferResidentNV({0}, {1})", buffer, LogEnumName(access));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMakeNamedBufferNonResidentNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void MakeNamedBufferNonResidentNV(UInt32 buffer)
		{
			Debug.Assert(Delegates.pglMakeNamedBufferNonResidentNV != null, "pglMakeNamedBufferNonResidentNV not implemented");
			Delegates.pglMakeNamedBufferNonResidentNV(buffer);
			LogFunction("glMakeNamedBufferNonResidentNV({0})", buffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsNamedBufferResidentNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static bool IsNamedBufferResidentNV(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsNamedBufferResidentNV != null, "pglIsNamedBufferResidentNV not implemented");
			retValue = Delegates.pglIsNamedBufferResidentNV(buffer);
			LogFunction("glIsNamedBufferResidentNV({0}) = {1}", buffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetBufferParameterui64vNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void GetBufferParameterNV(Int32 target, Int32 pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetBufferParameterui64vNV != null, "pglGetBufferParameterui64vNV not implemented");
					Delegates.pglGetBufferParameterui64vNV(target, pname, p_params);
					LogFunction("glGetBufferParameterui64vNV({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedBufferParameterui64vNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void GetNamedBufferParameterNV(UInt32 buffer, Int32 pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedBufferParameterui64vNV != null, "pglGetNamedBufferParameterui64vNV not implemented");
					Delegates.pglGetNamedBufferParameterui64vNV(buffer, pname, p_params);
					LogFunction("glGetNamedBufferParameterui64vNV({0}, {1}, {2})", buffer, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetIntegerui64vNV.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="result">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void GetIntegerNV(Int32 value, [Out] UInt64[] result)
		{
			unsafe {
				fixed (UInt64* p_result = result)
				{
					Debug.Assert(Delegates.pglGetIntegerui64vNV != null, "pglGetIntegerui64vNV not implemented");
					Delegates.pglGetIntegerui64vNV(value, p_result);
					LogFunction("glGetIntegerui64vNV({0}, {1})", LogEnumName(value), LogValue(result));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformui64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void UniformNV(Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglUniformui64NV != null, "pglUniformui64NV not implemented");
			Delegates.pglUniformui64NV(location, value);
			LogFunction("glUniformui64NV({0}, {1})", location, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformui64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void UniformNV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformui64vNV != null, "pglUniformui64vNV not implemented");
					Delegates.pglUniformui64vNV(location, count, p_value);
					LogFunction("glUniformui64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetUniformui64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void GetUniformNV(UInt32 program, Int32 location, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformui64vNV != null, "pglGetUniformui64vNV not implemented");
					Delegates.pglGetUniformui64vNV(program, location, p_params);
					LogFunction("glGetUniformui64vNV({0}, {1}, {2})", program, location, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformui64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void ProgramUniformNV(UInt32 program, Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglProgramUniformui64NV != null, "pglProgramUniformui64NV not implemented");
			Delegates.pglProgramUniformui64NV(program, location, value);
			LogFunction("glProgramUniformui64NV({0}, {1}, {2})", program, location, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformui64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void ProgramUniformNV(UInt32 program, Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformui64vNV != null, "pglProgramUniformui64vNV not implemented");
					Delegates.pglProgramUniformui64vNV(program, location, (Int32)value.Length, p_value);
					LogFunction("glProgramUniformui64vNV({0}, {1}, {2}, {3})", program, location, value.Length, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeBufferResidentNV", ExactSpelling = true)]
			internal extern static void glMakeBufferResidentNV(Int32 target, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeBufferNonResidentNV", ExactSpelling = true)]
			internal extern static void glMakeBufferNonResidentNV(Int32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsBufferResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsBufferResidentNV(Int32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeNamedBufferResidentNV", ExactSpelling = true)]
			internal extern static void glMakeNamedBufferResidentNV(UInt32 buffer, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeNamedBufferNonResidentNV", ExactSpelling = true)]
			internal extern static void glMakeNamedBufferNonResidentNV(UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsNamedBufferResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsNamedBufferResidentNV(UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetBufferParameterui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetBufferParameterui64vNV(Int32 target, Int32 pname, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedBufferParameterui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferParameterui64vNV(UInt32 buffer, Int32 pname, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetIntegerui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegerui64vNV(Int32 value, UInt64* result);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniformui64NV", ExactSpelling = true)]
			internal extern static void glUniformui64NV(Int32 location, UInt64 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniformui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformui64vNV(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetUniformui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformui64vNV(UInt32 program, Int32 location, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniformui64NV(UInt32 program, Int32 location, UInt64 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeBufferResidentNV(Int32 target, Int32 access);

			[ThreadStatic]
			internal static glMakeBufferResidentNV pglMakeBufferResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeBufferNonResidentNV(Int32 target);

			[ThreadStatic]
			internal static glMakeBufferNonResidentNV pglMakeBufferNonResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsBufferResidentNV(Int32 target);

			[ThreadStatic]
			internal static glIsBufferResidentNV pglIsBufferResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeNamedBufferResidentNV(UInt32 buffer, Int32 access);

			[ThreadStatic]
			internal static glMakeNamedBufferResidentNV pglMakeNamedBufferResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeNamedBufferNonResidentNV(UInt32 buffer);

			[ThreadStatic]
			internal static glMakeNamedBufferNonResidentNV pglMakeNamedBufferNonResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsNamedBufferResidentNV(UInt32 buffer);

			[ThreadStatic]
			internal static glIsNamedBufferResidentNV pglIsNamedBufferResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferParameterui64vNV(Int32 target, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetBufferParameterui64vNV pglGetBufferParameterui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferParameterui64vNV(UInt32 buffer, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetNamedBufferParameterui64vNV pglGetNamedBufferParameterui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetIntegerui64vNV(Int32 value, UInt64* result);

			[ThreadStatic]
			internal static glGetIntegerui64vNV pglGetIntegerui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformui64NV(Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glUniformui64NV pglUniformui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformui64vNV(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniformui64vNV pglUniformui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformui64vNV(UInt32 program, Int32 location, UInt64* @params);

			[ThreadStatic]
			internal static glGetUniformui64vNV pglGetUniformui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniformui64NV(UInt32 program, Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glProgramUniformui64NV pglProgramUniformui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glProgramUniformui64vNV pglProgramUniformui64vNV;

		}
	}

}
