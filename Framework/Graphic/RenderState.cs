﻿using System;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using ArcEngine.Graphic;

namespace ArcEngine.Graphic
{
	/// <summary>
	/// Defines the render state of a graphics device. 
	/// </summary>
	public sealed class RenderState
	{

		/// <summary>
		/// Captures the current value of states that are included in a state block.
		/// </summary>
		/// <returns>State block</returns>
		public StateBlock Capture()
		{
			StateBlock state = new StateBlock();
			state.Blending = Blending;
			state.ClearColor = ClearColor;
			state.Culling = Culling;
			state.DepthClearValue = DepthClearValue;
			state.DepthMask = DepthMask;
			state.DepthTest = DepthTest;
			state.MultiSample = MultiSample;
			state.PointSize = PointSize;
			state.Scissor = Scissor;
			state.StencilClearValue = StencilClearValue;
			state.StencilFail = StencilFail;
			state.StencilFunction = StencilFunction;
			state.StencilMask = StencilMask;
			state.StencilPass = StencilPass;
			state.StencilReference = StencilReference;
			state.StencilTest = StencilTest;
			state.StencilWriteMask = StencilWriteMask;
			state.TwoSidedStencilMode = TwoSidedStencilMode;

			return state;
		}


		/// <summary>
		/// Applies the state block 
		/// </summary>
		/// <param name="state">Stateblock to apply</param>
		public void Apply(StateBlock state)
		{
			Blending = state.Blending;
			ClearColor = state.ClearColor;
			Culling = state.Culling;
			DepthClearValue = state.DepthClearValue;
			DepthMask = state.DepthMask;
			DepthTest = state.DepthTest;
			MultiSample = state.MultiSample;
			PointSize = state.PointSize;
			Scissor = state.Scissor;
			StencilClearValue = state.StencilClearValue;
			StencilFail = state.StencilFail;
			StencilFunction = state.StencilFunction;
			StencilMask = state.StencilMask;
			StencilPass = state.StencilPass;
			StencilReference = state.StencilReference;
			StencilTest = state.StencilTest;
			StencilWriteMask = state.StencilWriteMask;
			TwoSidedStencilMode = state.TwoSidedStencilMode;	
		}



		#region Properties

		/// <summary>
		/// Gets/sets blending state
		/// </summary>
		public bool AlphaTest
		{
			get
			{
				return GL.IsEnabled(EnableCap.AlphaTest);
			}
			set
			{
				if (value)
					GL.Enable(EnableCap.AlphaTest);
				else
					GL.Disable(EnableCap.AlphaTest);
			}
		}


		#region Blending

		/// <summary>
		/// Gets/sets blending state
		/// </summary>
		public bool Blending
		{
			get
			{
				return GL.IsEnabled(EnableCap.Blend);
			}
			set
			{
				if (value)
					GL.Enable(EnableCap.Blend);
				else
					GL.Disable(EnableCap.Blend);
			}
		}


		#endregion


		/// <summary>
		/// Gets/Sets the scissor test
		/// </summary>
		public bool Scissor
		{
			get
			{
				return GL.IsEnabled(EnableCap.ScissorTest);

			}
			set
			{
				if (value)
					GL.Enable(EnableCap.ScissorTest);
				else
					GL.Disable(EnableCap.ScissorTest);
			}
		}


		/// <summary>
		/// Gets/Sets the stipple pattern
		/// </summary>
		[Obsolete("Deprecated")]
		public bool LineStipple
		{
			get
			{
				return GL.IsEnabled(EnableCap.LineStipple);

			}
			set
			{
				if (value)
					GL.Enable(EnableCap.LineStipple);
				else
					GL.Disable(EnableCap.LineStipple);
			}
		}


		/// <summary>
		/// Gets / sets the point size
		/// </summary>
		public int PointSize
		{
			get
			{
				int value;
				GL.GetInteger(GetPName.PointSize, out value);
				return value;
			}
			set
			{
				GL.PointSize(value);
			}
		}


		/// <summary>
		/// Gets / sets the line size
		/// </summary>
		[Obsolete("Deprecated")]
		public int LineWidth
		{
			get
			{
				int value;
				GL.GetInteger(GetPName.LineWidth, out value);
				return value;
			}
			set
			{
				GL.LineWidth(value);
			}
		}



