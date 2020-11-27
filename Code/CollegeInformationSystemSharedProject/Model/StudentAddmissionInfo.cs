using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentAddmissionInfo
{
	List<StudentAddmissionInfo> StudentAddmissionInfoList = new List<StudentAddmissionInfo>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentAddmissionInfo;
	SqlCommand comStudentAddmissionInfo;
	SqlDataAdapter daStudentAddmissionInfo;
	DataSet dsStudentAddmissionInfo;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentAddmissionInfo()
	{
		conStudentAddmissionInfo = new SqlConnection(connection_string);
		comStudentAddmissionInfo = new SqlCommand();
		daStudentAddmissionInfo = new SqlDataAdapter();
		dsStudentAddmissionInfo = new DataSet();
	}
	//Private Variables////////////////////////////////////////////////////////////////////////
	
	Int64 intStudentAddmissionID;
Int64 intStudentID;
string strStudentRollNo;
Int64 intAdmissionProgram;
Int64 intAddmissionDegree;
string strEducationSystem;
Int64 intStudentSessionID;
bool blnIsEnabled;
Int64 intStudentSection;
Int64 intAddByID;
DateTime datAddByDateTime;
Int64 intLastUpdateID;
DateTime datLastUpdateDateTime;

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Public Properties////////////////////////////////////////////////////////////////////////
	public Int64 StudentAddmissionID
{
	get
	{
		return intStudentAddmissionID;
	}
	set
	{
		intStudentAddmissionID = value;
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
public string StudentRollNo
{
	get
	{
		return strStudentRollNo;
	}
	set
	{
		strStudentRollNo = value;
	}
}
public Int64 AdmissionProgram
{
	get
	{
		return intAdmissionProgram;
	}
	set
	{
		intAdmissionProgram = value;
	}
}
public Int64 AddmissionDegree
{
	get
	{
		return intAddmissionDegree;
	}
	set
	{
		intAddmissionDegree = value;
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
public Int64 StudentSessionID
{
	get
	{
		return intStudentSessionID;
	}
	set
	{
		intStudentSessionID = value;
	}
}
public bool IsEnabled
{
	get
	{
		return blnIsEnabled;
	}
	set
	{
		blnIsEnabled = value;
	}
}
public Int64 StudentSection
{
	get
	{
		return intStudentSection;
	}
	set
	{
		intStudentSection = value;
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
public DateTime AddByDateTime
{
	get
	{
		return datAddByDateTime;
	}
	set
	{
		datAddByDateTime = value;
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
		StudentAddmissionInfoList.Clear();
		foreach (DataRow drStudentAddmissionInfo in dsStudentAddmissionInfo.Tables[0].Rows)
		{
			StudentAddmissionInfo objStudentAddmissionInfo = new StudentAddmissionInfo();
			objStudentAddmissionInfo.StudentAddmissionID = Convert.ToInt64(drStudentAddmissionInfo["StudentAddmissionID"]);
objStudentAddmissionInfo.StudentID = Convert.ToInt64(drStudentAddmissionInfo["StudentID"]);
objStudentAddmissionInfo.StudentRollNo = Convert.ToString(drStudentAddmissionInfo["StudentRollNo"]);
objStudentAddmissionInfo.AdmissionProgram = Convert.ToInt64(drStudentAddmissionInfo["AdmissionProgram"]);
objStudentAddmissionInfo.AddmissionDegree = Convert.ToInt64(drStudentAddmissionInfo["AddmissionDegree"]);
objStudentAddmissionInfo.EducationSystem = Convert.ToString(drStudentAddmissionInfo["EducationSystem"]);
objStudentAddmissionInfo.StudentSessionID = Convert.ToInt64(drStudentAddmissionInfo["StudentSessionID"]);
objStudentAddmissionInfo.IsEnabled = Convert.ToBoolean(drStudentAddmissionInfo["IsEnabled"]);
objStudentAddmissionInfo.StudentSection = Convert.ToInt64(drStudentAddmissionInfo["StudentSection"]);
objStudentAddmissionInfo.AddByID = Convert.ToInt64(drStudentAddmissionInfo["AddByID"]);
objStudentAddmissionInfo.AddByDateTime = Convert.ToDateTime(drStudentAddmissionInfo["AddByDateTime"]);
objStudentAddmissionInfo.LastUpdateID = Convert.ToInt64(drStudentAddmissionInfo["LastUpdateID"]);
objStudentAddmissionInfo.LastUpdateDateTime = Convert.ToDateTime(drStudentAddmissionInfo["LastUpdateDateTime"]);

			StudentAddmissionInfoList.Add(objStudentAddmissionInfo);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentAddmissionInfo.Clear();
		conStudentAddmissionInfo.Open();
		comStudentAddmissionInfo.Connection = conStudentAddmissionInfo;
		comStudentAddmissionInfo.CommandText = strCommandText;
		
		comStudentAddmissionInfo.CommandType = CommandType.StoredProcedure;
		daStudentAddmissionInfo.SelectCommand = comStudentAddmissionInfo;
		daStudentAddmissionInfo.Fill(dsStudentAddmissionInfo);
		conStudentAddmissionInfo.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentAddmissionInfo> StudentAddmissionInfoSelectAll()
	{
		try
		{
		    string sp_name = "StudentAddmissionInfoSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentAddmissionInfoList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentAddmissionInfo StudentAddmissionInfoSelectByID(int intStudentAddmissionID)
	{
		try
		{
		    string sp_name = "StudentAddmissionInfoSelectByID";
			comStudentAddmissionInfo.Parameters.AddWithValue("StudentAddmissionID", intStudentAddmissionID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentAddmissionInfo.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentAddmissionInfo = dsStudentAddmissionInfo.Tables[0].Rows[0];
				StudentAddmissionInfo objStudentAddmissionInfo = new StudentAddmissionInfo();
				objStudentAddmissionInfo.StudentAddmissionID = Convert.ToInt64(drStudentAddmissionInfo["StudentAddmissionID"]);
objStudentAddmissionInfo.StudentID = Convert.ToInt64(drStudentAddmissionInfo["StudentID"]);
objStudentAddmissionInfo.StudentRollNo = Convert.ToString(drStudentAddmissionInfo["StudentRollNo"]);
objStudentAddmissionInfo.AdmissionProgram = Convert.ToInt64(drStudentAddmissionInfo["AdmissionProgram"]);
objStudentAddmissionInfo.AddmissionDegree = Convert.ToInt64(drStudentAddmissionInfo["AddmissionDegree"]);
objStudentAddmissionInfo.EducationSystem = Convert.ToString(drStudentAddmissionInfo["EducationSystem"]);
objStudentAddmissionInfo.StudentSessionID = Convert.ToInt64(drStudentAddmissionInfo["StudentSessionID"]);
objStudentAddmissionInfo.IsEnabled = Convert.ToBoolean(drStudentAddmissionInfo["IsEnabled"]);
objStudentAddmissionInfo.StudentSection = Convert.ToInt64(drStudentAddmissionInfo["StudentSection"]);
objStudentAddmissionInfo.AddByID = Convert.ToInt64(drStudentAddmissionInfo["AddByID"]);
objStudentAddmissionInfo.AddByDateTime = Convert.ToDateTime(drStudentAddmissionInfo["AddByDateTime"]);
objStudentAddmissionInfo.LastUpdateID = Convert.ToInt64(drStudentAddmissionInfo["LastUpdateID"]);
objStudentAddmissionInfo.LastUpdateDateTime = Convert.ToDateTime(drStudentAddmissionInfo["LastUpdateDateTime"]);

				return objStudentAddmissionInfo;
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
	public Int64 InsertUpdateStudentAddmissionInfo()
	{
		try
		{
			//parameter setting
			comStudentAddmissionInfo.Parameters.AddWithValue("StudentAddmissionID", intStudentAddmissionID);
comStudentAddmissionInfo.Parameters.AddWithValue("StudentID", intStudentID);
comStudentAddmissionInfo.Parameters.AddWithValue("StudentRollNo", strStudentRollNo);
comStudentAddmissionInfo.Parameters.AddWithValue("AdmissionProgram", intAdmissionProgram);
comStudentAddmissionInfo.Parameters.AddWithValue("AddmissionDegree", intAddmissionDegree);
comStudentAddmissionInfo.Parameters.AddWithValue("EducationSystem", strEducationSystem);
comStudentAddmissionInfo.Parameters.AddWithValue("StudentSessionID", intStudentSessionID);
comStudentAddmissionInfo.Parameters.AddWithValue("IsEnabled", blnIsEnabled);
comStudentAddmissionInfo.Parameters.AddWithValue("StudentSection", intStudentSection);
comStudentAddmissionInfo.Parameters.AddWithValue("AddByID", intAddByID);
comStudentAddmissionInfo.Parameters.AddWithValue("AddByDateTime", datAddByDateTime);
comStudentAddmissionInfo.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
comStudentAddmissionInfo.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

			//end parameter setting
		
			ConnectAndExecute("StudentAddmissionInfoInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentAddmissionInfo.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentAddmissionInfo(Int64 intStudentAddmissionID = 0)
	{
		try
		{
			string sp_name = "StudentAddmissionInfoDeleteAll";
			if (intStudentAddmissionID != 0)
			{
				comStudentAddmissionInfo.Parameters.AddWithValue("StudentAddmissionID", intStudentAddmissionID);
				sp_name = "StudentAddmissionInfoDeleteByID";
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
			string sp_name = "StudentAddmissionInfoTruncate";
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