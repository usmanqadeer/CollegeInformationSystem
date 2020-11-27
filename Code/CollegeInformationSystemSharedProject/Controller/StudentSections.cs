using System;
using System.Collections;
using System.Collections.Generic;

public class StudentSectionsController
{
    static StudentSections objStudentSections = new StudentSections();
    public static List<StudentSections> StudentSectionsSelectAll()
    {
        return objStudentSections.StudentSectionsSelectAll();
    }

    public static StudentSections StudentSectionsSelectByID(Int32 intSectionID)
    {
        return objStudentSections.StudentSectionsSelectByID(intSectionID);
    }

    public static Int64 InsertUpdateStudentSections(StudentSections objIUStudentSections)
    {
        Int64 new_id = objIUStudentSections.InsertUpdateStudentSections();
        return new_id;
    }

    public static void DeleteStudentSections(Int32 intSectionID = 0)
    {
        objStudentSections.DeleteStudentSections(intSectionID);
    }

    public static void Truncate()
    {
        objStudentSections.Truncate();
    }
    public static List<StudentSections> StudentSectionsSelectBySessionID(Int64 session_id)
    {
        List<StudentSections> student_programs = StudentSectionsController.StudentSectionsSelectAll();
        List<StudentSections> selected_Sections = new List<StudentSections>();

        foreach (StudentSections sections in student_programs)
            if (sections.SectionID == session_id)
                selected_Sections.Add(sections);

        return selected_Sections;
    }

}