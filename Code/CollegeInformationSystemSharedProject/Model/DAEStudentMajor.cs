using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class DAEStudentMajor
{
    List<DAEStudentMajor> DAEStudentMajorList = new List<DAEStudentMajor>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conDAEStudentMajor;
    SqlCommand comDAEStudentMajor;
    SqlDataAdapter daDAEStudentMajor;
    DataSet dsDAEStudentMajor;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public DAEStudentMajor()
    {
        conDAEStudentMajor = new SqlConnection(connection_string);
        comDAEStudentMajor = new SqlCommand();
        daDAEStudentMajor = new SqlDataAdapter();
        dsDAEStudentMajor = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intDAEMajorID;
    string strDAEName;
    Int64 intAddByID;
    DateTime datAddByDateTime;
    Int64 intLastUpdateID;
    DateTime datLastUpdateDateTime;
    bool blnIsEnabled;
    string strRemarks;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
    public Int64 DAEMajorID
    {
        get
        {
            return intDAEMajorID;
        }
        set
        {
            intDAEMajorID = value;
        }
    }
    public string DAEName
    {
        get
        {
            return strDAEName;
        }
        set
        {
            strDAEName = value;
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

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Private Methods///////////////////////////////////////////////////////////////////////////

    //DB to Model//	
    private void GenerateModelList()
    {
        DAEStudentMajorList.Clear();
        foreach (DataRow drDAEStudentMajor in dsDAEStudentMajor.Tables[0].Rows)
        {
            DAEStudentMajor objDAEStudentMajor = new DAEStudentMajor();
            objDAEStudentMajor.DAEMajorID = Convert.ToInt64(drDAEStudentMajor["DAEMajorID"]);
            objDAEStudentMajor.DAEName = Convert.ToString(drDAEStudentMajor["DAEName"]);
            objDAEStudentMajor.AddByID = Convert.ToInt64(drDAEStudentMajor["AddByID"]);
            objDAEStudentMajor.AddByDateTime = Convert.ToDateTime(drDAEStudentMajor["AddByDateTime"]);
            objDAEStudentMajor.LastUpdateID = Convert.ToInt64(drDAEStudentMajor["LastUpdateID"]);
            objDAEStudentMajor.LastUpdateDateTime = Convert.ToDateTime(drDAEStudentMajor["LastUpdateDateTime"]);
            objDAEStudentMajor.IsEnabled = Convert.ToBoolean(drDAEStudentMajor["IsEnabled"]);
            objDAEStudentMajor.Remarks = Convert.ToString(drDAEStudentMajor["Remarks"]);

            DAEStudentMajorList.Add(objDAEStudentMajor);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsDAEStudentMajor.Clear();
        conDAEStudentMajor.Open();
        comDAEStudentMajor.Connection = conDAEStudentMajor;
        comDAEStudentMajor.CommandText = strCommandText;

        comDAEStudentMajor.CommandType = CommandType.StoredProcedure;
        daDAEStudentMajor.SelectCommand = comDAEStudentMajor;
        daDAEStudentMajor.Fill(dsDAEStudentMajor);
        conDAEStudentMajor.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<DAEStudentMajor> DAEStudentMajorSelectAll()
    {
        try
        {
            string sp_name = "DAEStudentMajorSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return DAEStudentMajorList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public DAEStudentMajor DAEStudentMajorSelectByID(int intDAEMajorID)
    {
        try
        {
            string sp_name = "DAEStudentMajorSelectByID";
            comDAEStudentMajor.Parameters.AddWithValue("DAEMajorID", intDAEMajorID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsDAEStudentMajor.Tables[0].Rows.Count == 1)
            {
                DataRow drDAEStudentMajor = dsDAEStudentMajor.Tables[0].Rows[0];
                DAEStudentMajor objDAEStudentMajor = new DAEStudentMajor();
                objDAEStudentMajor.DAEMajorID = Convert.ToInt64(drDAEStudentMajor["DAEMajorID"]);
                objDAEStudentMajor.DAEName = Convert.ToString(drDAEStudentMajor["DAEName"]);
                objDAEStudentMajor.AddByID = Convert.ToInt64(drDAEStudentMajor["AddByID"]);
                objDAEStudentMajor.AddByDateTime = Convert.ToDateTime(drDAEStudentMajor["AddByDateTime"]);
                objDAEStudentMajor.LastUpdateID = Convert.ToInt64(drDAEStudentMajor["LastUpdateID"]);
                objDAEStudentMajor.LastUpdateDateTime = Convert.ToDateTime(drDAEStudentMajor["LastUpdateDateTime"]);
                objDAEStudentMajor.IsEnabled = Convert.ToBoolean(drDAEStudentMajor["IsEnabled"]);
                objDAEStudentMajor.Remarks = Convert.ToString(drDAEStudentMajor["Remarks"]);

                return objDAEStudentMajor;
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
    public Int64 InsertUpdateDAEStudentMajor()
    {
        try
        {
            //parameter setting
            comDAEStudentMajor.Parameters.AddWithValue("DAEMajorID", intDAEMajorID);
            comDAEStudentMajor.Parameters.AddWithValue("DAEName", strDAEName);
            comDAEStudentMajor.Parameters.AddWithValue("AddByID", intAddByID);
            comDAEStudentMajor.Parameters.AddWithValue("AddByDateTime", datAddByDateTime);
            comDAEStudentMajor.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
            comDAEStudentMajor.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);
            comDAEStudentMajor.Parameters.AddWithValue("IsEnabled", blnIsEnabled);
            comDAEStudentMajor.Parameters.AddWithValue("Remarks", strRemarks);

            //end parameter setting

            ConnectAndExecute("DAEStudentMajorInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsDAEStudentMajor.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteDAEStudentMajor(Int64 intDAEMajorID = 0)
    {
        try
        {
            string sp_name = "DAEStudentMajorDeleteAll";
            if (intDAEMajorID != 0)
            {
                comDAEStudentMajor.Parameters.AddWithValue("DAEMajorID", intDAEMajorID);
                sp_name = "DAEStudentMajorDeleteByID";
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
            string sp_name = "DAEStudentMajorTruncate";
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