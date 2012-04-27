// 
// SQLiteDatabase.cs
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
using System.Data.SQLite;
using System.Data;

namespace BattleForEurope
{
	public class SQLiteDatabase
	{
		public SQLiteDatabase()
		{
			this.DBConnection = "Data Source=battle.s3db";
		}
		
		public SQLiteDatabase(string inputFile) {
			DBConnection = "Data Source=" + inputFile;
		}
		
		
	 	public string DBConnection {
			get;
			set;
		}
		
		
		public DataTable GetDataTable(string sql) {
			DataTable dt = new DataTable();
			
			using (var cnn = new SQLiteConnection(this.DBConnection)) {
				cnn.Open();
				SQLiteCommand myCommand = new SQLiteCommand(cnn);
				myCommand.CommandText = sql;
				using (SQLiteDataReader reader = myCommand.ExecuteReader()) 
				{
					dt.Load(reader);
				}
				
			}
			
			return dt;
				
		}
		
		public int ExecuteNonQuery(string sql) {
			using (var cnn = new SQLiteConnection(this.DBConnection)) {
				cnn.Open();
				SQLiteCommand myCommand = new SQLiteCommand(cnn);
				myCommand.CommandText = sql;
				int rowsUpdated = myCommand.ExecuteNonQuery();
				return rowsUpdated;
			}
		}
	}
}

