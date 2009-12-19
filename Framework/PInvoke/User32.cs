﻿#region Licence
//
//This file is part of ArcEngine.
//Copyright (C)2008-2009 Adrien Hémery ( iliak@mimicprod.net )
//
//ArcEngine is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//any later version.
//
//ArcEngine is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
//
#endregion

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Drawing;

namespace ArcEngine.PInvoke
{
	internal class User32
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="keyCode"></param>
		/// <returns></returns>
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		internal static extern short GetKeyState(int keyCode);


		/// <summary>
		/// 
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		internal struct NativeMessage
		{
			public IntPtr hWnd;
			public uint msg;
			public IntPtr wParam;
			public IntPtr lParam;
			public uint time;
			public Point p;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="hwnd"></param>
		/// <param name="messageFilterMin"></param>
		/// <param name="messageFilterMax"></param>
		/// <param name="flags"></param>
		/// <returns></returns>
		[SuppressUnmanagedCodeSecurityAttribute]
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool PeekMessage(out NativeMessage message, IntPtr hwnd, uint messageFilterMin, uint messageFilterMax, uint flags);

	
	}
}