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
	public partial class ScriptDeactivateTargetControl : ScriptActionControlBase
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="script"></param>
		public ScriptDeactivateTargetControl(ScriptDeactivateTarget script, Dungeon dungeon)
		{
			InitializeComponent();

			if (script != null)
				Action = script;
			else
				Action = new ScriptDeactivateTarget();

			TargetBox.SetTarget(dungeon, Action.Target);
		}



		#region


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		private void TargetBox_TargetChanged(object sender, DungeonLocation target)
		{
			if (Action == null)
				return;

			((ScriptDeactivateTarget) Action).Target = target;
		}


		#endregion


		#region Properties


		#endregion

	}
}
