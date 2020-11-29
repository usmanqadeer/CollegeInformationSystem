using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class AllReligion
{
    List<AllReligion> AllReligionList = new List<AllReligion>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conAllReligion;
    SqlCommand comAllReligion;
    SqlDataAdapter daAllReligion;
    DataSet dsAllReligion;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public AllReligion()
    {
        conAllReligion = new SqlConnection(connection_string);
        comAllReligion = new SqlCommand();
        daAllReligion = new SqlDataAdapter();
        dsAllReligion = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intReligionID;
    string strReligionName;
    Int64 intAddByID;
    DateTime datAddByDateTime;
    Int64 intLastUpDateByID;
    DateTime datLastUpdateDateTime;
    string strRemarks;
    bool blnIsEnable;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
    public Int64 ReligionID
    {
        get
        {
            return intReligionID;
        }
        set
        {
            intReligionID = value;
        }
    }
    public string ReligionName
    {
        get
        {
            return strReligionName;
        }
        set
        {
            strReligionName = value;
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
    public Int64 LastUpDateByID
    {
        get
        {
            return intLastUpDateByID;
        }
        set
        {
            intLastUpDateByID = value;
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
    public bool IsEnable
    {
        get
        {
            return blnIsEnable;
        }
        set
        {
            blnIsEnable = value;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Private Methods///////////////////////////////////////////////////////////////////////////

    //DB to Model//	
    private void GenerateModelList()
    {
        AllReligionList.Clear();
        foreach (DataRow drAllReligion in dsAllReligion.Tables[0].Rows)
        {
            AllReligion objAllReligion = new AllReligion();
            objAllReligion.ReligionID = Convert.ToInt64(drAllReligion["ReligionID"]);
            objAllReligion.ReligionName = Convert.ToString(drAllReligion["ReligionName"]);
            objAllReligion.AddByID = Convert.ToInt64(drAllReligion["AddByID"]);
            objAllReligion.AddByDateTime = Convert.ToDateTime(drAllReligion["AddByDateTime"]);
            objAllReligion.LastUpDateByID = Convert.ToInt64(drAllReligion["LastUpDateByID"]);
            objAllReligion.LastUpdateDateTime = Convert.ToDateTime(drAllReligion["LastUpdateDateTime"]);
            objAllReligion.Remarks = Convert.ToString(drAllReligion["Remarks"]);
            objAllReligion.IsEnable = Convert.ToBoolean(drAllReligion["IsEnable"]);

            AllReligionList.Add(objAllReligion);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsAllReligion.Clear();
        conAllReligion.Open();
        comAllReligion.Connection = conAllReligion;
        comAllReligion.CommandText = strCommandText;

        comAllReligion.CommandType = CommandType.StoredProcedure;
        daAllReligion.SelectCommand = comAllReligion;
        daAllReligion.Fill(dsAllReligion);
        conAllReligion.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<AllReligion> AllReligionSelectAll()
    {
        try
        {
            string sp_name = "AllReligionSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return AllReligionList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public AllReligion AllReligionSelectByID(int intReligionID)
    {
        try
        {
            string sp_name = "AllReligionSelectByID";
            comAllReligion.Parameters.AddWithValue("ReligionID", intReligionID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsAllReligion.Tables[0].Rows.Count == 1)
            {
                DataRow drAllReligion = dsAllReligion.Tables[0].Rows[0];
                AllReligion objAllReligion = new AllReligion();
                objAllReligion.ReligionID = Convert.ToInt64(drAllReligion["ReligionID"]);
                objAllReligion.ReligionName = Convert.ToString(drAllReligion["ReligionName"]);
                objAllReligion.AddByID = Convert.ToInt64(drAllReligion["AddByID"]);
                objAllReligion.AddByDateTime = Convert.ToDateTime(drAllReligion["AddByDateTime"]);
                objAllReligion.LastUpDateByID = Convert.ToInt64(drAllReligion["LastUpDateByID"]);
                objAllReligion.LastUpdateDateTime = Convert.ToDateTime(drAllReligion["LastUpdateDateTime"]);
                objAllReligion.Remarks = Convert.ToString(drAllReligion["Remarks"]);
                objAllReligion.IsEnable = Convert.ToBoolean(drAllReligion["IsEnable"]);

                return objAllReligion;
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
    public Int64 InsertUpdateAllReligion()
    {
        try
        {
            //parameter setting
            comAllReligion.Parameters.AddWithValue("ReligionID", intReligionID);
            comAllReligion.Parameters.AddWithValue("ReligionName", strReligionName);
            comAllReligion.Parameters.AddWithValue("AddByID", intAddByID);
            comAllReligion.Parameters.AddWithValue("AddByDateTime", datAddByDateTime);
            comAllReligion.Parameters.AddWithValue("LastUpDateByID", intLastUpDateByID);
            comAllReligion.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);
            comAllReligion.Parameters.AddWithValue("Remarks", strRemarks);
            comAllReligion.Parameters.AddWithValue("IsEnable", blnIsEnable);

            //end parameter setting

            ConnectAndExecute("AllReligionInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsAllReligion.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteAllReligion(Int64 intReligionID = 0)
    {
        try
        {
            string sp_name = "AllReligionDeleteAll";
            if (intReligionID != 0)
            {
                comAllReligion.Parameters.AddWithValue("ReligionID", intReligionID);
                sp_name = "AllReligionDeleteByID";
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
            string sp_name = "AllReligionTruncate";
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