		/// <summary>
		/// FSAA
		/// </summary>
		public bool MultiSample
		{
			get
			{
				return GL.IsEnabled(EnableCap.Multisample);
			}
			set
			{
				if (value)
					GL.Enable(EnableCap.Multisample);
				else
					GL.Disable(EnableCap.Multisample);
			}
		}


		/// <summary>
		/// Gets/sets the cleacolor
		/// </summary>
		public Color ClearColor
		{
			get
			{
				float[] tab = new float[4];
				GL.GetFloat(GetPName.ColorClearValue, tab);

				return Color.FromArgb((int)(tab[3] * 255), (int)(tab[0] * 255), (int)(tab[1] * 255), (int)(tab[2] * 255));
			}
			set
			{
				GL.ClearColor(value.R / 255.0f, value.G / 255.0f, value.B / 255.0f, value.A / 255.0f);
			}
		}

		/// <summary>
		/// Enables/disables face culling
		/// </summary>
		public bool Culling
		{
			get
			{
				return GL.IsEnabled(EnableCap.CullFace);
			}
			set
			{
				if (value)
					GL.Enable(EnableCap.CullFace);
				else
					GL.Disable(EnableCap.CullFace);
			}
		}


		/// <summary>
		/// Enables/disables depth test
		/// </summary>
		public bool DepthTest
		{
			get
			{
				return GL.IsEnabled(EnableCap.DepthTest);
			}

			set
			{
				if (value)
					GL.Enable(EnableCap.DepthTest);
				else
					GL.Disable(EnableCap.DepthTest);
			}
		}


		/// <summary>
		/// Gets/sets clear value for the depth buffer 
		/// </summary>
		public float DepthClearValue
		{
			get
			{
				int s;
				GL.GetInteger(GetPName.DepthClearValue, out s);
				return s;
			}
			set
			{
				GL.ClearDepth(value);
			}
		}


		/// <summary>
		/// Enable or disable writing into the depth buffer
		/// </summary>
		public bool DepthMask
		{
			get
			{
				bool ret;
				GL.GetBoolean(GetPName.DepthWritemask, out ret);

				return ret;
			}

			set
			{
				GL.DepthMask(value);
			}
		}


	
		#region Stencil


		/// <summary>
		/// Gets or sets stencil enabling. The default is false.
		/// </summary>
		public bool StencilTest
		{
			get
			{
				return GL.IsEnabled(EnableCap.StencilTest);
			}

			set
			{
				if (value)
					GL.Enable(EnableCap.StencilTest);
				else
					GL.Disable(EnableCap.StencilTest);
			}
		}


		/// <summary>
		/// Gets/sets clear value for the stencil buffer 
		/// </summary>
		public int StencilClearValue
		{
			get
			{
				int s;
				GL.GetInteger(GetPName.StencilClearValue, out s);
				return s;
			}
			set
			{
				GL.ClearStencil(value);
			}
		}

		/// <summary>
		/// Gets or sets the mask applied to the reference value and each stencil
		/// buffer entry to determine the significant bits for the stencil test. 
		/// </summary>
		public int StencilMask
		{
			get
			{
				int mask;
				GL.GetInteger(GetPName.StencilValueMask, out mask);
				return mask;
			}
			set
			{
				GL.StencilMask(value);
			}
		}


		/// <summary>
		/// Gets or sets the stencil operation to perform if the stencil test passes.
		/// </summary>
		public StencilOperation StencilPass
		{
			get
			{
				return StencilOperation.Keep;
			}
			set
			{
			}
		}


		/// <summary>
		/// Gets or sets the write mask applied to values written into the stencil buffer.
		/// </summary>
		public int StencilWriteMask
		{
			get
			{
				int mask;
				GL.GetInteger(GetPName.StencilWritemask, out mask);
				return mask;
			}
			set
			{

			}
		}


		/// <summary>
		/// Enables or disables two-sided stenciling. 
		/// </summary>
		public bool TwoSidedStencilMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}


		/// <summary>
		/// Specifies a reference value to use for the stencil test.
		/// </summary>
		public int StencilReference
		{
			get
			{
				int mask;
				GL.GetInteger(GetPName.StencilRef, out mask);
				return mask;
			}
			set
			{
			}
		}

