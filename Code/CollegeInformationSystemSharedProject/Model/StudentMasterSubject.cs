using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentMasterSubject
{
	List<StudentMasterSubject> StudentMasterSubjectList = new List<StudentMasterSubject>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentMasterSubject;
	SqlCommand comStudentMasterSubject;
	SqlDataAdapter daStudentMasterSubject;
	DataSet dsStudentMasterSubject;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentMasterSubject()
	{
		conStudentMasterSubject = new SqlConnection(connection_string);
		comStudentMasterSubject = new SqlCommand();
		daStudentMasterSubject = new SqlDataAdapter();
		dsStudentMasterSubject = new DataSet();
	}
	//Private Variables////////////////////////////////////////////////////////////////////////
	
	Int64 intStudentSubjectID;
Int64 intStudentID;
Int64 intSubjectID;
string strRemarks;
Int64 intAddedByID;
DateTime datAddedDateTime;
Int64 intLastUpdateID;
DateTime datLastUpdateDateTime;

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Public Properties////////////////////////////////////////////////////////////////////////
	public Int64 StudentSubjectID
{
	get
	{
		return intStudentSubjectID;
	}
	set
	{
		intStudentSubjectID = value;
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
public Int64 SubjectID
{
	get
	{
		return intSubjectID;
	}
	set
	{
		intSubjectID = value;
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
		StudentMasterSubjectList.Clear();
		foreach (DataRow drStudentMasterSubject in dsStudentMasterSubject.Tables[0].Rows)
		{
			StudentMasterSubject objStudentMasterSubject = new StudentMasterSubject();
			objStudentMasterSubject.StudentSubjectID = Convert.ToInt64(drStudentMasterSubject["StudentSubjectID"]);
objStudentMasterSubject.StudentID = Convert.ToInt64(drStudentMasterSubject["StudentID"]);
objStudentMasterSubject.SubjectID = Convert.ToInt64(drStudentMasterSubject["SubjectID"]);
objStudentMasterSubject.Remarks = Convert.ToString(drStudentMasterSubject["Remarks"]);
objStudentMasterSubject.AddedByID = Convert.ToInt64(drStudentMasterSubject["AddedByID"]);
objStudentMasterSubject.AddedDateTime = Convert.ToDateTime(drStudentMasterSubject["AddedDateTime"]);
objStudentMasterSubject.LastUpdateID = Convert.ToInt64(drStudentMasterSubject["LastUpdateID"]);
objStudentMasterSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentMasterSubject["LastUpdateDateTime"]);

			StudentMasterSubjectList.Add(objStudentMasterSubject);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentMasterSubject.Clear();
		conStudentMasterSubject.Open();
		comStudentMasterSubject.Connection = conStudentMasterSubject;
		comStudentMasterSubject.CommandText = strCommandText;
		
		comStudentMasterSubject.CommandType = CommandType.StoredProcedure;
		daStudentMasterSubject.SelectCommand = comStudentMasterSubject;
		daStudentMasterSubject.Fill(dsStudentMasterSubject);
		conStudentMasterSubject.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentMasterSubject> StudentMasterSubjectSelectAll()
	{
		try
		{
		    string sp_name = "StudentMasterSubjectSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentMasterSubjectList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentMasterSubject StudentMasterSubjectSelectByID(int intStudentSubjectID)
	{
		try
		{
		    string sp_name = "StudentMasterSubjectSelectByID";
			comStudentMasterSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentMasterSubject.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentMasterSubject = dsStudentMasterSubject.Tables[0].Rows[0];
				StudentMasterSubject objStudentMasterSubject = new StudentMasterSubject();
				objStudentMasterSubject.StudentSubjectID = Convert.ToInt64(drStudentMasterSubject["StudentSubjectID"]);
objStudentMasterSubject.StudentID = Convert.ToInt64(drStudentMasterSubject["StudentID"]);
objStudentMasterSubject.SubjectID = Convert.ToInt64(drStudentMasterSubject["SubjectID"]);
objStudentMasterSubject.Remarks = Convert.ToString(drStudentMasterSubject["Remarks"]);
objStudentMasterSubject.AddedByID = Convert.ToInt64(drStudentMasterSubject["AddedByID"]);
objStudentMasterSubject.AddedDateTime = Convert.ToDateTime(drStudentMasterSubject["AddedDateTime"]);
objStudentMasterSubject.LastUpdateID = Convert.ToInt64(drStudentMasterSubject["LastUpdateID"]);
objStudentMasterSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentMasterSubject["LastUpdateDateTime"]);

				return objStudentMasterSubject;
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
	public Int64 InsertUpdateStudentMasterSubject()
	{
		try
		{
			//parameter setting
			comStudentMasterSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
comStudentMasterSubject.Parameters.AddWithValue("StudentID", intStudentID);
comStudentMasterSubject.Parameters.AddWithValue("SubjectID", intSubjectID);
comStudentMasterSubject.Parameters.AddWithValue("Remarks", strRemarks);
comStudentMasterSubject.Parameters.AddWithValue("AddedByID", intAddedByID);
comStudentMasterSubject.Parameters.AddWithValue("AddedDateTime", datAddedDateTime);
comStudentMasterSubject.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
comStudentMasterSubject.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

			//end parameter setting
		
			ConnectAndExecute("StudentMasterSubjectInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentMasterSubject.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentMasterSubject(Int64 intStudentSubjectID = 0)
	{
		try
		{
			string sp_name = "StudentMasterSubjectDeleteAll";
			if (intStudentSubjectID != 0)
			{
				comStudentMasterSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
				sp_name = "StudentMasterSubjectDeleteByID";
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
			string sp_name = "StudentMasterSubjectTruncate";
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