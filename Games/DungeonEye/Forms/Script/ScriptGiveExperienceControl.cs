﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DungeonEye.EventScript;

namespace DungeonEye.Forms
{
	public partial class ScriptGiveExperienceControl : ScriptActionControlBase
	{
		public ScriptGiveExperienceControl()
		{
			InitializeComponent();


			Action = new ScriptGiveExperience();
		}


		#region Properties


		#endregion
	}
}
