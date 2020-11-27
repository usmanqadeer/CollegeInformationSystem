using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentIntermediateSubject
{
	List<StudentIntermediateSubject> StudentIntermediateSubjectList = new List<StudentIntermediateSubject>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentIntermediateSubject;
	SqlCommand comStudentIntermediateSubject;
	SqlDataAdapter daStudentIntermediateSubject;
	DataSet dsStudentIntermediateSubject;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentIntermediateSubject()
	{
		conStudentIntermediateSubject = new SqlConnection(connection_string);
		comStudentIntermediateSubject = new SqlCommand();
		daStudentIntermediateSubject = new SqlDataAdapter();
		dsStudentIntermediateSubject = new DataSet();
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
		StudentIntermediateSubjectList.Clear();
		foreach (DataRow drStudentIntermediateSubject in dsStudentIntermediateSubject.Tables[0].Rows)
		{
			StudentIntermediateSubject objStudentIntermediateSubject = new StudentIntermediateSubject();
			objStudentIntermediateSubject.StudentSubjectID = Convert.ToInt64(drStudentIntermediateSubject["StudentSubjectID"]);
objStudentIntermediateSubject.StudentID = Convert.ToInt64(drStudentIntermediateSubject["StudentID"]);
objStudentIntermediateSubject.SubjectID = Convert.ToInt64(drStudentIntermediateSubject["SubjectID"]);
objStudentIntermediateSubject.Remarks = Convert.ToString(drStudentIntermediateSubject["Remarks"]);
objStudentIntermediateSubject.AddedByID = Convert.ToInt64(drStudentIntermediateSubject["AddedByID"]);
objStudentIntermediateSubject.AddedDateTime = Convert.ToDateTime(drStudentIntermediateSubject["AddedDateTime"]);
objStudentIntermediateSubject.LastUpdateID = Convert.ToInt64(drStudentIntermediateSubject["LastUpdateID"]);
objStudentIntermediateSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentIntermediateSubject["LastUpdateDateTime"]);

			StudentIntermediateSubjectList.Add(objStudentIntermediateSubject);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentIntermediateSubject.Clear();
		conStudentIntermediateSubject.Open();
		comStudentIntermediateSubject.Connection = conStudentIntermediateSubject;
		comStudentIntermediateSubject.CommandText = strCommandText;
		
		comStudentIntermediateSubject.CommandType = CommandType.StoredProcedure;
		daStudentIntermediateSubject.SelectCommand = comStudentIntermediateSubject;
		daStudentIntermediateSubject.Fill(dsStudentIntermediateSubject);
		conStudentIntermediateSubject.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentIntermediateSubject> StudentIntermediateSubjectSelectAll()
	{
		try
		{
		    string sp_name = "StudentIntermediateSubjectSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentIntermediateSubjectList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentIntermediateSubject StudentIntermediateSubjectSelectByID(int intStudentSubjectID)
	{
		try
		{
		    string sp_name = "StudentIntermediateSubjectSelectByID";
			comStudentIntermediateSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentIntermediateSubject.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentIntermediateSubject = dsStudentIntermediateSubject.Tables[0].Rows[0];
				StudentIntermediateSubject objStudentIntermediateSubject = new StudentIntermediateSubject();
				objStudentIntermediateSubject.StudentSubjectID = Convert.ToInt64(drStudentIntermediateSubject["StudentSubjectID"]);
objStudentIntermediateSubject.StudentID = Convert.ToInt64(drStudentIntermediateSubject["StudentID"]);
objStudentIntermediateSubject.SubjectID = Convert.ToInt64(drStudentIntermediateSubject["SubjectID"]);
objStudentIntermediateSubject.Remarks = Convert.ToString(drStudentIntermediateSubject["Remarks"]);
objStudentIntermediateSubject.AddedByID = Convert.ToInt64(drStudentIntermediateSubject["AddedByID"]);
objStudentIntermediateSubject.AddedDateTime = Convert.ToDateTime(drStudentIntermediateSubject["AddedDateTime"]);
objStudentIntermediateSubject.LastUpdateID = Convert.ToInt64(drStudentIntermediateSubject["LastUpdateID"]);
objStudentIntermediateSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentIntermediateSubject["LastUpdateDateTime"]);

				return objStudentIntermediateSubject;
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
	public Int64 InsertUpdateStudentIntermediateSubject()
	{
		try
		{
			//parameter setting
			comStudentIntermediateSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
comStudentIntermediateSubject.Parameters.AddWithValue("StudentID", intStudentID);
comStudentIntermediateSubject.Parameters.AddWithValue("SubjectID", intSubjectID);
comStudentIntermediateSubject.Parameters.AddWithValue("Remarks", strRemarks);
comStudentIntermediateSubject.Parameters.AddWithValue("AddedByID", intAddedByID);
comStudentIntermediateSubject.Parameters.AddWithValue("AddedDateTime", datAddedDateTime);
comStudentIntermediateSubject.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
comStudentIntermediateSubject.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

			//end parameter setting
		
			ConnectAndExecute("StudentIntermediateSubjectInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentIntermediateSubject.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentIntermediateSubject(Int64 intStudentSubjectID = 0)
	{
		try
		{
			string sp_name = "StudentIntermediateSubjectDeleteAll";
			if (intStudentSubjectID != 0)
			{
				comStudentIntermediateSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
				sp_name = "StudentIntermediateSubjectDeleteByID";
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
			string sp_name = "StudentIntermediateSubjectTruncate";
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