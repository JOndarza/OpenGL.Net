
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
		/// Value of GL_LIST_PRIORITY_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public const int LIST_PRIORITY_SGIX = 0x8182;

		/// <summary>
		/// Binding for glGetListParameterfvSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void GetListParameterSGIX(UInt32 list, ListParameterName pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetListParameterfvSGIX != null, "pglGetListParameterfvSGIX not implemented");
					Delegates.pglGetListParameterfvSGIX(list, (Int32)pname, p_params);
					LogFunction("glGetListParameterfvSGIX({0}, {1}, {2})", list, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetListParameterivSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void GetListParameterSGIX(UInt32 list, ListParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetListParameterivSGIX != null, "pglGetListParameterivSGIX not implemented");
					Delegates.pglGetListParameterivSGIX(list, (Int32)pname, p_params);
					LogFunction("glGetListParameterivSGIX({0}, {1}, {2})", list, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glListParameterfSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglListParameterfSGIX != null, "pglListParameterfSGIX not implemented");
			Delegates.pglListParameterfSGIX(list, (Int32)pname, param);
			LogFunction("glListParameterfSGIX({0}, {1}, {2})", list, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glListParameterfvSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglListParameterfvSGIX != null, "pglListParameterfvSGIX not implemented");
					Delegates.pglListParameterfvSGIX(list, (Int32)pname, p_params);
					LogFunction("glListParameterfvSGIX({0}, {1}, {2})", list, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glListParameteriSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglListParameteriSGIX != null, "pglListParameteriSGIX not implemented");
			Delegates.pglListParameteriSGIX(list, (Int32)pname, param);
			LogFunction("glListParameteriSGIX({0}, {1}, {2})", list, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glListParameterivSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglListParameterivSGIX != null, "pglListParameterivSGIX not implemented");
					Delegates.pglListParameterivSGIX(list, (Int32)pname, p_params);
					LogFunction("glListParameterivSGIX({0}, {1}, {2})", list, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetListParameterfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetListParameterivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glListParameterfSGIX", ExactSpelling = true)]
			internal extern static void glListParameterfSGIX(UInt32 list, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glListParameterfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glListParameteriSGIX", ExactSpelling = true)]
			internal extern static void glListParameteriSGIX(UInt32 list, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glListParameterivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetListParameterfvSGIX pglGetListParameterfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetListParameterivSGIX pglGetListParameterivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glListParameterfSGIX(UInt32 list, Int32 pname, float param);

			[ThreadStatic]
			internal static glListParameterfSGIX pglListParameterfSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glListParameterfvSGIX pglListParameterfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glListParameteriSGIX(UInt32 list, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glListParameteriSGIX pglListParameteriSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glListParameterivSGIX pglListParameterivSGIX;

		}
	}

}
