//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class ToothGridColCrud {
		///<summary>Gets one ToothGridCol object from the database using the primary key.  Returns null if not found.</summary>
		public static ToothGridCol SelectOne(long toothGridColNum){
			string command="SELECT * FROM toothgridcol "
				+"WHERE ToothGridColNum = "+POut.Long(toothGridColNum);
			List<ToothGridCol> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one ToothGridCol object from the database using a query.</summary>
		public static ToothGridCol SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ToothGridCol> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of ToothGridCol objects from the database using a query.</summary>
		public static List<ToothGridCol> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ToothGridCol> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<ToothGridCol> TableToList(DataTable table){
			List<ToothGridCol> retVal=new List<ToothGridCol>();
			ToothGridCol toothGridCol;
			foreach(DataRow row in table.Rows) {
				toothGridCol=new ToothGridCol();
				toothGridCol.ToothGridColNum= PIn.Long  (row["ToothGridColNum"].ToString());
				toothGridCol.SheetFieldNum  = PIn.Long  (row["SheetFieldNum"].ToString());
				toothGridCol.NameItem       = PIn.String(row["NameItem"].ToString());
				toothGridCol.CellType       = (OpenDentBusiness.ToothGridCellType)PIn.Int(row["CellType"].ToString());
				toothGridCol.ItemOrder      = PIn.Int   (row["ItemOrder"].ToString());
				toothGridCol.ColumnWidth    = PIn.Int   (row["ColumnWidth"].ToString());
				toothGridCol.CodeNum        = PIn.Long  (row["CodeNum"].ToString());
				toothGridCol.ProcStatus     = (OpenDentBusiness.ProcStat)PIn.Int(row["ProcStatus"].ToString());
				retVal.Add(toothGridCol);
			}
			return retVal;
		}

		///<summary>Converts a list of ToothGridCol into a DataTable.</summary>
		public static DataTable ListToTable(List<ToothGridCol> listToothGridCols,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="ToothGridCol";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("ToothGridColNum");
			table.Columns.Add("SheetFieldNum");
			table.Columns.Add("NameItem");
			table.Columns.Add("CellType");
			table.Columns.Add("ItemOrder");
			table.Columns.Add("ColumnWidth");
			table.Columns.Add("CodeNum");
			table.Columns.Add("ProcStatus");
			foreach(ToothGridCol toothGridCol in listToothGridCols) {
				table.Rows.Add(new object[] {
					POut.Long  (toothGridCol.ToothGridColNum),
					POut.Long  (toothGridCol.SheetFieldNum),
					            toothGridCol.NameItem,
					POut.Int   ((int)toothGridCol.CellType),
					POut.Int   (toothGridCol.ItemOrder),
					POut.Int   (toothGridCol.ColumnWidth),
					POut.Long  (toothGridCol.CodeNum),
					POut.Int   ((int)toothGridCol.ProcStatus),
				});
			}
			return table;
		}

		///<summary>Inserts one ToothGridCol into the database.  Returns the new priKey.</summary>
		public static long Insert(ToothGridCol toothGridCol){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				toothGridCol.ToothGridColNum=DbHelper.GetNextOracleKey("toothgridcol","ToothGridColNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(toothGridCol,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							toothGridCol.ToothGridColNum++;
							loopcount++;
						}
						else{
							throw ex;
						}
					}
				}
				throw new ApplicationException("Insert failed.  Could not generate primary key.");
			}
			else {
				return Insert(toothGridCol,false);
			}
		}

		///<summary>Inserts one ToothGridCol into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(ToothGridCol toothGridCol,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				toothGridCol.ToothGridColNum=ReplicationServers.GetKey("toothgridcol","ToothGridColNum");
			}
			string command="INSERT INTO toothgridcol (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="ToothGridColNum,";
			}
			command+="SheetFieldNum,NameItem,CellType,ItemOrder,ColumnWidth,CodeNum,ProcStatus) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(toothGridCol.ToothGridColNum)+",";
			}
			command+=
				     POut.Long  (toothGridCol.SheetFieldNum)+","
				+"'"+POut.String(toothGridCol.NameItem)+"',"
				+    POut.Int   ((int)toothGridCol.CellType)+","
				+    POut.Int   (toothGridCol.ItemOrder)+","
				+    POut.Int   (toothGridCol.ColumnWidth)+","
				+    POut.Long  (toothGridCol.CodeNum)+","
				+    POut.Int   ((int)toothGridCol.ProcStatus)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				toothGridCol.ToothGridColNum=Db.NonQ(command,true,"ToothGridColNum","toothGridCol");
			}
			return toothGridCol.ToothGridColNum;
		}

		///<summary>Inserts one ToothGridCol into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ToothGridCol toothGridCol){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(toothGridCol,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					toothGridCol.ToothGridColNum=DbHelper.GetNextOracleKey("toothgridcol","ToothGridColNum"); //Cacheless method
				}
				return InsertNoCache(toothGridCol,true);
			}
		}

		///<summary>Inserts one ToothGridCol into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ToothGridCol toothGridCol,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO toothgridcol (";
			if(!useExistingPK && isRandomKeys) {
				toothGridCol.ToothGridColNum=ReplicationServers.GetKeyNoCache("toothgridcol","ToothGridColNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="ToothGridColNum,";
			}
			command+="SheetFieldNum,NameItem,CellType,ItemOrder,ColumnWidth,CodeNum,ProcStatus) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(toothGridCol.ToothGridColNum)+",";
			}
			command+=
				     POut.Long  (toothGridCol.SheetFieldNum)+","
				+"'"+POut.String(toothGridCol.NameItem)+"',"
				+    POut.Int   ((int)toothGridCol.CellType)+","
				+    POut.Int   (toothGridCol.ItemOrder)+","
				+    POut.Int   (toothGridCol.ColumnWidth)+","
				+    POut.Long  (toothGridCol.CodeNum)+","
				+    POut.Int   ((int)toothGridCol.ProcStatus)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				toothGridCol.ToothGridColNum=Db.NonQ(command,true,"ToothGridColNum","toothGridCol");
			}
			return toothGridCol.ToothGridColNum;
		}

		///<summary>Updates one ToothGridCol in the database.</summary>
		public static void Update(ToothGridCol toothGridCol){
			string command="UPDATE toothgridcol SET "
				+"SheetFieldNum  =  "+POut.Long  (toothGridCol.SheetFieldNum)+", "
				+"NameItem       = '"+POut.String(toothGridCol.NameItem)+"', "
				+"CellType       =  "+POut.Int   ((int)toothGridCol.CellType)+", "
				+"ItemOrder      =  "+POut.Int   (toothGridCol.ItemOrder)+", "
				+"ColumnWidth    =  "+POut.Int   (toothGridCol.ColumnWidth)+", "
				+"CodeNum        =  "+POut.Long  (toothGridCol.CodeNum)+", "
				+"ProcStatus     =  "+POut.Int   ((int)toothGridCol.ProcStatus)+" "
				+"WHERE ToothGridColNum = "+POut.Long(toothGridCol.ToothGridColNum);
			Db.NonQ(command);
		}

		///<summary>Updates one ToothGridCol in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(ToothGridCol toothGridCol,ToothGridCol oldToothGridCol){
			string command="";
			if(toothGridCol.SheetFieldNum != oldToothGridCol.SheetFieldNum) {
				if(command!=""){ command+=",";}
				command+="SheetFieldNum = "+POut.Long(toothGridCol.SheetFieldNum)+"";
			}
			if(toothGridCol.NameItem != oldToothGridCol.NameItem) {
				if(command!=""){ command+=",";}
				command+="NameItem = '"+POut.String(toothGridCol.NameItem)+"'";
			}
			if(toothGridCol.CellType != oldToothGridCol.CellType) {
				if(command!=""){ command+=",";}
				command+="CellType = "+POut.Int   ((int)toothGridCol.CellType)+"";
			}
			if(toothGridCol.ItemOrder != oldToothGridCol.ItemOrder) {
				if(command!=""){ command+=",";}
				command+="ItemOrder = "+POut.Int(toothGridCol.ItemOrder)+"";
			}
			if(toothGridCol.ColumnWidth != oldToothGridCol.ColumnWidth) {
				if(command!=""){ command+=",";}
				command+="ColumnWidth = "+POut.Int(toothGridCol.ColumnWidth)+"";
			}
			if(toothGridCol.CodeNum != oldToothGridCol.CodeNum) {
				if(command!=""){ command+=",";}
				command+="CodeNum = "+POut.Long(toothGridCol.CodeNum)+"";
			}
			if(toothGridCol.ProcStatus != oldToothGridCol.ProcStatus) {
				if(command!=""){ command+=",";}
				command+="ProcStatus = "+POut.Int   ((int)toothGridCol.ProcStatus)+"";
			}
			if(command==""){
				return false;
			}
			command="UPDATE toothgridcol SET "+command
				+" WHERE ToothGridColNum = "+POut.Long(toothGridCol.ToothGridColNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(ToothGridCol,ToothGridCol) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(ToothGridCol toothGridCol,ToothGridCol oldToothGridCol) {
			if(toothGridCol.SheetFieldNum != oldToothGridCol.SheetFieldNum) {
				return true;
			}
			if(toothGridCol.NameItem != oldToothGridCol.NameItem) {
				return true;
			}
			if(toothGridCol.CellType != oldToothGridCol.CellType) {
				return true;
			}
			if(toothGridCol.ItemOrder != oldToothGridCol.ItemOrder) {
				return true;
			}
			if(toothGridCol.ColumnWidth != oldToothGridCol.ColumnWidth) {
				return true;
			}
			if(toothGridCol.CodeNum != oldToothGridCol.CodeNum) {
				return true;
			}
			if(toothGridCol.ProcStatus != oldToothGridCol.ProcStatus) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one ToothGridCol from the database.</summary>
		public static void Delete(long toothGridColNum){
			string command="DELETE FROM toothgridcol "
				+"WHERE ToothGridColNum = "+POut.Long(toothGridColNum);
			Db.NonQ(command);
		}

	}
}