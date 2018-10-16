/*************************************************************
 * Name: Sharon Thomas (Z1833666)
 *       Sudheeshna Devarapalli (Z1840147)
 * Course: CSCI 504
 * Assignment#: 01
 * Due date: 09/13 11:59 pm
 *************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thomas_Assign2;

namespace Thomas_Assign2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * EventName: Form1_load
         * Parameters: sender,event
         * Summary: prints the existing list of students and courses when the form loads.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            Program p = new Program();
            p.NewStudents.Sort();               //sorting the list of students before printing.
            for (int i = 0; i < p.NewStudents.Count; i++)
            {
                lstStudent.Items.Add("z" + p.NewStudents[i].Zid + " -- " + p.NewStudents[i].LName + "," + p.NewStudents[i].FName);
            }
            p.NewCourses.Sort();               //sorting the list of courses before printing.
            for (int i = 0; i < p.NewCourses.Count; i++)
            {
                lstCourse.Items.Add(p.NewCourses[i].Deptcode + " " + p.NewCourses[i].Cnum + "-" + p.NewCourses[i].Section + "    (" + p.NewCourses[i].Stuenrolledcount + "/" + p.NewCourses[i].Maxenrollment + ")");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        * EventName: bttnEnroll_Click
        * Parameters: sender,event
        * Summary: this event gets called when the enroll button is clicked and enrolls the student into the requested course.
        * Pre-req: Only if the Zid entered is a valid one and also the course asked to 
        *           enroll is an existing course, and if student is not already enrolled in it.
        */
        private void bttnEnroll_Click(object sender, EventArgs e)
        {
            //clearing the message ad list boxes before displaying the result
            rtbOutput.Clear();
            lstCourse.Items.Clear();
            lstStudent.Items.Clear();
            Form1_Load(sender, e);
            Course cobj = new Course();
            Student sobj = new Student();
            int stcount = -1, ccount = -1;
            int index = 0;
            Program p = new Program();
            string id = txtSearchZid.Text;          //storing the input zid
            string coursenum = txtCourse.Text;      //storing the input course
            if (id.Length != 0)
            {
                if (coursenum.Length != 0)
                {
                    string c = id.Substring(0, 1);      //id the zid is entered without omitting the 'Z' character.
                    if (c == "z" || c == "Z")
                    {
                        id = id.Substring(1, id.Length - 1);
                    }
                    for (int k = 0; k < p.NewStudents.Count; k++)
                    {
                        if (p.NewStudents[k].Zid == Convert.ToInt32(id))
                        {
                            stcount = k;
                            break;
                        }
                        else
                            continue;
                    }
                    if (stcount >= 0 && stcount < p.NewStudents.Count)
                    {

                        string[] details = coursenum.Split(' ');
                        string[] cour_sec = details[1].Split('-');

                        for (int k = 0; k < p.NewCourses.Count; k++)
                        {
                            if (p.NewCourses[k].Cnum == Convert.ToUInt32(cour_sec[0]))
                                ccount = k;
                            else
                                continue;
                        }
                        if (ccount >= 0 && ccount < p.NewCourses.Count)
                        {

                            for (int i = 0; i < p.NewCourses.Count; i++)
                            {
                                if (p.NewCourses[i].Cnum == Convert.ToUInt32(cour_sec[0]))
                                {
                                    cobj = p.NewCourses[i];
                                    index = i;
                                    break;
                                }
                            }

                            if (!p.NewCourses[ccount].Stuenrolled.Contains(Convert.ToInt32(id)))
                            {
                                p.NewCourses[ccount].Stuenrolled.Add(Convert.ToInt32(id));
                                if (p.NewStudents[stcount].Crhours <= 18)
                                {
                                    p.NewStudents[stcount].Crhours += cobj.Chours;
                                }
                                else
                                {
                                    rtbOutput.AppendText("Student credit hours exceeds allowed limit of 18. Hence, could not enroll.");
                                }
                                if (p.NewCourses[ccount].Stuenrolledcount < p.NewCourses[ccount].Maxenrollment)
                                {
                                    p.NewCourses[ccount].Stuenrolledcount++;
                                }
                                else
                                {
                                    rtbOutput.AppendText("This class has reached its maximum capacity. Hence, could not enroll. Sorry!");
                                }

                                rtbOutput.AppendText("z" + id + " has been successfully enrolled into " + coursenum.ToUpper() + "\n\n");
                                lstCourse.Items.Clear();
                                for (int i = 0; i < p.NewCourses.Count; i++)
                                {
                                    lstCourse.Items.Add(p.NewCourses[i].Deptcode + " " + p.NewCourses[i].Cnum + "-" + p.NewCourses[i].Section + "    (" + p.NewCourses[i].Stuenrolledcount + "/" + p.NewCourses[i].Maxenrollment + ")");
                                }
                            }
                            else
                            {
                                rtbOutput.AppendText("Student already enrolled into this course");
                            }
                        }
                        else
                            rtbOutput.AppendText("Unfortunately, there is no such course. Please enter a valid course. \n\n\n");
                    }
                    else
                        rtbOutput.AppendText("Unfortunately, there is no such student to proceed to enrolling\n\n\n");
                }
                else
                    rtbOutput.AppendText("Please enter a Course number-Section number");
            }
            else
                rtbOutput.AppendText("Please enter a Z-id <omitting Z character>");
        }

        /*
        * EventName: btnDrop_Click
        * Parameters: sender,event
        * Summary: This event gets called when drop student button gets clicked and intends to drop a student from a particular course.
        * Pre-req: Only if the Zid entered is a valid one and also the course asked to 
        *           has that student enrolled in it. The student has ever enrolled in that course.
        */
        private void btnDrop_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            lstCourse.Items.Clear();
            lstStudent.Items.Clear();
            Form1_Load(sender, e);
            int stcount = -1, ccount = -1;
            Course cobj = new Course();
            Student sobj = new Student();
            Program p = new Program();
            string id = txtSearchZid.Text;
            string coursenum = txtCourse.Text;
            if (id.Length != 0)
            {
                if (coursenum.Length != 0 && coursenum.Length > 3)
                {
                    string c = id.Substring(0, 1);
                    if (c == "z" || c == "Z")                   //if the zid is entered without omitting the Z character.
                    {
                        id = id.Substring(1, id.Length - 1);
                    }
                    for (int k = 0; k < p.NewStudents.Count; k++)
                    {
                        if (p.NewStudents[k].Zid == Convert.ToInt32(id))
                            stcount = k;
                        else
                            continue;
                    }
                    if (stcount >= 0 && stcount < p.NewStudents.Count)
                    {
                        string[] details = coursenum.Split(' ');
                        string[] cour_sec = details[1].Split('-');

                        for (int k = 0; k < p.NewCourses.Count; k++)
                        {
                            if (p.NewCourses[k].Cnum == Convert.ToUInt32(cour_sec[0]))
                            {
                                ccount = k;
                                break;
                            }
                            else
                                continue;
                        }
                        if (ccount >= 0 && ccount < p.NewCourses.Count)
                        {
                            for (int i = 0; i < p.NewCourses.Count; i++)
                            {
                                if (p.NewCourses[i].Cnum == Convert.ToUInt32(cour_sec[0]))
                                {
                                    cobj = p.NewCourses[i];
                                    break;
                                }
                            }
                            if (p.NewCourses[ccount].Stuenrolled.Contains(Convert.ToInt32(id)))
                            {
                                p.NewCourses[ccount].Stuenrolled.Remove(Convert.ToInt32(id));
                                if (p.NewStudents[stcount].Crhours >= 0 && p.NewStudents[stcount].Crhours <= 18)
                                {
                                    p.NewStudents[stcount].Crhours -= p.NewCourses[ccount].Chours;
                                }
                                if (p.NewCourses[ccount].Stuenrolledcount < p.NewCourses[ccount].Maxenrollment)
                                {
                                    p.NewCourses[ccount].Stuenrolledcount--;
                                }
                                rtbOutput.AppendText("z" + id + " has been successfully dropped from " + coursenum.ToUpper() + "\n\n");
                                lstCourse.Items.Clear();
                                for (int i = 0; i < p.NewCourses.Count; i++)
                                {
                                    lstCourse.Items.Add(p.NewCourses[i].Deptcode + " " + p.NewCourses[i].Cnum + "-" + p.NewCourses[i].Section + "    (" + p.NewCourses[i].Stuenrolledcount + "/" + p.NewCourses[i].Maxenrollment + ")");
                                }
                            }
                            else
                                rtbOutput.AppendText("Student had never been enrolled in this course");
                        }
                        else
                            rtbOutput.AppendText("Unfortunately, there is no such course to drop \n\n");
                    }
                    else
                        rtbOutput.AppendText("Unfortunately, there is no such student to proceed to dropping a course\n\n");
                }
                else
                    rtbOutput.AppendText("Please enter a valid <Deptcode Course number-Section number>");
            }
            else
                rtbOutput.AppendText("Please enter a Z-id <omitting Z character>");
        }

        /*
        * EventName: btnAddS_Click
        * Parameters: sender,event
        * Summary: This event gets called when Add student button gets clicked and intends to add a student To NIU system.
        * Pre-req: Fills all the 4 fields, name,zid,major and year.
        */
        private void btnAddS_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            lstCourse.Items.Clear();
            lstStudent.Items.Clear();
            Form1_Load(sender, e);
            Program p = new Program();
            string name = txtName.Text;
            string zid = txtZid.Text;
            string major = cbMajor.Text;
            string year = cbYear.Text;
            string[] flname = name.Split(',');
            int stu_count = p.NewStudents.Count;
            if (name.Length != 0 && zid.Length != 0 && major.Length != 0 && year.Length != 0)
            {
                string c = zid.Substring(0, 1);
                if (c == "z" || c == "Z")                   //if the zid is entered without omitting the Z character.
                {
                    zid = zid.Substring(1, zid.Length - 1);
                }
                else
                    zid = txtZid.Text;
                stu_count++;
                p.Temp = Convert.ToUInt32(zid);
                p.NewStudents.Add(new Student(p.Temp, flname[1], flname[0], major, (Acadyear)Enum.Parse(typeof(Acadyear), year), 0));
                lstStudent.Items.Clear();
                p.NewStudents.Sort();
                for (int i = 0; i < p.NewStudents.Count; i++)
                {
                    lstStudent.Items.Add("z" + p.NewStudents[i].Zid + " -- " + p.NewStudents[i].LName + "," + p.NewStudents[i].FName);
                }
                rtbOutput.AppendText("Welcome to NIU! You have been succesfully added to the Enrollment System");
                txtZid.Clear();
                txtName.Clear();
                cbMajor.SelectedIndex = -1;
                cbYear.SelectedIndex = -1;
            }
            else
                rtbOutput.AppendText("Please fill in all the fields required to add a student");
        }

        /*
        * EventName: btnAddC_Click
        * Parameters: sender,event
        * Summary: This event gets called when Add Course button gets clicked and intends to add a Course To NIU system's existing course list.
        * Pre-req: Fills all the 4 fields, deptcode,Coursenumber,Section and total capacity of students that the course can accept.
        *           Course number should be between 100 to 499
        */
        private void btnAddC_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            lstCourse.Items.Clear();
            lstStudent.Items.Clear();
            Form1_Load(sender, e);
            Program p = new Program();
            Course cobj = new Course();
            cobj.Deptcode = cbDeptCode.Text;
            cobj.Cnum = Convert.ToUInt32(txtCnum.Text);
            cobj.Section = txtSec.Text;
            cobj.Maxenrollment = Convert.ToUInt16(nudCapacity.Value);
            int cr_count = p.NewCourses.Count;
            if (cobj.Cnum > 0)
            {
                
                if (cbDeptCode.SelectedIndex != -1 && txtCnum.Text != "" && txtSec.Text != "" && nudCapacity.Value > 0)
                {
                    cr_count++;
                    p.NewCourses.Add(new Course(cobj.Deptcode, Convert.ToUInt32(cobj.Cnum), cobj.Section, 0, Convert.ToUInt16(cobj.Maxenrollment)));
                    lstCourse.Items.Clear();
                    p.NewCourses.Sort();
                    for (int i = 0; i < p.NewCourses.Count; i++)
                    {
                        lstCourse.Items.Add(p.NewCourses[i].Deptcode + " " + p.NewCourses[i].Cnum + "-" + p.NewCourses[i].Section + "    (" + p.NewCourses[i].Stuenrolledcount + "/" + p.NewCourses[i].Maxenrollment + ")");
                    }
                    rtbOutput.AppendText("You have succesfully added a Course to the Enrollment System");
                    cbDeptCode.SelectedIndex = -1;
                    txtCnum.Clear();
                    txtSec.Clear();
                    nudCapacity.Value = 0;
                }
                else
                    rtbOutput.AppendText("Please fill in all the fields with valid values required to add a course");
            }
            else
                rtbOutput.AppendText("Course numbers should be in a range of 100 to 499");
        }

        /*
        * EventName: btnSearch_Click
        * Parameters: sender,event
        * Summary: This event gets called when Apply Search Criteria button gets clicked and this provides a text completion platform for the parts of zid and courses entered.
        *           i.e, prints the result of all students and courses starting with the values entered, if any.
        */
        private void btnSearch_Click(object sender, EventArgs e)
        {

            rtbOutput.Clear();
            lstCourse.Items.Clear();
            lstStudent.Items.Clear();
            string zid = txtSearchZid.Text;
            string id;
            int result = 0, start = 1;
            int length = zid.Length;
            string course = txtCourse.Text;
            Program p = new Program();
            Course cobj = new Course();
            if (zid != "")
            {   
                id = zid.Substring(start, length - 1);
                for (int i = 0; i < p.NewStudents.Count; i++)
                {
                    if (p.NewStudents[i].Zid.ToString().StartsWith(id) || p.NewStudents[i].Zid.ToString().StartsWith(zid))
                    {
                        lstStudent.Items.Add("z" + p.NewStudents[i].Zid + " -- " + p.NewStudents[i].LName + "," + p.NewStudents[i].FName + "\n");
                        result++;
                    }
                }
                if (result == 0)
                {
                    lstStudent.Items.Add("No result");
                }
            }
            if (course != "")
            {
                result = 0;
                for (int j = 0; j < p.NewCourses.Count; j++)
                {
                    if (p.NewCourses[j].Deptcode.ToString().ToUpper() == course.ToUpper())
                    {
                        lstCourse.Items.Add(p.NewCourses[j].Deptcode + " " + p.NewCourses[j].Cnum + "-" + p.NewCourses[j].Section + " (" + p.NewCourses[j].Stuenrolledcount + "/" + p.NewCourses[j].Maxenrollment + ")\n");
                        result++;
                    }
                }
                if (result == 0)
                    lstCourse.Items.Add("No results");
            }
            if (zid == "" && course == "")
            {
                rtbOutput.AppendText("Please provide a search criteria to proceed...");
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {

        }

        /*  HEREAFTER THERE IS MouseHover AND MouseLeave EVENTS
        * EventName: *_MouseHover and  *_MouseLeave
        * Parameters: sender,event
        * Summary: This event gets called when Mouse hovers and leaves the respective button and changes the color of the button and brings it back
        *           to default color respectively.
        */
        private void bttnEnroll_MouseLeave(object sender, EventArgs e)
        {
            bttnEnroll.BackColor = default(Color);
            bttnEnroll.UseVisualStyleBackColor = true;
        }

        private void bttnEnroll_MouseHover(object sender, EventArgs e)
        {
            bttnEnroll.BackColor = Color.AliceBlue;
        }

        private void btnDrop_MouseHover(object sender, EventArgs e)
        {
            btnDrop.BackColor = Color.AliceBlue;
        }

        private void btnDrop_MouseLeave(object sender, EventArgs e)
        {
            btnDrop.BackColor = default(Color);
            btnDrop.UseVisualStyleBackColor = true;
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.AliceBlue;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = default(Color);
            btnSearch.UseVisualStyleBackColor = true;
        }

        private void btnAddS_MouseHover(object sender, EventArgs e)
        {
            btnAddS.BackColor = Color.AliceBlue;
        }

        private void btnAddS_MouseLeave(object sender, EventArgs e)
        {
            btnAddS.BackColor = default(Color);
            btnAddS.UseVisualStyleBackColor = true;
        }

        private void btnAddC_MouseHover(object sender, EventArgs e)
        {
            btnAddC.BackColor = Color.AliceBlue;
        }

        private void btnAddC_MouseLeave(object sender, EventArgs e)
        {
            btnAddC.BackColor = default(Color);
            btnAddC.UseVisualStyleBackColor = true;
        }

        /*
        * EventName: lstStudent_SelectedIndexChanged
        * Parameters: sender,event
        * Summary: This event gets called when any item from the student list box to the right of the form is clicked.
        *           This displays all the courses enrolled by that particular student, If any.
        */
        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            Program p = new Program();
            Student s = new Student();
            Course c = new Course();
            string selectedItem = lstStudent.Items[lstStudent.SelectedIndex].ToString();
            string[] item = selectedItem.Split(' ');
            string zid = item[0];
            string id = zid.Substring(1, zid.Length - 1);
            int count = 0;
            for (int i = 0; i < p.NewStudents.Count; i++)
            {
                if (p.NewStudents[i].Zid == Convert.ToUInt32(id))
                {
                    p.Temp = p.NewStudents[i].Zid;
                    s.FName = p.NewStudents[i].FName;
                    s.LName = p.NewStudents[i].LName;
                    s.Major = p.NewStudents[i].Major;
                    s.Acdyear = p.NewStudents[i].Acdyear;
                    s.GPA = p.NewStudents[i].GPA;
                    rtbOutput.AppendText(s.ToString());
                    break;
                }
            }
            rtbOutput.AppendText("\n------------------------------------------------------------------------------------------------------------------------------\n");
            for (int i = 0; i < p.NewCourses.Count; i++)
            {
                if (p.NewCourses[i].Stuenrolled.Contains(Convert.ToInt32(id)))
                {
                    c.Deptcode = p.NewCourses[i].Deptcode;
                    c.Cnum = p.NewCourses[i].Cnum;
                    c.Section = p.NewCourses[i].Section;
                    c.Stuenrolledcount = p.NewCourses[i].Stuenrolledcount;
                    c.Maxenrollment = p.NewCourses[i].Maxenrollment;
                    rtbOutput.AppendText(c.ToString() + "\n");
                    count++;
                }
            }
            if (count == 0)
                rtbOutput.AppendText("Not yet registered into any courses");
        }


        /*
        * EventName: lstCourse_SelectedIndexChanged
        * Parameters: sender,event
        * Summary: This event gets called when any item from the course list box to the right of the form is clicked.
        *           This displays all the students enrolled into that particular course, If any.
        */
        private void lstCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            Program p = new Program();
            Student s = new Student();
            Course c = new Course();
            string selectedItem = lstCourse.Items[lstCourse.SelectedIndex].ToString();
            string[] item = selectedItem.Split(' ');
            string dcode = item[0];
            string[] csec = item[1].Split('-');
            string course = csec[0];
            string sec = csec[1];
            List<int> zids = new List<int>();
            int count = 0;
            for (int i = 0; i < p.NewCourses.Count; i++)
            {
                if (p.NewCourses[i].Deptcode == dcode && p.NewCourses[i].Cnum == Convert.ToUInt32(course) && p.NewCourses[i].Section == sec)
                {
                    zids = p.NewCourses[i].Stuenrolled.ToList();
                    c.Deptcode = p.NewCourses[i].Deptcode;
                    c.Cnum = p.NewCourses[i].Cnum;
                    c.Section = p.NewCourses[i].Section;
                    c.Stuenrolledcount = p.NewCourses[i].Stuenrolledcount;
                    c.Maxenrollment = p.NewCourses[i].Maxenrollment;
                    rtbOutput.AppendText("Course: " + dcode + "    " + course + "-" + sec + "    (" + p.NewCourses[i].Stuenrolledcount + "/" + p.NewCourses[i].Maxenrollment + ")");
                }
            }
            rtbOutput.AppendText("\n--------------------------------------------------------------------------------------------------------\n");

            for (int i = 0; i < p.NewStudents.Count; i++)
            {
                if (zids.Contains(Convert.ToInt32(p.NewStudents[i].Zid)))
                {

                    rtbOutput.AppendText("z" + p.NewStudents[i].Zid + "  " + p.NewStudents[i].FName + "," + p.NewStudents[i].LName + "  " + p.NewStudents[i].Major + "\n");
                    count++;
                }
            }
            if (count == 0)
                rtbOutput.AppendText("Nobody has registered into this course yet");
        }

        /*
        * EventName: btnPrntRoster_Click
        * Parameters: sender,event
        * Summary: this event gets called when the Print Roster button is clicked and prints all the students enrolled into that particular course
        *           mentioned in the filter courses text box.
        */
        private void btnPrntRoster_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            lstCourse.Items.Clear();
            lstStudent.Items.Clear();
            Form1_Load(sender, e);
            Program p = new Program();
            Student s = new Student();
            Course c = new Course();
            string selectedItem = txtCourse.Text;
            if (selectedItem != "")
            {
                string[] item = selectedItem.Split(' ');
                string dcode = item[0];
                string[] csec = item[1].Split('-');
                string course = csec[0];
                string sec = csec[1];
                List<int> zids = new List<int>();
                int count = 0;
                for (int i = 0; i < p.NewCourses.Count; i++)
                {
                    if (p.NewCourses[i].Deptcode.ToUpper() == dcode.ToUpper() && p.NewCourses[i].Cnum == Convert.ToUInt32(course) && p.NewCourses[i].Section == sec)
                    {
                        zids = p.NewCourses[i].Stuenrolled.ToList();
                        c.Deptcode = p.NewCourses[i].Deptcode;
                        c.Cnum = p.NewCourses[i].Cnum;
                        c.Section = p.NewCourses[i].Section;
                        c.Stuenrolledcount = p.NewCourses[i].Stuenrolledcount;
                        c.Maxenrollment = p.NewCourses[i].Maxenrollment;
                        rtbOutput.AppendText("Course: " + dcode.ToUpper() + "    " + course + "-" + sec + "    (" + p.NewCourses[i].Stuenrolledcount + "/" + p.NewCourses[i].Maxenrollment + ")");
                    }
                }
                rtbOutput.AppendText("\n--------------------------------------------------------------------------------------------------------\n");

                for (int i = 0; i < p.NewStudents.Count; i++)
                {
                    if (zids.Contains(Convert.ToInt32(p.NewStudents[i].Zid)))
                    {

                        rtbOutput.AppendText("z" + p.NewStudents[i].Zid + "  " + p.NewStudents[i].LName + "," + p.NewStudents[i].FName + "  " + p.NewStudents[i].Major + "\n");
                        count++;
                    }
                }
                if (count == 0)
                    rtbOutput.AppendText("Nobody has registered into this course yet");
            }
            else
                rtbOutput.AppendText("Please enter a course detail to print its roster");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnPrntRoster_MouseHover(object sender, EventArgs e)
        {
            btnPrntRoster.BackColor = Color.AliceBlue;
        }

        private void btnPrntRoster_MouseLeave(object sender, EventArgs e)
        {
            btnPrntRoster.BackColor = default(Color);
            btnPrntRoster.UseVisualStyleBackColor = true;
        }
    }
}