		/*
				/// <summary>
				/// Gets or sets the stencil operation to perform if the stencil and 
				/// z-tests pass for a counterclockwise triangle.
				/// </summary>
				public StencilOperation CounterClockwiseStencilPass 
				{
					get
					{
					}
					set
					{
					}
				}


				/// <summary>
				/// Gets or sets the comparison function to use for counterclockwise stencil tests. 
				/// </summary>
				public CompareFunction CounterClockwiseStencilFunction 
				{
					get
					{
					}
					set
					{
					}
				}


				/// <summary>
				/// Gets or sets the stencil operation to perform if the stencil 
				/// test fails for a counterclockwise triangle. 
				/// </summary>
				public StencilOperation CounterClockwiseStencilFail 
				{
					get
					{
					}
					set
					{
					}
				}


				/// <summary>
				/// Gets or sets the stencil operation to perform if the stencil test passes
				/// and the depth-buffer test fails for a counterclockwise triangle.
				/// </summary>
				public StencilOperation CounterClockwiseStencilDepthBufferFail 
				{
					get
					{
					}
					set
					{
					}
				}
		*/

		/// <summary>
		/// Gets or sets the comparison function for the stencil test. 
		/// </summary>
		public CompareFunction StencilFunction
		{
			get
			{
				return CompareFunction.Never;
			}
			set
			{
				GL.StencilFunc((OpenTK.Graphics.OpenGL.StencilFunction)value, StencilReference, StencilMask);
			}
		}


		/// <summary>
		/// Gets or sets the stencil operation to perform if the stencil test fails. 
		/// </summary>
		public StencilOperation StencilFail
		{
			get
			{
				return StencilOperation.Keep;
			}
			set
			{
			}
		}




		#endregion

