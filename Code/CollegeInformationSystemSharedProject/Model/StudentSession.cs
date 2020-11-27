using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentSession
{
    List<StudentSession> StudentSessionList = new List<StudentSession>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentSession;
    SqlCommand comStudentSession;
    SqlDataAdapter daStudentSession;
    DataSet dsStudentSession;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentSession()
    {
        conStudentSession = new SqlConnection(connection_string);
        comStudentSession = new SqlCommand();
        daStudentSession = new SqlDataAdapter();
        dsStudentSession = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intSessionID;
    string strSessionName;
    string strRemarks;
    DateTime datInsertDataTime;
    Int64 intInsertByID;
    bool blnIsEnabeled;
    DateTime datLastUpdateTime;
    Int64 intLastUpdateID;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
    public Int64 SessionID
    {
        get
        {
            return intSessionID;
        }
        set
        {
            intSessionID = value;
        }
    }
    public string SessionName
    {
        get
        {
            return strSessionName;
        }
        set
        {
            strSessionName = value;
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
        StudentSessionList.Clear();
        foreach (DataRow drStudentSession in dsStudentSession.Tables[0].Rows)
        {
            StudentSession objStudentSession = new StudentSession();
            objStudentSession.SessionID = Convert.ToInt64(drStudentSession["SessionID"]);
            objStudentSession.SessionName = Convert.ToString(drStudentSession["SessionName"]);
            objStudentSession.Remarks = Convert.ToString(drStudentSession["Remarks"]);
            objStudentSession.InsertDataTime = Convert.ToDateTime(drStudentSession["InsertDataTime"]);
            objStudentSession.InsertByID = Convert.ToInt64(drStudentSession["InsertByID"]);
            objStudentSession.IsEnabeled = Convert.ToBoolean(drStudentSession["IsEnabeled"]);
            objStudentSession.LastUpdateTime = Convert.ToDateTime(drStudentSession["LastUpdateTime"]);
            objStudentSession.LastUpdateID = Convert.ToInt64(drStudentSession["LastUpdateID"]);

            StudentSessionList.Add(objStudentSession);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentSession.Clear();
        conStudentSession.Open();
        comStudentSession.Connection = conStudentSession;
        comStudentSession.CommandText = strCommandText;

        comStudentSession.CommandType = CommandType.StoredProcedure;
        daStudentSession.SelectCommand = comStudentSession;
        daStudentSession.Fill(dsStudentSession);
        conStudentSession.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentSession> StudentSessionSelectAll()
    {
        try
        {
            string sp_name = "StudentSessionSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentSessionList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentSession StudentSessionSelectByID(int intSessionID)
    {
        try
        {
            string sp_name = "StudentSessionSelectByID";
            comStudentSession.Parameters.AddWithValue("SessionID", intSessionID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentSession.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentSession = dsStudentSession.Tables[0].Rows[0];
                StudentSession objStudentSession = new StudentSession();
                objStudentSession.SessionID = Convert.ToInt64(drStudentSession["SessionID"]);
                objStudentSession.SessionName = Convert.ToString(drStudentSession["SessionName"]);
                objStudentSession.Remarks = Convert.ToString(drStudentSession["Remarks"]);
                objStudentSession.InsertDataTime = Convert.ToDateTime(drStudentSession["InsertDataTime"]);
                objStudentSession.InsertByID = Convert.ToInt64(drStudentSession["InsertByID"]);
                objStudentSession.IsEnabeled = Convert.ToBoolean(drStudentSession["IsEnabeled"]);
                objStudentSession.LastUpdateTime = Convert.ToDateTime(drStudentSession["LastUpdateTime"]);
                objStudentSession.LastUpdateID = Convert.ToInt64(drStudentSession["LastUpdateID"]);

                return objStudentSession;
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
    public Int64 InsertUpdateStudentSession()
    {
        try
        {
            //parameter setting
            comStudentSession.Parameters.AddWithValue("SessionID", intSessionID);
            comStudentSession.Parameters.AddWithValue("SessionName", strSessionName);
            comStudentSession.Parameters.AddWithValue("Remarks", strRemarks);
            comStudentSession.Parameters.AddWithValue("InsertDataTime", datInsertDataTime);
            comStudentSession.Parameters.AddWithValue("InsertByID", intInsertByID);
            comStudentSession.Parameters.AddWithValue("IsEnabeled", blnIsEnabeled);
            comStudentSession.Parameters.AddWithValue("LastUpdateTime", datLastUpdateTime);
            comStudentSession.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);

            //end parameter setting

            ConnectAndExecute("StudentSessionInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentSession.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentSession(Int64 intSessionID = 0)
    {
        try
        {
            string sp_name = "StudentSessionDeleteAll";
            if (intSessionID != 0)
            {
                comStudentSession.Parameters.AddWithValue("SessionID", intSessionID);
                sp_name = "StudentSessionDeleteByID";
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
            string sp_name = "StudentSessionTruncate";
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