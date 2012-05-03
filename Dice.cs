// 
// Dice.cs
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

namespace Com.Maadworks.BattleForEurope
{
	/// <summary>
	/// A type for recreating and simulating a dice roll
	/// </summary>
	public class Dice
	{
		
		private int _number;
		private int _min;
		private int _max;
		Random rand;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Com.Maadworks.BattleForEurope.Dice"/> class.
		/// Makes the type default to a one 6 sided dice.
		/// </summary>
		public Dice () : this(1, 6, 1)
		{
			
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Com.Maadworks.BattleForEurope.Dice"/> class.
		/// </summary>
		/// <param name='min'>
		/// Minimum.
		/// </param>
		/// <param name='max'>
		/// Max.
		/// </param>
		/// <param name='number'>
		/// Number.
		/// </param>
		public Dice(int min, int max, int number)
		{
			_sides = sides;
			_min = min;
			_max = max;
			rand = new Random();
		}
		
		public int getRoll() 
		{
			int totalRoll = 0;
			
			
			for (int i = 1; i <= _number;i++) {
				totalRoll += rand.Next(_min, _max);
			}
		}
		
}