		#endregion

	}



	/// <summary>
	/// Encapsulates render states
	/// </summary>
	public struct StateBlock
	{

		/// <summary>
		/// Gets/sets blending state
		/// </summary>
		bool AlphaTest;


		/// <summary>
		/// Gets/Sets the scissor test
		/// </summary>
		public bool Scissor;


		/// <summary>
		/// Gets / sets the point size
		/// </summary>
		public int PointSize;


		/// <summary>
		/// FSAA
		/// </summary>
		public bool MultiSample;


		/// <summary>
		/// Gets/sets the cleacolor
		/// </summary>
		public Color ClearColor;

		/// <summary>
		/// Enables/disables face culling
		/// </summary>
		public bool Culling;


		/// <summary>
		/// Enables/disables depth test
		/// </summary>
		public bool DepthTest;


		/// <summary>
		/// Gets/sets clear value for the depth buffer 
		/// </summary>
		public float DepthClearValue;


		/// <summary>
		/// Enable or disable writing into the depth buffer
		/// </summary>
		public bool DepthMask;


		/// <summary>
		/// Gets/sets blending state
		/// </summary>
		public bool Blending;

	
		#region Stencil


		/// <summary>
		/// Gets or sets stencil enabling. The default is false.
		/// </summary>
		public bool StencilTest;


		/// <summary>
		/// Gets/sets clear value for the stencil buffer 
		/// </summary>
		public int StencilClearValue;

		/// <summary>
		/// Gets or sets the mask applied to the reference value and each stencil
		/// buffer entry to determine the significant bits for the stencil test. 
		/// </summary>
		public int StencilMask;


		/// <summary>
		/// Gets or sets the stencil operation to perform if the stencil test passes.
		/// </summary>
		public StencilOperation StencilPass;


		/// <summary>
		/// Gets or sets the write mask applied to values written into the stencil buffer.
		/// </summary>
		public int StencilWriteMask;


		/// <summary>
		/// Enables or disables two-sided stenciling. 
		/// </summary>
		public bool TwoSidedStencilMode;


		/// <summary>
		/// Specifies a reference value to use for the stencil test.
		/// </summary>
		public int StencilReference;


		/// <summary>
		/// Gets or sets the comparison function for the stencil test. 
		/// </summary>
		public CompareFunction StencilFunction;


		/// <summary>
		/// Gets or sets the stencil operation to perform if the stencil test fails. 
		/// </summary>
		public StencilOperation StencilFail;

		#endregion
	}




	/// <summary>
	/// Defines stencil buffer operations. 
	/// </summary>
	public enum StencilOperation
	{
		/// <summary>
		/// Decrements the stencil-buffer entry, wrapping to the maximum value if the new value is less than 0.
		/// </summary>
		Decrement = OpenTK.Graphics.OpenGL.StencilOp.Decr,

		/// <summary>
		/// Decrements the stencil-buffer entry, clamping to 0.
		/// </summary>
		DecrementSaturation = OpenTK.Graphics.OpenGL.StencilOp.DecrWrap,

		/// <summary>
		/// Increments the stencil-buffer entry, wrapping to 0 if the new value exceeds the maximum value.
		/// </summary>
		Increment = OpenTK.Graphics.OpenGL.StencilOp.Incr,

		/// <summary>
		/// Increments the stencil-buffer entry, clamping to the maximum value.
		/// </summary>
		IncrementSaturation = OpenTK.Graphics.OpenGL.StencilOp.IncrWrap,

		/// <summary>
		/// Inverts the bits in the stencil-buffer entry.
		/// </summary>
		Invert = OpenTK.Graphics.OpenGL.StencilOp.Invert,

		/// <summary>
		/// 	Does not update the stencil-buffer entry. This is the default value.
		/// </summary>
		Keep = OpenTK.Graphics.OpenGL.StencilOp.Keep,

		/// <summary>
		/// Replaces the stencil-buffer entry with a reference value.
		/// </summary>
		Replace = OpenTK.Graphics.OpenGL.StencilOp.Replace,

		/// <summary>
		/// Sets the stencil-buffer entry to 0.
		/// </summary>
		Zero = OpenTK.Graphics.OpenGL.StencilOp.Zero,
	}

	/// <summary>
	/// Defines comparison functions that can be chosen for alpha, stencil, or depth-buffer tests.
	/// </summary>
	public enum CompareFunction
	{
		/// <summary>
		/// Always pass the test.
		/// </summary>
		Always = OpenTK.Graphics.OpenGL.StencilFunction.Always,


		/// <summary>
		/// Accept the new pixel if its value is equal to the value of the current pixel.
		/// </summary>
		Equal = OpenTK.Graphics.OpenGL.StencilFunction.Equal,

		/// <summary>
		/// Accept the new pixel if its value is greater than the value of the current pixel.
		/// </summary>
		Greater = OpenTK.Graphics.OpenGL.StencilFunction.Greater,

		/// <summary>
		/// Accept the new pixel if its value is greater than or equal to the value of the current pixel.
		/// </summary>
		GreaterEqual = OpenTK.Graphics.OpenGL.StencilFunction.Gequal,

		/// <summary>
		/// 	Accept the new pixel if its value is less than the value of the current pixel.
		/// </summary>
		Less = OpenTK.Graphics.OpenGL.StencilFunction.Less,

		/// <summary>
		/// Accept the new pixel if its value is less than or equal to the value of the current pixel. 
		/// </summary>
		LessEqual = OpenTK.Graphics.OpenGL.StencilFunction.Lequal,

		/// <summary>
		/// Always fail the test.
		/// </summary>
		Never = OpenTK.Graphics.OpenGL.StencilFunction.Never,

		/// <summary>
		/// Accept the new pixel if its value does not equal the value of the current pixel.
		/// </summary>
		NotEqual = OpenTK.Graphics.OpenGL.StencilFunction.Notequal,
	}



	/// <summary>
	/// Defines how to combine a source color with the destination color 
	/// already on the render target for color blending.
	/// </summary>
	public enum BlendingFactorSource
	{
		/// <summary>
		/// 
		/// </summary>
		Zero = OpenTK.Graphics.OpenGL.BlendingFactorSrc.Zero,

		/// <summary>
		/// 
		/// </summary>
		One = OpenTK.Graphics.OpenGL.BlendingFactorSrc.One,

		/// <summary>
		/// 
		/// </summary>
		SrcAlpha = OpenTK.Graphics.OpenGL.BlendingFactorSrc.SrcAlpha,

		/// <summary>
		/// 
		/// </summary>
		OneMinusSrcAlpha = OpenTK.Graphics.OpenGL.BlendingFactorSrc.OneMinusSrcAlpha,

		/// <summary>
		/// 
		/// </summary>
		DstAlpha = OpenTK.Graphics.OpenGL.BlendingFactorSrc.DstAlpha,

		/// <summary>
		/// 
		/// </summary>
		OneMinusDstAlpha = OpenTK.Graphics.OpenGL.BlendingFactorSrc.OneMinusDstAlpha,

		/// <summary>
		/// 
		/// </summary>
		DstColor = OpenTK.Graphics.OpenGL.BlendingFactorSrc.DstColor,

		/// <summary>
		/// 
		/// </summary>
		OneMinusDstColor = OpenTK.Graphics.OpenGL.BlendingFactorSrc.OneMinusDstColor,
		
		/// <summary>
		/// 
		/// </summary>
		SrcAlphaSaturate = OpenTK.Graphics.OpenGL.BlendingFactorSrc.SrcAlphaSaturate,

		/// <summary>
		/// 
		/// </summary>
		ConstantColor = OpenTK.Graphics.OpenGL.BlendingFactorSrc.ConstantColor,

		/// <summary>
		/// 
		/// </summary>
		OneMinusConstantColor = OpenTK.Graphics.OpenGL.BlendingFactorSrc.OneMinusConstantColor,

		/// <summary>
		/// 
		/// </summary>
		ConstantAlpha = OpenTK.Graphics.OpenGL.BlendingFactorSrc.ConstantAlpha,

		/// <summary>
		/// 
		/// </summary>
		OneMinusConstantAlpha = OpenTK.Graphics.OpenGL.BlendingFactorSrc.OneMinusConstantAlpha,
	}


	/// <summary>
	/// 
	/// </summary>
	public enum BlendingFactorDest
	{
		/// <summary>
		/// 
		/// </summary>
		Zero = OpenTK.Graphics.OpenGL.BlendingFactorDest.Zero,

		/// <summary>
		/// 
		/// </summary>
		One = OpenTK.Graphics.OpenGL.BlendingFactorDest.One,

		/// <summary>
		/// 
		/// </summary>
		SrcColor = OpenTK.Graphics.OpenGL.BlendingFactorDest.SrcColor,

		/// <summary>
		/// 
		/// </summary>
		OneMinusSrcColor = OpenTK.Graphics.OpenGL.BlendingFactorDest.OneMinusSrcColor,

		/// <summary>
		/// 
		/// </summary>
		SrcAlpha = OpenTK.Graphics.OpenGL.BlendingFactorDest.SrcAlpha,

		/// <summary>
		/// 
		/// </summary>
		OneMinusSrcAlpha = OpenTK.Graphics.OpenGL.BlendingFactorDest.OneMinusSrcAlpha,

		/// <summary>
		/// 
		/// </summary>
		DstAlpha = OpenTK.Graphics.OpenGL.BlendingFactorDest.DstAlpha,

		/// <summary>
		/// 
		/// </summary>
		OneMinusDstAlpha = OpenTK.Graphics.OpenGL.BlendingFactorDest.OneMinusDstAlpha,

		/// <summary>
		/// 
		/// </summary>
		DstColor = OpenTK.Graphics.OpenGL.BlendingFactorDest.DstColor,

		/// <summary>
		/// 
		/// </summary>
		OneMinusDstColor = OpenTK.Graphics.OpenGL.BlendingFactorDest.OneMinusDstColor,

		/// <summary>
		/// 
		/// </summary>
		ConstantColor = OpenTK.Graphics.OpenGL.BlendingFactorDest.ConstantColor,

		/// <summary>
		/// 
		/// </summary>
		OneMinusConstantColor = OpenTK.Graphics.OpenGL.BlendingFactorDest.OneMinusConstantColor,

		/// <summary>
		/// 
		/// </summary>
		ConstantAlpha = OpenTK.Graphics.OpenGL.BlendingFactorDest.ConstantAlpha,

		/// <summary>
		/// 
		/// </summary>
		OneMinusConstantAlpha = OpenTK.Graphics.OpenGL.BlendingFactorDest.OneMinusConstantAlpha,
	}
}