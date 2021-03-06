
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
		/// Value of GL_PIXEL_TRANSFORM_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_TRANSFORM_2D_EXT = 0x8330;

		/// <summary>
		/// Value of GL_PIXEL_MAG_FILTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_MAG_FILTER_EXT = 0x8331;

		/// <summary>
		/// Value of GL_PIXEL_MIN_FILTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_MIN_FILTER_EXT = 0x8332;

		/// <summary>
		/// Value of GL_PIXEL_CUBIC_WEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_CUBIC_WEIGHT_EXT = 0x8333;

		/// <summary>
		/// Value of GL_CUBIC_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int CUBIC_EXT = 0x8334;

		/// <summary>
		/// Value of GL_AVERAGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int AVERAGE_EXT = 0x8335;

		/// <summary>
		/// Value of GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;

		/// <summary>
		/// Value of GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;

		/// <summary>
		/// Value of GL_PIXEL_TRANSFORM_2D_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public const int PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;

		/// <summary>
		/// Binding for glPixelTransformParameteriEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void PixelTransformParameterEXT(Int32 target, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTransformParameteriEXT != null, "pglPixelTransformParameteriEXT not implemented");
			Delegates.pglPixelTransformParameteriEXT(target, pname, param);
			LogFunction("glPixelTransformParameteriEXT({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelTransformParameterfEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void PixelTransformParameterEXT(Int32 target, Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTransformParameterfEXT != null, "pglPixelTransformParameterfEXT not implemented");
			Delegates.pglPixelTransformParameterfEXT(target, pname, param);
			LogFunction("glPixelTransformParameterfEXT({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelTransformParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void PixelTransformParameterEXT(Int32 target, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTransformParameterivEXT != null, "pglPixelTransformParameterivEXT not implemented");
					Delegates.pglPixelTransformParameterivEXT(target, pname, p_params);
					LogFunction("glPixelTransformParameterivEXT({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelTransformParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void PixelTransformParameterEXT(Int32 target, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTransformParameterfvEXT != null, "pglPixelTransformParameterfvEXT not implemented");
					Delegates.pglPixelTransformParameterfvEXT(target, pname, p_params);
					LogFunction("glPixelTransformParameterfvEXT({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPixelTransformParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void GetPixelTransformParameterEXT(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTransformParameterivEXT != null, "pglGetPixelTransformParameterivEXT not implemented");
					Delegates.pglGetPixelTransformParameterivEXT(target, pname, p_params);
					LogFunction("glGetPixelTransformParameterivEXT({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPixelTransformParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_pixel_transform")]
		public static void GetPixelTransformParameterEXT(Int32 target, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTransformParameterfvEXT != null, "pglGetPixelTransformParameterfvEXT not implemented");
					Delegates.pglGetPixelTransformParameterfvEXT(target, pname, p_params);
					LogFunction("glGetPixelTransformParameterfvEXT({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelTransformParameteriEXT", ExactSpelling = true)]
			internal extern static void glPixelTransformParameteriEXT(Int32 target, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelTransformParameterfEXT", ExactSpelling = true)]
			internal extern static void glPixelTransformParameterfEXT(Int32 target, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelTransformParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glPixelTransformParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelTransformParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glPixelTransformParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPixelTransformParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelTransformParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPixelTransformParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelTransformParameterfvEXT(Int32 target, Int32 pname, float* @params);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransformParameteriEXT(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelTransformParameteriEXT pglPixelTransformParameteriEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransformParameterfEXT(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelTransformParameterfEXT pglPixelTransformParameterfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelTransformParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glPixelTransformParameterivEXT pglPixelTransformParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelTransformParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glPixelTransformParameterfvEXT pglPixelTransformParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelTransformParameterivEXT(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetPixelTransformParameterivEXT pglGetPixelTransformParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelTransformParameterfvEXT(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetPixelTransformParameterfvEXT pglGetPixelTransformParameterfvEXT;

		}
	}

}
