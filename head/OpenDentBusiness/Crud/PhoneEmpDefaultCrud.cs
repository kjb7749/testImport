//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class PhoneEmpDefaultCrud {
		///<summary>Gets one PhoneEmpDefault object from the database using the primary key.  Returns null if not found.</summary>
		public static PhoneEmpDefault SelectOne(long employeeNum){
			string command="SELECT * FROM phoneempdefault "
				+"WHERE EmployeeNum = "+POut.Long(employeeNum);
			List<PhoneEmpDefault> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one PhoneEmpDefault object from the database using a query.</summary>
		public static PhoneEmpDefault SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PhoneEmpDefault> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of PhoneEmpDefault objects from the database using a query.</summary>
		public static List<PhoneEmpDefault> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PhoneEmpDefault> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<PhoneEmpDefault> TableToList(DataTable table){
			List<PhoneEmpDefault> retVal=new List<PhoneEmpDefault>();
			PhoneEmpDefault phoneEmpDefault;
			foreach(DataRow row in table.Rows) {
				phoneEmpDefault=new PhoneEmpDefault();
				phoneEmpDefault.EmployeeNum     = PIn.Long  (row["EmployeeNum"].ToString());
				phoneEmpDefault.IsGraphed       = PIn.Bool  (row["IsGraphed"].ToString());
				phoneEmpDefault.HasColor        = PIn.Bool  (row["HasColor"].ToString());
				phoneEmpDefault.RingGroups      = (OpenDentBusiness.AsteriskQueues)PIn.Int(row["RingGroups"].ToString());
				phoneEmpDefault.EmpName         = PIn.String(row["EmpName"].ToString());
				phoneEmpDefault.PhoneExt        = PIn.Int   (row["PhoneExt"].ToString());
				phoneEmpDefault.StatusOverride  = (OpenDentBusiness.PhoneEmpStatusOverride)PIn.Int(row["StatusOverride"].ToString());
				phoneEmpDefault.Notes           = PIn.String(row["Notes"].ToString());
				phoneEmpDefault.IsPrivateScreen = PIn.Bool  (row["IsPrivateScreen"].ToString());
				phoneEmpDefault.IsTriageOperator= PIn.Bool  (row["IsTriageOperator"].ToString());
				phoneEmpDefault.EscalationOrder = PIn.Int   (row["EscalationOrder"].ToString());
				phoneEmpDefault.SiteNum         = PIn.Long  (row["SiteNum"].ToString());
				retVal.Add(phoneEmpDefault);
			}
			return retVal;
		}

		///<summary>Converts a list of PhoneEmpDefault into a DataTable.</summary>
		public static DataTable ListToTable(List<PhoneEmpDefault> listPhoneEmpDefaults,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="PhoneEmpDefault";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("EmployeeNum");
			table.Columns.Add("IsGraphed");
			table.Columns.Add("HasColor");
			table.Columns.Add("RingGroups");
			table.Columns.Add("EmpName");
			table.Columns.Add("PhoneExt");
			table.Columns.Add("StatusOverride");
			table.Columns.Add("Notes");
			table.Columns.Add("IsPrivateScreen");
			table.Columns.Add("IsTriageOperator");
			table.Columns.Add("EscalationOrder");
			table.Columns.Add("SiteNum");
			foreach(PhoneEmpDefault phoneEmpDefault in listPhoneEmpDefaults) {
				table.Rows.Add(new object[] {
					POut.Long  (phoneEmpDefault.EmployeeNum),
					POut.Bool  (phoneEmpDefault.IsGraphed),
					POut.Bool  (phoneEmpDefault.HasColor),
					POut.Int   ((int)phoneEmpDefault.RingGroups),
					            phoneEmpDefault.EmpName,
					POut.Int   (phoneEmpDefault.PhoneExt),
					POut.Int   ((int)phoneEmpDefault.StatusOverride),
					            phoneEmpDefault.Notes,
					POut.Bool  (phoneEmpDefault.IsPrivateScreen),
					POut.Bool  (phoneEmpDefault.IsTriageOperator),
					POut.Int   (phoneEmpDefault.EscalationOrder),
					POut.Long  (phoneEmpDefault.SiteNum),
				});
			}
			return table;
		}

		///<summary>Inserts one PhoneEmpDefault into the database.  Returns the new priKey.</summary>
		public static long Insert(PhoneEmpDefault phoneEmpDefault){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				phoneEmpDefault.EmployeeNum=DbHelper.GetNextOracleKey("phoneempdefault","EmployeeNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(phoneEmpDefault,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							phoneEmpDefault.EmployeeNum++;
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
				return Insert(phoneEmpDefault,false);
			}
		}

		///<summary>Inserts one PhoneEmpDefault into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(PhoneEmpDefault phoneEmpDefault,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				phoneEmpDefault.EmployeeNum=ReplicationServers.GetKey("phoneempdefault","EmployeeNum");
			}
			string command="INSERT INTO phoneempdefault (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="EmployeeNum,";
			}
			command+="IsGraphed,HasColor,RingGroups,EmpName,PhoneExt,StatusOverride,Notes,IsPrivateScreen,IsTriageOperator,EscalationOrder,SiteNum) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(phoneEmpDefault.EmployeeNum)+",";
			}
			command+=
				     POut.Bool  (phoneEmpDefault.IsGraphed)+","
				+    POut.Bool  (phoneEmpDefault.HasColor)+","
				+    POut.Int   ((int)phoneEmpDefault.RingGroups)+","
				+"'"+POut.String(phoneEmpDefault.EmpName)+"',"
				+    POut.Int   (phoneEmpDefault.PhoneExt)+","
				+    POut.Int   ((int)phoneEmpDefault.StatusOverride)+","
				+"'"+POut.String(phoneEmpDefault.Notes)+"',"
				+    POut.Bool  (phoneEmpDefault.IsPrivateScreen)+","
				+    POut.Bool  (phoneEmpDefault.IsTriageOperator)+","
				+    POut.Int   (phoneEmpDefault.EscalationOrder)+","
				+    POut.Long  (phoneEmpDefault.SiteNum)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				phoneEmpDefault.EmployeeNum=Db.NonQ(command,true,"EmployeeNum","phoneEmpDefault");
			}
			return phoneEmpDefault.EmployeeNum;
		}

		///<summary>Inserts one PhoneEmpDefault into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PhoneEmpDefault phoneEmpDefault){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(phoneEmpDefault,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					phoneEmpDefault.EmployeeNum=DbHelper.GetNextOracleKey("phoneempdefault","EmployeeNum"); //Cacheless method
				}
				return InsertNoCache(phoneEmpDefault,true);
			}
		}

		///<summary>Inserts one PhoneEmpDefault into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PhoneEmpDefault phoneEmpDefault,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO phoneempdefault (";
			if(!useExistingPK && isRandomKeys) {
				phoneEmpDefault.EmployeeNum=ReplicationServers.GetKeyNoCache("phoneempdefault","EmployeeNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="EmployeeNum,";
			}
			command+="IsGraphed,HasColor,RingGroups,EmpName,PhoneExt,StatusOverride,Notes,IsPrivateScreen,IsTriageOperator,EscalationOrder,SiteNum) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(phoneEmpDefault.EmployeeNum)+",";
			}
			command+=
				     POut.Bool  (phoneEmpDefault.IsGraphed)+","
				+    POut.Bool  (phoneEmpDefault.HasColor)+","
				+    POut.Int   ((int)phoneEmpDefault.RingGroups)+","
				+"'"+POut.String(phoneEmpDefault.EmpName)+"',"
				+    POut.Int   (phoneEmpDefault.PhoneExt)+","
				+    POut.Int   ((int)phoneEmpDefault.StatusOverride)+","
				+"'"+POut.String(phoneEmpDefault.Notes)+"',"
				+    POut.Bool  (phoneEmpDefault.IsPrivateScreen)+","
				+    POut.Bool  (phoneEmpDefault.IsTriageOperator)+","
				+    POut.Int   (phoneEmpDefault.EscalationOrder)+","
				+    POut.Long  (phoneEmpDefault.SiteNum)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				phoneEmpDefault.EmployeeNum=Db.NonQ(command,true,"EmployeeNum","phoneEmpDefault");
			}
			return phoneEmpDefault.EmployeeNum;
		}

		///<summary>Updates one PhoneEmpDefault in the database.</summary>
		public static void Update(PhoneEmpDefault phoneEmpDefault){
			string command="UPDATE phoneempdefault SET "
				+"IsGraphed       =  "+POut.Bool  (phoneEmpDefault.IsGraphed)+", "
				+"HasColor        =  "+POut.Bool  (phoneEmpDefault.HasColor)+", "
				+"RingGroups      =  "+POut.Int   ((int)phoneEmpDefault.RingGroups)+", "
				+"EmpName         = '"+POut.String(phoneEmpDefault.EmpName)+"', "
				+"PhoneExt        =  "+POut.Int   (phoneEmpDefault.PhoneExt)+", "
				+"StatusOverride  =  "+POut.Int   ((int)phoneEmpDefault.StatusOverride)+", "
				+"Notes           = '"+POut.String(phoneEmpDefault.Notes)+"', "
				+"IsPrivateScreen =  "+POut.Bool  (phoneEmpDefault.IsPrivateScreen)+", "
				+"IsTriageOperator=  "+POut.Bool  (phoneEmpDefault.IsTriageOperator)+", "
				+"EscalationOrder =  "+POut.Int   (phoneEmpDefault.EscalationOrder)+", "
				+"SiteNum         =  "+POut.Long  (phoneEmpDefault.SiteNum)+" "
				+"WHERE EmployeeNum = "+POut.Long(phoneEmpDefault.EmployeeNum);
			Db.NonQ(command);
		}

		///<summary>Updates one PhoneEmpDefault in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(PhoneEmpDefault phoneEmpDefault,PhoneEmpDefault oldPhoneEmpDefault){
			string command="";
			if(phoneEmpDefault.IsGraphed != oldPhoneEmpDefault.IsGraphed) {
				if(command!=""){ command+=",";}
				command+="IsGraphed = "+POut.Bool(phoneEmpDefault.IsGraphed)+"";
			}
			if(phoneEmpDefault.HasColor != oldPhoneEmpDefault.HasColor) {
				if(command!=""){ command+=",";}
				command+="HasColor = "+POut.Bool(phoneEmpDefault.HasColor)+"";
			}
			if(phoneEmpDefault.RingGroups != oldPhoneEmpDefault.RingGroups) {
				if(command!=""){ command+=",";}
				command+="RingGroups = "+POut.Int   ((int)phoneEmpDefault.RingGroups)+"";
			}
			if(phoneEmpDefault.EmpName != oldPhoneEmpDefault.EmpName) {
				if(command!=""){ command+=",";}
				command+="EmpName = '"+POut.String(phoneEmpDefault.EmpName)+"'";
			}
			if(phoneEmpDefault.PhoneExt != oldPhoneEmpDefault.PhoneExt) {
				if(command!=""){ command+=",";}
				command+="PhoneExt = "+POut.Int(phoneEmpDefault.PhoneExt)+"";
			}
			if(phoneEmpDefault.StatusOverride != oldPhoneEmpDefault.StatusOverride) {
				if(command!=""){ command+=",";}
				command+="StatusOverride = "+POut.Int   ((int)phoneEmpDefault.StatusOverride)+"";
			}
			if(phoneEmpDefault.Notes != oldPhoneEmpDefault.Notes) {
				if(command!=""){ command+=",";}
				command+="Notes = '"+POut.String(phoneEmpDefault.Notes)+"'";
			}
			if(phoneEmpDefault.IsPrivateScreen != oldPhoneEmpDefault.IsPrivateScreen) {
				if(command!=""){ command+=",";}
				command+="IsPrivateScreen = "+POut.Bool(phoneEmpDefault.IsPrivateScreen)+"";
			}
			if(phoneEmpDefault.IsTriageOperator != oldPhoneEmpDefault.IsTriageOperator) {
				if(command!=""){ command+=",";}
				command+="IsTriageOperator = "+POut.Bool(phoneEmpDefault.IsTriageOperator)+"";
			}
			if(phoneEmpDefault.EscalationOrder != oldPhoneEmpDefault.EscalationOrder) {
				if(command!=""){ command+=",";}
				command+="EscalationOrder = "+POut.Int(phoneEmpDefault.EscalationOrder)+"";
			}
			if(phoneEmpDefault.SiteNum != oldPhoneEmpDefault.SiteNum) {
				if(command!=""){ command+=",";}
				command+="SiteNum = "+POut.Long(phoneEmpDefault.SiteNum)+"";
			}
			if(command==""){
				return false;
			}
			command="UPDATE phoneempdefault SET "+command
				+" WHERE EmployeeNum = "+POut.Long(phoneEmpDefault.EmployeeNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(PhoneEmpDefault,PhoneEmpDefault) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(PhoneEmpDefault phoneEmpDefault,PhoneEmpDefault oldPhoneEmpDefault) {
			if(phoneEmpDefault.IsGraphed != oldPhoneEmpDefault.IsGraphed) {
				return true;
			}
			if(phoneEmpDefault.HasColor != oldPhoneEmpDefault.HasColor) {
				return true;
			}
			if(phoneEmpDefault.RingGroups != oldPhoneEmpDefault.RingGroups) {
				return true;
			}
			if(phoneEmpDefault.EmpName != oldPhoneEmpDefault.EmpName) {
				return true;
			}
			if(phoneEmpDefault.PhoneExt != oldPhoneEmpDefault.PhoneExt) {
				return true;
			}
			if(phoneEmpDefault.StatusOverride != oldPhoneEmpDefault.StatusOverride) {
				return true;
			}
			if(phoneEmpDefault.Notes != oldPhoneEmpDefault.Notes) {
				return true;
			}
			if(phoneEmpDefault.IsPrivateScreen != oldPhoneEmpDefault.IsPrivateScreen) {
				return true;
			}
			if(phoneEmpDefault.IsTriageOperator != oldPhoneEmpDefault.IsTriageOperator) {
				return true;
			}
			if(phoneEmpDefault.EscalationOrder != oldPhoneEmpDefault.EscalationOrder) {
				return true;
			}
			if(phoneEmpDefault.SiteNum != oldPhoneEmpDefault.SiteNum) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one PhoneEmpDefault from the database.</summary>
		public static void Delete(long employeeNum){
			string command="DELETE FROM phoneempdefault "
				+"WHERE EmployeeNum = "+POut.Long(employeeNum);
			Db.NonQ(command);
		}

	}
}