//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class StatementCrud {
		///<summary>Gets one Statement object from the database using the primary key.  Returns null if not found.</summary>
		public static Statement SelectOne(long statementNum){
			string command="SELECT * FROM statement "
				+"WHERE StatementNum = "+POut.Long(statementNum);
			List<Statement> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one Statement object from the database using a query.</summary>
		public static Statement SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Statement> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of Statement objects from the database using a query.</summary>
		public static List<Statement> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<Statement> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<Statement> TableToList(DataTable table){
			List<Statement> retVal=new List<Statement>();
			Statement statement;
			foreach(DataRow row in table.Rows) {
				statement=new Statement();
				statement.StatementNum     = PIn.Long  (row["StatementNum"].ToString());
				statement.PatNum           = PIn.Long  (row["PatNum"].ToString());
				statement.SuperFamily      = PIn.Long  (row["SuperFamily"].ToString());
				statement.DateSent         = PIn.Date  (row["DateSent"].ToString());
				statement.DateRangeFrom    = PIn.Date  (row["DateRangeFrom"].ToString());
				statement.DateRangeTo      = PIn.Date  (row["DateRangeTo"].ToString());
				statement.Note             = PIn.String(row["Note"].ToString());
				statement.NoteBold         = PIn.String(row["NoteBold"].ToString());
				statement.Mode_            = (OpenDentBusiness.StatementMode)PIn.Int(row["Mode_"].ToString());
				statement.HidePayment      = PIn.Bool  (row["HidePayment"].ToString());
				statement.SinglePatient    = PIn.Bool  (row["SinglePatient"].ToString());
				statement.Intermingled     = PIn.Bool  (row["Intermingled"].ToString());
				statement.IsSent           = PIn.Bool  (row["IsSent"].ToString());
				statement.DocNum           = PIn.Long  (row["DocNum"].ToString());
				statement.DateTStamp       = PIn.DateT (row["DateTStamp"].ToString());
				statement.IsReceipt        = PIn.Bool  (row["IsReceipt"].ToString());
				statement.IsInvoice        = PIn.Bool  (row["IsInvoice"].ToString());
				statement.IsInvoiceCopy    = PIn.Bool  (row["IsInvoiceCopy"].ToString());
				statement.EmailSubject     = PIn.String(row["EmailSubject"].ToString());
				statement.EmailBody        = PIn.String(row["EmailBody"].ToString());
				statement.IsBalValid       = PIn.Bool  (row["IsBalValid"].ToString());
				statement.InsEst           = PIn.Double(row["InsEst"].ToString());
				statement.BalTotal         = PIn.Double(row["BalTotal"].ToString());
				string statementType=row["StatementType"].ToString();
				if(statementType==""){
					statement.StatementType  =(StmtType)0;
				}
				else try{
					statement.StatementType  =(StmtType)Enum.Parse(typeof(StmtType),statementType);
				}
				catch{
					statement.StatementType  =(StmtType)0;
				}
				statement.ShortGUID        = PIn.String(row["ShortGUID"].ToString());
				statement.StatementURL     = PIn.String(row["StatementURL"].ToString());
				statement.StatementShortURL= PIn.String(row["StatementShortURL"].ToString());
				statement.SmsSendStatus    = (OpenDentBusiness.AutoCommStatus)PIn.Int(row["SmsSendStatus"].ToString());
				retVal.Add(statement);
			}
			return retVal;
		}

		///<summary>Converts a list of Statement into a DataTable.</summary>
		public static DataTable ListToTable(List<Statement> listStatements,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="Statement";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("StatementNum");
			table.Columns.Add("PatNum");
			table.Columns.Add("SuperFamily");
			table.Columns.Add("DateSent");
			table.Columns.Add("DateRangeFrom");
			table.Columns.Add("DateRangeTo");
			table.Columns.Add("Note");
			table.Columns.Add("NoteBold");
			table.Columns.Add("Mode_");
			table.Columns.Add("HidePayment");
			table.Columns.Add("SinglePatient");
			table.Columns.Add("Intermingled");
			table.Columns.Add("IsSent");
			table.Columns.Add("DocNum");
			table.Columns.Add("DateTStamp");
			table.Columns.Add("IsReceipt");
			table.Columns.Add("IsInvoice");
			table.Columns.Add("IsInvoiceCopy");
			table.Columns.Add("EmailSubject");
			table.Columns.Add("EmailBody");
			table.Columns.Add("IsBalValid");
			table.Columns.Add("InsEst");
			table.Columns.Add("BalTotal");
			table.Columns.Add("StatementType");
			table.Columns.Add("ShortGUID");
			table.Columns.Add("StatementURL");
			table.Columns.Add("StatementShortURL");
			table.Columns.Add("SmsSendStatus");
			foreach(Statement statement in listStatements) {
				table.Rows.Add(new object[] {
					POut.Long  (statement.StatementNum),
					POut.Long  (statement.PatNum),
					POut.Long  (statement.SuperFamily),
					POut.DateT (statement.DateSent,false),
					POut.DateT (statement.DateRangeFrom,false),
					POut.DateT (statement.DateRangeTo,false),
					            statement.Note,
					            statement.NoteBold,
					POut.Int   ((int)statement.Mode_),
					POut.Bool  (statement.HidePayment),
					POut.Bool  (statement.SinglePatient),
					POut.Bool  (statement.Intermingled),
					POut.Bool  (statement.IsSent),
					POut.Long  (statement.DocNum),
					POut.DateT (statement.DateTStamp,false),
					POut.Bool  (statement.IsReceipt),
					POut.Bool  (statement.IsInvoice),
					POut.Bool  (statement.IsInvoiceCopy),
					            statement.EmailSubject,
					            statement.EmailBody,
					POut.Bool  (statement.IsBalValid),
					POut.Double(statement.InsEst),
					POut.Double(statement.BalTotal),
					POut.Int   ((int)statement.StatementType),
					            statement.ShortGUID,
					            statement.StatementURL,
					            statement.StatementShortURL,
					POut.Int   ((int)statement.SmsSendStatus),
				});
			}
			return table;
		}

		///<summary>Inserts one Statement into the database.  Returns the new priKey.</summary>
		public static long Insert(Statement statement){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				statement.StatementNum=DbHelper.GetNextOracleKey("statement","StatementNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(statement,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							statement.StatementNum++;
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
				return Insert(statement,false);
			}
		}

		///<summary>Inserts one Statement into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(Statement statement,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				statement.StatementNum=ReplicationServers.GetKey("statement","StatementNum");
			}
			string command="INSERT INTO statement (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="StatementNum,";
			}
			command+="PatNum,SuperFamily,DateSent,DateRangeFrom,DateRangeTo,Note,NoteBold,Mode_,HidePayment,SinglePatient,Intermingled,IsSent,DocNum,IsReceipt,IsInvoice,IsInvoiceCopy,EmailSubject,EmailBody,IsBalValid,InsEst,BalTotal,StatementType,ShortGUID,StatementURL,StatementShortURL,SmsSendStatus) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(statement.StatementNum)+",";
			}
			command+=
				     POut.Long  (statement.PatNum)+","
				+    POut.Long  (statement.SuperFamily)+","
				+    POut.Date  (statement.DateSent)+","
				+    POut.Date  (statement.DateRangeFrom)+","
				+    POut.Date  (statement.DateRangeTo)+","
				+    DbHelper.ParamChar+"paramNote,"
				+    DbHelper.ParamChar+"paramNoteBold,"
				+    POut.Int   ((int)statement.Mode_)+","
				+    POut.Bool  (statement.HidePayment)+","
				+    POut.Bool  (statement.SinglePatient)+","
				+    POut.Bool  (statement.Intermingled)+","
				+    POut.Bool  (statement.IsSent)+","
				+    POut.Long  (statement.DocNum)+","
				//DateTStamp can only be set by MySQL
				+    POut.Bool  (statement.IsReceipt)+","
				+    POut.Bool  (statement.IsInvoice)+","
				+    POut.Bool  (statement.IsInvoiceCopy)+","
				+"'"+POut.String(statement.EmailSubject)+"',"
				+    DbHelper.ParamChar+"paramEmailBody,"
				+    POut.Bool  (statement.IsBalValid)+","
				+"'"+POut.Double(statement.InsEst)+"',"
				+"'"+POut.Double(statement.BalTotal)+"',"
				+"'"+POut.String(statement.StatementType.ToString())+"',"
				+"'"+POut.String(statement.ShortGUID)+"',"
				+"'"+POut.String(statement.StatementURL)+"',"
				+"'"+POut.String(statement.StatementShortURL)+"',"
				+    POut.Int   ((int)statement.SmsSendStatus)+")";
			if(statement.Note==null) {
				statement.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringParam(statement.Note));
			if(statement.NoteBold==null) {
				statement.NoteBold="";
			}
			OdSqlParameter paramNoteBold=new OdSqlParameter("paramNoteBold",OdDbType.Text,POut.StringParam(statement.NoteBold));
			if(statement.EmailBody==null) {
				statement.EmailBody="";
			}
			OdSqlParameter paramEmailBody=new OdSqlParameter("paramEmailBody",OdDbType.Text,POut.StringParam(statement.EmailBody));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramNote,paramNoteBold,paramEmailBody);
			}
			else {
				statement.StatementNum=Db.NonQ(command,true,"StatementNum","statement",paramNote,paramNoteBold,paramEmailBody);
			}
			return statement.StatementNum;
		}

		///<summary>Inserts one Statement into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Statement statement){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(statement,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					statement.StatementNum=DbHelper.GetNextOracleKey("statement","StatementNum"); //Cacheless method
				}
				return InsertNoCache(statement,true);
			}
		}

		///<summary>Inserts one Statement into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(Statement statement,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO statement (";
			if(!useExistingPK && isRandomKeys) {
				statement.StatementNum=ReplicationServers.GetKeyNoCache("statement","StatementNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="StatementNum,";
			}
			command+="PatNum,SuperFamily,DateSent,DateRangeFrom,DateRangeTo,Note,NoteBold,Mode_,HidePayment,SinglePatient,Intermingled,IsSent,DocNum,IsReceipt,IsInvoice,IsInvoiceCopy,EmailSubject,EmailBody,IsBalValid,InsEst,BalTotal,StatementType,ShortGUID,StatementURL,StatementShortURL,SmsSendStatus) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(statement.StatementNum)+",";
			}
			command+=
				     POut.Long  (statement.PatNum)+","
				+    POut.Long  (statement.SuperFamily)+","
				+    POut.Date  (statement.DateSent)+","
				+    POut.Date  (statement.DateRangeFrom)+","
				+    POut.Date  (statement.DateRangeTo)+","
				+    DbHelper.ParamChar+"paramNote,"
				+    DbHelper.ParamChar+"paramNoteBold,"
				+    POut.Int   ((int)statement.Mode_)+","
				+    POut.Bool  (statement.HidePayment)+","
				+    POut.Bool  (statement.SinglePatient)+","
				+    POut.Bool  (statement.Intermingled)+","
				+    POut.Bool  (statement.IsSent)+","
				+    POut.Long  (statement.DocNum)+","
				//DateTStamp can only be set by MySQL
				+    POut.Bool  (statement.IsReceipt)+","
				+    POut.Bool  (statement.IsInvoice)+","
				+    POut.Bool  (statement.IsInvoiceCopy)+","
				+"'"+POut.String(statement.EmailSubject)+"',"
				+    DbHelper.ParamChar+"paramEmailBody,"
				+    POut.Bool  (statement.IsBalValid)+","
				+"'"+POut.Double(statement.InsEst)+"',"
				+"'"+POut.Double(statement.BalTotal)+"',"
				+"'"+POut.String(statement.StatementType.ToString())+"',"
				+"'"+POut.String(statement.ShortGUID)+"',"
				+"'"+POut.String(statement.StatementURL)+"',"
				+"'"+POut.String(statement.StatementShortURL)+"',"
				+    POut.Int   ((int)statement.SmsSendStatus)+")";
			if(statement.Note==null) {
				statement.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringParam(statement.Note));
			if(statement.NoteBold==null) {
				statement.NoteBold="";
			}
			OdSqlParameter paramNoteBold=new OdSqlParameter("paramNoteBold",OdDbType.Text,POut.StringParam(statement.NoteBold));
			if(statement.EmailBody==null) {
				statement.EmailBody="";
			}
			OdSqlParameter paramEmailBody=new OdSqlParameter("paramEmailBody",OdDbType.Text,POut.StringParam(statement.EmailBody));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramNote,paramNoteBold,paramEmailBody);
			}
			else {
				statement.StatementNum=Db.NonQ(command,true,"StatementNum","statement",paramNote,paramNoteBold,paramEmailBody);
			}
			return statement.StatementNum;
		}

		///<summary>Updates one Statement in the database.</summary>
		public static void Update(Statement statement){
			string command="UPDATE statement SET "
				+"PatNum           =  "+POut.Long  (statement.PatNum)+", "
				+"SuperFamily      =  "+POut.Long  (statement.SuperFamily)+", "
				+"DateSent         =  "+POut.Date  (statement.DateSent)+", "
				+"DateRangeFrom    =  "+POut.Date  (statement.DateRangeFrom)+", "
				+"DateRangeTo      =  "+POut.Date  (statement.DateRangeTo)+", "
				+"Note             =  "+DbHelper.ParamChar+"paramNote, "
				+"NoteBold         =  "+DbHelper.ParamChar+"paramNoteBold, "
				+"Mode_            =  "+POut.Int   ((int)statement.Mode_)+", "
				+"HidePayment      =  "+POut.Bool  (statement.HidePayment)+", "
				+"SinglePatient    =  "+POut.Bool  (statement.SinglePatient)+", "
				+"Intermingled     =  "+POut.Bool  (statement.Intermingled)+", "
				+"IsSent           =  "+POut.Bool  (statement.IsSent)+", "
				+"DocNum           =  "+POut.Long  (statement.DocNum)+", "
				//DateTStamp can only be set by MySQL
				+"IsReceipt        =  "+POut.Bool  (statement.IsReceipt)+", "
				+"IsInvoice        =  "+POut.Bool  (statement.IsInvoice)+", "
				+"IsInvoiceCopy    =  "+POut.Bool  (statement.IsInvoiceCopy)+", "
				+"EmailSubject     = '"+POut.String(statement.EmailSubject)+"', "
				+"EmailBody        =  "+DbHelper.ParamChar+"paramEmailBody, "
				+"IsBalValid       =  "+POut.Bool  (statement.IsBalValid)+", "
				+"InsEst           = '"+POut.Double(statement.InsEst)+"', "
				+"BalTotal         = '"+POut.Double(statement.BalTotal)+"', "
				+"StatementType    = '"+POut.String(statement.StatementType.ToString())+"', "
				+"ShortGUID        = '"+POut.String(statement.ShortGUID)+"', "
				+"StatementURL     = '"+POut.String(statement.StatementURL)+"', "
				+"StatementShortURL= '"+POut.String(statement.StatementShortURL)+"', "
				+"SmsSendStatus    =  "+POut.Int   ((int)statement.SmsSendStatus)+" "
				+"WHERE StatementNum = "+POut.Long(statement.StatementNum);
			if(statement.Note==null) {
				statement.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringParam(statement.Note));
			if(statement.NoteBold==null) {
				statement.NoteBold="";
			}
			OdSqlParameter paramNoteBold=new OdSqlParameter("paramNoteBold",OdDbType.Text,POut.StringParam(statement.NoteBold));
			if(statement.EmailBody==null) {
				statement.EmailBody="";
			}
			OdSqlParameter paramEmailBody=new OdSqlParameter("paramEmailBody",OdDbType.Text,POut.StringParam(statement.EmailBody));
			Db.NonQ(command,paramNote,paramNoteBold,paramEmailBody);
		}

		///<summary>Updates one Statement in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(Statement statement,Statement oldStatement){
			string command="";
			if(statement.PatNum != oldStatement.PatNum) {
				if(command!=""){ command+=",";}
				command+="PatNum = "+POut.Long(statement.PatNum)+"";
			}
			if(statement.SuperFamily != oldStatement.SuperFamily) {
				if(command!=""){ command+=",";}
				command+="SuperFamily = "+POut.Long(statement.SuperFamily)+"";
			}
			if(statement.DateSent.Date != oldStatement.DateSent.Date) {
				if(command!=""){ command+=",";}
				command+="DateSent = "+POut.Date(statement.DateSent)+"";
			}
			if(statement.DateRangeFrom.Date != oldStatement.DateRangeFrom.Date) {
				if(command!=""){ command+=",";}
				command+="DateRangeFrom = "+POut.Date(statement.DateRangeFrom)+"";
			}
			if(statement.DateRangeTo.Date != oldStatement.DateRangeTo.Date) {
				if(command!=""){ command+=",";}
				command+="DateRangeTo = "+POut.Date(statement.DateRangeTo)+"";
			}
			if(statement.Note != oldStatement.Note) {
				if(command!=""){ command+=",";}
				command+="Note = "+DbHelper.ParamChar+"paramNote";
			}
			if(statement.NoteBold != oldStatement.NoteBold) {
				if(command!=""){ command+=",";}
				command+="NoteBold = "+DbHelper.ParamChar+"paramNoteBold";
			}
			if(statement.Mode_ != oldStatement.Mode_) {
				if(command!=""){ command+=",";}
				command+="Mode_ = "+POut.Int   ((int)statement.Mode_)+"";
			}
			if(statement.HidePayment != oldStatement.HidePayment) {
				if(command!=""){ command+=",";}
				command+="HidePayment = "+POut.Bool(statement.HidePayment)+"";
			}
			if(statement.SinglePatient != oldStatement.SinglePatient) {
				if(command!=""){ command+=",";}
				command+="SinglePatient = "+POut.Bool(statement.SinglePatient)+"";
			}
			if(statement.Intermingled != oldStatement.Intermingled) {
				if(command!=""){ command+=",";}
				command+="Intermingled = "+POut.Bool(statement.Intermingled)+"";
			}
			if(statement.IsSent != oldStatement.IsSent) {
				if(command!=""){ command+=",";}
				command+="IsSent = "+POut.Bool(statement.IsSent)+"";
			}
			if(statement.DocNum != oldStatement.DocNum) {
				if(command!=""){ command+=",";}
				command+="DocNum = "+POut.Long(statement.DocNum)+"";
			}
			//DateTStamp can only be set by MySQL
			if(statement.IsReceipt != oldStatement.IsReceipt) {
				if(command!=""){ command+=",";}
				command+="IsReceipt = "+POut.Bool(statement.IsReceipt)+"";
			}
			if(statement.IsInvoice != oldStatement.IsInvoice) {
				if(command!=""){ command+=",";}
				command+="IsInvoice = "+POut.Bool(statement.IsInvoice)+"";
			}
			if(statement.IsInvoiceCopy != oldStatement.IsInvoiceCopy) {
				if(command!=""){ command+=",";}
				command+="IsInvoiceCopy = "+POut.Bool(statement.IsInvoiceCopy)+"";
			}
			if(statement.EmailSubject != oldStatement.EmailSubject) {
				if(command!=""){ command+=",";}
				command+="EmailSubject = '"+POut.String(statement.EmailSubject)+"'";
			}
			if(statement.EmailBody != oldStatement.EmailBody) {
				if(command!=""){ command+=",";}
				command+="EmailBody = "+DbHelper.ParamChar+"paramEmailBody";
			}
			if(statement.IsBalValid != oldStatement.IsBalValid) {
				if(command!=""){ command+=",";}
				command+="IsBalValid = "+POut.Bool(statement.IsBalValid)+"";
			}
			if(statement.InsEst != oldStatement.InsEst) {
				if(command!=""){ command+=",";}
				command+="InsEst = '"+POut.Double(statement.InsEst)+"'";
			}
			if(statement.BalTotal != oldStatement.BalTotal) {
				if(command!=""){ command+=",";}
				command+="BalTotal = '"+POut.Double(statement.BalTotal)+"'";
			}
			if(statement.StatementType != oldStatement.StatementType) {
				if(command!=""){ command+=",";}
				command+="StatementType = '"+POut.String(statement.StatementType.ToString())+"'";
			}
			if(statement.ShortGUID != oldStatement.ShortGUID) {
				if(command!=""){ command+=",";}
				command+="ShortGUID = '"+POut.String(statement.ShortGUID)+"'";
			}
			if(statement.StatementURL != oldStatement.StatementURL) {
				if(command!=""){ command+=",";}
				command+="StatementURL = '"+POut.String(statement.StatementURL)+"'";
			}
			if(statement.StatementShortURL != oldStatement.StatementShortURL) {
				if(command!=""){ command+=",";}
				command+="StatementShortURL = '"+POut.String(statement.StatementShortURL)+"'";
			}
			if(statement.SmsSendStatus != oldStatement.SmsSendStatus) {
				if(command!=""){ command+=",";}
				command+="SmsSendStatus = "+POut.Int   ((int)statement.SmsSendStatus)+"";
			}
			if(command==""){
				return false;
			}
			if(statement.Note==null) {
				statement.Note="";
			}
			OdSqlParameter paramNote=new OdSqlParameter("paramNote",OdDbType.Text,POut.StringParam(statement.Note));
			if(statement.NoteBold==null) {
				statement.NoteBold="";
			}
			OdSqlParameter paramNoteBold=new OdSqlParameter("paramNoteBold",OdDbType.Text,POut.StringParam(statement.NoteBold));
			if(statement.EmailBody==null) {
				statement.EmailBody="";
			}
			OdSqlParameter paramEmailBody=new OdSqlParameter("paramEmailBody",OdDbType.Text,POut.StringParam(statement.EmailBody));
			command="UPDATE statement SET "+command
				+" WHERE StatementNum = "+POut.Long(statement.StatementNum);
			Db.NonQ(command,paramNote,paramNoteBold,paramEmailBody);
			return true;
		}

		///<summary>Returns true if Update(Statement,Statement) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(Statement statement,Statement oldStatement) {
			if(statement.PatNum != oldStatement.PatNum) {
				return true;
			}
			if(statement.SuperFamily != oldStatement.SuperFamily) {
				return true;
			}
			if(statement.DateSent.Date != oldStatement.DateSent.Date) {
				return true;
			}
			if(statement.DateRangeFrom.Date != oldStatement.DateRangeFrom.Date) {
				return true;
			}
			if(statement.DateRangeTo.Date != oldStatement.DateRangeTo.Date) {
				return true;
			}
			if(statement.Note != oldStatement.Note) {
				return true;
			}
			if(statement.NoteBold != oldStatement.NoteBold) {
				return true;
			}
			if(statement.Mode_ != oldStatement.Mode_) {
				return true;
			}
			if(statement.HidePayment != oldStatement.HidePayment) {
				return true;
			}
			if(statement.SinglePatient != oldStatement.SinglePatient) {
				return true;
			}
			if(statement.Intermingled != oldStatement.Intermingled) {
				return true;
			}
			if(statement.IsSent != oldStatement.IsSent) {
				return true;
			}
			if(statement.DocNum != oldStatement.DocNum) {
				return true;
			}
			//DateTStamp can only be set by MySQL
			if(statement.IsReceipt != oldStatement.IsReceipt) {
				return true;
			}
			if(statement.IsInvoice != oldStatement.IsInvoice) {
				return true;
			}
			if(statement.IsInvoiceCopy != oldStatement.IsInvoiceCopy) {
				return true;
			}
			if(statement.EmailSubject != oldStatement.EmailSubject) {
				return true;
			}
			if(statement.EmailBody != oldStatement.EmailBody) {
				return true;
			}
			if(statement.IsBalValid != oldStatement.IsBalValid) {
				return true;
			}
			if(statement.InsEst != oldStatement.InsEst) {
				return true;
			}
			if(statement.BalTotal != oldStatement.BalTotal) {
				return true;
			}
			if(statement.StatementType != oldStatement.StatementType) {
				return true;
			}
			if(statement.ShortGUID != oldStatement.ShortGUID) {
				return true;
			}
			if(statement.StatementURL != oldStatement.StatementURL) {
				return true;
			}
			if(statement.StatementShortURL != oldStatement.StatementShortURL) {
				return true;
			}
			if(statement.SmsSendStatus != oldStatement.SmsSendStatus) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one Statement from the database.</summary>
		public static void Delete(long statementNum){
			string command="DELETE FROM statement "
				+"WHERE StatementNum = "+POut.Long(statementNum);
			Db.NonQ(command);
		}

	}
}