// 
// MainGame.cs
//  
// Author:
//       Devon J Weaver <devon.weaver@gmail.com>
// 
// Copyright (c) 2012 MaadWorks Software
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.using System;
using System;
using SdlDotNet.Core;
using SdlDotNet.Graphics;
using SdlDotNet.Input;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;


namespace Com.Maadworks.BattleForEurope
{
	public class MainGame
	{
		public static SQLiteDatabase gameDB = new SQLiteDatabase();
		
		
		public MainGame ()
		{
			Surface sfcMain = Video.SetVideoMode(1024,768);
			
			DataTable dt = gameDB.GetDataTable("SELECT * FROM Players");
			
			
//			
//			foreach (DataRow player in dt.Rows) {
//				Console.WriteLine(player["PLAYER_ID"].ToString());
//				Console.WriteLine(player["PLAYER_FIRSTNAME"].ToString());
//			}
//			
//			
//			
//			Dictionary<string, string> data = new Dictionary<string, string>();
//			bool result = db.Delete("Players", "PLAYER_FIRSTNAME = 'Bob'");
//			if (result)
//				Console.WriteLine("Deleted!");
//			
//			data.Add("PLAYER_HIGHSCORE", "300");
//			data.Add("PLAYER_FIRSTNAME", "Bob");
//			try 
//			{
//				db.Insert("Players", data);
//				
//			}
//			catch (Exception crap) 
//			{
//				Console.WriteLine(crap.Message);
//			}	
			
			Events.Quit += new EventHandler<QuitEventArgs>(Events_Quit);
			Events.Tick += new EventHandler<TickEventArgs>(Events_Tick);
			Events.KeyboardUp += new EventHandler<KeyboardEventArgs>(Events_KeyboardUp);

			Events.Run();
		}
		
		public static void Events_quit(object sender, QuitEventArgs e)
		{
			
		}
		
		public static void Events_Tick(object sender, TickEventArgs e)
		{
			
		}
		
		public static void Events_KeyboardUp(object sender, KeyboardEventArgs e)
		{
			
		}
		
		/// <summary>
		/// Update with the specified gameTime.
		/// </summary>
		/// <param name='gameTime'>
		/// Game time.
		/// </param>
		public void Update()
		{
			
		}
	
		/// <summary>
		/// Draw this instance.
		/// </summary>
		public void Draw() 
		{
			
		}
		
	}
}

