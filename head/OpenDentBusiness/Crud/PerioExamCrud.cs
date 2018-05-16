//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class PerioExamCrud {
		///<summary>Gets one PerioExam object from the database using the primary key.  Returns null if not found.</summary>
		public static PerioExam SelectOne(long perioExamNum){
			string command="SELECT * FROM perioexam "
				+"WHERE PerioExamNum = "+POut.Long(perioExamNum);
			List<PerioExam> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one PerioExam object from the database using a query.</summary>
		public static PerioExam SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PerioExam> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of PerioExam objects from the database using a query.</summary>
		public static List<PerioExam> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<PerioExam> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<PerioExam> TableToList(DataTable table){
			List<PerioExam> retVal=new List<PerioExam>();
			PerioExam perioExam;
			foreach(DataRow row in table.Rows) {
				perioExam=new PerioExam();
				perioExam.PerioExamNum    = PIn.Long  (row["PerioExamNum"].ToString());
				perioExam.PatNum          = PIn.Long  (row["PatNum"].ToString());
				perioExam.ExamDate        = PIn.Date  (row["ExamDate"].ToString());
				perioExam.ProvNum         = PIn.Long  (row["ProvNum"].ToString());
				perioExam.DateTMeasureEdit= PIn.DateT (row["DateTMeasureEdit"].ToString());
				retVal.Add(perioExam);
			}
			return retVal;
		}

		///<summary>Converts a list of PerioExam into a DataTable.</summary>
		public static DataTable ListToTable(List<PerioExam> listPerioExams,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="PerioExam";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("PerioExamNum");
			table.Columns.Add("PatNum");
			table.Columns.Add("ExamDate");
			table.Columns.Add("ProvNum");
			table.Columns.Add("DateTMeasureEdit");
			foreach(PerioExam perioExam in listPerioExams) {
				table.Rows.Add(new object[] {
					POut.Long  (perioExam.PerioExamNum),
					POut.Long  (perioExam.PatNum),
					POut.DateT (perioExam.ExamDate,false),
					POut.Long  (perioExam.ProvNum),
					POut.DateT (perioExam.DateTMeasureEdit,false),
				});
			}
			return table;
		}

		///<summary>Inserts one PerioExam into the database.  Returns the new priKey.</summary>
		public static long Insert(PerioExam perioExam){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				perioExam.PerioExamNum=DbHelper.GetNextOracleKey("perioexam","PerioExamNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(perioExam,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							perioExam.PerioExamNum++;
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
				return Insert(perioExam,false);
			}
		}

		///<summary>Inserts one PerioExam into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(PerioExam perioExam,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				perioExam.PerioExamNum=ReplicationServers.GetKey("perioexam","PerioExamNum");
			}
			string command="INSERT INTO perioexam (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="PerioExamNum,";
			}
			command+="PatNum,ExamDate,ProvNum,DateTMeasureEdit) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(perioExam.PerioExamNum)+",";
			}
			command+=
				     POut.Long  (perioExam.PatNum)+","
				+    POut.Date  (perioExam.ExamDate)+","
				+    POut.Long  (perioExam.ProvNum)+","
				+    DbHelper.Now()+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				perioExam.PerioExamNum=Db.NonQ(command,true,"PerioExamNum","perioExam");
			}
			return perioExam.PerioExamNum;
		}

		///<summary>Inserts one PerioExam into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PerioExam perioExam){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(perioExam,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					perioExam.PerioExamNum=DbHelper.GetNextOracleKey("perioexam","PerioExamNum"); //Cacheless method
				}
				return InsertNoCache(perioExam,true);
			}
		}

		///<summary>Inserts one PerioExam into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(PerioExam perioExam,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO perioexam (";
			if(!useExistingPK && isRandomKeys) {
				perioExam.PerioExamNum=ReplicationServers.GetKeyNoCache("perioexam","PerioExamNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="PerioExamNum,";
			}
			command+="PatNum,ExamDate,ProvNum,DateTMeasureEdit) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(perioExam.PerioExamNum)+",";
			}
			command+=
				     POut.Long  (perioExam.PatNum)+","
				+    POut.Date  (perioExam.ExamDate)+","
				+    POut.Long  (perioExam.ProvNum)+","
				+    DbHelper.Now()+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				perioExam.PerioExamNum=Db.NonQ(command,true,"PerioExamNum","perioExam");
			}
			return perioExam.PerioExamNum;
		}

		///<summary>Updates one PerioExam in the database.</summary>
		public static void Update(PerioExam perioExam){
			string command="UPDATE perioexam SET "
				+"PatNum          =  "+POut.Long  (perioExam.PatNum)+", "
				+"ExamDate        =  "+POut.Date  (perioExam.ExamDate)+", "
				+"ProvNum         =  "+POut.Long  (perioExam.ProvNum)+", "
				+"DateTMeasureEdit=  "+POut.DateT (perioExam.DateTMeasureEdit)+" "
				+"WHERE PerioExamNum = "+POut.Long(perioExam.PerioExamNum);
			Db.NonQ(command);
		}

		///<summary>Updates one PerioExam in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(PerioExam perioExam,PerioExam oldPerioExam){
			string command="";
			if(perioExam.PatNum != oldPerioExam.PatNum) {
				if(command!=""){ command+=",";}
				command+="PatNum = "+POut.Long(perioExam.PatNum)+"";
			}
			if(perioExam.ExamDate.Date != oldPerioExam.ExamDate.Date) {
				if(command!=""){ command+=",";}
				command+="ExamDate = "+POut.Date(perioExam.ExamDate)+"";
			}
			if(perioExam.ProvNum != oldPerioExam.ProvNum) {
				if(command!=""){ command+=",";}
				command+="ProvNum = "+POut.Long(perioExam.ProvNum)+"";
			}
			if(perioExam.DateTMeasureEdit != oldPerioExam.DateTMeasureEdit) {
				if(command!=""){ command+=",";}
				command+="DateTMeasureEdit = "+POut.DateT(perioExam.DateTMeasureEdit)+"";
			}
			if(command==""){
				return false;
			}
			command="UPDATE perioexam SET "+command
				+" WHERE PerioExamNum = "+POut.Long(perioExam.PerioExamNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(PerioExam,PerioExam) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(PerioExam perioExam,PerioExam oldPerioExam) {
			if(perioExam.PatNum != oldPerioExam.PatNum) {
				return true;
			}
			if(perioExam.ExamDate.Date != oldPerioExam.ExamDate.Date) {
				return true;
			}
			if(perioExam.ProvNum != oldPerioExam.ProvNum) {
				return true;
			}
			if(perioExam.DateTMeasureEdit != oldPerioExam.DateTMeasureEdit) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one PerioExam from the database.</summary>
		public static void Delete(long perioExamNum){
			string command="DELETE FROM perioexam "
				+"WHERE PerioExamNum = "+POut.Long(perioExamNum);
			Db.NonQ(command);
		}

	}
}