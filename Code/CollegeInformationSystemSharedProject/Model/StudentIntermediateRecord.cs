using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentIntermediateRecord
{
	List<StudentIntermediateRecord> StudentIntermediateRecordList = new List<StudentIntermediateRecord>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentIntermediateRecord;
	SqlCommand comStudentIntermediateRecord;
	SqlDataAdapter daStudentIntermediateRecord;
	DataSet dsStudentIntermediateRecord;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentIntermediateRecord()
	{
		conStudentIntermediateRecord = new SqlConnection(connection_string);
		comStudentIntermediateRecord = new SqlCommand();
		daStudentIntermediateRecord = new SqlDataAdapter();
		dsStudentIntermediateRecord = new DataSet();
	}
	//Private Variables////////////////////////////////////////////////////////////////////////
	
	Int64 intIntermediateStudentID;
Int64 intStudentID;
string strBoardInstitute;
string strSchoolCollege;
Int64 intMajorDAE;
int intTotalMarks;
int intObtainedMarks;
int intYearPassed;
Int64 intAddByID;
DateTime datAddDateTime;
Int64 intLastUpdateID;
DateTime datLastUpdateDateTime;

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Public Properties////////////////////////////////////////////////////////////////////////
	public Int64 IntermediateStudentID
{
	get
	{
		return intIntermediateStudentID;
	}
	set
	{
		intIntermediateStudentID = value;
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
public string BoardInstitute
{
	get
	{
		return strBoardInstitute;
	}
	set
	{
		strBoardInstitute = value;
	}
}
public string SchoolCollege
{
	get
	{
		return strSchoolCollege;
	}
	set
	{
		strSchoolCollege = value;
	}
}
public Int64 MajorDAE
{
	get
	{
		return intMajorDAE;
	}
	set
	{
		intMajorDAE = value;
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

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Private Methods///////////////////////////////////////////////////////////////////////////
	
	//DB to Model//	
	private void GenerateModelList()
	{
		StudentIntermediateRecordList.Clear();
		foreach (DataRow drStudentIntermediateRecord in dsStudentIntermediateRecord.Tables[0].Rows)
		{
			StudentIntermediateRecord objStudentIntermediateRecord = new StudentIntermediateRecord();
			objStudentIntermediateRecord.IntermediateStudentID = Convert.ToInt64(drStudentIntermediateRecord["IntermediateStudentID"]);
objStudentIntermediateRecord.StudentID = Convert.ToInt64(drStudentIntermediateRecord["StudentID"]);
objStudentIntermediateRecord.BoardInstitute = Convert.ToString(drStudentIntermediateRecord["BoardInstitute"]);
objStudentIntermediateRecord.SchoolCollege = Convert.ToString(drStudentIntermediateRecord["SchoolCollege"]);
objStudentIntermediateRecord.MajorDAE = Convert.ToInt64(drStudentIntermediateRecord["MajorDAE"]);
objStudentIntermediateRecord.TotalMarks = Convert.ToInt32(drStudentIntermediateRecord["TotalMarks"]);
objStudentIntermediateRecord.ObtainedMarks = Convert.ToInt32(drStudentIntermediateRecord["ObtainedMarks"]);
objStudentIntermediateRecord.YearPassed = Convert.ToInt32(drStudentIntermediateRecord["YearPassed"]);
objStudentIntermediateRecord.AddByID = Convert.ToInt64(drStudentIntermediateRecord["AddByID"]);
objStudentIntermediateRecord.AddDateTime = Convert.ToDateTime(drStudentIntermediateRecord["AddDateTime"]);
objStudentIntermediateRecord.LastUpdateID = Convert.ToInt64(drStudentIntermediateRecord["LastUpdateID"]);
objStudentIntermediateRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentIntermediateRecord["LastUpdateDateTime"]);

			StudentIntermediateRecordList.Add(objStudentIntermediateRecord);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentIntermediateRecord.Clear();
		conStudentIntermediateRecord.Open();
		comStudentIntermediateRecord.Connection = conStudentIntermediateRecord;
		comStudentIntermediateRecord.CommandText = strCommandText;
		
		comStudentIntermediateRecord.CommandType = CommandType.StoredProcedure;
		daStudentIntermediateRecord.SelectCommand = comStudentIntermediateRecord;
		daStudentIntermediateRecord.Fill(dsStudentIntermediateRecord);
		conStudentIntermediateRecord.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentIntermediateRecord> StudentIntermediateRecordSelectAll()
	{
		try
		{
		    string sp_name = "StudentIntermediateRecordSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentIntermediateRecordList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentIntermediateRecord StudentIntermediateRecordSelectByID(int intIntermediateStudentID)
	{
		try
		{
		    string sp_name = "StudentIntermediateRecordSelectByID";
			comStudentIntermediateRecord.Parameters.AddWithValue("IntermediateStudentID", intIntermediateStudentID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentIntermediateRecord.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentIntermediateRecord = dsStudentIntermediateRecord.Tables[0].Rows[0];
				StudentIntermediateRecord objStudentIntermediateRecord = new StudentIntermediateRecord();
				objStudentIntermediateRecord.IntermediateStudentID = Convert.ToInt64(drStudentIntermediateRecord["IntermediateStudentID"]);
objStudentIntermediateRecord.StudentID = Convert.ToInt64(drStudentIntermediateRecord["StudentID"]);
objStudentIntermediateRecord.BoardInstitute = Convert.ToString(drStudentIntermediateRecord["BoardInstitute"]);
objStudentIntermediateRecord.SchoolCollege = Convert.ToString(drStudentIntermediateRecord["SchoolCollege"]);
objStudentIntermediateRecord.MajorDAE = Convert.ToInt64(drStudentIntermediateRecord["MajorDAE"]);
objStudentIntermediateRecord.TotalMarks = Convert.ToInt32(drStudentIntermediateRecord["TotalMarks"]);
objStudentIntermediateRecord.ObtainedMarks = Convert.ToInt32(drStudentIntermediateRecord["ObtainedMarks"]);
objStudentIntermediateRecord.YearPassed = Convert.ToInt32(drStudentIntermediateRecord["YearPassed"]);
objStudentIntermediateRecord.AddByID = Convert.ToInt64(drStudentIntermediateRecord["AddByID"]);
objStudentIntermediateRecord.AddDateTime = Convert.ToDateTime(drStudentIntermediateRecord["AddDateTime"]);
objStudentIntermediateRecord.LastUpdateID = Convert.ToInt64(drStudentIntermediateRecord["LastUpdateID"]);
objStudentIntermediateRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentIntermediateRecord["LastUpdateDateTime"]);

				return objStudentIntermediateRecord;
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
	public Int64 InsertUpdateStudentIntermediateRecord()
	{
		try
		{
			//parameter setting
			comStudentIntermediateRecord.Parameters.AddWithValue("IntermediateStudentID", intIntermediateStudentID);
comStudentIntermediateRecord.Parameters.AddWithValue("StudentID", intStudentID);
comStudentIntermediateRecord.Parameters.AddWithValue("BoardInstitute", strBoardInstitute);
comStudentIntermediateRecord.Parameters.AddWithValue("SchoolCollege", strSchoolCollege);
comStudentIntermediateRecord.Parameters.AddWithValue("MajorDAE", intMajorDAE);
comStudentIntermediateRecord.Parameters.AddWithValue("TotalMarks", intTotalMarks);
comStudentIntermediateRecord.Parameters.AddWithValue("ObtainedMarks", intObtainedMarks);
comStudentIntermediateRecord.Parameters.AddWithValue("YearPassed", intYearPassed);
comStudentIntermediateRecord.Parameters.AddWithValue("AddByID", intAddByID);
comStudentIntermediateRecord.Parameters.AddWithValue("AddDateTime", datAddDateTime);
comStudentIntermediateRecord.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
comStudentIntermediateRecord.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

			//end parameter setting
		
			ConnectAndExecute("StudentIntermediateRecordInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentIntermediateRecord.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentIntermediateRecord(Int64 intIntermediateStudentID = 0)
	{
		try
		{
			string sp_name = "StudentIntermediateRecordDeleteAll";
			if (intIntermediateStudentID != 0)
			{
				comStudentIntermediateRecord.Parameters.AddWithValue("IntermediateStudentID", intIntermediateStudentID);
				sp_name = "StudentIntermediateRecordDeleteByID";
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
			string sp_name = "StudentIntermediateRecordTruncate";
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