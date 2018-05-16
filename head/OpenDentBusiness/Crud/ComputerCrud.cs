//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class ComputerCrud {
		///<summary>Gets one Computer object from the database using the primary key.  Returns null if not found.</summary>
		public static Computer SelectOne(long computerNum){
			string command="SELECT * FROM computer "
				+"WHERE ComputerNum = "+POut.Long(computerNum);
			List<Computer> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Computer object from the database using a query.</summary>
		public static Computer SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Computer> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Computer objects from the database using a query.</summary>
		public static List<Computer> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Computer> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Computer> TableToList(DataTable table){
			List<Computer> retVal=new List<Computer>();
			Computer computer;
			foreach(DataRow row in table.Rows) {
				computer=new Computer();
				computer.ComputerNum  = PIn.Long  (row["ComputerNum"].ToString());
				computer.CompName     = PIn.String(row["CompName"].ToString());
				computer.LastHeartBeat= PIn.DateT (row["LastHeartBeat"].ToString());
				retVal.Add(computer);
			}
			return retVal;
		}

		///<summary>Converts a list of Computer into a DataTable.</summary>
		public static DataTable ListToTable(List<Computer> listComputers,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Computer";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("ComputerNum");
			table.Columns.Add("CompName");
			table.Columns.Add("LastHeartBeat");
			foreach(Computer computer in listComputers) {
				table.Rows.Add(new object[] {
					POut.Long  (computer.ComputerNum),
					            computer.CompName,
					POut.DateT (computer.LastHeartBeat,false),
				});
			}
			return table;
		}

		///<summary>Inserts one Computer into the database.  Returns the new priKey.</summary>
		public static long Insert(Computer computer){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				computer.ComputerNum=DbHelper.GetNextOracleKey("computer","ComputerNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(computer,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							computer.ComputerNum++;
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
				return Insert(computer,false);
			}
		}

		///<summary>Inserts one Computer into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Computer computer,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				computer.ComputerNum=ReplicationServers.GetKey("computer","ComputerNum");
			}
			string command="INSERT INTO computer (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="ComputerNum,";
			}
			command+="CompName,LastHeartBeat) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(computer.ComputerNum)+",";
			}
			command+=
				 "'"+POut.String(computer.CompName)+"',"
				+    POut.DateT (computer.LastHeartBeat)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				computer.ComputerNum=Db.NonQ(command,true,"ComputerNum","computer");
			}
			return computer.ComputerNum;
		}

		///<summary>Inserts one Computer into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Computer computer){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(computer,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					computer.ComputerNum=DbHelper.GetNextOracleKey("computer","ComputerNum"); //Cacheless method
				}
				return InsertNoCache(computer,true);
			}
		}

		///<summary>Inserts one Computer into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Computer computer,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO computer (";
			if(!useExistingPK && isRandomKeys) {
				computer.ComputerNum=ReplicationServers.GetKeyNoCache("computer","ComputerNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="ComputerNum,";
			}
			command+="CompName,LastHeartBeat) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(computer.ComputerNum)+",";
			}
			command+=
				 "'"+POut.String(computer.CompName)+"',"
				+    POut.DateT (computer.LastHeartBeat)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				computer.ComputerNum=Db.NonQ(command,true,"ComputerNum","computer");
			}
			return computer.ComputerNum;
		}

		///<summary>Updates one Computer in the database.</summary>
		public static void Update(Computer computer){
			string command="UPDATE computer SET "
				+"CompName     = '"+POut.String(computer.CompName)+"', "
				+"LastHeartBeat=  "+POut.DateT (computer.LastHeartBeat)+" "
				+"WHERE ComputerNum = "+POut.Long(computer.ComputerNum);
			Db.NonQ(command);
		}

		///<summary>Updates one Computer in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Computer computer,Computer oldComputer){
			string command="";
			if(computer.CompName != oldComputer.CompName) {
				if(command!=""){ command+=",";}
				command+="CompName = '"+POut.String(computer.CompName)+"'";
			}
			if(computer.LastHeartBeat != oldComputer.LastHeartBeat) {
				if(command!=""){ command+=",";}
				command+="LastHeartBeat = "+POut.DateT(computer.LastHeartBeat)+"";
			}
			if(command==""){
				return false;
			}
			command="UPDATE computer SET "+command
				+" WHERE ComputerNum = "+POut.Long(computer.ComputerNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(Computer,Computer) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Computer computer,Computer oldComputer) {
			if(computer.CompName != oldComputer.CompName) {
				return true;
			}
			if(computer.LastHeartBeat != oldComputer.LastHeartBeat) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Computer from the database.</summary>
		public static void Delete(long computerNum){
			string command="DELETE FROM computer "
				+"WHERE ComputerNum = "+POut.Long(computerNum);
			Db.NonQ(command);
		}

	}
}