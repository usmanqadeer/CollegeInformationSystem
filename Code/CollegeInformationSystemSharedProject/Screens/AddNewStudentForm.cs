using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CollegeInformationSystem
{
    public partial class AddNewStudentForm : Form
    {
        // Create class-level accesible variables
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;
        int program_ID = 0;
        int degree_ID = 0;
        Int64 student_id = 0;
        // Declare required methods
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }
        private void CaptureCamera2()
        {
            camera = new Thread(new ThreadStart(CaptureCamraGuardin));
            camera.Start();
        }
        private void CaptureCameraCallback()
        {
            try
            {
                frame = new Mat();
                capture = new VideoCapture(0);
                capture.Open(0);

                if (capture.IsOpened())
                {
                    while (isCameraRunning)
                    {
                        capture.Read(frame);
                        image = BitmapConverter.ToBitmap(frame);
                        if (picStudent.Image != null)
                        {
                            picStudent.Image.Dispose();
                        }
                        picStudent.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CaptureCamraGuardin()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);
            if (capture.IsOpened())
            {
                try
                {
                    while (isCameraRunning)
                    {
                        capture.Read(frame);
                        image = BitmapConverter.ToBitmap(frame);
                        if (picGuardin.Image != null)
                        {
                            picGuardin.Image.Dispose();
                        }
                        picGuardin.Image = image;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        public AddNewStudentForm()
        {
            InitializeComponent();
        }
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            BindingDataToComboBox();
            
            //StudentAdmissionInfoDataGridView.DataSource = StudentPersonalInfoController.StudentPersonalInfoSelectAll();
        }
        #region DataBindung To ComboBox From Tables......
        private void BindingDataToComboBox()
        {
            try
            {
                List<StudentDegree> student_degrees = StudentDegreeController.StudentDegreeSelectAll();
                cmbStudentAdmissionDegree.DataSource = student_degrees;
                cmbStudentAdmissionDegree.DisplayMember = "DegreeName";
                cmbStudentAdmissionDegree.ValueMember = "DegreeID";
                cmbStudentAdmissionDegree.Tag = "DegreeID";
                cmbStudentAdmissionDegree.SelectedIndex = 0;

                List<StudentProgram> selected_programs = StudentProgramController.StudentProgramSelectAll();
                cmbStudentAdmissionProgram.DataSource = selected_programs;
                cmbStudentAdmissionProgram.DisplayMember = "ProgramName";
                cmbStudentAdmissionProgram.ValueMember = "ProgramID";
                cmbStudentAdmissionProgram.Tag = "ProgramID";
                cmbStudentAdmissionProgram.SelectedIndex = 0;

                List<StudentSession> student_Sessions = StudentSessionController.StudentSessionSelectAll();
                cmbStudentSession.DataSource = student_Sessions;
                cmbStudentSession.DisplayMember = "SessionName";
                cmbStudentSession.ValueMember = "SessionID";
                cmbStudentSession.Tag = "SessionID";
                cmbStudentSession.SelectedIndex = 0;

                List<StudentSections> Student_section = StudentSectionsController.StudentSectionsSelectAll();
                cmbStudentSession.DataSource = Student_section;
                cmbStudentSession.DisplayMember = "SectionName";
                cmbStudentSession.ValueMember = "SectionID";
                cmbStudentSession.Tag = "SectionID";
                cmbStudentSession.SelectedIndex = 0;

                List<StudentSubject> student_Subject = StudentSubjectController.StudentSubjectSelectAll();
                cmbMasterMajor.DataSource = student_Subject;
                cmbMasterMajor.DisplayMember = "SubjectName";
                cmbMasterMajor.ValueMember = "SubjectID";
                cmbMasterMajor.Tag = "SubjectID";
                cmbMasterMajor.SelectedIndex = 0;

                List<DAEStudentMajor> student_DAEMajor = DAEStudentMajorController.DAEStudentMajorSelectAll();
                cmbInterStudentDEAMajor.DataSource = student_DAEMajor;
                cmbDAE.DisplayMember = "DAEName";
                cmbInterStudentDEAMajor.ValueMember = "DAEMajorID";
                cmbInterStudentDEAMajor.Tag = "DAEMajorID";
                cmbInterStudentDEAMajor.SelectedIndex = 0;

                List<AllReligion> religion = AllReligionController.AllReligionSelectAll();
                cmbRligion.DataSource = religion;
                cmbRligion.DisplayMember = "ReligionName";
                cmbRligion.ValueMember = "ReligionID";
                cmbRligion.Tag = "ReligionID";
                cmbRligion.SelectedIndex = 0;
            }
            catch (Exception) { }
        }
        #endregion
        private void btnStudentPic_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnStudentPic.Text.Equals("Start"))
                {
                    CaptureCamera();
                    btnStudentPic.Text = "Stop";
                    isCameraRunning = true;
                }
                else
                {
                    capture.Release();
                    btnStudentPic.Text = "Start";
                    isCameraRunning = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnPicCapture_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (isCameraRunning)
                {
                    VideoCapture capture = new VideoCapture();
                    picStudent.Image = picStudent.Image;
                    isCameraRunning = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPictureGuardinStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnPictureGuardinStart.Text.Equals("Start"))
                {
                    CaptureCamera2();
                    btnPictureGuardinStart.Text = "Stop";
                    isCameraRunning = true;
                }
                else
                {
                    capture.Release();
                    btnPictureGuardinStart.Text = "Start";
                    isCameraRunning = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (isCameraRunning)
                {
                    VideoCapture capture2 = new VideoCapture();
                    picGuardin.Image = picGuardin.Image;
                    isCameraRunning = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtCurrentAge_Enter(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dtpStudentDOB.Value.Year - (DateTime.Now.DayOfYear < dtpStudentDOB.Value.DayOfYear ? 1 : 0);
            txtCurrentAge.Text = Convert.ToString(age);
        }
        private void tabStudentInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabStudentInfo.SelectedIndex.Equals(5))
            {
                tabStudentInfo.Height = 650;

            }
            else
            {
                tabStudentInfo.Height = 519;
            }
            if (tabStudentInfo.SelectedIndex.Equals(4))
            {
                tpgFee.Height = 350;

            }
            else
            {
                tpgFee.Height = 519;
            }
        }
        #region Event for TabIndex Increment And Decrement......
        private void TabIndexChangedNextTwo_Event_Clicked(Object sender, EventArgs eventArgs)
        {
            tabStudentInfo.SelectedIndex += 1;
        }
        private void TabIndexChangedPreviousTwo_Event_Clicked(Object sender, EventArgs args)
        {
            tabStudentInfo.SelectedIndex -= 1;
        }
        private void TabIndexChangedNext_Event_Clicked(Object sender, EventArgs eventArgs)
        {
            tabStudentEducation.SelectedIndex += 1;
        }
        private void TabIndexChangedPrevious_Event_Clicked(Object sender, EventArgs args)
        {
            tabStudentEducation.SelectedIndex -= 1;
        }
        #endregion
        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            try
            {
                Image admin_pic = picStudent.Image;
                admin_pic.Save("image//student//" + txtStudentCNIC.Text + ".jpg");
                StudentPersonalInfo studentPersonal = new StudentPersonalInfo();

                // Inser student personal record in Database..
                studentPersonal.StudentID = Convert.ToInt32(txtStudentName.Tag);
                studentPersonal.SudentName = txtStudentName.Text;
                studentPersonal.StudentCNIC = txtStudentCNIC.Text;
                studentPersonal.StudentDateOfBrith = dtpStudentDOB.Value;
                studentPersonal.StudentEmail = txtStudentEmail.Text;
                studentPersonal.StudentContactNo = txtStudentPhone.Text;
                studentPersonal.StudentReligionID = Convert.ToInt32(cmbRligion.SelectedValue);
                studentPersonal.StudentAddress = txtStudentAddress.Text;
                studentPersonal.IsEnabled = true;
                studentPersonal.StudentPicture = "image//student//" + txtStudentCNIC.Text + ".jpg";
                studentPersonal.Remarks = txtStudentRemarks.Text;
                studentPersonal.AddByID = Convert.ToInt32(this.Tag);
                studentPersonal.AddByDateTime = System.DateTime.Now;
                studentPersonal.LastUpdateID = Convert.ToInt32(this.Tag);
                studentPersonal.LastUpdateDateTime = System.DateTime.Now;
                Int64 student_id = StudentPersonalInfoController.InsertUpdateStudentPersonalInfo(studentPersonal);

                StudentAdmissionInfoInsertUpdate(student_id);
                StudentAssingedSubjectInsertUpdate(student_id);
                StudentGurdianInsertUpdate(student_id);
                StudentGraduationSubjectInsertUpdate(student_id);
                StudentMAstertInsertUpdate(student_id);
                StudentMatricRecordInserUpdate(student_id);
                StudentMatricSubjectInsertUpdate(student_id);
                StudentInterMediateRecordInsertUpdate(student_id);
                StudentInterMediateSubjectInsertUpdate(student_id);
                StudentFeeRecordInsertUpdate(student_id);
                StudentGurdianInsertUpdate(student_id);
                GeneratingStudentRollNumber();
                if (student_id > 0)
                {
                    MessageBox.Show("Record enter successfully");
                }
                else
                {
                    MessageBox.Show("Record not entered successfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #region InsertUpdate student record.........
        private void StudentAdmissionInfoInsertUpdate(Int64 student_Id = 0)
        {
            StudentAddmissionInfo studentAddmissionInfo = new StudentAddmissionInfo();
            studentAddmissionInfo.StudentAddmissionID = 0;
            studentAddmissionInfo.StudentID = student_Id;
            studentAddmissionInfo.StudentRollNo = txtStudentRollNumber.Text;
            studentAddmissionInfo.AdmissionProgram = Convert.ToInt64(cmbStudentAdmissionProgram.SelectedValue);
            studentAddmissionInfo.AddmissionDegree = Convert.ToInt64(cmbStudentAdmissionDegree.SelectedValue);
            studentAddmissionInfo.EducationSystem = cmbEducationSystem.Text;
            studentAddmissionInfo.StudentSessionID = Convert.ToInt64(cmbStudentSession.SelectedValue);
            studentAddmissionInfo.IsEnabled = true;
            studentAddmissionInfo.StudentSection = Convert.ToInt64(cmbStudentSection.SelectedValue);
            studentAddmissionInfo.AddByID = Convert.ToInt64(this.Tag);
            studentAddmissionInfo.AddByDateTime = System.DateTime.Now;
            studentAddmissionInfo.LastUpdateID = Convert.ToInt64(this.Tag);
            studentAddmissionInfo.LastUpdateDateTime = System.DateTime.Now;
            StudentAddmissionInfoController.InsertUpdateStudentAddmissionInfo(studentAddmissionInfo);
        }
        private void StudentAssingedSubjectInsertUpdate(Int64 student_Id = 0)
        {
            StudentAssignedSubject studentAssignedSubject = new StudentAssignedSubject();
            ArrayList subjectList = chkAdmissionSubject.GetSelectedItems();
            foreach (StudentSubject studentSubject in subjectList)
            {
                studentAssignedSubject = new StudentAssignedSubject();
                studentAssignedSubject.StudentSubjectID = 0;
                studentAssignedSubject.SubjectID = studentSubject.SubjectID;
                studentAssignedSubject.StudentID = student_Id;
                studentAssignedSubject.Remarks = txtAdmissionInfoRemarks.Text;
                studentAssignedSubject.AddedByID = Convert.ToInt32(this.Tag);
                studentAssignedSubject.AddedDateTime = System.DateTime.Now;
                studentAssignedSubject.LastUpdateID = Convert.ToInt32(this.Tag);
                studentAssignedSubject.LastUpdateDateTime = System.DateTime.Now;
                StudentAssignedSubjectController.InsertUpdateStudentAssignedSubject(studentAssignedSubject);
            }
        }
        private void StudentGurdianInsertUpdate(Int64 student_Id = 0)
        {
            Image guardian_pic = picGuardin.Image;
            guardian_pic.Save("guardian//image//" + txtGuardianCNIC.Text + ".jpg");
            StudentGuardianRecord studentGuardianRecord = new StudentGuardianRecord();
            studentGuardianRecord.GuardianID = 0;
            studentGuardianRecord.StudentID = student_Id;
            studentGuardianRecord.GuardianName = txtGuardianName.Text;
            studentGuardianRecord.GuardianCNIC = txtGuardianCNIC.Text;
            studentGuardianRecord.GuadianEmail = txtGuardianEmail.Text;
            studentGuardianRecord.GuardianContact = txtGuardianPhoneNo.Text;
            studentGuardianRecord.GuardianPic = "guardiang//image//" + txtGuardianCNIC.Text + ".jpg";
            studentGuardianRecord.GuardianAddress = txtGuardianAddress.Text;
            studentGuardianRecord.AddedByID = Convert.ToInt64(this.Tag);
            studentGuardianRecord.AddedDateTime = System.DateTime.Now;
            studentGuardianRecord.LastUpdateByID = Convert.ToInt64(this.Tag);
            studentGuardianRecord.LastUpdateDateTime = System.DateTime.Now;
            studentGuardianRecord.Remarks = txtGuardianRemarks.Text;
           StudentGuardianRecordController.InsertUpdateStudentGuardianRecord(studentGuardianRecord);
        }
        private void StudentMatricRecordInserUpdate(Int64 student_Id = 0)
        {
            StudentMatricRecord studentMatricRecord = new StudentMatricRecord();
            studentMatricRecord.MatricStudentID = 0;
            studentMatricRecord.StudentID = student_Id;
            studentMatricRecord.Board = txtMatricStudentBoardInstitute.Text;
            studentMatricRecord.School = txtMatricSchoolInstitute.Text;
            studentMatricRecord.TotalMarks = Convert.ToInt32(txtInMatricTotalMarks.Text);
            studentMatricRecord.ObtainedMarks = Convert.ToInt32(txtInMatricObtainedMarks.Text);
            studentMatricRecord.YearPassed = Convert.ToInt32(txtMatricPassedYear.Text);
            studentMatricRecord.AddByID = Convert.ToInt64(this.Tag);
            studentMatricRecord.AddDateTime = System.DateTime.Now;
            studentMatricRecord.LastUpdateID = Convert.ToInt64(this.Tag);
            studentMatricRecord.LastUpdateDateTime = System.DateTime.Now;
            StudentMatricRecordController.InsertUpdateStudentMatricRecord(studentMatricRecord);
        }
        private void StudentMatricSubjectInsertUpdate(Int64 student_Id = 0)
        {
            StudentMatricSubject studentMatricSubject = new StudentMatricSubject();
            ArrayList matricSubjectList = chkStudentMatricSelectedSubject.GetSelectedItems();
            foreach (StudentSubject studentSubject in matricSubjectList)
            {
                studentMatricSubject = new StudentMatricSubject();
                studentMatricSubject.StudentSubjectID = 0;
                studentMatricSubject.StudentID = student_Id;
                studentMatricSubject.SubjectID = studentSubject.SubjectID;
                studentMatricSubject.Remarks = txtMatricStudentRemark.Text;
                studentMatricSubject.AddedByID = Convert.ToInt64(this.Tag);
                studentMatricSubject.AddedDateTime = System.DateTime.Now;
                studentMatricSubject.LastUpdateID = Convert.ToInt64(this.Tag);
                studentMatricSubject.LastUpdateDateTime = System.DateTime.Now;
                Int64 id =StudentMatricSubjectController.InsertUpdateStudentMatricSubject(studentMatricSubject);
            }
        }
        private void StudentInterMediateRecordInsertUpdate(Int64 student_Id = 0)
        {
            StudentIntermediateRecord studentIntermediateRecord = new StudentIntermediateRecord();
            studentIntermediateRecord.IntermediateStudentID = 0;
            studentIntermediateRecord.StudentID = student_Id;
            studentIntermediateRecord.BoardInstitute = txtInterBoardIntitute.Text;
            studentIntermediateRecord.SchoolCollege = txtInterSchoolCollege.Text;
            studentIntermediateRecord.MajorDAE = Convert.ToInt64(cmbInterStudentDEAMajor.SelectedValue);
            studentIntermediateRecord.TotalMarks = Convert.ToInt32(txtInInterTotalMarks.Text);
            studentIntermediateRecord.ObtainedMarks = Convert.ToInt32(txtInInterObtainedMarks.Text);
            studentIntermediateRecord.YearPassed = Convert.ToInt32(txtInInterPercantage.Text);
            studentIntermediateRecord.AddByID = Convert.ToInt64(this.Tag);
            studentIntermediateRecord.AddDateTime = System.DateTime.Now;
            studentIntermediateRecord.LastUpdateID = Convert.ToInt64(this.Tag);
            studentIntermediateRecord.LastUpdateDateTime = System.DateTime.Now;
            StudentIntermediateRecordController.InsertUpdateStudentIntermediateRecord(studentIntermediateRecord);
        }
        private void StudentInterMediateSubjectInsertUpdate(Int64 student_Id = 0)
        {
            StudentIntermediateSubject studentIntermediateSubject = new StudentIntermediateSubject();
            ArrayList studentInterSubjectList = chkInterSelectedSubject.GetSelectedItems();
            foreach (StudentSubject studentSubject in studentInterSubjectList)
            {
                studentIntermediateSubject = new StudentIntermediateSubject();
                studentIntermediateSubject.StudentSubjectID = 0;
                studentIntermediateSubject.StudentID = student_Id;
                studentIntermediateSubject.SubjectID = studentSubject.SubjectID;
                studentIntermediateSubject.Remarks = txtInterStudentRemarks.Text;
                studentIntermediateSubject.AddedByID = Convert.ToInt64(this.Tag);
                studentIntermediateSubject.AddedDateTime = System.DateTime.Now;
                studentIntermediateSubject.LastUpdateID = Convert.ToInt64(this.Tag);
                studentIntermediateSubject.LastUpdateDateTime = System.DateTime.Now;
                StudentIntermediateSubjectController.InsertUpdateStudentIntermediateSubject(studentIntermediateSubject);
            }
        }
        private void StudentGraduationInsertUpdate(Int64 student_Id = 0)
        {
            StudentGraduationRecord studentGraduationRecord = new StudentGraduationRecord();
            studentGraduationRecord.GraduationStudentID = 0;
            studentGraduationRecord.StudentID = student_id;
            studentGraduationRecord.UniversityInstitute = txtGraduationBoardInstituteUni.Text;
            studentGraduationRecord.Collage = txtGraduationCollegeIntitute.Text;
            studentGraduationRecord.EducationSystem = cmbGraduationStudentEducationSystem.Text;
            studentGraduationRecord.TotalMarks = Convert.ToInt32(txtInGraduationTotalMarks.Text);
            studentGraduationRecord.GraduationCGPA = Convert.ToInt64(txtGraduationStudentCGPA.Text);
            studentGraduationRecord.ObtainedMarks = Convert.ToInt32(txtGraduationObtainedMarks.Text);
            studentGraduationRecord.YearPassed = Convert.ToInt32(txtGraduationPassedYear.Text);
            studentGraduationRecord.AddByID = Convert.ToInt64(this.Tag);
            studentGraduationRecord.AddDateTime = System.DateTime.Now;
            studentGraduationRecord.LastUpdateID = Convert.ToInt64(this.Tag);
            studentGraduationRecord.LastUpdateDateTime = System.DateTime.Now;
            StudentGraduationRecordController.InsertUpdateStudentGraduationRecord(studentGraduationRecord);
        }
        private void StudentGraduationSubjectInsertUpdate(Int64 student_Id = 0)
        {
            StudentGraduationSubject studentGraduationSubject = new StudentGraduationSubject();
            ArrayList studentGraduationSubjectList = chkGraduationSelectedSubject.GetSelectedItems();
            foreach (StudentSubject studentSubject in studentGraduationSubjectList)
            {
                studentGraduationSubject = new StudentGraduationSubject();
                studentGraduationSubject.StudentSubjectID = 0;
                studentGraduationSubject.StudentID = student_Id;
                studentGraduationSubject.SubjectID = studentSubject.SubjectID;
                studentGraduationSubject.Remarks = txtGraduationStudentRemarks.Text;
                studentGraduationSubject.AddedByID = Convert.ToInt64(this.Tag);
                studentGraduationSubject.AddedDateTime = System.DateTime.Now;
                studentGraduationSubject.LastUpdateID = Convert.ToInt64(this.Tag);
                studentGraduationSubject.LastUpdateDateTime = System.DateTime.Now;
                StudentGraduationSubjectController.InsertUpdateStudentGraduationSubject(studentGraduationSubject);
            }
        }
        private void StudentMAstertInsertUpdate(Int64 student_Id = 0)
        {
            StudentMasterRecord studentMasterRecord = new StudentMasterRecord();
            studentMasterRecord.MasterStudentID = 0;
            studentMasterRecord.StudentID = student_id;
            studentMasterRecord.UniversityInstitute = txtMasterBoardInstiute.Text;
            studentMasterRecord.CollegeInstitute = txtMastersUniversityCollege.Text;
            studentMasterRecord.EducationSystem = Convert.ToString(cmbMasterEducationSystem.Text);
            studentMasterRecord.Major = Convert.ToInt64(cmbMasterMajor.SelectedValue);
            studentMasterRecord.TotalMarks = Convert.ToInt32(txtMasterTotalMarks.Text);
            studentMasterRecord.ObtainedMarks = Convert.ToInt32(txtMasterObtainedMarks.Text);
            studentMasterRecord.CGPA = Convert.ToDouble(txtMasterObtainedCGPA.Text);
            studentMasterRecord.YearPassed = Convert.ToInt32(txtMasterPassingYear.Text);
            studentMasterRecord.AddByID = Convert.ToInt64(this.Tag);
            studentMasterRecord.AddDateTime = System.DateTime.Now;
            studentMasterRecord.LastUpdateID = Convert.ToInt64(this.Tag);
            studentMasterRecord.LastUpdateDateTime = System.DateTime.Now;
            StudentMasterRecordController.InsertUpdateStudentMasterRecord(studentMasterRecord);
        }
        private void StudentFeeRecordInsertUpdate(Int64 student_Id = 0)
        {
            StudentFeeInfo studentFeeInfo = new StudentFeeInfo();
            studentFeeInfo.StudentFeeInfoID = 0;
            studentFeeInfo.StudentID = student_id;
            studentFeeInfo.TutionFee = txtTutionFee.Text;
            studentFeeInfo.AdmissionFee = txtAdmissionFee.Text;
            studentFeeInfo.RegistrationFee = txtRegistrationFee.Text;
            studentFeeInfo.ExaminationFee = txtEaminationFee.Text;
            studentFeeInfo.Remarks = txtRemarksAboutFee.Text;
            studentFeeInfo.AddedByID = Convert.ToInt64(this.Tag);
            studentFeeInfo.AddedDateTime = System.DateTime.Now;
            studentFeeInfo.LastUpdateID = Convert.ToInt64(this.Tag);
            studentFeeInfo.LastUpdateDateTime = System.DateTime.Now;
            StudentFeeInfoController.InsertUpdateStudentFeeInfo(studentFeeInfo);
        }
        #endregion
        private void GeneratingStudentRollNumber()
        {
            // TODO: Genrate auto Student rollNo
            degree_ID = Convert.ToInt32(cmbAdmissionDegree.SelectedValue);
            program_ID = Convert.ToInt32(cmbAdmissionProgram.SelectedValue);
            string firstDigit = new string(degree_ID.ToString().Take(1).ToArray());
            string secDigit = new string(program_ID.ToString().Take(1).ToArray());
            String strDegree = new String(cmbAdmissionDegree.Text.Take(1).ToArray());
            String strProgram = new String(cmbAdmissionProgram.Text.Take(1).ToArray());
            String strStudentId = new String(student_id.ToString().Take(2).ToArray());
            string counter = strDegree + "" + strProgram;
            string strRollNoStudent = firstDigit + secDigit;
            txtStudentRollNumber.Text = counter + "_" + strRollNoStudent + strStudentId;
        }
        #region Calculate Student Age ...
        public int[] CalculateAge(DateTime dateNow, DateTime birthDate)
        {
            int day1, month1, year1;
            int day2, month2, year2;
            int diffYear, diffMonth, diffDay;
            diffYear = 0; diffMonth = 0; diffDay = 0;
            year1 = birthDate.Year;
            month1 = birthDate.Month;
            day1 = birthDate.Day;
            day2 = dateNow.Day;
            month2 = dateNow.Month;
            year2 = dateNow.Year;
            if (day2 < day1)
            {
                day2 += DateTime.DaysInMonth(year2, month2);
                diffDay = day2 - day1;
                month2--;
                if (month2 < month1)
                {
                    month2 += 12;
                    year2--;
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
                else
                {
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
            }
            else
            {
                diffDay = day2 - day1;
                if (month2 < month1)
                {
                    month2 += 12;
                    year2--;
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
                else
                {
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
            }
            int[] sonuc = new int[3];
            sonuc[0] = diffYear;
            sonuc[1] = diffMonth;
            sonuc[2] = diffDay;
            return sonuc;
        }
        #endregion
        private void dtpStudentDOB_ValueChanged(object sender, EventArgs e)
        {
            int[] result = CalculateAge(DateTime.Now, Convert.ToDateTime(dtpStudentDOB.Text));
            txtCurrentAge.Text = result[0].ToString() + " Year(s) " + result[1].ToString() + " Month(s) " + result[2].ToString() + " Day(s)";
        }
        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbStudentSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            GeneratingStudentRollNumber();
        }

        private void txtInMatricObtainedMarks_TextChanged(object sender, EventArgs e)
        {
            if (txtInMatricTotalMarks.Text == "" || txtInMatricObtainedMarks.Text == "")
                return;

            decimal mat_obtained_marks = Convert.ToDecimal(txtInMatricObtainedMarks.Text);
            decimal mat_total_marks = Convert.ToDecimal(txtInMatricTotalMarks.Text);
            decimal mat_percentage = (mat_obtained_marks / mat_total_marks) * 100;
            txtInMatricPercantage.Text = Math.Round(mat_percentage, 2).ToString();
        }
        private void txtInInterObtainedMarks_TextChanged(object sender, EventArgs e)
        {
            if (txtInInterTotalMarks.Text == "" || txtInInterObtainedMarks.Text == "")
                return;

            decimal inter_obtained_marks = Convert.ToDecimal(txtInInterObtainedMarks.Text);
            decimal inter_total_marks = Convert.ToDecimal(txtInInterTotalMarks.Text);
            decimal inter_percentage = (inter_obtained_marks / inter_total_marks) * 100;
            txtInInterPercantage.Text = Math.Round(inter_percentage, 2).ToString();
        }
        private void txtInGraduationObtainedMarks_TextChanged(object sender, EventArgs e)
        {
            if (txtInGraduationTotalMarks.Text == "" || txtInGraduationObtainedMarks.Text == "")
                return;

            decimal gradiuation_obtained_marks = Convert.ToDecimal(txtInGraduationObtainedMarks.Text);
            decimal graduation_total_marks = Convert.ToDecimal(txtInGraduationTotalMarks.Text);
            decimal graduation_percentage = (gradiuation_obtained_marks / graduation_total_marks) * 100;
            txtInInterPercantage.Text = Math.Round(graduation_percentage, 2).ToString();
        }

        private void cmbStudentAdmissionDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 degree_id = Convert.ToInt32(cmbAdmissionDegree.SelectedValue);
                List<StudentProgram> selected_programs = StudentProgramController.StudentProgramSelectByDegreeID(degree_id);
                cmbAdmissionProgram.DataSource = selected_programs;
                cmbAdmissionProgram.DisplayMember = "ProgramName";
                cmbAdmissionProgram.ValueMember = "ProgramID";
                cmbAdmissionProgram.SelectedIndex = 0;
                cmbAdmissionProgram.Tag = "ProgramID";
                cmbAdmissionProgram.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void cmbStudentSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int session_id = 0;
            try
            {
                session_id = Convert.ToInt32(cmbSession.SelectedValue);
                List<StudentSections> selected_Sections = new List<StudentSections>();
                selected_Sections = StudentSectionsController.StudentSectionsSelectBySessionID(session_id);

                cmbSection.DataSource = selected_Sections;
                cmbSection.DisplayMember = "SectioName";
                cmbSection.ValueMember = "SectionID";
                cmbSection.Tag = "SectionID";
                cmbSection.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            reportViewerStudentAdmission.RefreshReport();
            reportViewerStudentAdmission.Show();
            
        }
    }
}

