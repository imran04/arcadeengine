﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DungeonEye.Script;


namespace DungeonEye.Forms
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ScriptDisableChoiceControl : ScriptActionControlBase
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="script"></param>
		public ScriptDisableChoiceControl(ScriptDisableChoice script)
		{
			InitializeComponent();

			if (script != null)
				Action = script;
			else
				Action = new ScriptDisableChoice();
		}



		#region Properties


		#endregion

	}
}
