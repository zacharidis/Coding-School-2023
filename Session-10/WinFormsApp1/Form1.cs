using Session_06.Academics;
using Session_06.Helpers;
using Session_06.Stuff;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.None; // no caption

            FillTheGrids();





        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }


        public void FillTheGrids()
        {

            List<Student> students = new List<Student>();

            Student studentOne = new Student()
            {
                Name = "George",
                Gender = GenderEnum.Male,
                RegistrationNumber = 1,
                Age = 25,
                StudiesLevel = StudiesLevelEnum.Undergraduate

            };

            Student studentTwo = new Student()
            {
                Name = "Zachs",
                Gender = GenderEnum.Male,
                RegistrationNumber = 2,
                Age = 24,
                StudiesLevel = StudiesLevelEnum.Postgraduate

            };

            students.Add(studentOne);
            students.Add(studentTwo);


            
            
            grvStudents.DataSource = students;
            
           


            // -- Courses 

            List<Course> courses = new List<Course>();

            Course courseOne = new Course()
            {

                Subject = "DISCRETE Mathematics",
                Code = "MATH"
            };


            Course courseTwo = new Course()
            {

                Subject = "Programming with Pascal",
                Code = "PROGRAMMING INTRO"
            };


            courses.Add(courseOne);
            courses.Add(courseTwo);

            grvCourses.DataSource = courses;



            // -- Grades 


            List <Grade>grades = new List<Grade>();
            Grade gradeOne = new Grade()
            {
                GradeValue = 10,
                CourseID = courseOne.ID,
                StudentId = studentOne.Id,

            };

            Grade gradeTwo = new Grade()
            {
                GradeValue = 9,
                CourseID = courseTwo.ID,
                StudentId = studentTwo.Id,

            };

            grades.Add(gradeOne);
            grades.Add(gradeTwo);

            grvGrades.DataSource = grades;


            // Schedules 

            List <Schedule> schedules = new List<Schedule>();

            Schedule scheduleOne = new Schedule()
            {
                CourseID = courseOne.ID,
                DateTime = DateTime.Now,




            };


            Schedule scheduleTwo = new Schedule()
            {
                CourseID = courseOne.ID,
                DateTime = DateTime.Now,




            };

            schedules.Add(scheduleOne);
            schedules.Add(scheduleTwo);

            grvSchedule.DataSource= schedules;







        }

        private void grvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

             //clear the grids before loading up data 

            grvSchedule.DataSource = null;
            grvCourses.DataSource = null;
            grvGrades.DataSource = null;
            grvStudents.DataSource = null;

            University.MasterSerializer master = new University.MasterSerializer();
            
            // master.SerializeToFile()

            



        }
    }
}
    
