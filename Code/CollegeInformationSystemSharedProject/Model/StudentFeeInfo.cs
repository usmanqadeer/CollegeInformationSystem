using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentFeeInfo
{
	List<StudentFeeInfo> StudentFeeInfoList = new List<StudentFeeInfo>();
	//Database Variables///////////////////////////////////////////////////////////////////////
	string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
	SqlConnection conStudentFeeInfo;
	SqlCommand comStudentFeeInfo;
	SqlDataAdapter daStudentFeeInfo;
	DataSet dsStudentFeeInfo;
	int intRecords;
	///////////////////////////////////////////////////////////////////////////////////////////
	
	public StudentFeeInfo()
	{
		conStudentFeeInfo = new SqlConnection(connection_string);
		comStudentFeeInfo = new SqlCommand();
		daStudentFeeInfo = new SqlDataAdapter();
		dsStudentFeeInfo = new DataSet();
	}
	//Private Variables////////////////////////////////////////////////////////////////////////
	
	Int64 intStudentFeeInfoID;
Int64 intStudentID;
string strTutionFee;
string strAdmissionFee;
string strRegistrationFee;
string strExaminationFee;
string strRemarks;
Int64 intAddedByID;
DateTime datAddedDateTime;
Int64 intLastUpdateID;
DateTime datLastUpdateDateTime;

	///////////////////////////////////////////////////////////////////////////////////////////
	
	//Public Properties////////////////////////////////////////////////////////////////////////
	public Int64 StudentFeeInfoID
{
	get
	{
		return intStudentFeeInfoID;
	}
	set
	{
		intStudentFeeInfoID = value;
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
public string TutionFee
{
	get
	{
		return strTutionFee;
	}
	set
	{
		strTutionFee = value;
	}
}
public string AdmissionFee
{
	get
	{
		return strAdmissionFee;
	}
	set
	{
		strAdmissionFee = value;
	}
}
public string RegistrationFee
{
	get
	{
		return strRegistrationFee;
	}
	set
	{
		strRegistrationFee = value;
	}
}
public string ExaminationFee
{
	get
	{
		return strExaminationFee;
	}
	set
	{
		strExaminationFee = value;
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
		StudentFeeInfoList.Clear();
		foreach (DataRow drStudentFeeInfo in dsStudentFeeInfo.Tables[0].Rows)
		{
			StudentFeeInfo objStudentFeeInfo = new StudentFeeInfo();
			objStudentFeeInfo.StudentFeeInfoID = Convert.ToInt64(drStudentFeeInfo["StudentFeeInfoID"]);
objStudentFeeInfo.StudentID = Convert.ToInt64(drStudentFeeInfo["StudentID"]);
objStudentFeeInfo.TutionFee = Convert.ToString(drStudentFeeInfo["TutionFee"]);
objStudentFeeInfo.AdmissionFee = Convert.ToString(drStudentFeeInfo["AdmissionFee"]);
objStudentFeeInfo.RegistrationFee = Convert.ToString(drStudentFeeInfo["RegistrationFee"]);
objStudentFeeInfo.ExaminationFee = Convert.ToString(drStudentFeeInfo["ExaminationFee"]);
objStudentFeeInfo.Remarks = Convert.ToString(drStudentFeeInfo["Remarks"]);
objStudentFeeInfo.AddedByID = Convert.ToInt64(drStudentFeeInfo["AddedByID"]);
objStudentFeeInfo.AddedDateTime = Convert.ToDateTime(drStudentFeeInfo["AddedDateTime"]);
objStudentFeeInfo.LastUpdateID = Convert.ToInt64(drStudentFeeInfo["LastUpdateID"]);
objStudentFeeInfo.LastUpdateDateTime = Convert.ToDateTime(drStudentFeeInfo["LastUpdateDateTime"]);

			StudentFeeInfoList.Add(objStudentFeeInfo);
		}
	}
	
	/// <summary>
	/// This function connect to database and execute the given stored procedure with command object
	/// </summary>
	/// <param name="strCommandText">Stored Procedure name</param>
	private void ConnectAndExecute(string strCommandText)
	{
		dsStudentFeeInfo.Clear();
		conStudentFeeInfo.Open();
		comStudentFeeInfo.Connection = conStudentFeeInfo;
		comStudentFeeInfo.CommandText = strCommandText;
		
		comStudentFeeInfo.CommandType = CommandType.StoredProcedure;
		daStudentFeeInfo.SelectCommand = comStudentFeeInfo;
		daStudentFeeInfo.Fill(dsStudentFeeInfo);
		conStudentFeeInfo.Close();
	}
	
	/// <summary>
	/// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
	/// </summary>
	/// <param name="primary key">Optional primary key for spacific record</param>
	/// <return>Retrived record from database</return>
	public List<StudentFeeInfo> StudentFeeInfoSelectAll()
	{
		try
		{
		    string sp_name = "StudentFeeInfoSelectAll";
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			GenerateModelList();
			return StudentFeeInfoList;
		}
		catch (Exception ex) 
		{
			SetError(ex.Message);
			return null;
		}//end try
	}//end function
	
	public StudentFeeInfo StudentFeeInfoSelectByID(int intStudentFeeInfoID)
	{
		try
		{
		    string sp_name = "StudentFeeInfoSelectByID";
			comStudentFeeInfo.Parameters.AddWithValue("StudentFeeInfoID", intStudentFeeInfoID);
			ConnectAndExecute(sp_name); //no parameter will send to stored procedure
			if (dsStudentFeeInfo.Tables[0].Rows.Count == 1)
			{
				DataRow drStudentFeeInfo = dsStudentFeeInfo.Tables[0].Rows[0];
				StudentFeeInfo objStudentFeeInfo = new StudentFeeInfo();
				objStudentFeeInfo.StudentFeeInfoID = Convert.ToInt64(drStudentFeeInfo["StudentFeeInfoID"]);
objStudentFeeInfo.StudentID = Convert.ToInt64(drStudentFeeInfo["StudentID"]);
objStudentFeeInfo.TutionFee = Convert.ToString(drStudentFeeInfo["TutionFee"]);
objStudentFeeInfo.AdmissionFee = Convert.ToString(drStudentFeeInfo["AdmissionFee"]);
objStudentFeeInfo.RegistrationFee = Convert.ToString(drStudentFeeInfo["RegistrationFee"]);
objStudentFeeInfo.ExaminationFee = Convert.ToString(drStudentFeeInfo["ExaminationFee"]);
objStudentFeeInfo.Remarks = Convert.ToString(drStudentFeeInfo["Remarks"]);
objStudentFeeInfo.AddedByID = Convert.ToInt64(drStudentFeeInfo["AddedByID"]);
objStudentFeeInfo.AddedDateTime = Convert.ToDateTime(drStudentFeeInfo["AddedDateTime"]);
objStudentFeeInfo.LastUpdateID = Convert.ToInt64(drStudentFeeInfo["LastUpdateID"]);
objStudentFeeInfo.LastUpdateDateTime = Convert.ToDateTime(drStudentFeeInfo["LastUpdateDateTime"]);

				return objStudentFeeInfo;
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
	public Int64 InsertUpdateStudentFeeInfo()
	{
		try
		{
			//parameter setting
			comStudentFeeInfo.Parameters.AddWithValue("StudentFeeInfoID", intStudentFeeInfoID);
comStudentFeeInfo.Parameters.AddWithValue("StudentID", intStudentID);
comStudentFeeInfo.Parameters.AddWithValue("TutionFee", strTutionFee);
comStudentFeeInfo.Parameters.AddWithValue("AdmissionFee", strAdmissionFee);
comStudentFeeInfo.Parameters.AddWithValue("RegistrationFee", strRegistrationFee);
comStudentFeeInfo.Parameters.AddWithValue("ExaminationFee", strExaminationFee);
comStudentFeeInfo.Parameters.AddWithValue("Remarks", strRemarks);
comStudentFeeInfo.Parameters.AddWithValue("AddedByID", intAddedByID);
comStudentFeeInfo.Parameters.AddWithValue("AddedDateTime", datAddedDateTime);
comStudentFeeInfo.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
comStudentFeeInfo.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

			//end parameter setting
		
			ConnectAndExecute("StudentFeeInfoInsertUpdate");
			Int64 record_id = Convert.ToInt64(dsStudentFeeInfo.Tables[0].Rows[0][0]);
			return record_id;
		}
		catch (Exception ex)
		{
			SetError(ex.Message);
			return 0;
		}
	}
	
	public void DeleteStudentFeeInfo(Int64 intStudentFeeInfoID = 0)
	{
		try
		{
			string sp_name = "StudentFeeInfoDeleteAll";
			if (intStudentFeeInfoID != 0)
			{
				comStudentFeeInfo.Parameters.AddWithValue("StudentFeeInfoID", intStudentFeeInfoID);
				sp_name = "StudentFeeInfoDeleteByID";
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
			string sp_name = "StudentFeeInfoTruncate";
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