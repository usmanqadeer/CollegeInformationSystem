using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentGraduationSubject
{
    List<StudentGraduationSubject> StudentGraduationSubjectList = new List<StudentGraduationSubject>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentGraduationSubject;
    SqlCommand comStudentGraduationSubject;
    SqlDataAdapter daStudentGraduationSubject;
    DataSet dsStudentGraduationSubject;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentGraduationSubject()
    {
        conStudentGraduationSubject = new SqlConnection(connection_string);
        comStudentGraduationSubject = new SqlCommand();
        daStudentGraduationSubject = new SqlDataAdapter();
        dsStudentGraduationSubject = new DataSet();
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
        StudentGraduationSubjectList.Clear();
        foreach (DataRow drStudentGraduationSubject in dsStudentGraduationSubject.Tables[0].Rows)
        {
            StudentGraduationSubject objStudentGraduationSubject = new StudentGraduationSubject();
            objStudentGraduationSubject.StudentSubjectID = Convert.ToInt64(drStudentGraduationSubject["StudentSubjectID"]);
            objStudentGraduationSubject.StudentID = Convert.ToInt64(drStudentGraduationSubject["StudentID"]);
            objStudentGraduationSubject.SubjectID = Convert.ToInt64(drStudentGraduationSubject["SubjectID"]);
            objStudentGraduationSubject.Remarks = Convert.ToString(drStudentGraduationSubject["Remarks"]);
            objStudentGraduationSubject.AddedByID = Convert.ToInt64(drStudentGraduationSubject["AddedByID"]);
            objStudentGraduationSubject.AddedDateTime = Convert.ToDateTime(drStudentGraduationSubject["AddedDateTime"]);
            objStudentGraduationSubject.LastUpdateID = Convert.ToInt64(drStudentGraduationSubject["LastUpdateID"]);
            objStudentGraduationSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentGraduationSubject["LastUpdateDateTime"]);

            StudentGraduationSubjectList.Add(objStudentGraduationSubject);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentGraduationSubject.Clear();
        conStudentGraduationSubject.Open();
        comStudentGraduationSubject.Connection = conStudentGraduationSubject;
        comStudentGraduationSubject.CommandText = strCommandText;

        comStudentGraduationSubject.CommandType = CommandType.StoredProcedure;
        daStudentGraduationSubject.SelectCommand = comStudentGraduationSubject;
        daStudentGraduationSubject.Fill(dsStudentGraduationSubject);
        conStudentGraduationSubject.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentGraduationSubject> StudentGraduationSubjectSelectAll()
    {
        try
        {
            string sp_name = "StudentGraduationSubjectSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentGraduationSubjectList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentGraduationSubject StudentGraduationSubjectSelectByID(int intStudentSubjectID)
    {
        try
        {
            string sp_name = "StudentGraduationSubjectSelectByID";
            comStudentGraduationSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentGraduationSubject.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentGraduationSubject = dsStudentGraduationSubject.Tables[0].Rows[0];
                StudentGraduationSubject objStudentGraduationSubject = new StudentGraduationSubject();
                objStudentGraduationSubject.StudentSubjectID = Convert.ToInt64(drStudentGraduationSubject["StudentSubjectID"]);
                objStudentGraduationSubject.StudentID = Convert.ToInt64(drStudentGraduationSubject["StudentID"]);
                objStudentGraduationSubject.SubjectID = Convert.ToInt64(drStudentGraduationSubject["SubjectID"]);
                objStudentGraduationSubject.Remarks = Convert.ToString(drStudentGraduationSubject["Remarks"]);
                objStudentGraduationSubject.AddedByID = Convert.ToInt64(drStudentGraduationSubject["AddedByID"]);
                objStudentGraduationSubject.AddedDateTime = Convert.ToDateTime(drStudentGraduationSubject["AddedDateTime"]);
                objStudentGraduationSubject.LastUpdateID = Convert.ToInt64(drStudentGraduationSubject["LastUpdateID"]);
                objStudentGraduationSubject.LastUpdateDateTime = Convert.ToDateTime(drStudentGraduationSubject["LastUpdateDateTime"]);

                return objStudentGraduationSubject;
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
    public Int64 InsertUpdateStudentGraduationSubject()
    {
        try
        {
            //parameter setting
            comStudentGraduationSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
            comStudentGraduationSubject.Parameters.AddWithValue("StudentID", intStudentID);
            comStudentGraduationSubject.Parameters.AddWithValue("SubjectID", intSubjectID);
            comStudentGraduationSubject.Parameters.AddWithValue("Remarks", strRemarks);
            comStudentGraduationSubject.Parameters.AddWithValue("AddedByID", intAddedByID);
            comStudentGraduationSubject.Parameters.AddWithValue("AddedDateTime", datAddedDateTime);
            comStudentGraduationSubject.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
            comStudentGraduationSubject.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

            //end parameter setting

            ConnectAndExecute("StudentGraduationSubjectInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentGraduationSubject.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentGraduationSubject(Int64 intStudentSubjectID = 0)
    {
        try
        {
            string sp_name = "StudentGraduationSubjectDeleteAll";
            if (intStudentSubjectID != 0)
            {
                comStudentGraduationSubject.Parameters.AddWithValue("StudentSubjectID", intStudentSubjectID);
                sp_name = "StudentGraduationSubjectDeleteByID";
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
            string sp_name = "StudentGraduationSubjectTruncate";
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