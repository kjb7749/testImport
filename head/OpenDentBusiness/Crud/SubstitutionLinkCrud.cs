//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Crud{
	public class SubstitutionLinkCrud {
		///<summary>Gets one SubstitutionLink object from the database using the primary key.  Returns null if not found.</summary>
		public static SubstitutionLink SelectOne(long substitutionLinkNum){
			string command="SELECT * FROM substitutionlink "
				+"WHERE SubstitutionLinkNum = "+POut.Long(substitutionLinkNum);
			List<SubstitutionLink> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one SubstitutionLink object from the database using a query.</summary>
		public static SubstitutionLink SelectOne(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<SubstitutionLink> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of SubstitutionLink objects from the database using a query.</summary>
		public static List<SubstitutionLink> SelectMany(string command){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<SubstitutionLink> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<SubstitutionLink> TableToList(DataTable table){
			List<SubstitutionLink> retVal=new List<SubstitutionLink>();
			SubstitutionLink substitutionLink;
			foreach(DataRow row in table.Rows) {
				substitutionLink=new SubstitutionLink();
				substitutionLink.SubstitutionLinkNum= PIn.Long  (row["SubstitutionLinkNum"].ToString());
				substitutionLink.PlanNum            = PIn.Long  (row["PlanNum"].ToString());
				substitutionLink.CodeNum            = PIn.Long  (row["CodeNum"].ToString());
				retVal.Add(substitutionLink);
			}
			return retVal;
		}

		///<summary>Converts a list of SubstitutionLink into a DataTable.</summary>
		public static DataTable ListToTable(List<SubstitutionLink> listSubstitutionLinks,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="SubstitutionLink";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("SubstitutionLinkNum");
			table.Columns.Add("PlanNum");
			table.Columns.Add("CodeNum");
			foreach(SubstitutionLink substitutionLink in listSubstitutionLinks) {
				table.Rows.Add(new object[] {
					POut.Long  (substitutionLink.SubstitutionLinkNum),
					POut.Long  (substitutionLink.PlanNum),
					POut.Long  (substitutionLink.CodeNum),
				});
			}
			return table;
		}

		///<summary>Inserts one SubstitutionLink into the database.  Returns the new priKey.</summary>
		public static long Insert(SubstitutionLink substitutionLink){
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				substitutionLink.SubstitutionLinkNum=DbHelper.GetNextOracleKey("substitutionlink","SubstitutionLinkNum");
				int loopcount=0;
				while(loopcount<100){
					try {
						return Insert(substitutionLink,true);
					}
					catch(Oracle.ManagedDataAccess.Client.OracleException ex){
						if(ex.Number==1 && ex.Message.ToLower().Contains("unique constraint") && ex.Message.ToLower().Contains("violated")){
							substitutionLink.SubstitutionLinkNum++;
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
				return Insert(substitutionLink,false);
			}
		}

		///<summary>Inserts one SubstitutionLink into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(SubstitutionLink substitutionLink,bool useExistingPK){
			if(!useExistingPK && PrefC.RandomKeys) {
				substitutionLink.SubstitutionLinkNum=ReplicationServers.GetKey("substitutionlink","SubstitutionLinkNum");
			}
			string command="INSERT INTO substitutionlink (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="SubstitutionLinkNum,";
			}
			command+="PlanNum,CodeNum) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(substitutionLink.SubstitutionLinkNum)+",";
			}
			command+=
				     POut.Long  (substitutionLink.PlanNum)+","
				+    POut.Long  (substitutionLink.CodeNum)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				substitutionLink.SubstitutionLinkNum=Db.NonQ(command,true,"SubstitutionLinkNum","substitutionLink");
			}
			return substitutionLink.SubstitutionLinkNum;
		}

		///<summary>Inserts one SubstitutionLink into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(SubstitutionLink substitutionLink){
			if(DataConnection.DBtype==DatabaseType.MySql) {
				return InsertNoCache(substitutionLink,false);
			}
			else {
				if(DataConnection.DBtype==DatabaseType.Oracle) {
					substitutionLink.SubstitutionLinkNum=DbHelper.GetNextOracleKey("substitutionlink","SubstitutionLinkNum"); //Cacheless method
				}
				return InsertNoCache(substitutionLink,true);
			}
		}

		///<summary>Inserts one SubstitutionLink into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(SubstitutionLink substitutionLink,bool useExistingPK){
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO substitutionlink (";
			if(!useExistingPK && isRandomKeys) {
				substitutionLink.SubstitutionLinkNum=ReplicationServers.GetKeyNoCache("substitutionlink","SubstitutionLinkNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="SubstitutionLinkNum,";
			}
			command+="PlanNum,CodeNum) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(substitutionLink.SubstitutionLinkNum)+",";
			}
			command+=
				     POut.Long  (substitutionLink.PlanNum)+","
				+    POut.Long  (substitutionLink.CodeNum)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				substitutionLink.SubstitutionLinkNum=Db.NonQ(command,true,"SubstitutionLinkNum","substitutionLink");
			}
			return substitutionLink.SubstitutionLinkNum;
		}

		///<summary>Updates one SubstitutionLink in the database.</summary>
		public static void Update(SubstitutionLink substitutionLink){
			string command="UPDATE substitutionlink SET "
				+"PlanNum            =  "+POut.Long  (substitutionLink.PlanNum)+", "
				+"CodeNum            =  "+POut.Long  (substitutionLink.CodeNum)+" "
				+"WHERE SubstitutionLinkNum = "+POut.Long(substitutionLink.SubstitutionLinkNum);
			Db.NonQ(command);
		}

		///<summary>Updates one SubstitutionLink in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(SubstitutionLink substitutionLink,SubstitutionLink oldSubstitutionLink){
			string command="";
			if(substitutionLink.PlanNum != oldSubstitutionLink.PlanNum) {
				if(command!=""){ command+=",";}
				command+="PlanNum = "+POut.Long(substitutionLink.PlanNum)+"";
			}
			if(substitutionLink.CodeNum != oldSubstitutionLink.CodeNum) {
				if(command!=""){ command+=",";}
				command+="CodeNum = "+POut.Long(substitutionLink.CodeNum)+"";
			}
			if(command==""){
				return false;
			}
			command="UPDATE substitutionlink SET "+command
				+" WHERE SubstitutionLinkNum = "+POut.Long(substitutionLink.SubstitutionLinkNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(SubstitutionLink,SubstitutionLink) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(SubstitutionLink substitutionLink,SubstitutionLink oldSubstitutionLink) {
			if(substitutionLink.PlanNum != oldSubstitutionLink.PlanNum) {
				return true;
			}
			if(substitutionLink.CodeNum != oldSubstitutionLink.CodeNum) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one SubstitutionLink from the database.</summary>
		public static void Delete(long substitutionLinkNum){
			string command="DELETE FROM substitutionlink "
				+"WHERE SubstitutionLinkNum = "+POut.Long(substitutionLinkNum);
			Db.NonQ(command);
		}

		///<summary>Inserts, updates, or deletes database rows to match supplied list.  Returns true if db changes were made.</summary>
		public static bool Sync(List<SubstitutionLink> listNew,List<SubstitutionLink> listDB) {
			//Adding items to lists changes the order of operation. All inserts are completed first, then updates, then deletes.
			List<SubstitutionLink> listIns    =new List<SubstitutionLink>();
			List<SubstitutionLink> listUpdNew =new List<SubstitutionLink>();
			List<SubstitutionLink> listUpdDB  =new List<SubstitutionLink>();
			List<SubstitutionLink> listDel    =new List<SubstitutionLink>();
			listNew.Sort((SubstitutionLink x,SubstitutionLink y) => { return x.SubstitutionLinkNum.CompareTo(y.SubstitutionLinkNum); });//Anonymous function, sorts by compairing PK.  Lambda expressions are not allowed, this is the one and only exception.  JS approved.
			listDB.Sort((SubstitutionLink x,SubstitutionLink y) => { return x.SubstitutionLinkNum.CompareTo(y.SubstitutionLinkNum); });//Anonymous function, sorts by compairing PK.  Lambda expressions are not allowed, this is the one and only exception.  JS approved.
			int idxNew=0;
			int idxDB=0;
			int rowsUpdatedCount=0;
			SubstitutionLink fieldNew;
			SubstitutionLink fieldDB;
			//Because both lists have been sorted using the same criteria, we can now walk each list to determine which list contians the next element.  The next element is determined by Primary Key.
			//If the New list contains the next item it will be inserted.  If the DB contains the next item, it will be deleted.  If both lists contain the next item, the item will be updated.
			while(idxNew<listNew.Count || idxDB<listDB.Count) {
				fieldNew=null;
				if(idxNew<listNew.Count) {
					fieldNew=listNew[idxNew];
				}
				fieldDB=null;
				if(idxDB<listDB.Count) {
					fieldDB=listDB[idxDB];
				}
				//begin compare
				if(fieldNew!=null && fieldDB==null) {//listNew has more items, listDB does not.
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew==null && fieldDB!=null) {//listDB has more items, listNew does not.
					listDel.Add(fieldDB);
					idxDB++;
					continue;
				}
				else if(fieldNew.SubstitutionLinkNum<fieldDB.SubstitutionLinkNum) {//newPK less than dbPK, newItem is 'next'
					listIns.Add(fieldNew);
					idxNew++;
					continue;
				}
				else if(fieldNew.SubstitutionLinkNum>fieldDB.SubstitutionLinkNum) {//dbPK less than newPK, dbItem is 'next'
					listDel.Add(fieldDB);
					idxDB++;
					continue;
				}
				//Both lists contain the 'next' item, update required
				listUpdNew.Add(fieldNew);
				listUpdDB.Add(fieldDB);
				idxNew++;
				idxDB++;
			}
			//Commit changes to DB
			for(int i=0;i<listIns.Count;i++) {
				Insert(listIns[i]);
			}
			for(int i=0;i<listUpdNew.Count;i++) {
				if(Update(listUpdNew[i],listUpdDB[i])){
					rowsUpdatedCount++;
				}
			}
			for(int i=0;i<listDel.Count;i++) {
				Delete(listDel[i].SubstitutionLinkNum);
			}
			if(rowsUpdatedCount>0 || listIns.Count>0 || listDel.Count>0) {
				return true;
			}
			return false;
		}

	}
}