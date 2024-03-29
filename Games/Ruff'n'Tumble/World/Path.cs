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
using ArcEngine;
using System;
using System.Collections.Generic;
using System.Text;
using ArcEngine.Asset;
using System.Xml;
using System.Drawing;
using ArcEngine.Graphic;


namespace RuffnTumble
{
	/// <summary>
	/// 
	/// </summary>
	/// http://www.erikasorson.com/tutorials/tutorial_splines.html
	/// http://www.codeproject.com/KB/recipes/BezirCurves.aspx
	/// http://www.cs.mtu.edu/~shene/COURSES/cs3621/NOTES/spline/Bezier/de-casteljau.html
	///
	public class Path// : ResourceBase
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name"></param>
		public Path()//string name) : base(name)
		{
			points = new List<Vector2>();
		}


		/// <summary>
		/// Draws the path on the screen
		/// </summary>
		/// <param name="location">Location of the level</param>
		public void Draw(SpriteBatch batch, Camera camera)
		{
			if (batch == null)
				return;

			for (int i = 0; i < points.Count - 1; i++)
				batch.DrawLine(points[i], points[i + 1], Color.Red);

			batch.DrawRectangle(Zone, Color.Green);
		}


		/// <summary>
		/// Checks if a point is on the path
		/// </summary>
		/// <param name="point">Point to check</param>
		/// <returns>True if on the path, otherwise false</returns>
		// http://www.topcoder.com/tc?module=Static&d1=tutorials&d2=geometry1
		// http://www.gamedev.net/community/forums/topic.asp?topic_id=398748
		public bool IsOnPath(Point point)
		{
			//if (!zone.Contains(point))
			//	return false;

			for (int i = 0; i < points.Count - 1; i++)
			{



			}


			return false;
		}



		#region IO routines

		///
		///<summary>
		/// Saves to a xml node
		/// </summary>
		///
		public bool Save(XmlWriter xml)
		{
			if (xml == null)
				return false;

			xml.WriteStartElement("path");
	//		xml.WriteAttributeString("name", Name);

	//		base.SaveComment(xml);


			foreach (Vector2 point in points)
			{
				xml.WriteStartElement("point");
				xml.WriteAttributeString("x", point.X.ToString());
				xml.WriteAttributeString("y", point.Y.ToString());
				xml.WriteEndElement();
			}

			xml.WriteEndElement();	// path

			return true;
		}


		/// <summary>
		/// Loads form a xml node
		/// </summary>
		/// <param name="xml">Xml node</param>
		/// <returns></returns>
		public bool Load(XmlNode xml)
		{

			points.Clear();

			XmlNodeList nodes = xml.ChildNodes;
			foreach (XmlNode node in nodes)
			{
				if (node.NodeType == XmlNodeType.Comment)
				{
			//	base.LoadComment(node);
					continue;
				}

				switch (node.Name.ToLower())
				{
					case "point":
					{
						AddPoint(new Vector2(float.Parse(node.Attributes["x"].Value), float.Parse(node.Attributes["y"].Value)));
					}
					break;

					default:
					{
						Trace.WriteLine("Path : Unknown node element \"" + node.Name + "\"");
					}
					break;
				}
			}


			return true;

		}

		#endregion



		#region Points

		/// <summary>
		/// Adds a point at the end
		/// </summary>
		/// <param name="point"></param>
		public void AddPoint(Vector2 point)
		{
			points.Add(point);
			ComputeRectangle();
		}

		/// <summary>
		/// Inserts a point at a given position
		/// </summary>
		/// <param name="point"></param>
		/// <param name="pos"></param>
		public void InsertPoint(Point point, int pos)
		{
			ComputeRectangle();
		}


		/// <summary>
		/// Removes a point
		/// </summary>
		/// <param name="point"></param>
		public void RemovePoint(Point point)
		{
			ComputeRectangle();
		}


		/// <summary>
		/// Removes a point by its BufferID
		/// </summary>
		/// <param name="BufferID"></param>
		public void RemovePoint(int id)
		{
			ComputeRectangle();
		}


		/// <summary>
		/// Compute the zone of all points
		/// </summary>
		void ComputeRectangle()
		{
			// No elements
			if (points.Count == 0)
			{
				zone = Vector4.Zero;
				return;
			}

			zone = new Vector4(points[0]);

			foreach (Vector2 point in points)
			{
				if (!zone.Contains(point))
				{
					if (zone.Left > point.X)
						zone.Location = new Vector2(point.X, zone.Top);

					if (zone.Top > point.Y)
						zone.Location = new Vector2(zone.Left, point.Y);

					if (zone.Right < point.X)
						zone.Size = new Vector2(point.X - Zone.Left, zone.Height);

					if (zone.Bottom < point.Y)
						zone.Size = new Vector2(zone.Width, point.Y - Zone.Top);
				}
			}
		}


		#endregion



		#region Properties


		/// <summary>
		/// List of points in the path
		/// </summary>
		public List<Vector2> Points
		{
			get
			{
				return points;
			}
		}
		List<Vector2> points;


		/// <summary>
		/// Width of the lines
		/// </summary>
		public int LineWidth;


		/// <summary>
		/// Gets the rectangle of the path
		/// </summary>
		public Vector4 Zone
		{
			get
			{
				return zone;
			}
		}
		Vector4 zone;


		#endregion
	}
}
