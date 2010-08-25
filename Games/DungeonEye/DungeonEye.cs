﻿#region Licence
//
//This file is part of ArcEngine.
//Copyright (C)2008-2010 Adrien Hémery ( iliak@mimicprod.net )
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
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcEngine.Graphic;
using ArcEngine.Input;
using ArcEngine.Utility.ScreenManager;

namespace DungeonEye
{
	/// <summary>
	/// DungeonEye base game class
	/// </summary>
	class Game : GameBase
	{
		/// <summary>
		/// Application entry point
		/// </summary>
		[STAThread]
		static void Main()
		{
			using (Game game = new Game())
				game.Run();
		}


		/// <summary>
		/// Constructor
		/// </summary>
		public Game()
		{
			Settings.Load("data/settings.xml");
			InputSchemeName = Settings.GetString("inputscheme");
			LanguageName = Settings.GetString("language");

			// Add the provider
			ResourceManager.AddProvider(new Providers());

			GSM = new ScreenManager(this);

		}




		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.
		/// </summary>
		public override void LoadContent()
		{
			GameWindowParams param = new GameWindowParams();
			param.Samples = 0;
			param.Size = new Size(640,400);
			CreateGameWindow(param);

			Window.Text = "Dungeon Eye";

			// Default texture parameters
			Display.TextureParameters.BorderColor = Color.Black;
			Display.TextureParameters.MagFilter = TextureMagFilter.Linear;
			Display.TextureParameters.MinFilter = TextureMinFilter.Linear;


			// Display settings
			Mouse.Visible = false;

			GSM.AddScreen(new MainMenu());
			GSM.AddScreen(new Team(null));
			//GSM.AddScreen(new IntroScreen());
			//GSM.AddScreen(new CharGen());
		}




		/// <summary>
		/// Called when graphics resources need to be unloaded.
		/// </summary>
		public override void UnloadContent()
		{
			GSM.UnloadContent();

			ResourceManager.ClearAssets();
		}




		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		public override void Update(GameTime gameTime)
		{
			if (Keyboard.IsKeyPress(Keys.Insert))
				RunEditor();


			GSM.Update(gameTime);
			
		}



		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		public override void Draw()
		{
			GSM.Draw();
		}





		#region Properties


		/// <summary>
		/// Game state manager
		/// </summary>
		ScreenManager GSM;

		/// <summary>
		/// Current keyboard schema
		/// </summary>
		static public string InputSchemeName = "azerty";

		/// <summary>
		/// Current language
		/// </summary>
		static public string LanguageName = "English";

		#endregion
	}

}
