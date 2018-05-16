//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class CreditCardCrud {
		///<summary>Gets one CreditCard object from the database using the primary key.  Returns null if not found.</summary>
		public static CreditCard SelectOne(long creditCardNum){
			string command="SELECT * FROM creditcard "
				+"WHERE CreditCardNum = "+POut.Long(creditCardNum);
			List<CreditCard> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one CreditCard object from the database using a query.</summary>
		public static CreditCard SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<CreditCard> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of CreditCard objects from the database using a query.</summary>
		public static List<CreditCard> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<CreditCard> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<CreditCard> TableToList(DataTable table){
			List<CreditCard> retVal=new List<CreditCard>();
			CreditCard creditCard;
			foreach(DataRow row in table.Rows) {
				creditCard=new CreditCard();
				creditCard.CreditCardNum     = PIn.Long  (row["CreditCardNum"].ToString());
				creditCard.PatNum            = PIn.Long  (row["PatNum"].ToString());
				creditCard.Address           = PIn.String(row["Address"].ToString());
				creditCard.Zip               = PIn.String(row["Zip"].ToString());
				creditCard.XChargeToken      = PIn.String(row["XChargeToken"].ToString());
				creditCard.CCNumberMasked    = PIn.String(row["CCNumberMasked"].ToString());
				creditCard.CCExpiration      = PIn.Date  (row["CCExpiration"].ToString());
				creditCard.ItemOrder         = PIn.Int   (row["ItemOrder"].ToString());
				creditCard.ChargeAmt         = PIn.Double(row["ChargeAmt"].ToString());
				creditCard.DateStart         = PIn.Date  (row["DateStart"].ToString());
				creditCard.DateStop          = PIn.Date  (row["DateStop"].ToString());
				creditCard.Note              = PIn.String(row["Note"].ToString());
				creditCard.PayPlanNum        = PIn.Long  (row["PayPlanNum"].ToString());
				creditCard.PayConnectToken   = PIn.String(row["PayConnectToken"].ToString());
				creditCard.PayConnectTokenExp= PIn.Date  (row["PayConnectTokenExp"].ToString());
				creditCard.Procedures        = PIn.String(row["Procedures"].ToString());
				creditCard.CCSource          = (OpenDentBusiness.CreditCardSource)PIn.Int(row["CCSource"].ToString());
				creditCard.ClinicNum         = PIn.Long  (row["ClinicNum"].ToString());
				creditCard.ExcludeProcSync   = PIn.Bool  (row["ExcludeProcSync"].ToString());
				creditCard.PaySimpleToken    = PIn.String(row["PaySimpleToken"].ToString());
				retVal.Add(creditCard);
			}
			return retVal;
		}

		///<summary>Converts a list of CreditCard into a DataTable.</summary>
		public static DataTable ListToTable(List<CreditCard> listCreditCards,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="CreditCard";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("CreditCardNum");
			table.Columns.Add("PatNum");
			table.Columns.Add("Address");
			table.Columns.Add("Zip");
			table.Columns.Add("XChargeToken");
			table.Columns.Add("CCNumberMasked");
			table.Columns.Add("CCExpiration");
			table.Columns.Add("ItemOrder");
			table.Columns.Add("ChargeAmt");
			table.Columns.Add("DateStart");
			table.Columns.Add("DateStop");
			table.Columns.Add("Note");
			table.Columns.Add("PayPlanNum");
			table.Columns.Add("PayConnectToken");
			table.Columns.Add("PayConnectTokenExp");
			table.Columns.Add("Procedures");
			table.Columns.Add("CCSource");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("ExcludeProcSync");
			table.Columns.Add("PaySimpleToken");
			foreach(CreditCard creditCard in listCreditCards) {
				table.Rows.Add(new object[] {
					POut.Long  (creditCard.CreditCardNum),
					POut.Long  (creditCard.PatNum),
					            creditCard.Address,
					            creditCard.Zip,
					            creditCard.XChargeToken,
					            creditCard.CCNumberMasked,
					POut.DateT (creditCard.CCExpiration,false),
					POut.Int   (creditCard.ItemOrder),
					POut.Double(creditCard.ChargeAmt),
					POut.DateT (creditCard.DateStart,false),
					POut.DateT (creditCard.DateStop,false),
					            creditCard.Note,
					POut.Long  (creditCard.PayPlanNum),
					            creditCard.PayConnectToken,
					POut.DateT (creditCard.PayConnectTokenExp,false),
					            creditCard.Procedures,
					POut.Int   ((int)creditCard.CCSource),
					POut.Long  (creditCard.ClinicNum),
					POut.Bool  (creditCard.ExcludeProcSync),
					            creditCard.PaySimpleToken,
				});
			}
			return table;
		}

		///<summary>Inserts one CreditCard into the database.  Returns the new priKey.</summary>
		public static long Insert(CreditCard creditCard){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				creditCard.CreditCardNum=DbHelper.GetNextOracleKey("creditcard","CreditCardNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(creditCard,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							creditCard.CreditCardNum++;
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
				return Insert(creditCard,false);
			}
		}

		///<summary>Inserts one CreditCard into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(CreditCard creditCard,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				creditCard.CreditCardNum=ReplicationServers.GetKey("creditcard","CreditCardNum");
			}
			string command="INSERT INTO creditcard (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="CreditCardNum,";
			}
			command+="PatNum,Address,Zip,XChargeToken,CCNumberMasked,CCExpiration,ItemOrder,ChargeAmt,DateStart,DateStop,Note,PayPlanNum,PayConnectToken,PayConnectTokenExp,Procedures,CCSource,ClinicNum,ExcludeProcSync,PaySimpleToken) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(creditCard.CreditCardNum)+",";
			}
			command+=
				     POut.Long  (creditCard.PatNum)+","
				+"'"+POut.String(creditCard.Address)+"',"
				+"'"+POut.String(creditCard.Zip)+"',"
				+"'"+POut.String(creditCard.XChargeToken)+"',"
				+"'"+POut.String(creditCard.CCNumberMasked)+"',"
				+    POut.Date  (creditCard.CCExpiration)+","
				+    POut.Int   (creditCard.ItemOrder)+","
				+"'"+POut.Double(creditCard.ChargeAmt)+"',"
				+    POut.Date  (creditCard.DateStart)+","
				+    POut.Date  (creditCard.DateStop)+","
				+"'"+POut.String(creditCard.Note)+"',"
				+    POut.Long  (creditCard.PayPlanNum)+","
				+"'"+POut.String(creditCard.PayConnectToken)+"',"
				+    POut.Date  (creditCard.PayConnectTokenExp)+","
				+    DbHelper.ParamChar+"paramProcedures,"
				+    POut.Int   ((int)creditCard.CCSource)+","
				+    POut.Long  (creditCard.ClinicNum)+","
				+    POut.Bool  (creditCard.ExcludeProcSync)+","
				+"'"+POut.String(creditCard.PaySimpleToken)+"')";
			if(creditCard.Procedures==null) {
				creditCard.Procedures="";
			}
			OdSqlParameter paramProcedures=new OdSqlParameter("paramProcedures",OdDbType.Text,POut.StringParam(creditCard.Procedures));
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command,paramProcedures);
			}
			else {
				creditCard.CreditCardNum=Db.NonQ(command,true,"CreditCardNum","creditCard",paramProcedures);
			}
			return creditCard.CreditCardNum;
		}

		///<summary>Inserts one CreditCard into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(CreditCard creditCard){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(creditCard,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					creditCard.CreditCardNum=DbHelper.GetNextOracleKey("creditcard","CreditCardNum"); //Cacheless method
				}
				return InsertNoCache(creditCard,true);
			}
		}

		///<summary>Inserts one CreditCard into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(CreditCard creditCard,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO creditcard (";
			if(!useExistingPK && isRandomKeys) {
				creditCard.CreditCardNum=ReplicationServers.GetKeyNoCache("creditcard","CreditCardNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="CreditCardNum,";
			}
			command+="PatNum,Address,Zip,XChargeToken,CCNumberMasked,CCExpiration,ItemOrder,ChargeAmt,DateStart,DateStop,Note,PayPlanNum,PayConnectToken,PayConnectTokenExp,Procedures,CCSource,ClinicNum,ExcludeProcSync,PaySimpleToken) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(creditCard.CreditCardNum)+",";
			}
			command+=
				     POut.Long  (creditCard.PatNum)+","
				+"'"+POut.String(creditCard.Address)+"',"
				+"'"+POut.String(creditCard.Zip)+"',"
				+"'"+POut.String(creditCard.XChargeToken)+"',"
				+"'"+POut.String(creditCard.CCNumberMasked)+"',"
				+    POut.Date  (creditCard.CCExpiration)+","
				+    POut.Int   (creditCard.ItemOrder)+","
				+"'"+POut.Double(creditCard.ChargeAmt)+"',"
				+    POut.Date  (creditCard.DateStart)+","
				+    POut.Date  (creditCard.DateStop)+","
				+"'"+POut.String(creditCard.Note)+"',"
				+    POut.Long  (creditCard.PayPlanNum)+","
				+"'"+POut.String(creditCard.PayConnectToken)+"',"
				+    POut.Date  (creditCard.PayConnectTokenExp)+","
				+    DbHelper.ParamChar+"paramProcedures,"
				+    POut.Int   ((int)creditCard.CCSource)+","
				+    POut.Long  (creditCard.ClinicNum)+","
				+    POut.Bool  (creditCard.ExcludeProcSync)+","
				+"'"+POut.String(creditCard.PaySimpleToken)+"')";
			if(creditCard.Procedures==null) {
				creditCard.Procedures="";
			}
			OdSqlParameter paramProcedures=new OdSqlParameter("paramProcedures",OdDbType.Text,POut.StringParam(creditCard.Procedures));
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command,paramProcedures);
			}
			else {
				creditCard.CreditCardNum=Db.NonQ(command,true,"CreditCardNum","creditCard",paramProcedures);
			}
			return creditCard.CreditCardNum;
		}

		///<summary>Updates one CreditCard in the database.</summary>
		public static void Update(CreditCard creditCard){
			string command="UPDATE creditcard SET "
				+"PatNum            =  "+POut.Long  (creditCard.PatNum)+", "
				+"Address           = '"+POut.String(creditCard.Address)+"', "
				+"Zip               = '"+POut.String(creditCard.Zip)+"', "
				+"XChargeToken      = '"+POut.String(creditCard.XChargeToken)+"', "
				+"CCNumberMasked    = '"+POut.String(creditCard.CCNumberMasked)+"', "
				+"CCExpiration      =  "+POut.Date  (creditCard.CCExpiration)+", "
				+"ItemOrder         =  "+POut.Int   (creditCard.ItemOrder)+", "
				+"ChargeAmt         = '"+POut.Double(creditCard.ChargeAmt)+"', "
				+"DateStart         =  "+POut.Date  (creditCard.DateStart)+", "
				+"DateStop          =  "+POut.Date  (creditCard.DateStop)+", "
				+"Note              = '"+POut.String(creditCard.Note)+"', "
				+"PayPlanNum        =  "+POut.Long  (creditCard.PayPlanNum)+", "
				+"PayConnectToken   = '"+POut.String(creditCard.PayConnectToken)+"', "
				+"PayConnectTokenExp=  "+POut.Date  (creditCard.PayConnectTokenExp)+", "
				+"Procedures        =  "+DbHelper.ParamChar+"paramProcedures, "
				+"CCSource          =  "+POut.Int   ((int)creditCard.CCSource)+", "
				+"ClinicNum         =  "+POut.Long  (creditCard.ClinicNum)+", "
				+"ExcludeProcSync   =  "+POut.Bool  (creditCard.ExcludeProcSync)+", "
				+"PaySimpleToken    = '"+POut.String(creditCard.PaySimpleToken)+"' "
				+"WHERE CreditCardNum = "+POut.Long(creditCard.CreditCardNum);
			if(creditCard.Procedures==null) {
				creditCard.Procedures="";
			}
			OdSqlParameter paramProcedures=new OdSqlParameter("paramProcedures",OdDbType.Text,POut.StringParam(creditCard.Procedures));
			Db.NonQ(command,paramProcedures);
		}

		///<summary>Updates one CreditCard in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(CreditCard creditCard,CreditCard oldCreditCard){
			string command="";
			if(creditCard.PatNum != oldCreditCard.PatNum) {
				if(command!=""){ command+=",";}
				command+="PatNum = "+POut.Long(creditCard.PatNum)+"";
			}
			if(creditCard.Address != oldCreditCard.Address) {
				if(command!=""){ command+=",";}
				command+="Address = '"+POut.String(creditCard.Address)+"'";
			}
			if(creditCard.Zip != oldCreditCard.Zip) {
				if(command!=""){ command+=",";}
				command+="Zip = '"+POut.String(creditCard.Zip)+"'";
			}
			if(creditCard.XChargeToken != oldCreditCard.XChargeToken) {
				if(command!=""){ command+=",";}
				command+="XChargeToken = '"+POut.String(creditCard.XChargeToken)+"'";
			}
			if(creditCard.CCNumberMasked != oldCreditCard.CCNumberMasked) {
				if(command!=""){ command+=",";}
				command+="CCNumberMasked = '"+POut.String(creditCard.CCNumberMasked)+"'";
			}
			if(creditCard.CCExpiration.Date != oldCreditCard.CCExpiration.Date) {
				if(command!=""){ command+=",";}
				command+="CCExpiration = "+POut.Date(creditCard.CCExpiration)+"";
			}
			if(creditCard.ItemOrder != oldCreditCard.ItemOrder) {
				if(command!=""){ command+=",";}
				command+="ItemOrder = "+POut.Int(creditCard.ItemOrder)+"";
			}
			if(creditCard.ChargeAmt != oldCreditCard.ChargeAmt) {
				if(command!=""){ command+=",";}
				command+="ChargeAmt = '"+POut.Double(creditCard.ChargeAmt)+"'";
			}
			if(creditCard.DateStart.Date != oldCreditCard.DateStart.Date) {
				if(command!=""){ command+=",";}
				command+="DateStart = "+POut.Date(creditCard.DateStart)+"";
			}
			if(creditCard.DateStop.Date != oldCreditCard.DateStop.Date) {
				if(command!=""){ command+=",";}
				command+="DateStop = "+POut.Date(creditCard.DateStop)+"";
			}
			if(creditCard.Note != oldCreditCard.Note) {
				if(command!=""){ command+=",";}
				command+="Note = '"+POut.String(creditCard.Note)+"'";
			}
			if(creditCard.PayPlanNum != oldCreditCard.PayPlanNum) {
				if(command!=""){ command+=",";}
				command+="PayPlanNum = "+POut.Long(creditCard.PayPlanNum)+"";
			}
			if(creditCard.PayConnectToken != oldCreditCard.PayConnectToken) {
				if(command!=""){ command+=",";}
				command+="PayConnectToken = '"+POut.String(creditCard.PayConnectToken)+"'";
			}
			if(creditCard.PayConnectTokenExp.Date != oldCreditCard.PayConnectTokenExp.Date) {
				if(command!=""){ command+=",";}
				command+="PayConnectTokenExp = "+POut.Date(creditCard.PayConnectTokenExp)+"";
			}
			if(creditCard.Procedures != oldCreditCard.Procedures) {
				if(command!=""){ command+=",";}
				command+="Procedures = "+DbHelper.ParamChar+"paramProcedures";
			}
			if(creditCard.CCSource != oldCreditCard.CCSource) {
				if(command!=""){ command+=",";}
				command+="CCSource = "+POut.Int   ((int)creditCard.CCSource)+"";
			}
			if(creditCard.ClinicNum != oldCreditCard.ClinicNum) {
				if(command!=""){ command+=",";}
				command+="ClinicNum = "+POut.Long(creditCard.ClinicNum)+"";
			}
			if(creditCard.ExcludeProcSync != oldCreditCard.ExcludeProcSync) {
				if(command!=""){ command+=",";}
				command+="ExcludeProcSync = "+POut.Bool(creditCard.ExcludeProcSync)+"";
			}
			if(creditCard.PaySimpleToken != oldCreditCard.PaySimpleToken) {
				if(command!=""){ command+=",";}
				command+="PaySimpleToken = '"+POut.String(creditCard.PaySimpleToken)+"'";
			}
			if(command==""){
				return false;
			}
			if(creditCard.Procedures==null) {
				creditCard.Procedures="";
			}
			OdSqlParameter paramProcedures=new OdSqlParameter("paramProcedures",OdDbType.Text,POut.StringParam(creditCard.Procedures));
			command="UPDATE creditcard SET "+command
				+" WHERE CreditCardNum = "+POut.Long(creditCard.CreditCardNum);
			Db.NonQ(command,paramProcedures);
			return true;
		}

		///<summary>Returns true if Update(CreditCard,CreditCard) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(CreditCard creditCard,CreditCard oldCreditCard) {
			if(creditCard.PatNum != oldCreditCard.PatNum) {
				return true;
			}
			if(creditCard.Address != oldCreditCard.Address) {
				return true;
			}
			if(creditCard.Zip != oldCreditCard.Zip) {
				return true;
			}
			if(creditCard.XChargeToken != oldCreditCard.XChargeToken) {
				return true;
			}
			if(creditCard.CCNumberMasked != oldCreditCard.CCNumberMasked) {
				return true;
			}
			if(creditCard.CCExpiration.Date != oldCreditCard.CCExpiration.Date) {
				return true;
			}
			if(creditCard.ItemOrder != oldCreditCard.ItemOrder) {
				return true;
			}
			if(creditCard.ChargeAmt != oldCreditCard.ChargeAmt) {
				return true;
			}
			if(creditCard.DateStart.Date != oldCreditCard.DateStart.Date) {
				return true;
			}
			if(creditCard.DateStop.Date != oldCreditCard.DateStop.Date) {
				return true;
			}
			if(creditCard.Note != oldCreditCard.Note) {
				return true;
			}
			if(creditCard.PayPlanNum != oldCreditCard.PayPlanNum) {
				return true;
			}
			if(creditCard.PayConnectToken != oldCreditCard.PayConnectToken) {
				return true;
			}
			if(creditCard.PayConnectTokenExp.Date != oldCreditCard.PayConnectTokenExp.Date) {
				return true;
			}
			if(creditCard.Procedures != oldCreditCard.Procedures) {
				return true;
			}
			if(creditCard.CCSource != oldCreditCard.CCSource) {
				return true;
			}
			if(creditCard.ClinicNum != oldCreditCard.ClinicNum) {
				return true;
			}
			if(creditCard.ExcludeProcSync != oldCreditCard.ExcludeProcSync) {
				return true;
			}
			if(creditCard.PaySimpleToken != oldCreditCard.PaySimpleToken) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one CreditCard from the database.</summary>
		public static void Delete(long creditCardNum){
			string command="DELETE FROM creditcard "
				+"WHERE CreditCardNum = "+POut.Long(creditCardNum);
			Db.NonQ(command);
		}

	}
}