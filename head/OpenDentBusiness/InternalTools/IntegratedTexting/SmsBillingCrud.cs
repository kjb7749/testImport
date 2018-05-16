//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class SmsBillingCrud {
		///<summary>Gets one SmsBilling object from the database using the primary key.  Returns null if not found.</summary>
		public static SmsBilling SelectOne(long smsBillingNum){
			string command="SELECT * FROM smsbilling "
				+"WHERE SmsBillingNum = "+POut.Long(smsBillingNum);
			List<SmsBilling> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one SmsBilling object from the database using a query.</summary>
		public static SmsBilling SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<SmsBilling> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of SmsBilling objects from the database using a query.</summary>
		public static List<SmsBilling> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<SmsBilling> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<SmsBilling> TableToList(DataTable table){
			List<SmsBilling> retVal=new List<SmsBilling>();
			SmsBilling smsBilling;
			foreach(DataRow row in table.Rows) {
				smsBilling=new SmsBilling();
				smsBilling.SmsBillingNum             = PIn.Long  (row["SmsBillingNum"].ToString());
				smsBilling.RegistrationKeyNum        = PIn.Long  (row["RegistrationKeyNum"].ToString());
				smsBilling.CustPatNum                = PIn.Long  (row["CustPatNum"].ToString());
				smsBilling.DateUsage                 = PIn.Date  (row["DateUsage"].ToString());
				smsBilling.MsgChargeTotalUSD         = PIn.Float (row["MsgChargeTotalUSD"].ToString());
				smsBilling.AccessChargeTotalUSD      = PIn.Float (row["AccessChargeTotalUSD"].ToString());
				smsBilling.ClinicsTotalCount         = PIn.Int   (row["ClinicsTotalCount"].ToString());
				smsBilling.ClinicsActiveCount        = PIn.Int   (row["ClinicsActiveCount"].ToString());
				smsBilling.ClinicsUsedCount          = PIn.Int   (row["ClinicsUsedCount"].ToString());
				smsBilling.PhonesTotalCount          = PIn.Int   (row["PhonesTotalCount"].ToString());
				smsBilling.PhonesActiveCount         = PIn.Int   (row["PhonesActiveCount"].ToString());
				smsBilling.PhonesUsedCount           = PIn.Int   (row["PhonesUsedCount"].ToString());
				smsBilling.MsgSentOkCount            = PIn.Int   (row["MsgSentOkCount"].ToString());
				smsBilling.MsgRcvOkCount             = PIn.Int   (row["MsgRcvOkCount"].ToString());
				smsBilling.MsgSentFailCount          = PIn.Int   (row["MsgSentFailCount"].ToString());
				smsBilling.MsgRcvFailCount           = PIn.Int   (row["MsgRcvFailCount"].ToString());
				smsBilling.ConfirmationClinics       = PIn.Int   (row["ConfirmationClinics"].ToString());
				smsBilling.ConfirmationsTotal        = PIn.Int   (row["ConfirmationsTotal"].ToString());
				smsBilling.ConfirmationsEmail        = PIn.Int   (row["ConfirmationsEmail"].ToString());
				smsBilling.ConfirmationsSms          = PIn.Int   (row["ConfirmationsSms"].ToString());
				smsBilling.ConfirmationChargeTotalUSD= PIn.Float (row["ConfirmationChargeTotalUSD"].ToString());
				smsBilling.BillingDescSms            = PIn.String(row["BillingDescSms"].ToString());
				smsBilling.BillingDescConfirmation   = PIn.String(row["BillingDescConfirmation"].ToString());
				retVal.Add(smsBilling);
			}
			return retVal;
		}

		///<summary>Converts a list of SmsBilling into a DataTable.</summary>
		public static DataTable ListToTable(List<SmsBilling> listSmsBillings,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="SmsBilling";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("SmsBillingNum");
			table.Columns.Add("RegistrationKeyNum");
			table.Columns.Add("CustPatNum");
			table.Columns.Add("DateUsage");
			table.Columns.Add("MsgChargeTotalUSD");
			table.Columns.Add("AccessChargeTotalUSD");
			table.Columns.Add("ClinicsTotalCount");
			table.Columns.Add("ClinicsActiveCount");
			table.Columns.Add("ClinicsUsedCount");
			table.Columns.Add("PhonesTotalCount");
			table.Columns.Add("PhonesActiveCount");
			table.Columns.Add("PhonesUsedCount");
			table.Columns.Add("MsgSentOkCount");
			table.Columns.Add("MsgRcvOkCount");
			table.Columns.Add("MsgSentFailCount");
			table.Columns.Add("MsgRcvFailCount");
			table.Columns.Add("ConfirmationClinics");
			table.Columns.Add("ConfirmationsTotal");
			table.Columns.Add("ConfirmationsEmail");
			table.Columns.Add("ConfirmationsSms");
			table.Columns.Add("ConfirmationChargeTotalUSD");
			table.Columns.Add("BillingDescSms");
			table.Columns.Add("BillingDescConfirmation");
			foreach(SmsBilling smsBilling in listSmsBillings) {
				table.Rows.Add(new object[] {
					POut.Long  (smsBilling.SmsBillingNum),
					POut.Long  (smsBilling.RegistrationKeyNum),
					POut.Long  (smsBilling.CustPatNum),
					POut.DateT (smsBilling.DateUsage,false),
					POut.Float (smsBilling.MsgChargeTotalUSD),
					POut.Float (smsBilling.AccessChargeTotalUSD),
					POut.Int   (smsBilling.ClinicsTotalCount),
					POut.Int   (smsBilling.ClinicsActiveCount),
					POut.Int   (smsBilling.ClinicsUsedCount),
					POut.Int   (smsBilling.PhonesTotalCount),
					POut.Int   (smsBilling.PhonesActiveCount),
					POut.Int   (smsBilling.PhonesUsedCount),
					POut.Int   (smsBilling.MsgSentOkCount),
					POut.Int   (smsBilling.MsgRcvOkCount),
					POut.Int   (smsBilling.MsgSentFailCount),
					POut.Int   (smsBilling.MsgRcvFailCount),
					POut.Int   (smsBilling.ConfirmationClinics),
					POut.Int   (smsBilling.ConfirmationsTotal),
					POut.Int   (smsBilling.ConfirmationsEmail),
					POut.Int   (smsBilling.ConfirmationsSms),
					POut.Float (smsBilling.ConfirmationChargeTotalUSD),
					            smsBilling.BillingDescSms,
					            smsBilling.BillingDescConfirmation,
				});
			}
			return table;
		}

		///<summary>Inserts one SmsBilling into the database.  Returns the new priKey.</summary>
		public static long Insert(SmsBilling smsBilling){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				smsBilling.SmsBillingNum=DbHelper.GetNextOracleKey("smsbilling","SmsBillingNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(smsBilling,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							smsBilling.SmsBillingNum++;
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
				return Insert(smsBilling,false);
			}
		}

		///<summary>Inserts one SmsBilling into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(SmsBilling smsBilling,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				smsBilling.SmsBillingNum=ReplicationServers.GetKey("smsbilling","SmsBillingNum");
			}
			string command="INSERT INTO smsbilling (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="SmsBillingNum,";
			}
			command+="RegistrationKeyNum,CustPatNum,DateUsage,MsgChargeTotalUSD,AccessChargeTotalUSD,ClinicsTotalCount,ClinicsActiveCount,ClinicsUsedCount,PhonesTotalCount,PhonesActiveCount,PhonesUsedCount,MsgSentOkCount,MsgRcvOkCount,MsgSentFailCount,MsgRcvFailCount,ConfirmationClinics,ConfirmationsTotal,ConfirmationsEmail,ConfirmationsSms,ConfirmationChargeTotalUSD,BillingDescSms,BillingDescConfirmation) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(smsBilling.SmsBillingNum)+",";
			}
			command+=
				     POut.Long  (smsBilling.RegistrationKeyNum)+","
				+    POut.Long  (smsBilling.CustPatNum)+","
				+    POut.Date  (smsBilling.DateUsage)+","
				+    POut.Float (smsBilling.MsgChargeTotalUSD)+","
				+    POut.Float (smsBilling.AccessChargeTotalUSD)+","
				+    POut.Int   (smsBilling.ClinicsTotalCount)+","
				+    POut.Int   (smsBilling.ClinicsActiveCount)+","
				+    POut.Int   (smsBilling.ClinicsUsedCount)+","
				+    POut.Int   (smsBilling.PhonesTotalCount)+","
				+    POut.Int   (smsBilling.PhonesActiveCount)+","
				+    POut.Int   (smsBilling.PhonesUsedCount)+","
				+    POut.Int   (smsBilling.MsgSentOkCount)+","
				+    POut.Int   (smsBilling.MsgRcvOkCount)+","
				+    POut.Int   (smsBilling.MsgSentFailCount)+","
				+    POut.Int   (smsBilling.MsgRcvFailCount)+","
				+    POut.Int   (smsBilling.ConfirmationClinics)+","
				+    POut.Int   (smsBilling.ConfirmationsTotal)+","
				+    POut.Int   (smsBilling.ConfirmationsEmail)+","
				+    POut.Int   (smsBilling.ConfirmationsSms)+","
				+    POut.Float (smsBilling.ConfirmationChargeTotalUSD)+","
				+    DbHelper.ParamChar+"paramBillingDescSms,"
				+    DbHelper.ParamChar+"paramBillingDescConfirmation)";
			if(smsBilling.BillingDescSms==null) {
				smsBilling.BillingDescSms="";
			}
			OdSqlParameter paramBillingDescSms=new OdSqlParameter("paramBillingDescSms",OdDbType.Text,smsBilling.BillingDescSms);
			if(smsBilling.BillingDescConfirmation==null) {
				smsBilling.BillingDescConfirmation="";
			}
			OdSqlParameter paramBillingDescConfirmation=new OdSqlParameter("paramBillingDescConfirmation",OdDbType.Text,smsBilling.BillingDescConfirmation);
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramBillingDescSms,paramBillingDescConfirmation);
			}
			else {
				smsBilling.SmsBillingNum=Db.NonQ(command,true,paramBillingDescSms,paramBillingDescConfirmation);
			}
			return smsBilling.SmsBillingNum;
		}

		///<summary>Inserts one SmsBilling into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(SmsBilling smsBilling){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(smsBilling,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					smsBilling.SmsBillingNum=DbHelper.GetNextOracleKey("smsbilling","SmsBillingNum"); //Cacheless method
				}
				return InsertNoCache(smsBilling,true);
			}
		}

		///<summary>Inserts one SmsBilling into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(SmsBilling smsBilling,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO smsbilling (";
			if(!useExistingPK && isRandomKeys) {
				smsBilling.SmsBillingNum=ReplicationServers.GetKeyNoCache("smsbilling","SmsBillingNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="SmsBillingNum,";
			}
			command+="RegistrationKeyNum,CustPatNum,DateUsage,MsgChargeTotalUSD,AccessChargeTotalUSD,ClinicsTotalCount,ClinicsActiveCount,ClinicsUsedCount,PhonesTotalCount,PhonesActiveCount,PhonesUsedCount,MsgSentOkCount,MsgRcvOkCount,MsgSentFailCount,MsgRcvFailCount,ConfirmationClinics,ConfirmationsTotal,ConfirmationsEmail,ConfirmationsSms,ConfirmationChargeTotalUSD,BillingDescSms,BillingDescConfirmation) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(smsBilling.SmsBillingNum)+",";
			}
			command+=
				     POut.Long  (smsBilling.RegistrationKeyNum)+","
				+    POut.Long  (smsBilling.CustPatNum)+","
				+    POut.Date  (smsBilling.DateUsage)+","
				+    POut.Float (smsBilling.MsgChargeTotalUSD)+","
				+    POut.Float (smsBilling.AccessChargeTotalUSD)+","
				+    POut.Int   (smsBilling.ClinicsTotalCount)+","
				+    POut.Int   (smsBilling.ClinicsActiveCount)+","
				+    POut.Int   (smsBilling.ClinicsUsedCount)+","
				+    POut.Int   (smsBilling.PhonesTotalCount)+","
				+    POut.Int   (smsBilling.PhonesActiveCount)+","
				+    POut.Int   (smsBilling.PhonesUsedCount)+","
				+    POut.Int   (smsBilling.MsgSentOkCount)+","
				+    POut.Int   (smsBilling.MsgRcvOkCount)+","
				+    POut.Int   (smsBilling.MsgSentFailCount)+","
				+    POut.Int   (smsBilling.MsgRcvFailCount)+","
				+    POut.Int   (smsBilling.ConfirmationClinics)+","
				+    POut.Int   (smsBilling.ConfirmationsTotal)+","
				+    POut.Int   (smsBilling.ConfirmationsEmail)+","
				+    POut.Int   (smsBilling.ConfirmationsSms)+","
				+    POut.Float (smsBilling.ConfirmationChargeTotalUSD)+","
				+    DbHelper.ParamChar+"paramBillingDescSms,"
				+    DbHelper.ParamChar+"paramBillingDescConfirmation)";
			if(smsBilling.BillingDescSms==null) {
				smsBilling.BillingDescSms="";
			}
			OdSqlParameter paramBillingDescSms=new OdSqlParameter("paramBillingDescSms",OdDbType.Text,smsBilling.BillingDescSms);
			if(smsBilling.BillingDescConfirmation==null) {
				smsBilling.BillingDescConfirmation="";
			}
			OdSqlParameter paramBillingDescConfirmation=new OdSqlParameter("paramBillingDescConfirmation",OdDbType.Text,smsBilling.BillingDescConfirmation);
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramBillingDescSms,paramBillingDescConfirmation);
			}
			else {
				smsBilling.SmsBillingNum=Db.NonQ(command,true,paramBillingDescSms,paramBillingDescConfirmation);
			}
			return smsBilling.SmsBillingNum;
		}

		///<summary>Updates one SmsBilling in the database.</summary>
		public static void Update(SmsBilling smsBilling){
			string command="UPDATE smsbilling SET "
				+"RegistrationKeyNum        =  "+POut.Long  (smsBilling.RegistrationKeyNum)+", "
				+"CustPatNum                =  "+POut.Long  (smsBilling.CustPatNum)+", "
				+"DateUsage                 =  "+POut.Date  (smsBilling.DateUsage)+", "
				+"MsgChargeTotalUSD         =  "+POut.Float (smsBilling.MsgChargeTotalUSD)+", "
				+"AccessChargeTotalUSD      =  "+POut.Float (smsBilling.AccessChargeTotalUSD)+", "
				+"ClinicsTotalCount         =  "+POut.Int   (smsBilling.ClinicsTotalCount)+", "
				+"ClinicsActiveCount        =  "+POut.Int   (smsBilling.ClinicsActiveCount)+", "
				+"ClinicsUsedCount          =  "+POut.Int   (smsBilling.ClinicsUsedCount)+", "
				+"PhonesTotalCount          =  "+POut.Int   (smsBilling.PhonesTotalCount)+", "
				+"PhonesActiveCount         =  "+POut.Int   (smsBilling.PhonesActiveCount)+", "
				+"PhonesUsedCount           =  "+POut.Int   (smsBilling.PhonesUsedCount)+", "
				+"MsgSentOkCount            =  "+POut.Int   (smsBilling.MsgSentOkCount)+", "
				+"MsgRcvOkCount             =  "+POut.Int   (smsBilling.MsgRcvOkCount)+", "
				+"MsgSentFailCount          =  "+POut.Int   (smsBilling.MsgSentFailCount)+", "
				+"MsgRcvFailCount           =  "+POut.Int   (smsBilling.MsgRcvFailCount)+", "
				+"ConfirmationClinics       =  "+POut.Int   (smsBilling.ConfirmationClinics)+", "
				+"ConfirmationsTotal        =  "+POut.Int   (smsBilling.ConfirmationsTotal)+", "
				+"ConfirmationsEmail        =  "+POut.Int   (smsBilling.ConfirmationsEmail)+", "
				+"ConfirmationsSms          =  "+POut.Int   (smsBilling.ConfirmationsSms)+", "
				+"ConfirmationChargeTotalUSD=  "+POut.Float (smsBilling.ConfirmationChargeTotalUSD)+", "
				+"BillingDescSms            =  "+DbHelper.ParamChar+"paramBillingDescSms, "
				+"BillingDescConfirmation   =  "+DbHelper.ParamChar+"paramBillingDescConfirmation "
				+"WHERE SmsBillingNum = "+POut.Long(smsBilling.SmsBillingNum);
			if(smsBilling.BillingDescSms==null) {
				smsBilling.BillingDescSms="";
			}
			OdSqlParameter paramBillingDescSms=new OdSqlParameter("paramBillingDescSms",OdDbType.Text,smsBilling.BillingDescSms);
			if(smsBilling.BillingDescConfirmation==null) {
				smsBilling.BillingDescConfirmation="";
			}
			OdSqlParameter paramBillingDescConfirmation=new OdSqlParameter("paramBillingDescConfirmation",OdDbType.Text,smsBilling.BillingDescConfirmation);
			Db.NonQ(command,paramBillingDescSms,paramBillingDescConfirmation);
		}

		///<summary>Updates one SmsBilling in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(SmsBilling smsBilling,SmsBilling oldSmsBilling){
			string command="";
			if(smsBilling.RegistrationKeyNum != oldSmsBilling.RegistrationKeyNum) {
				if(command!=""){ command+=",";}
				command+="RegistrationKeyNum = "+POut.Long(smsBilling.RegistrationKeyNum)+"";
			}
			if(smsBilling.CustPatNum != oldSmsBilling.CustPatNum) {
				if(command!=""){ command+=",";}
				command+="CustPatNum = "+POut.Long(smsBilling.CustPatNum)+"";
			}
			if(smsBilling.DateUsage.Date != oldSmsBilling.DateUsage.Date) {
				if(command!=""){ command+=",";}
				command+="DateUsage = "+POut.Date(smsBilling.DateUsage)+"";
			}
			if(smsBilling.MsgChargeTotalUSD != oldSmsBilling.MsgChargeTotalUSD) {
				if(command!=""){ command+=",";}
				command+="MsgChargeTotalUSD = "+POut.Float(smsBilling.MsgChargeTotalUSD)+"";
			}
			if(smsBilling.AccessChargeTotalUSD != oldSmsBilling.AccessChargeTotalUSD) {
				if(command!=""){ command+=",";}
				command+="AccessChargeTotalUSD = "+POut.Float(smsBilling.AccessChargeTotalUSD)+"";
			}
			if(smsBilling.ClinicsTotalCount != oldSmsBilling.ClinicsTotalCount) {
				if(command!=""){ command+=",";}
				command+="ClinicsTotalCount = "+POut.Int(smsBilling.ClinicsTotalCount)+"";
			}
			if(smsBilling.ClinicsActiveCount != oldSmsBilling.ClinicsActiveCount) {
				if(command!=""){ command+=",";}
				command+="ClinicsActiveCount = "+POut.Int(smsBilling.ClinicsActiveCount)+"";
			}
			if(smsBilling.ClinicsUsedCount != oldSmsBilling.ClinicsUsedCount) {
				if(command!=""){ command+=",";}
				command+="ClinicsUsedCount = "+POut.Int(smsBilling.ClinicsUsedCount)+"";
			}
			if(smsBilling.PhonesTotalCount != oldSmsBilling.PhonesTotalCount) {
				if(command!=""){ command+=",";}
				command+="PhonesTotalCount = "+POut.Int(smsBilling.PhonesTotalCount)+"";
			}
			if(smsBilling.PhonesActiveCount != oldSmsBilling.PhonesActiveCount) {
				if(command!=""){ command+=",";}
				command+="PhonesActiveCount = "+POut.Int(smsBilling.PhonesActiveCount)+"";
			}
			if(smsBilling.PhonesUsedCount != oldSmsBilling.PhonesUsedCount) {
				if(command!=""){ command+=",";}
				command+="PhonesUsedCount = "+POut.Int(smsBilling.PhonesUsedCount)+"";
			}
			if(smsBilling.MsgSentOkCount != oldSmsBilling.MsgSentOkCount) {
				if(command!=""){ command+=",";}
				command+="MsgSentOkCount = "+POut.Int(smsBilling.MsgSentOkCount)+"";
			}
			if(smsBilling.MsgRcvOkCount != oldSmsBilling.MsgRcvOkCount) {
				if(command!=""){ command+=",";}
				command+="MsgRcvOkCount = "+POut.Int(smsBilling.MsgRcvOkCount)+"";
			}
			if(smsBilling.MsgSentFailCount != oldSmsBilling.MsgSentFailCount) {
				if(command!=""){ command+=",";}
				command+="MsgSentFailCount = "+POut.Int(smsBilling.MsgSentFailCount)+"";
			}
			if(smsBilling.MsgRcvFailCount != oldSmsBilling.MsgRcvFailCount) {
				if(command!=""){ command+=",";}
				command+="MsgRcvFailCount = "+POut.Int(smsBilling.MsgRcvFailCount)+"";
			}
			if(smsBilling.ConfirmationClinics != oldSmsBilling.ConfirmationClinics) {
				if(command!=""){ command+=",";}
				command+="ConfirmationClinics = "+POut.Int(smsBilling.ConfirmationClinics)+"";
			}
			if(smsBilling.ConfirmationsTotal != oldSmsBilling.ConfirmationsTotal) {
				if(command!=""){ command+=",";}
				command+="ConfirmationsTotal = "+POut.Int(smsBilling.ConfirmationsTotal)+"";
			}
			if(smsBilling.ConfirmationsEmail != oldSmsBilling.ConfirmationsEmail) {
				if(command!=""){ command+=",";}
				command+="ConfirmationsEmail = "+POut.Int(smsBilling.ConfirmationsEmail)+"";
			}
			if(smsBilling.ConfirmationsSms != oldSmsBilling.ConfirmationsSms) {
				if(command!=""){ command+=",";}
				command+="ConfirmationsSms = "+POut.Int(smsBilling.ConfirmationsSms)+"";
			}
			if(smsBilling.ConfirmationChargeTotalUSD != oldSmsBilling.ConfirmationChargeTotalUSD) {
				if(command!=""){ command+=",";}
				command+="ConfirmationChargeTotalUSD = "+POut.Float(smsBilling.ConfirmationChargeTotalUSD)+"";
			}
			if(smsBilling.BillingDescSms != oldSmsBilling.BillingDescSms) {
				if(command!=""){ command+=",";}
				command+="BillingDescSms = "+DbHelper.ParamChar+"paramBillingDescSms";
			}
			if(smsBilling.BillingDescConfirmation != oldSmsBilling.BillingDescConfirmation) {
				if(command!=""){ command+=",";}
				command+="BillingDescConfirmation = "+DbHelper.ParamChar+"paramBillingDescConfirmation";
			}
			if(command==""){
				return false;
			}
			if(smsBilling.BillingDescSms==null) {
				smsBilling.BillingDescSms="";
			}
			OdSqlParameter paramBillingDescSms=new OdSqlParameter("paramBillingDescSms",OdDbType.Text,smsBilling.BillingDescSms);
			if(smsBilling.BillingDescConfirmation==null) {
				smsBilling.BillingDescConfirmation="";
			}
			OdSqlParameter paramBillingDescConfirmation=new OdSqlParameter("paramBillingDescConfirmation",OdDbType.Text,smsBilling.BillingDescConfirmation);
			command="UPDATE smsbilling SET "+command
				+" WHERE SmsBillingNum = "+POut.Long(smsBilling.SmsBillingNum);
			Db.NonQ(command,paramBillingDescSms,paramBillingDescConfirmation);
			return true;
		}

		///<summary>Returns true if Update(SmsBilling,SmsBilling) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(SmsBilling smsBilling,SmsBilling oldSmsBilling) {
			if(smsBilling.RegistrationKeyNum != oldSmsBilling.RegistrationKeyNum) {
				return true;
			}
			if(smsBilling.CustPatNum != oldSmsBilling.CustPatNum) {
				return true;
			}
			if(smsBilling.DateUsage.Date != oldSmsBilling.DateUsage.Date) {
				return true;
			}
			if(smsBilling.MsgChargeTotalUSD != oldSmsBilling.MsgChargeTotalUSD) {
				return true;
			}
			if(smsBilling.AccessChargeTotalUSD != oldSmsBilling.AccessChargeTotalUSD) {
				return true;
			}
			if(smsBilling.ClinicsTotalCount != oldSmsBilling.ClinicsTotalCount) {
				return true;
			}
			if(smsBilling.ClinicsActiveCount != oldSmsBilling.ClinicsActiveCount) {
				return true;
			}
			if(smsBilling.ClinicsUsedCount != oldSmsBilling.ClinicsUsedCount) {
				return true;
			}
			if(smsBilling.PhonesTotalCount != oldSmsBilling.PhonesTotalCount) {
				return true;
			}
			if(smsBilling.PhonesActiveCount != oldSmsBilling.PhonesActiveCount) {
				return true;
			}
			if(smsBilling.PhonesUsedCount != oldSmsBilling.PhonesUsedCount) {
				return true;
			}
			if(smsBilling.MsgSentOkCount != oldSmsBilling.MsgSentOkCount) {
				return true;
			}
			if(smsBilling.MsgRcvOkCount != oldSmsBilling.MsgRcvOkCount) {
				return true;
			}
			if(smsBilling.MsgSentFailCount != oldSmsBilling.MsgSentFailCount) {
				return true;
			}
			if(smsBilling.MsgRcvFailCount != oldSmsBilling.MsgRcvFailCount) {
				return true;
			}
			if(smsBilling.ConfirmationClinics != oldSmsBilling.ConfirmationClinics) {
				return true;
			}
			if(smsBilling.ConfirmationsTotal != oldSmsBilling.ConfirmationsTotal) {
				return true;
			}
			if(smsBilling.ConfirmationsEmail != oldSmsBilling.ConfirmationsEmail) {
				return true;
			}
			if(smsBilling.ConfirmationsSms != oldSmsBilling.ConfirmationsSms) {
				return true;
			}
			if(smsBilling.ConfirmationChargeTotalUSD != oldSmsBilling.ConfirmationChargeTotalUSD) {
				return true;
			}
			if(smsBilling.BillingDescSms != oldSmsBilling.BillingDescSms) {
				return true;
			}
			if(smsBilling.BillingDescConfirmation != oldSmsBilling.BillingDescConfirmation) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one SmsBilling from the database.</summary>
		public static void Delete(long smsBillingNum){
			string command="DELETE FROM smsbilling "
				+"WHERE SmsBillingNum = "+POut.Long(smsBillingNum);
			Db.NonQ(command);
		}

	}
}