// 
// World1.cs
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
using SdlDotNet.Audio;
using System.Drawing;
using System.Collections.Generic;

namespace Com.Maadworks.BattleForEurope
{
	public class World1 : World
	{
		public World1 ()
		{
			
			
			
		}
		
		public override void Draw (Surface mainWindow)
		{
			base.Draw (mainWindow);
			mainWindow.Blit(Contents.mapAssests[0], new Point(0,0), new Rectangle(0,1000, 1024, 768));   // add map to main window
		}
		
		public override void Update (int gametime)
		{
			base.Update(gametime);
			
				
		}
	}
}

