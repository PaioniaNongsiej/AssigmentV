using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    class Program
    {
        public static SqlConnection con;

        public static SqlCommand cmd;

        public static SqlDataReader dr;

        static void Main(string[] args)

        {
            Console.WriteLine("---------------Employee Management Portal----------");
            Console.WriteLine("\r\nType Role: Admin = 1 ,User = 2 ");
            int role = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose Operation");
            if (role == 1)
                Console.WriteLine("Admin \n  1:Display\n 2:Insert \n 3:Update \n  4:Delete");
            else
                Console.WriteLine("User \n 1:Display \n 2:Update Profiles ");
            int operation = Convert.ToInt32(Console.ReadLine());


            switch (role)

            {

                case 1:

                    switch (operation)

                    {

                        case 1:
                            SelectData();


                            break;

                        case 2:

                            InsertData();

                            break;


                        case 3:

                            UpdateData();

                            break;

                        case 4:
                            DeleteData();

                            break;

                    }

                    break;



                case 2:

                    switch (operation)

                    {

                        case 1:

                            SelectData();
                            break;

                        case 2:

                            UpdateData();

                            break;

                    }

                    break;



                default:

                    Console.WriteLine("Invalid Role/Usertype");

                    break;
            }

            Console.ReadLine();

        }
        public static SqlConnection getConnection()

        {

            con = new SqlConnection("data source=LAPTOP-6IRQ0U8L; Initial Catalog =master;" + "integrated security = true");

            con.Open();

            return con;

        }
        public static void SelectData()

        {

            try

            {

                con = getConnection(); // gets the connection details after executing the getConnection method

                cmd = new SqlCommand("select * from Emp3", con);

                dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    //Console.WriteLine(dr[0] + " |" + dr[1] + "| " + dr[2]);

                    Console.WriteLine("--------------------");

                    Console.WriteLine("Employee Id : {0}", dr[0]);

                    Console.WriteLine("Employee Name : {0}", dr[1]);

                    Console.WriteLine("Employee job : {0}", dr[2]);

                    Console.WriteLine("Employee MGR : {0}", dr[3]);

                    Console.WriteLine("Employee Hiredate : {0}", dr[4]);

                    Console.WriteLine("Employee salary : {0}", dr[5]);

                }

            }

            catch (SqlException se)

            {

                Console.WriteLine("Some Error Occured.. Try after sometime");

                Console.WriteLine(se.Message);

            }

        }
        public static void InsertData()

        {

            con = getConnection();
            

            Console.WriteLine("Enter Employee id:");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter Employee job:");
            string empjob = Console.ReadLine();
            Console.WriteLine("Enter Employee MGR:");
            int empMGR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee salary:");
            int esalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee commission:");
            int ecomm = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("insert into emp3 values(@empno,@ename,@job,@MGR, @salary, @commission)", con);
            cmd.Parameters.AddWithValue("@empno", empid);
            cmd.Parameters.AddWithValue("@ename", empname);
            cmd.Parameters.AddWithValue("@job", empjob);
            cmd.Parameters.AddWithValue("@MGR", empMGR);
            cmd.Parameters.AddWithValue("@salary", esalary);
            cmd.Parameters.AddWithValue("@commission", ecomm);

            int rws = cmd.ExecuteNonQuery();

            if (rws > 0)

            {

                Console.WriteLine("Record Inserted Successfully.");

            }

            else

                Console.WriteLine("Not Inserted..");

        }




        public static void DeleteData()

        {

            con = getConnection();

            Console.WriteLine("Enter Employee id :");

            int eid = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd1 = new SqlCommand("Select * from emp3 where empno=@ecode");

            cmd1.Parameters.AddWithValue("@ecode", eid);

            cmd1.Connection = con; SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())

            {

                for (int i = 0; i < dr1.FieldCount; i++)

                {

                    Console.WriteLine(dr1[i]);

                }

            }

            con.Close();

            Console.WriteLine("Are you sure to delete this employee ? Y/N");

            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")

            {

                cmd = new SqlCommand("delete from emp3 where empno=@ecode", con);

                cmd.Parameters.AddWithValue("@ecode", eid);

                con.Open(); int rw = cmd.ExecuteNonQuery();

                if (rw > 0)

                    Console.WriteLine("Record Deleted..");

                else

                    Console.WriteLine("Not deleted");

            }
        }

        public static void UpdateData()

        {

            con = getConnection();

            Console.WriteLine("Enter Employee id :");
            int eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee new job:");
            string empjob = Console.ReadLine();
            Console.WriteLine("Enter Employee new MGR:");
            int empMGR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee new salary :");
            int empsalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee new commission:");
            int empcomm = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n___________orignal data____________\n");

            SqlCommand cmd1 = new SqlCommand("Select * from emp3 where empno=@ecode");

            cmd1.Parameters.AddWithValue("@ecode", eid);

            cmd1.Connection = con; SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())

            {

                for (int i = 0; i < dr1.FieldCount; i++)

                {

                    Console.WriteLine(dr1[i]);

                }

            }

            con.Close();

            Console.WriteLine("Are you sure to update this employees data ? Y/N");

            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")

            {

                cmd = new SqlCommand("update emp3 set  job= @ejob, MGR=@eMGR, salary=@esal, commission = @ecomm where empno=@ecode", con);

                cmd.Parameters.AddWithValue("@ecode", eid);
               
                cmd.Parameters.AddWithValue("@ejob", empjob);
                cmd.Parameters.AddWithValue("@eMGR", empMGR);
                cmd.Parameters.AddWithValue("@esal", empsalary);
                cmd.Parameters.AddWithValue("@ecomm", empcomm);

                con.Open(); 
                int rw = cmd.ExecuteNonQuery();

                if (rw > 0)

                    Console.WriteLine("Record updated..");

                else

                    Console.WriteLine("Not updated");

            }
        }
    }
}
