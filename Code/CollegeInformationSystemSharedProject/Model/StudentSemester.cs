using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentSemester
{
    List<StudentSemester> StudentSemesterList = new List<StudentSemester>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentSemester;
    SqlCommand comStudentSemester;
    SqlDataAdapter daStudentSemester;
    DataSet dsStudentSemester;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentSemester()
    {
        conStudentSemester = new SqlConnection(connection_string);
        comStudentSemester = new SqlCommand();
        daStudentSemester = new SqlDataAdapter();
        dsStudentSemester = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intSemesterID;
    string strSemesterName;
    Int64 intAddByID;
    bool blnIsEnabled;
    DateTime datAddDateTime;
    string strRemarks;
    Int64 intLastUpdateID;
    DateTime datLastUpdateDateTime;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
    public Int64 SemesterID
    {
        get
        {
            return intSemesterID;
        }
        set
        {
            intSemesterID = value;
        }
    }
    public string SemesterName
    {
        get
        {
            return strSemesterName;
        }
        set
        {
            strSemesterName = value;
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
        StudentSemesterList.Clear();
        foreach (DataRow drStudentSemester in dsStudentSemester.Tables[0].Rows)
        {
            StudentSemester objStudentSemester = new StudentSemester();
            objStudentSemester.SemesterID = Convert.ToInt64(drStudentSemester["SemesterID"]);
            objStudentSemester.SemesterName = Convert.ToString(drStudentSemester["SemesterName"]);
            objStudentSemester.AddByID = Convert.ToInt64(drStudentSemester["AddByID"]);
            objStudentSemester.IsEnabled = Convert.ToBoolean(drStudentSemester["IsEnabled"]);
            objStudentSemester.AddDateTime = Convert.ToDateTime(drStudentSemester["AddDateTime"]);
            objStudentSemester.Remarks = Convert.ToString(drStudentSemester["Remarks"]);
            objStudentSemester.LastUpdateID = Convert.ToInt64(drStudentSemester["LastUpdateID"]);
            objStudentSemester.LastUpdateDateTime = Convert.ToDateTime(drStudentSemester["LastUpdateDateTime"]);

            StudentSemesterList.Add(objStudentSemester);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentSemester.Clear();
        conStudentSemester.Open();
        comStudentSemester.Connection = conStudentSemester;
        comStudentSemester.CommandText = strCommandText;

        comStudentSemester.CommandType = CommandType.StoredProcedure;
        daStudentSemester.SelectCommand = comStudentSemester;
        daStudentSemester.Fill(dsStudentSemester);
        conStudentSemester.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentSemester> StudentSemesterSelectAll()
    {
        try
        {
            string sp_name = "StudentSemesterSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentSemesterList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentSemester StudentSemesterSelectByID(int intSemesterID)
    {
        try
        {
            string sp_name = "StudentSemesterSelectByID";
            comStudentSemester.Parameters.AddWithValue("SemesterID", intSemesterID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentSemester.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentSemester = dsStudentSemester.Tables[0].Rows[0];
                StudentSemester objStudentSemester = new StudentSemester();
                objStudentSemester.SemesterID = Convert.ToInt64(drStudentSemester["SemesterID"]);
                objStudentSemester.SemesterName = Convert.ToString(drStudentSemester["SemesterName"]);
                objStudentSemester.AddByID = Convert.ToInt64(drStudentSemester["AddByID"]);
                objStudentSemester.IsEnabled = Convert.ToBoolean(drStudentSemester["IsEnabled"]);
                objStudentSemester.AddDateTime = Convert.ToDateTime(drStudentSemester["AddDateTime"]);
                objStudentSemester.Remarks = Convert.ToString(drStudentSemester["Remarks"]);
                objStudentSemester.LastUpdateID = Convert.ToInt64(drStudentSemester["LastUpdateID"]);
                objStudentSemester.LastUpdateDateTime = Convert.ToDateTime(drStudentSemester["LastUpdateDateTime"]);

                return objStudentSemester;
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
    public Int64 InsertUpdateStudentSemester()
    {
        try
        {
            //parameter setting
            comStudentSemester.Parameters.AddWithValue("SemesterID", intSemesterID);
            comStudentSemester.Parameters.AddWithValue("SemesterName", strSemesterName);
            comStudentSemester.Parameters.AddWithValue("AddByID", intAddByID);
            comStudentSemester.Parameters.AddWithValue("IsEnabled", blnIsEnabled);
            comStudentSemester.Parameters.AddWithValue("AddDateTime", datAddDateTime);
            comStudentSemester.Parameters.AddWithValue("Remarks", strRemarks);
            comStudentSemester.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
            comStudentSemester.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

            //end parameter setting

            ConnectAndExecute("StudentSemesterInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentSemester.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentSemester(Int64 intSemesterID = 0)
    {
        try
        {
            string sp_name = "StudentSemesterDeleteAll";
            if (intSemesterID != 0)
            {
                comStudentSemester.Parameters.AddWithValue("SemesterID", intSemesterID);
                sp_name = "StudentSemesterDeleteByID";
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
            string sp_name = "StudentSemesterTruncate";
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