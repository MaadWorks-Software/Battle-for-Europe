// 
// World.cs
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
// THE SOFTWARE.

using System;
using SdlDotNet.Core;
using SdlDotNet.Graphics;
using SdlDotNet.Input;
using System.Drawing;
using System.Collections.Generic;

namespace Com.Maadworks.BattleForEurope
{
	public class World
	{
		public World ()
		{
		}
		
		/// <summary>
		/// Updates the logic of the world
		/// </summary>
		/// <param name='gametime'>
		/// Gametime.
		/// </param>
		public virtual void Update(int gametime){}
		
		/// <summary>
		/// Draws the graphics of the world
		/// </summary>
		public virtual void Draw(Surface mainWindow){}
			
		
		
		
	}
}

