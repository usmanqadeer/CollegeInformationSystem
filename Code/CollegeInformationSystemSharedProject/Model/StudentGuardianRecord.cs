using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentGuardianRecord
{
	List<StudentGuardianRecord> StudentGuardianRecordList = new List<StudentGuardianRecord>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentGuardianRecord;
	SqlCommand comStudentGuardianRecord;
	SqlDataAdapter daStudentGuardianRecord;
	DataSet dsStudentGuardianRecord;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentGuardianRecord()
	{
		conStudentGuardianRecord = new SqlConnection(connection_string);
		comStudentGuardianRecord = new SqlCommand();
		daStudentGuardianRecord = new SqlDataAdapter();
		dsStudentGuardianRecord = new DataSet();
	}
	//Private Variables////////////////////////////////////////////////////////////////////////
	
	Int64 intGuardianID;
Int64 intStudentID;
string strGuardianName;
string strGuardianCNIC;
string strGuadianEmail;
string strGuardianContact;
string strGuardianPic;
string strGuardianAddress;
Int64 intAddedByID;
DateTime datAddedDateTime;
DateTime datLastUpdateDateTime;
Int64 intLastUpdateByID;
string strRemarks;

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Public Properties////////////////////////////////////////////////////////////////////////
	public Int64 GuardianID
{
	get
	{
		return intGuardianID;
	}
	set
	{
		intGuardianID = value;
	}
}
public Int64 StudentID
{
	get
	{
		return intStudentID;
	}
	set
	{
		intStudentID = value;
	}
}
public string GuardianName
{
	get
	{
		return strGuardianName;
	}
	set
	{
		strGuardianName = value;
	}
}
public string GuardianCNIC
{
	get
	{
		return strGuardianCNIC;
	}
	set
	{
		strGuardianCNIC = value;
	}
}
public string GuadianEmail
{
	get
	{
		return strGuadianEmail;
	}
	set
	{
		strGuadianEmail = value;
	}
}
public string GuardianContact
{
	get
	{
		return strGuardianContact;
	}
	set
	{
		strGuardianContact = value;
	}
}
public string GuardianPic
{
	get
	{
		return strGuardianPic;
	}
	set
	{
		strGuardianPic = value;
	}
}
public string GuardianAddress
{
	get
	{
		return strGuardianAddress;
	}
	set
	{
		strGuardianAddress = value;
	}
}
public Int64 AddedByID
{
	get
	{
		return intAddedByID;
	}
	set
	{
		intAddedByID = value;
	}
}
public DateTime AddedDateTime
{
	get
	{
		return datAddedDateTime;
	}
	set
	{
		datAddedDateTime = value;
	}
}
public DateTime LastUpdateDateTime
{
	get
	{
		return datLastUpdateDateTime;
	}
	set
	{
		datLastUpdateDateTime = value;
	}
}
public Int64 LastUpdateByID
{
	get
	{
		return intLastUpdateByID;
	}
	set
	{
		intLastUpdateByID = value;
	}
}
public string Remarks
{
	get
	{
		return strRemarks;
	}
	set
	{
		strRemarks = value;
	}
}

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Private Methods///////////////////////////////////////////////////////////////////////////
	
	//DB to Model//	
	private void GenerateModelList()
	{
		StudentGuardianRecordList.Clear();
		foreach (DataRow drStudentGuardianRecord in dsStudentGuardianRecord.Tables[0].Rows)
		{
			StudentGuardianRecord objStudentGuardianRecord = new StudentGuardianRecord();
			objStudentGuardianRecord.GuardianID = Convert.ToInt64(drStudentGuardianRecord["GuardianID"]);
objStudentGuardianRecord.StudentID = Convert.ToInt64(drStudentGuardianRecord["StudentID"]);
objStudentGuardianRecord.GuardianName = Convert.ToString(drStudentGuardianRecord["GuardianName"]);
objStudentGuardianRecord.GuardianCNIC = Convert.ToString(drStudentGuardianRecord["GuardianCNIC"]);
objStudentGuardianRecord.GuadianEmail = Convert.ToString(drStudentGuardianRecord["GuadianEmail"]);
objStudentGuardianRecord.GuardianContact = Convert.ToString(drStudentGuardianRecord["GuardianContact"]);
objStudentGuardianRecord.GuardianPic = Convert.ToString(drStudentGuardianRecord["GuardianPic"]);
objStudentGuardianRecord.GuardianAddress = Convert.ToString(drStudentGuardianRecord["GuardianAddress"]);
objStudentGuardianRecord.AddedByID = Convert.ToInt64(drStudentGuardianRecord["AddedByID"]);
objStudentGuardianRecord.AddedDateTime = Convert.ToDateTime(drStudentGuardianRecord["AddedDateTime"]);
objStudentGuardianRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentGuardianRecord["LastUpdateDateTime"]);
objStudentGuardianRecord.LastUpdateByID = Convert.ToInt64(drStudentGuardianRecord["LastUpdateByID"]);
objStudentGuardianRecord.Remarks = Convert.ToString(drStudentGuardianRecord["Remarks"]);

			StudentGuardianRecordList.Add(objStudentGuardianRecord);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentGuardianRecord.Clear();
		conStudentGuardianRecord.Open();
		comStudentGuardianRecord.Connection = conStudentGuardianRecord;
		comStudentGuardianRecord.CommandText = strCommandText;
		
		comStudentGuardianRecord.CommandType = CommandType.StoredProcedure;
		daStudentGuardianRecord.SelectCommand = comStudentGuardianRecord;
		daStudentGuardianRecord.Fill(dsStudentGuardianRecord);
		conStudentGuardianRecord.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentGuardianRecord> StudentGuardianRecordSelectAll()
	{
		try
		{
		    string sp_name = "StudentGuardianRecordSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentGuardianRecordList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentGuardianRecord StudentGuardianRecordSelectByID(int intGuardianID)
	{
		try
		{
		    string sp_name = "StudentGuardianRecordSelectByID";
			comStudentGuardianRecord.Parameters.AddWithValue("GuardianID", intGuardianID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentGuardianRecord.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentGuardianRecord = dsStudentGuardianRecord.Tables[0].Rows[0];
				StudentGuardianRecord objStudentGuardianRecord = new StudentGuardianRecord();
				objStudentGuardianRecord.GuardianID = Convert.ToInt64(drStudentGuardianRecord["GuardianID"]);
objStudentGuardianRecord.StudentID = Convert.ToInt64(drStudentGuardianRecord["StudentID"]);
objStudentGuardianRecord.GuardianName = Convert.ToString(drStudentGuardianRecord["GuardianName"]);
objStudentGuardianRecord.GuardianCNIC = Convert.ToString(drStudentGuardianRecord["GuardianCNIC"]);
objStudentGuardianRecord.GuadianEmail = Convert.ToString(drStudentGuardianRecord["GuadianEmail"]);
objStudentGuardianRecord.GuardianContact = Convert.ToString(drStudentGuardianRecord["GuardianContact"]);
objStudentGuardianRecord.GuardianPic = Convert.ToString(drStudentGuardianRecord["GuardianPic"]);
objStudentGuardianRecord.GuardianAddress = Convert.ToString(drStudentGuardianRecord["GuardianAddress"]);
objStudentGuardianRecord.AddedByID = Convert.ToInt64(drStudentGuardianRecord["AddedByID"]);
objStudentGuardianRecord.AddedDateTime = Convert.ToDateTime(drStudentGuardianRecord["AddedDateTime"]);
objStudentGuardianRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentGuardianRecord["LastUpdateDateTime"]);
objStudentGuardianRecord.LastUpdateByID = Convert.ToInt64(drStudentGuardianRecord["LastUpdateByID"]);
objStudentGuardianRecord.Remarks = Convert.ToString(drStudentGuardianRecord["Remarks"]);

				return objStudentGuardianRecord;
			}
			return null;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	/// <summary>
	///  To insert or update record in database. If primary key value is not given then Insert operation will be execute
	/// </summary>
	/// <params></params>
	/// <return>Retrived record from database</return>
	public Int64 InsertUpdateStudentGuardianRecord()
	{
		try
		{
			//parameter setting
			comStudentGuardianRecord.Parameters.AddWithValue("GuardianID", intGuardianID);
comStudentGuardianRecord.Parameters.AddWithValue("StudentID", intStudentID);
comStudentGuardianRecord.Parameters.AddWithValue("GuardianName", strGuardianName);
comStudentGuardianRecord.Parameters.AddWithValue("GuardianCNIC", strGuardianCNIC);
comStudentGuardianRecord.Parameters.AddWithValue("GuadianEmail", strGuadianEmail);
comStudentGuardianRecord.Parameters.AddWithValue("GuardianContact", strGuardianContact);
comStudentGuardianRecord.Parameters.AddWithValue("GuardianPic", strGuardianPic);
comStudentGuardianRecord.Parameters.AddWithValue("GuardianAddress", strGuardianAddress);
comStudentGuardianRecord.Parameters.AddWithValue("AddedByID", intAddedByID);
comStudentGuardianRecord.Parameters.AddWithValue("AddedDateTime", datAddedDateTime);
comStudentGuardianRecord.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);
comStudentGuardianRecord.Parameters.AddWithValue("LastUpdateByID", intLastUpdateByID);
comStudentGuardianRecord.Parameters.AddWithValue("Remarks", strRemarks);

			//end parameter setting
		
			ConnectAndExecute("StudentGuardianRecordInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentGuardianRecord.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentGuardianRecord(Int64 intGuardianID = 0)
	{
		try
		{
			string sp_name = "StudentGuardianRecordDeleteAll";
			if (intGuardianID != 0)
			{
				comStudentGuardianRecord.Parameters.AddWithValue("GuardianID", intGuardianID);
				sp_name = "StudentGuardianRecordDeleteByID";
			}
		
			ConnectAndExecute(sp_name);
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
		}
	}
	
	public void Truncate()
	{
		try
		{
			string sp_name = "StudentGuardianRecordTruncate";
			ConnectAndExecute(sp_name);
		}
		catch(Exception ex)
		{
			SetError(ex.Message);
		}
	}
	
	private void SetError(string message)
	{}
	
	
}