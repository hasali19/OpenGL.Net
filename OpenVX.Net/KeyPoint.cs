﻿
// MIT License
// 
// Copyright (c) 2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#pragma warning disable 169

using System.Runtime.InteropServices;

namespace OpenVX
{
	/// <summary>
	/// The keypoint data structure.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct KeyPoint
	{
		/// <summary>
		/// The X coordinate.
		/// </summary>
		public int X;

		/// <summary>
		/// The Y coordinate.
		/// </summary>
		public int Y;

		/// <summary>
		/// The strength of the keypoint. Its definition is specific to the corner detector.
		/// </summary>
		public float Strength;

		/// <summary>
		/// Initialized to 0 by corner detectors.
		/// </summary>
		public float Scale;

		/// <summary>
		/// Initialized to 0 by corner detectors.
		/// </summary>
		public float Orientation;

		/// <summary>
		/// A zero indicates a lost point. Initialized to 1 by corner detectors.
		/// </summary>
		public int TrackingStatus;

		/// <summary>
		/// A tracking method specific error. Initialized to 0 by corner detectors.
		/// </summary>
		public float Error;
	}
}
