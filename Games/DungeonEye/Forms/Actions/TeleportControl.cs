﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DungeonEye.Script.Actions;

namespace DungeonEye.Forms
{
	/// <summary>
	/// 
	/// </summary>
	public partial class TeleportControl : ActionControlBase
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="script"></param>
		public TeleportControl(ActionTeleport script, Dungeon dungeon)
		{
			InitializeComponent();


			if (script != null)
				Action = script;
			else
				Action = new ActionTeleport();

			TargetBox.Dungeon = dungeon;
			TargetBox.SetTarget(((ActionTeleport)Action).Target);

			TargetBox.TargetChanged +=new TargetControl.TargetChangedEventHandler(TargetBox_TargetChanged);
			
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="target"></param>
		void TargetBox_TargetChanged(object sender, DungeonLocation target)
		{
			((ActionTeleport) Action).Target = target;
		}


		#region Events



		#endregion



		#region Properties

		/// <summary>
		/// Target location
		/// </summary>
		public DungeonLocation Target
		{
			get;
			private set;
		}

		#endregion

	}
}