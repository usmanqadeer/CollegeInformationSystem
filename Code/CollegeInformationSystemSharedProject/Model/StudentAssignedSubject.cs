using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentAssignedSubject
{
	List<StudentAssignedSubject> StudentAssignedSubjectList = new List<StudentAssignedSubject>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentAssignedSubject;
	SqlCommand comStudentAssignedSubject;
	SqlDataAdapter daStudentAssignedSubject;
	DataSet dsStudentAssignedSubject;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentAssignedSubject()
	{
		conStudentAssignedSubject = new SqlConnection(connection_string);
		comStudentAssignedSubject = new SqlCommand();
		daStudentAssignedSubject = new SqlDataAdapter();
		dsStudentAssignedSubject = new DataSet();
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
		StudentAssignedSubjectList.Clear();
		foreach (DataRow drStudentAssignedSubject in dsStudentAssignedSubject.Tables[0].Rows)
		{
			StudentAssignedSubject objStudentAssignedSubject = new StudentAssignedSubject();
			objStudentAssignedSubject.StudentSubjectID = Convert.ToInt64(drStudentAssignedSubject["StudentSubjectID"]);
objStudentAssignedSubject.StudentID = Convert.ToInt64(drStudentAssignedSubject["StudentID"]);
objStudentAssignedSubject.SubjectID = Convert.ToInt64(drStudentAssignedSubject["SubjectID"]);
objStudentAssignedSubject.Remarks = Convert.ToString(drStudentAssignedSubject["Remarks"]);
objStudentAssignedSubject.AddedByID = Convert.ToInt64(drStudentAssignedSubject["AddedByID"]);
objStudentAssignedSubject.AddedDateTime = Convert.ToDateTime(drStudentAssignedSubject["AddedDateTime"]);
objStudentAssignedSubject.LastUpdateID = Convert.ToInt64(drStudentAssignedSubject["LastUpdateID"]);
objStudentAssignedSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentAssignedSubject["LastUpdateDateTime"]);

			StudentAssignedSubjectList.Add(objStudentAssignedSubject);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentAssignedSubject.Clear();
		conStudentAssignedSubject.Open();
		comStudentAssignedSubject.Connection = conStudentAssignedSubject;
		comStudentAssignedSubject.CommandText = strCommandText;
		
		comStudentAssignedSubject.CommandType = CommandType.StoredProcedure;
		daStudentAssignedSubject.SelectCommand = comStudentAssignedSubject;
		daStudentAssignedSubject.Fill(dsStudentAssignedSubject);
		conStudentAssignedSubject.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentAssignedSubject> StudentAssignedSubjectSelectAll()
	{
		try
		{
		    string sp_name = "StudentAssignedSubjectSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentAssignedSubjectList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentAssignedSubject StudentAssignedSubjectSelectByID(int intStudentSubjectID)
	{
		try
		{
		    string sp_name = "StudentAssignedSubjectSelectByID";
			comStudentAssignedSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentAssignedSubject.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentAssignedSubject = dsStudentAssignedSubject.Tables[0].Rows[0];
				StudentAssignedSubject objStudentAssignedSubject = new StudentAssignedSubject();
				objStudentAssignedSubject.StudentSubjectID = Convert.ToInt64(drStudentAssignedSubject["StudentSubjectID"]);
objStudentAssignedSubject.StudentID = Convert.ToInt64(drStudentAssignedSubject["StudentID"]);
objStudentAssignedSubject.SubjectID = Convert.ToInt64(drStudentAssignedSubject["SubjectID"]);
objStudentAssignedSubject.Remarks = Convert.ToString(drStudentAssignedSubject["Remarks"]);
objStudentAssignedSubject.AddedByID = Convert.ToInt64(drStudentAssignedSubject["AddedByID"]);
objStudentAssignedSubject.AddedDateTime = Convert.ToDateTime(drStudentAssignedSubject["AddedDateTime"]);
objStudentAssignedSubject.LastUpdateID = Convert.ToInt64(drStudentAssignedSubject["LastUpdateID"]);
objStudentAssignedSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentAssignedSubject["LastUpdateDateTime"]);

				return objStudentAssignedSubject;
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
	public Int64 InsertUpdateStudentAssignedSubject()
	{
		try
		{
			//parameter setting
			comStudentAssignedSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
comStudentAssignedSubject.Parameters.AddWithValue("StudentID", intStudentID);
comStudentAssignedSubject.Parameters.AddWithValue("SubjectID", intSubjectID);
comStudentAssignedSubject.Parameters.AddWithValue("Remarks", strRemarks);
comStudentAssignedSubject.Parameters.AddWithValue("AddedByID", intAddedByID);
comStudentAssignedSubject.Parameters.AddWithValue("AddedDateTime", datAddedDateTime);
comStudentAssignedSubject.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
comStudentAssignedSubject.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

			//end parameter setting
		
			ConnectAndExecute("StudentAssignedSubjectInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentAssignedSubject.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentAssignedSubject(Int64 intStudentSubjectID = 0)
	{
		try
		{
			string sp_name = "StudentAssignedSubjectDeleteAll";
			if (intStudentSubjectID != 0)
			{
				comStudentAssignedSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
				sp_name = "StudentAssignedSubjectDeleteByID";
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
			string sp_name = "StudentAssignedSubjectTruncate";
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