//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class SnomedCrud {
		///<summary>Gets one Snomed object from the database using the primary key.  Returns null if not found.</summary>
		public static Snomed SelectOne(long snomedNum){
			string command="SELECT * FROM snomed "
				+"WHERE SnomedNum = "+POut.Long(snomedNum);
			List<Snomed> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Snomed object from the database using a query.</summary>
		public static Snomed SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Snomed> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Snomed objects from the database using a query.</summary>
		public static List<Snomed> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Snomed> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Snomed> TableToList(DataTable table){
			List<Snomed> retVal=new List<Snomed>();
			Snomed snomed;
			foreach(DataRow row in table.Rows) {
				snomed=new Snomed();
				snomed.SnomedNum  = PIn.Long  (row["SnomedNum"].ToString());
				snomed.SnomedCode = PIn.String(row["SnomedCode"].ToString());
				snomed.Description= PIn.String(row["Description"].ToString());
				retVal.Add(snomed);
			}
			return retVal;
		}

		///<summary>Converts a list of Snomed into a DataTable.</summary>
		public static DataTable ListToTable(List<Snomed> listSnomeds,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Snomed";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("SnomedNum");
			table.Columns.Add("SnomedCode");
			table.Columns.Add("Description");
			foreach(Snomed snomed in listSnomeds) {
				table.Rows.Add(new object[] {
					POut.Long  (snomed.SnomedNum),
					            snomed.SnomedCode,
					            snomed.Description,
				});
			}
			return table;
		}

		///<summary>Inserts one Snomed into the database.  Returns the new priKey.</summary>
		public static long Insert(Snomed snomed){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				snomed.SnomedNum=DbHelper.GetNextOracleKey("snomed","SnomedNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(snomed,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							snomed.SnomedNum++;
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
				return Insert(snomed,false);
			}
		}

		///<summary>Inserts one Snomed into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Snomed snomed,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				snomed.SnomedNum=ReplicationServers.GetKey("snomed","SnomedNum");
			}
			string command="INSERT INTO snomed (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="SnomedNum,";
			}
			command+="SnomedCode,Description) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(snomed.SnomedNum)+",";
			}
			command+=
				 "'"+POut.String(snomed.SnomedCode)+"',"
				+"'"+POut.String(snomed.Description)+"')";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				snomed.SnomedNum=Db.NonQ(command,true,"SnomedNum","snomed");
			}
			return snomed.SnomedNum;
		}

		///<summary>Inserts one Snomed into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Snomed snomed){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(snomed,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					snomed.SnomedNum=DbHelper.GetNextOracleKey("snomed","SnomedNum"); //Cacheless method
				}
				return InsertNoCache(snomed,true);
			}
		}

		///<summary>Inserts one Snomed into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Snomed snomed,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO snomed (";
			if(!useExistingPK && isRandomKeys) {
				snomed.SnomedNum=ReplicationServers.GetKeyNoCache("snomed","SnomedNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="SnomedNum,";
			}
			command+="SnomedCode,Description) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(snomed.SnomedNum)+",";
			}
			command+=
				 "'"+POut.String(snomed.SnomedCode)+"',"
				+"'"+POut.String(snomed.Description)+"')";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				snomed.SnomedNum=Db.NonQ(command,true,"SnomedNum","snomed");
			}
			return snomed.SnomedNum;
		}

		///<summary>Updates one Snomed in the database.</summary>
		public static void Update(Snomed snomed){
			string command="UPDATE snomed SET "
				+"SnomedCode = '"+POut.String(snomed.SnomedCode)+"', "
				+"Description= '"+POut.String(snomed.Description)+"' "
				+"WHERE SnomedNum = "+POut.Long(snomed.SnomedNum);
			Db.NonQ(command);
		}

		///<summary>Updates one Snomed in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Snomed snomed,Snomed oldSnomed){
			string command="";
			if(snomed.SnomedCode != oldSnomed.SnomedCode) {
				if(command!=""){ command+=",";}
				command+="SnomedCode = '"+POut.String(snomed.SnomedCode)+"'";
			}
			if(snomed.Description != oldSnomed.Description) {
				if(command!=""){ command+=",";}
				command+="Description = '"+POut.String(snomed.Description)+"'";
			}
			if(command==""){
				return false;
			}
			command="UPDATE snomed SET "+command
				+" WHERE SnomedNum = "+POut.Long(snomed.SnomedNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(Snomed,Snomed) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Snomed snomed,Snomed oldSnomed) {
			if(snomed.SnomedCode != oldSnomed.SnomedCode) {
				return true;
			}
			if(snomed.Description != oldSnomed.Description) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Snomed from the database.</summary>
		public static void Delete(long snomedNum){
			string command="DELETE FROM snomed "
				+"WHERE SnomedNum = "+POut.Long(snomedNum);
			Db.NonQ(command);
		}

	}
}