
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_GPU_VENDOR_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_VENDOR_AMD = 0x1F00;

		/// <summary>
		/// Value of GLX_GPU_RENDERER_STRING_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_RENDERER_STRING_AMD = 0x1F01;

		/// <summary>
		/// Value of GLX_GPU_OPENGL_VERSION_STRING_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_OPENGL_VERSION_STRING_AMD = 0x1F02;

		/// <summary>
		/// Value of GLX_GPU_FASTEST_TARGET_GPUS_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_FASTEST_TARGET_GPUS_AMD = 0x21A2;

		/// <summary>
		/// Value of GLX_GPU_RAM_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_RAM_AMD = 0x21A3;

		/// <summary>
		/// Value of GLX_GPU_CLOCK_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_CLOCK_AMD = 0x21A4;

		/// <summary>
		/// Value of GLX_GPU_NUM_PIPES_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_NUM_PIPES_AMD = 0x21A5;

		/// <summary>
		/// Value of GLX_GPU_NUM_SIMD_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_NUM_SIMD_AMD = 0x21A6;

		/// <summary>
		/// Value of GLX_GPU_NUM_RB_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_NUM_RB_AMD = 0x21A7;

		/// <summary>
		/// Value of GLX_GPU_NUM_SPI_AMD symbol.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public const int GPU_NUM_SPI_AMD = 0x21A8;

		/// <summary>
		/// Binding for glXGetGPUIDsAMD.
		/// </summary>
		/// <param name="maxCount">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static UInt32 GetAMD(UInt32 maxCount, [Out] UInt32[] ids)
		{
			UInt32 retValue;

			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglXGetGPUIDsAMD != null, "pglXGetGPUIDsAMD not implemented");
					retValue = Delegates.pglXGetGPUIDsAMD(maxCount, p_ids);
					LogFunction("glXGetGPUIDsAMD({0}, {1}) = {2}", maxCount, LogValue(ids), retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXGetGPUInfoAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="property">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dataType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static int GetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data)
		{
			int retValue;

			Debug.Assert(Delegates.pglXGetGPUInfoAMD != null, "pglXGetGPUInfoAMD not implemented");
			retValue = Delegates.pglXGetGPUInfoAMD(id, property, dataType, size, data);
			LogFunction("glXGetGPUInfoAMD({0}, {1}, {2}, {3}, 0x{4}) = {5}", id, property, LogEnumName(dataType), size, data.ToString("X8"), retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXGetContextGPUIDAMD.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static UInt32 GetContextAMD(IntPtr ctx)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglXGetContextGPUIDAMD != null, "pglXGetContextGPUIDAMD not implemented");
			retValue = Delegates.pglXGetContextGPUIDAMD(ctx);
			LogFunction("glXGetContextGPUIDAMD(0x{0}) = {1}", ctx.ToString("X8"), retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXCreateAssociatedContextAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="share_list">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static IntPtr CreateAssociatedContextAMD(UInt32 id, IntPtr share_list)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateAssociatedContextAMD != null, "pglXCreateAssociatedContextAMD not implemented");
			retValue = Delegates.pglXCreateAssociatedContextAMD(id, share_list);
			LogFunction("glXCreateAssociatedContextAMD({0}, 0x{1}) = {2}", id, share_list.ToString("X8"), retValue.ToString("X8"));

			return (retValue);
		}

		/// <summary>
		/// Binding for glXCreateAssociatedContextAttribsAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="share_context">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static IntPtr CreateAssociatedContextAttribsAMD(UInt32 id, IntPtr share_context, int[] attribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pglXCreateAssociatedContextAttribsAMD != null, "pglXCreateAssociatedContextAttribsAMD not implemented");
					retValue = Delegates.pglXCreateAssociatedContextAttribsAMD(id, share_context, p_attribList);
					LogFunction("glXCreateAssociatedContextAttribsAMD({0}, 0x{1}, {2}) = {3}", id, share_context.ToString("X8"), LogValue(attribList), retValue.ToString("X8"));
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXDeleteAssociatedContextAMD.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static bool DeleteAssociatedContextAMD(IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXDeleteAssociatedContextAMD != null, "pglXDeleteAssociatedContextAMD not implemented");
			retValue = Delegates.pglXDeleteAssociatedContextAMD(ctx);
			LogFunction("glXDeleteAssociatedContextAMD(0x{0}) = {1}", ctx.ToString("X8"), retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXMakeAssociatedContextCurrentAMD.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static bool MakeAssociatedContextCurrentAMD(IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXMakeAssociatedContextCurrentAMD != null, "pglXMakeAssociatedContextCurrentAMD not implemented");
			retValue = Delegates.pglXMakeAssociatedContextCurrentAMD(ctx);
			LogFunction("glXMakeAssociatedContextCurrentAMD(0x{0}) = {1}", ctx.ToString("X8"), retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXGetCurrentAssociatedContextAMD.
		/// </summary>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static IntPtr GetCurrentAssociatedContextAMD()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetCurrentAssociatedContextAMD != null, "pglXGetCurrentAssociatedContextAMD not implemented");
			retValue = Delegates.pglXGetCurrentAssociatedContextAMD();
			LogFunction("glXGetCurrentAssociatedContextAMD() = {0}", retValue.ToString("X8"));

			return (retValue);
		}

		/// <summary>
		/// Binding for glXBlitContextFramebufferAMD.
		/// </summary>
		/// <param name="dstCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="srcX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GLX_AMD_gpu_association")]
		public static void BlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter)
		{
			Debug.Assert(Delegates.pglXBlitContextFramebufferAMD != null, "pglXBlitContextFramebufferAMD not implemented");
			Delegates.pglXBlitContextFramebufferAMD(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			LogFunction("glXBlitContextFramebufferAMD(0x{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", dstCtx.ToString("X8"), srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, LogEnumName(filter));
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetGPUIDsAMD", ExactSpelling = true)]
			internal extern static unsafe UInt32 glXGetGPUIDsAMD(UInt32 maxCount, UInt32* ids);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetGPUInfoAMD", ExactSpelling = true)]
			internal extern static unsafe int glXGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetContextGPUIDAMD", ExactSpelling = true)]
			internal extern static unsafe UInt32 glXGetContextGPUIDAMD(IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateAssociatedContextAMD", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateAssociatedContextAMD(UInt32 id, IntPtr share_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateAssociatedContextAttribsAMD", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr share_context, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDeleteAssociatedContextAMD", ExactSpelling = true)]
			internal extern static unsafe bool glXDeleteAssociatedContextAMD(IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXMakeAssociatedContextCurrentAMD", ExactSpelling = true)]
			internal extern static unsafe bool glXMakeAssociatedContextCurrentAMD(IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentAssociatedContextAMD", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentAssociatedContextAMD();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBlitContextFramebufferAMD", ExactSpelling = true)]
			internal extern static unsafe void glXBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glXGetGPUIDsAMD(UInt32 maxCount, UInt32* ids);

			internal static glXGetGPUIDsAMD pglXGetGPUIDsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);

			internal static glXGetGPUInfoAMD pglXGetGPUInfoAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glXGetContextGPUIDAMD(IntPtr ctx);

			internal static glXGetContextGPUIDAMD pglXGetContextGPUIDAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateAssociatedContextAMD(UInt32 id, IntPtr share_list);

			internal static glXCreateAssociatedContextAMD pglXCreateAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr share_context, int* attribList);

			internal static glXCreateAssociatedContextAttribsAMD pglXCreateAssociatedContextAttribsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXDeleteAssociatedContextAMD(IntPtr ctx);

			internal static glXDeleteAssociatedContextAMD pglXDeleteAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXMakeAssociatedContextCurrentAMD(IntPtr ctx);

			internal static glXMakeAssociatedContextCurrentAMD pglXMakeAssociatedContextCurrentAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentAssociatedContextAMD();

			internal static glXGetCurrentAssociatedContextAMD pglXGetCurrentAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			internal static glXBlitContextFramebufferAMD pglXBlitContextFramebufferAMD;

		}
	}

}
