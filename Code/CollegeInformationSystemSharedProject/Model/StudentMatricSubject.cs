using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

public class StudentMatricSubject
{
    List<StudentMatricSubject> StudentMatricSubjectList = new List<StudentMatricSubject>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentMatricSubject;
    SqlCommand comStudentMatricSubject;
    SqlDataAdapter daStudentMatricSubject;
    DataSet dsStudentMatricSubject;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentMatricSubject()
    {
        conStudentMatricSubject = new SqlConnection(connection_string);
        comStudentMatricSubject = new SqlCommand();
        daStudentMatricSubject = new SqlDataAdapter();
        dsStudentMatricSubject = new DataSet();
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
        StudentMatricSubjectList.Clear();
        foreach (DataRow drStudentMatricSubject in dsStudentMatricSubject.Tables[0].Rows)
        {
            StudentMatricSubject objStudentMatricSubject = new StudentMatricSubject();
            objStudentMatricSubject.StudentSubjectID = Convert.ToInt64(drStudentMatricSubject["StudentSubjectID"]);
            objStudentMatricSubject.StudentID = Convert.ToInt64(drStudentMatricSubject["StudentID"]);
            objStudentMatricSubject.SubjectID = Convert.ToInt64(drStudentMatricSubject["SubjectID"]);
            objStudentMatricSubject.Remarks = Convert.ToString(drStudentMatricSubject["Remarks"]);
            objStudentMatricSubject.AddedByID = Convert.ToInt64(drStudentMatricSubject["AddedByID"]);
            objStudentMatricSubject.AddedDateTime = Convert.ToDateTime(drStudentMatricSubject["AddedDateTime"]);
            objStudentMatricSubject.LastUpdateID = Convert.ToInt64(drStudentMatricSubject["LastUpdateID"]);
            objStudentMatricSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentMatricSubject["LastUpdateDateTime"]);

            StudentMatricSubjectList.Add(objStudentMatricSubject);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentMatricSubject.Clear();
        conStudentMatricSubject.Open();
        comStudentMatricSubject.Connection = conStudentMatricSubject;
        comStudentMatricSubject.CommandText = strCommandText;

        comStudentMatricSubject.CommandType = CommandType.StoredProcedure;
        daStudentMatricSubject.SelectCommand = comStudentMatricSubject;
        daStudentMatricSubject.Fill(dsStudentMatricSubject);
        conStudentMatricSubject.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentMatricSubject> StudentMatricSubjectSelectAll()
    {
        try
        {
            string sp_name = "StudentMatricSubjectSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentMatricSubjectList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentMatricSubject StudentMatricSubjectSelectByID(int intStudentSubjectID)
    {
        try
        {
            string sp_name = "StudentMatricSubjectSelectByID";
            comStudentMatricSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentMatricSubject.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentMatricSubject = dsStudentMatricSubject.Tables[0].Rows[0];
                StudentMatricSubject objStudentMatricSubject = new StudentMatricSubject();
                objStudentMatricSubject.StudentSubjectID = Convert.ToInt64(drStudentMatricSubject["StudentSubjectID"]);
                objStudentMatricSubject.StudentID = Convert.ToInt64(drStudentMatricSubject["StudentID"]);
                objStudentMatricSubject.SubjectID = Convert.ToInt64(drStudentMatricSubject["SubjectID"]);
                objStudentMatricSubject.Remarks = Convert.ToString(drStudentMatricSubject["Remarks"]);
                objStudentMatricSubject.AddedByID = Convert.ToInt64(drStudentMatricSubject["AddedByID"]);
                objStudentMatricSubject.AddedDateTime = Convert.ToDateTime(drStudentMatricSubject["AddedDateTime"]);
                objStudentMatricSubject.LastUpdateID = Convert.ToInt64(drStudentMatricSubject["LastUpdateID"]);
                objStudentMatricSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentMatricSubject["LastUpdateDateTime"]);

                return objStudentMatricSubject;
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
    public Int64 InsertUpdateStudentMatricSubject()
    {
        try
        {
            //parameter setting
            comStudentMatricSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
            comStudentMatricSubject.Parameters.AddWithValue("StudentID", intStudentID);
            comStudentMatricSubject.Parameters.AddWithValue("SubjectID", intSubjectID);
            comStudentMatricSubject.Parameters.AddWithValue("Remarks", strRemarks);
            comStudentMatricSubject.Parameters.AddWithValue("AddedByID", intAddedByID);
            comStudentMatricSubject.Parameters.AddWithValue("AddedDateTime", datAddedDateTime);
            comStudentMatricSubject.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
            comStudentMatricSubject.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

            //end parameter setting

            ConnectAndExecute("StudentMatricSubjectInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentMatricSubject.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentMatricSubject(Int64 intStudentSubjectID = 0)
    {
        try
        {
            string sp_name = "StudentMatricSubjectDeleteAll";
            if (intStudentSubjectID != 0)
            {
                comStudentMatricSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
                sp_name = "StudentMatricSubjectDeleteByID";
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
            string sp_name = "StudentMatricSubjectTruncate";
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