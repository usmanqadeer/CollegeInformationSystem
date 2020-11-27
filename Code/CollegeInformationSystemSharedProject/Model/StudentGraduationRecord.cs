using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentGraduationRecord
{
	List<StudentGraduationRecord> StudentGraduationRecordList = new List<StudentGraduationRecord>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentGraduationRecord;
	SqlCommand comStudentGraduationRecord;
	SqlDataAdapter daStudentGraduationRecord;
	DataSet dsStudentGraduationRecord;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentGraduationRecord()
	{
		conStudentGraduationRecord = new SqlConnection(connection_string);
		comStudentGraduationRecord = new SqlCommand();
		daStudentGraduationRecord = new SqlDataAdapter();
		dsStudentGraduationRecord = new DataSet();
	}
	//Private Variables////////////////////////////////////////////////////////////////////////
	
	Int64 intGraduationStudentID;
Int64 intStudentID;
string strUniversityInstitute;
string strCollage;
string strEducationSystem;
int intTotalMarks;
Int64 intGraduationCGPA;
int intObtainedMarks;
int intYearPassed;
Int64 intAddByID;
DateTime datAddDateTime;
Int64 intLastUpdateID;
DateTime datLastUpdateDateTime;

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Public Properties////////////////////////////////////////////////////////////////////////
	public Int64 GraduationStudentID
{
	get
	{
		return intGraduationStudentID;
	}
	set
	{
		intGraduationStudentID = value;
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
public string UniversityInstitute
{
	get
	{
		return strUniversityInstitute;
	}
	set
	{
		strUniversityInstitute = value;
	}
}
public string Collage
{
	get
	{
		return strCollage;
	}
	set
	{
		strCollage = value;
	}
}
public string EducationSystem
{
	get
	{
		return strEducationSystem;
	}
	set
	{
		strEducationSystem = value;
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
public Int64 GraduationCGPA
{
	get
	{
		return intGraduationCGPA;
	}
	set
	{
		intGraduationCGPA = value;
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
		StudentGraduationRecordList.Clear();
		foreach (DataRow drStudentGraduationRecord in dsStudentGraduationRecord.Tables[0].Rows)
		{
			StudentGraduationRecord objStudentGraduationRecord = new StudentGraduationRecord();
			objStudentGraduationRecord.GraduationStudentID = Convert.ToInt64(drStudentGraduationRecord["GraduationStudentID"]);
objStudentGraduationRecord.StudentID = Convert.ToInt64(drStudentGraduationRecord["StudentID"]);
objStudentGraduationRecord.UniversityInstitute = Convert.ToString(drStudentGraduationRecord["UniversityInstitute"]);
objStudentGraduationRecord.Collage = Convert.ToString(drStudentGraduationRecord["Collage"]);
objStudentGraduationRecord.EducationSystem = Convert.ToString(drStudentGraduationRecord["EducationSystem"]);
objStudentGraduationRecord.TotalMarks = Convert.ToInt32(drStudentGraduationRecord["TotalMarks"]);
objStudentGraduationRecord.GraduationCGPA = Convert.ToInt64(drStudentGraduationRecord["GraduationCGPA"]);
objStudentGraduationRecord.ObtainedMarks = Convert.ToInt32(drStudentGraduationRecord["ObtainedMarks"]);
objStudentGraduationRecord.YearPassed = Convert.ToInt32(drStudentGraduationRecord["YearPassed"]);
objStudentGraduationRecord.AddByID = Convert.ToInt64(drStudentGraduationRecord["AddByID"]);
objStudentGraduationRecord.AddDateTime = Convert.ToDateTime(drStudentGraduationRecord["AddDateTime"]);
objStudentGraduationRecord.LastUpdateID = Convert.ToInt64(drStudentGraduationRecord["LastUpdateID"]);
objStudentGraduationRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentGraduationRecord["LastUpdateDateTime"]);

			StudentGraduationRecordList.Add(objStudentGraduationRecord);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentGraduationRecord.Clear();
		conStudentGraduationRecord.Open();
		comStudentGraduationRecord.Connection = conStudentGraduationRecord;
		comStudentGraduationRecord.CommandText = strCommandText;
		
		comStudentGraduationRecord.CommandType = CommandType.StoredProcedure;
		daStudentGraduationRecord.SelectCommand = comStudentGraduationRecord;
		daStudentGraduationRecord.Fill(dsStudentGraduationRecord);
		conStudentGraduationRecord.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentGraduationRecord> StudentGraduationRecordSelectAll()
	{
		try
		{
		    string sp_name = "StudentGraduationRecordSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentGraduationRecordList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentGraduationRecord StudentGraduationRecordSelectByID(int intGraduationStudentID)
	{
		try
		{
		    string sp_name = "StudentGraduationRecordSelectByID";
			comStudentGraduationRecord.Parameters.AddWithValue("GraduationStudentID", intGraduationStudentID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentGraduationRecord.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentGraduationRecord = dsStudentGraduationRecord.Tables[0].Rows[0];
				StudentGraduationRecord objStudentGraduationRecord = new StudentGraduationRecord();
				objStudentGraduationRecord.GraduationStudentID = Convert.ToInt64(drStudentGraduationRecord["GraduationStudentID"]);
objStudentGraduationRecord.StudentID = Convert.ToInt64(drStudentGraduationRecord["StudentID"]);
objStudentGraduationRecord.UniversityInstitute = Convert.ToString(drStudentGraduationRecord["UniversityInstitute"]);
objStudentGraduationRecord.Collage = Convert.ToString(drStudentGraduationRecord["Collage"]);
objStudentGraduationRecord.EducationSystem = Convert.ToString(drStudentGraduationRecord["EducationSystem"]);
objStudentGraduationRecord.TotalMarks = Convert.ToInt32(drStudentGraduationRecord["TotalMarks"]);
objStudentGraduationRecord.GraduationCGPA = Convert.ToInt64(drStudentGraduationRecord["GraduationCGPA"]);
objStudentGraduationRecord.ObtainedMarks = Convert.ToInt32(drStudentGraduationRecord["ObtainedMarks"]);
objStudentGraduationRecord.YearPassed = Convert.ToInt32(drStudentGraduationRecord["YearPassed"]);
objStudentGraduationRecord.AddByID = Convert.ToInt64(drStudentGraduationRecord["AddByID"]);
objStudentGraduationRecord.AddDateTime = Convert.ToDateTime(drStudentGraduationRecord["AddDateTime"]);
objStudentGraduationRecord.LastUpdateID = Convert.ToInt64(drStudentGraduationRecord["LastUpdateID"]);
objStudentGraduationRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentGraduationRecord["LastUpdateDateTime"]);

				return objStudentGraduationRecord;
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
	public Int64 InsertUpdateStudentGraduationRecord()
	{
		try
		{
			//parameter setting
			comStudentGraduationRecord.Parameters.AddWithValue("GraduationStudentID", intGraduationStudentID);
comStudentGraduationRecord.Parameters.AddWithValue("StudentID", intStudentID);
comStudentGraduationRecord.Parameters.AddWithValue("UniversityInstitute", strUniversityInstitute);
comStudentGraduationRecord.Parameters.AddWithValue("Collage", strCollage);
comStudentGraduationRecord.Parameters.AddWithValue("EducationSystem", strEducationSystem);
comStudentGraduationRecord.Parameters.AddWithValue("TotalMarks", intTotalMarks);
comStudentGraduationRecord.Parameters.AddWithValue("GraduationCGPA", intGraduationCGPA);
comStudentGraduationRecord.Parameters.AddWithValue("ObtainedMarks", intObtainedMarks);
comStudentGraduationRecord.Parameters.AddWithValue("YearPassed", intYearPassed);
comStudentGraduationRecord.Parameters.AddWithValue("AddByID", intAddByID);
comStudentGraduationRecord.Parameters.AddWithValue("AddDateTime", datAddDateTime);
comStudentGraduationRecord.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
comStudentGraduationRecord.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

			//end parameter setting
		
			ConnectAndExecute("StudentGraduationRecordInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentGraduationRecord.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentGraduationRecord(Int64 intGraduationStudentID = 0)
	{
		try
		{
			string sp_name = "StudentGraduationRecordDeleteAll";
			if (intGraduationStudentID != 0)
			{
				comStudentGraduationRecord.Parameters.AddWithValue("GraduationStudentID", intGraduationStudentID);
				sp_name = "StudentGraduationRecordDeleteByID";
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
			string sp_name = "StudentGraduationRecordTruncate";
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