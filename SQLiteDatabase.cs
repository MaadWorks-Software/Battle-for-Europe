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
using System.Collections.Generic;

namespace Com.Maadworks.BattleForEurope
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
		
		
		/// <summary>
		/// Gets the data table.
		/// </summary>
		/// <returns>
		/// The data table.
		/// </returns>
		/// <param name='sql'>
		/// Sql.
		/// </param>
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
		
		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <returns>
		/// The non query.
		/// </returns>
		/// <param name='sql'>
		/// Sql.
		/// </param>
		public int ExecuteNonQuery(string sql) {
			using (var cnn = new SQLiteConnection(this.DBConnection)) {
				cnn.Open();
				SQLiteCommand myCommand = new SQLiteCommand(cnn);
				myCommand.CommandText = sql;
				int rowsUpdated = myCommand.ExecuteNonQuery();
				return rowsUpdated;
			}
		}
		
		/// <summary>
		/// Allows the programmer to retrieve single items from the DB.
		/// </summary>
		/// <returns>
		/// A string
		/// </returns>
		/// <param name='sql'>
		/// The query to run
		/// </param>
		public string ExecuteScalar(string sql) {
			using (var cnn = new SQLiteConnection(this.DBConnection)) {
				cnn.Open();
				SQLiteCommand myCommand = new SQLiteCommand(cnn);
				myCommand.CommandText = sql;
				object value = myCommand.ExecuteScalar();
				return (value != null) ? value.ToString() : "";
			}
			
		}
		
		/// <summary>
		/// Update the database
		/// </summary>
		/// <param name='tableName'>
		/// table's name.
		/// </param>
		/// <param name='data'>
		/// data to be updated
		/// </param>
		/// <param name='where'>
		/// the conditions.
		/// </param>
		public bool Update(string tableName, Dictionary<string, string> data, string where) {
			
			string vals = "";
			bool returnCode = true;
			if (data.Count >= 1) 
			{
				foreach (KeyValuePair<string, string> val in data) {
					vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString());
		
				}
				vals = vals.Substring(0, vals.Length - 1);
			}
			
			try 
			{
				this.ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));	
			}
			catch
			{
				returnCode = false;
			}
			return returnCode;
		}
		
		/// <summary>
		/// Delete the specified record from tableName and where.
		/// </summary>
		/// <param name='tableName'>
		/// table name.
		/// </param>
		/// <param name='where'>
		///  where.
		/// </param>
		public bool Delete(string tableName, string where) {
			
			bool returnCode = true;
			try 
			{
				this.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
				
			}
			catch (Exception fail)
			{
				Console.WriteLine(fail.Message);
				returnCode = false;
			}
			return returnCode;
			
			
		}
		
		/// <summary>
		/// Insert the specified tableName and data.
		/// </summary>
		/// <param name='tableName'>
		/// If set to <c>true</c> table name.
		/// </param>
		/// <param name='data'>
		/// If set to <c>true</c> data.
		/// </param>
		public bool Insert(string tableName, Dictionary<string, string> data)
		{
			string columns = "";
			string values = "";
			bool returnCode = true;
			
			foreach (KeyValuePair<string, string> val in data)
			{
				columns += String.Format(" {0},", val.Key.ToString());
				values += String.Format (" '{0}',", val.Value);
			}
			
			columns = columns.Substring(0, columns.Length - 1);
			values = values.Substring(0, values.Length -1);
			
			try 
			{
				this.ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values));	
			}
			catch (Exception fail) 
			{
				Console.WriteLine(fail.Message);
				returnCode = false;
				
			}
			
			return returnCode;
		
		}
		
		public bool ClearDB()
		{
			DataTable tables;
			
			try
			{
				tables = this.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");
				foreach (DataRow table in tables.Rows)
				{
					this.ClearTable(table["NAME"].ToString());
				}
				return true;
			}
			catch 
			{
				return false;
			}
		}
		
		public bool ClearTable(string table) 
		{
			try
			{
				this.ExecuteNonQuery(String.Format("delete from {0};", table));
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}

