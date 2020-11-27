using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

public class StudentSubject
{
    List<StudentSubject> StudentSubjectList = new List<StudentSubject>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentSubject;
    SqlCommand comStudentSubject;
    SqlDataAdapter daStudentSubject;
    DataSet dsStudentSubject;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentSubject()
    {
        conStudentSubject = new SqlConnection(connection_string);
        comStudentSubject = new SqlCommand();
        daStudentSubject = new SqlDataAdapter();
        dsStudentSubject = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intSubjectID;
    string strSubjectName;
    string strRemarks;
    DateTime datInsertDataTime;
    Int64 intInsertByID;
    bool blnIsEnabeled;
    DateTime datLastUpdateTime;
    Int64 intLastUpdateID;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
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
    public string SubjectName
    {
        get
        {
            return strSubjectName;
        }
        set
        {
            strSubjectName = value;
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
    public DateTime InsertDataTime
    {
        get
        {
            return datInsertDataTime;
        }
        set
        {
            datInsertDataTime = value;
        }
    }
    public Int64 InsertByID
    {
        get
        {
            return intInsertByID;
        }
        set
        {
            intInsertByID = value;
        }
    }
    public bool IsEnabeled
    {
        get
        {
            return blnIsEnabeled;
        }
        set
        {
            blnIsEnabeled = value;
        }
    }
    public DateTime LastUpdateTime
    {
        get
        {
            return datLastUpdateTime;
        }
        set
        {
            datLastUpdateTime = value;
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

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Private Methods///////////////////////////////////////////////////////////////////////////

    //DB to Model//	
    private void GenerateModelList()
    {
        StudentSubjectList.Clear();
        foreach (DataRow drStudentSubject in dsStudentSubject.Tables[0].Rows)
        {
            StudentSubject objStudentSubject = new StudentSubject();
            objStudentSubject.SubjectID = Convert.ToInt64(drStudentSubject["SubjectID"]);
            objStudentSubject.SubjectName = Convert.ToString(drStudentSubject["SubjectName"]);
            objStudentSubject.Remarks = Convert.ToString(drStudentSubject["Remarks"]);
            objStudentSubject.InsertDataTime = Convert.ToDateTime(drStudentSubject["InsertDataTime"]);
            objStudentSubject.InsertByID = Convert.ToInt64(drStudentSubject["InsertByID"]);
            objStudentSubject.IsEnabeled = Convert.ToBoolean(drStudentSubject["IsEnabeled"]);
            objStudentSubject.LastUpdateTime = Convert.ToDateTime(drStudentSubject["LastUpdateTime"]);
            objStudentSubject.LastUpdateID = Convert.ToInt64(drStudentSubject["LastUpdateID"]);

            StudentSubjectList.Add(objStudentSubject);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentSubject.Clear();
        conStudentSubject.Open();
        comStudentSubject.Connection = conStudentSubject;
        comStudentSubject.CommandText = strCommandText;

        comStudentSubject.CommandType = CommandType.StoredProcedure;
        daStudentSubject.SelectCommand = comStudentSubject;
        daStudentSubject.Fill(dsStudentSubject);
        conStudentSubject.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentSubject> StudentSubjectSelectAll()
    {
        try
        {
            string sp_name = "StudentSubjectSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentSubjectList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentSubject StudentSubjectSelectByID(int intSubjectID)
    {
        try
        {
            string sp_name = "StudentSubjectSelectByID";
            comStudentSubject.Parameters.AddWithValue("SubjectID", intSubjectID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentSubject.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentSubject = dsStudentSubject.Tables[0].Rows[0];
                StudentSubject objStudentSubject = new StudentSubject();
                objStudentSubject.SubjectID = Convert.ToInt64(drStudentSubject["SubjectID"]);
                objStudentSubject.SubjectName = Convert.ToString(drStudentSubject["SubjectName"]);
                objStudentSubject.Remarks = Convert.ToString(drStudentSubject["Remarks"]);
                objStudentSubject.InsertDataTime = Convert.ToDateTime(drStudentSubject["InsertDataTime"]);
                objStudentSubject.InsertByID = Convert.ToInt64(drStudentSubject["InsertByID"]);
                objStudentSubject.IsEnabeled = Convert.ToBoolean(drStudentSubject["IsEnabeled"]);
                objStudentSubject.LastUpdateTime = Convert.ToDateTime(drStudentSubject["LastUpdateTime"]);
                objStudentSubject.LastUpdateID = Convert.ToInt64(drStudentSubject["LastUpdateID"]);

                return objStudentSubject;
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
    public Int64 InsertUpdateStudentSubject()
    {
        try
        {
            //parameter setting
            comStudentSubject.Parameters.AddWithValue("SubjectID", intSubjectID);
            comStudentSubject.Parameters.AddWithValue("SubjectName", strSubjectName);
            comStudentSubject.Parameters.AddWithValue("Remarks", strRemarks);
            comStudentSubject.Parameters.AddWithValue("InsertDataTime", datInsertDataTime);
            comStudentSubject.Parameters.AddWithValue("InsertByID", intInsertByID);
            comStudentSubject.Parameters.AddWithValue("IsEnabeled", blnIsEnabeled);
            comStudentSubject.Parameters.AddWithValue("LastUpdateTime", datLastUpdateTime);
            comStudentSubject.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);

            //end parameter setting

            ConnectAndExecute("StudentSubjectInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentSubject.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentSubject(Int64 intSubjectID = 0)
    {
        try
        {
            string sp_name = "StudentSubjectDeleteAll";
            if (intSubjectID != 0)
            {
                comStudentSubject.Parameters.AddWithValue("SubjectID", intSubjectID);
                sp_name = "StudentSubjectDeleteByID";
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
            string sp_name = "StudentSubjectTruncate";
            ConnectAndExecute(sp_name);
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
        }
    }

    private void SetError(string message)
    { }


}