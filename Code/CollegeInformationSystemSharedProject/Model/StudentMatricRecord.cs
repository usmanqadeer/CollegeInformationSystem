using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentMatricRecord
{
	List<StudentMatricRecord> StudentMatricRecordList = new List<StudentMatricRecord>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentMatricRecord;
	SqlCommand comStudentMatricRecord;
	SqlDataAdapter daStudentMatricRecord;
	DataSet dsStudentMatricRecord;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentMatricRecord()
	{
		conStudentMatricRecord = new SqlConnection(connection_string);
		comStudentMatricRecord = new SqlCommand();
		daStudentMatricRecord = new SqlDataAdapter();
		dsStudentMatricRecord = new DataSet();
	}
	//Private Variables////////////////////////////////////////////////////////////////////////
	
	Int64 intMatricStudentID;
Int64 intStudentID;
string strBoard;
string strSchool;
int intTotalMarks;
int intObtainedMarks;
int intYearPassed;
Int64 intLastUpdateID;
Int64 intAddByID;
DateTime datLastUpdateDateTime;
DateTime datAddDateTime;

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Public Properties////////////////////////////////////////////////////////////////////////
	public Int64 MatricStudentID
{
	get
	{
		return intMatricStudentID;
	}
	set
	{
		intMatricStudentID = value;
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
public string Board
{
	get
	{
		return strBoard;
	}
	set
	{
		strBoard = value;
	}
}
public string School
{
	get
	{
		return strSchool;
	}
	set
	{
		strSchool = value;
	}
}
public int TotalMarks
{
	get
	{
		return intTotalMarks;
	}
	set
	{
		intTotalMarks = value;
	}
}
public int ObtainedMarks
{
	get
	{
		return intObtainedMarks;
	}
	set
	{
		intObtainedMarks = value;
	}
}
public int YearPassed
{
	get
	{
		return intYearPassed;
	}
	set
	{
		intYearPassed = value;
	}
}
public Int64 LastUpdateID
{
	get
	{
		return intLastUpdateID;
	}
	set
	{
		intLastUpdateID = value;
	}
}
public Int64 AddByID
{
	get
	{
		return intAddByID;
	}
	set
	{
		intAddByID = value;
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
public DateTime AddDateTime
{
	get
	{
		return datAddDateTime;
	}
	set
	{
		datAddDateTime = value;
	}
}

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Private Methods///////////////////////////////////////////////////////////////////////////
	
	//DB to Model//	
	private void GenerateModelList()
	{
		StudentMatricRecordList.Clear();
		foreach (DataRow drStudentMatricRecord in dsStudentMatricRecord.Tables[0].Rows)
		{
			StudentMatricRecord objStudentMatricRecord = new StudentMatricRecord();
			objStudentMatricRecord.MatricStudentID = Convert.ToInt64(drStudentMatricRecord["MatricStudentID"]);
objStudentMatricRecord.StudentID = Convert.ToInt64(drStudentMatricRecord["StudentID"]);
objStudentMatricRecord.Board = Convert.ToString(drStudentMatricRecord["Board"]);
objStudentMatricRecord.School = Convert.ToString(drStudentMatricRecord["School"]);
objStudentMatricRecord.TotalMarks = Convert.ToInt32(drStudentMatricRecord["TotalMarks"]);
objStudentMatricRecord.ObtainedMarks = Convert.ToInt32(drStudentMatricRecord["ObtainedMarks"]);
objStudentMatricRecord.YearPassed = Convert.ToInt32(drStudentMatricRecord["YearPassed"]);
objStudentMatricRecord.LastUpdateID = Convert.ToInt64(drStudentMatricRecord["LastUpdateID"]);
objStudentMatricRecord.AddByID = Convert.ToInt64(drStudentMatricRecord["AddByID"]);
objStudentMatricRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentMatricRecord["LastUpdateDateTime"]);
objStudentMatricRecord.AddDateTime = Convert.ToDateTime(drStudentMatricRecord["AddDateTime"]);

			StudentMatricRecordList.Add(objStudentMatricRecord);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentMatricRecord.Clear();
		conStudentMatricRecord.Open();
		comStudentMatricRecord.Connection = conStudentMatricRecord;
		comStudentMatricRecord.CommandText = strCommandText;
		
		comStudentMatricRecord.CommandType = CommandType.StoredProcedure;
		daStudentMatricRecord.SelectCommand = comStudentMatricRecord;
		daStudentMatricRecord.Fill(dsStudentMatricRecord);
		conStudentMatricRecord.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentMatricRecord> StudentMatricRecordSelectAll()
	{
		try
		{
		    string sp_name = "StudentMatricRecordSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentMatricRecordList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentMatricRecord StudentMatricRecordSelectByID(int intMatricStudentID)
	{
		try
		{
		    string sp_name = "StudentMatricRecordSelectByID";
			comStudentMatricRecord.Parameters.AddWithValue("MatricStudentID", intMatricStudentID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentMatricRecord.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentMatricRecord = dsStudentMatricRecord.Tables[0].Rows[0];
				StudentMatricRecord objStudentMatricRecord = new StudentMatricRecord();
				objStudentMatricRecord.MatricStudentID = Convert.ToInt64(drStudentMatricRecord["MatricStudentID"]);
objStudentMatricRecord.StudentID = Convert.ToInt64(drStudentMatricRecord["StudentID"]);
objStudentMatricRecord.Board = Convert.ToString(drStudentMatricRecord["Board"]);
objStudentMatricRecord.School = Convert.ToString(drStudentMatricRecord["School"]);
objStudentMatricRecord.TotalMarks = Convert.ToInt32(drStudentMatricRecord["TotalMarks"]);
objStudentMatricRecord.ObtainedMarks = Convert.ToInt32(drStudentMatricRecord["ObtainedMarks"]);
objStudentMatricRecord.YearPassed = Convert.ToInt32(drStudentMatricRecord["YearPassed"]);
objStudentMatricRecord.LastUpdateID = Convert.ToInt64(drStudentMatricRecord["LastUpdateID"]);
objStudentMatricRecord.AddByID = Convert.ToInt64(drStudentMatricRecord["AddByID"]);
objStudentMatricRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentMatricRecord["LastUpdateDateTime"]);
objStudentMatricRecord.AddDateTime = Convert.ToDateTime(drStudentMatricRecord["AddDateTime"]);

				return objStudentMatricRecord;
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
	public Int64 InsertUpdateStudentMatricRecord()
	{
		try
		{
			//parameter setting
			comStudentMatricRecord.Parameters.AddWithValue("MatricStudentID", intMatricStudentID);
comStudentMatricRecord.Parameters.AddWithValue("StudentID", intStudentID);
comStudentMatricRecord.Parameters.AddWithValue("Board", strBoard);
comStudentMatricRecord.Parameters.AddWithValue("School", strSchool);
comStudentMatricRecord.Parameters.AddWithValue("TotalMarks", intTotalMarks);
comStudentMatricRecord.Parameters.AddWithValue("ObtainedMarks", intObtainedMarks);
comStudentMatricRecord.Parameters.AddWithValue("YearPassed", intYearPassed);
comStudentMatricRecord.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
comStudentMatricRecord.Parameters.AddWithValue("AddByID", intAddByID);
comStudentMatricRecord.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);
comStudentMatricRecord.Parameters.AddWithValue("AddDateTime", datAddDateTime);

			//end parameter setting
		
			ConnectAndExecute("StudentMatricRecordInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentMatricRecord.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentMatricRecord(Int64 intMatricStudentID = 0)
	{
		try
		{
			string sp_name = "StudentMatricRecordDeleteAll";
			if (intMatricStudentID != 0)
			{
				comStudentMatricRecord.Parameters.AddWithValue("MatricStudentID", intMatricStudentID);
				sp_name = "StudentMatricRecordDeleteByID";
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
			string sp_name = "StudentMatricRecordTruncate";
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