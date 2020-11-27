using System;
using System.Collections;
using System.Collections.Generic;

public class AllReligionController
{
    static AllReligion objAllReligion = new AllReligion();
    public static List<AllReligion> AllReligionSelectAll()
    {
        return objAllReligion.AllReligionSelectAll();
    }

    public static AllReligion AllReligionSelectByID(Int32 intReligionID)
    {
        return objAllReligion.AllReligionSelectByID(intReligionID);
    }

    public static Int64 InsertUpdateAllReligion(AllReligion objIUAllReligion)
    {
        Int64 new_id = objIUAllReligion.InsertUpdateAllReligion();
        return new_id;
    }

    public static void DeleteAllReligion(Int32 intReligionID = 0)
    {
        objAllReligion.DeleteAllReligion(intReligionID);
    }

    public static void Truncate()
    {
        objAllReligion.Truncate();
    }
}