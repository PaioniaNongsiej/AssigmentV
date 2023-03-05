using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQassignment
{
    class Employee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string city { get; set; }




        public static List<Employee> GetEmployeeData()
        {
            List<Employee> employees = new List<Employee>()
            {
                (new Employee{EmployeeId =1001,FirstName ="Malcolm",LastName = "Daruwalla" ,Title="Manager",DOB=Convert.ToDateTime("16/11/1984"),DOJ=Convert.ToDateTime("08/06/2011"),city ="Mumbai"}),
                (new Employee{EmployeeId =1002,FirstName ="Asdin",LastName = "Dhalla" ,Title="AsstManager",DOB=Convert.ToDateTime("20/08/1984"),DOJ=Convert.ToDateTime("07/07/2012"),city ="Mumbai"}),
                (new Employee{EmployeeId =1003,FirstName ="Madhavi",LastName = "Oza" ,Title="Consultant",DOB=Convert.ToDateTime("14/11/1987"),DOJ=Convert.ToDateTime("12/04/2015"),city ="Pune"}),
                (new Employee{EmployeeId =1004,FirstName ="Saba",LastName = "Shaikh" ,Title="SE",DOB=Convert.ToDateTime("3/6/1990"),DOJ=Convert.ToDateTime("2/2/2016"),city ="Pune"}),
                (new Employee{EmployeeId =1005,FirstName =" Nazia",LastName = "Shaikh" ,Title="SE",DOB=Convert.ToDateTime("08/03/1991"),DOJ=Convert.ToDateTime("02/06/2006"),city ="Mumbai"}),
                (new Employee{EmployeeId =1006,FirstName ="Amit",LastName = "Pathak" ,Title="Consultant",DOB=Convert.ToDateTime("07/11/1989"),DOJ=Convert.ToDateTime("08/08/2014"),city ="Chennai"}),
                (new Employee{EmployeeId =1007,FirstName =" Vijay",LastName = "Natrajan" ,Title="SE",DOB=Convert.ToDateTime("02/12/1989"),DOJ=Convert.ToDateTime("01/06/2015"),city ="Mumbai"}),
                (new Employee{EmployeeId =1008,FirstName =" Rahul",LastName = "Dubey" ,Title="Associate",DOB=Convert.ToDateTime("11/11/1993") ,DOJ=Convert.ToDateTime("06/11/2014"),city ="Chennai"}),
                (new Employee{EmployeeId =1009,FirstName =" Suresh",LastName = "Mistry" ,Title="Associate",DOB=Convert.ToDateTime("12/08/1992"),DOJ=Convert.ToDateTime("03/12/2014"),city ="Chennai"}),
                (new Employee{EmployeeId =1010,FirstName =" Sumit",LastName = "Shah" ,Title="Manager",DOB=Convert.ToDateTime("12/04/1991"),DOJ=Convert.ToDateTime("02/01/2016"),city ="Pune"}),

            };
            return employees;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("\r\n 1.list all employee \n2.list employees whose location is not mumbai\n3.employee whose title is Asstmanger\n4.employee whos last ame starts with s \n5.employees who have joined before 1/1/2015\n6.employee whose date of birth is after 1/1/1990\n7.employee whose desigamtio is consultant and assosiate \n8.total umer of employees\n9.employees elogig to chennai \n10.highest employee id\n11.total employee who joined after 1/1/2015 \n12.employee whose desigation is not associate\n13.total employee based on city \n14. employee ased on city and title\n 15.youngest employee\n");
            Console.WriteLine("\nenter your choice\n");
            int op = Convert.ToInt32(Console.ReadLine());
           
            switch (op)
            {
                case 1:
                    AllEmployee();
                    break;
                case 2:
                    NotMumbai();
                    break;
                case 3:
                    Asstmanger();
                    break;
                case 4:
                    LastName();
                    break;
                case 5:
                    DOJbefore();
                    break;
                case 6:
                    DOBafter();
                    break;
                case 7:
                    consultantNassoc();
                    break;
                case 8:
                    TotalEmp();
                    break;
                case 9:
                    TotalEmpChennai();
                    break;
                case 10:
                    MaxID();
                    break;
                case 11:
                    TotalAfter();
                    break;
                case 12:
                    TotalNotAssoc();
                    break;
                case 13:
                    TotalBasedonCity();
                    break;
                case 14:
                    TotalBasedonCityNtitle();
                    break;
                case 15:
                    youngest();
                    break;
                default:
                    Console.WriteLine("Invalid Role/Usertype");

                    break;

            }
            Console.Read();
        }
        static void AllEmployee()
        {


            Console.WriteLine("-----ALL EMPLOYEE--");

            IEnumerable<Employee> emps = from emp in Employee.GetEmployeeData()
                                         select emp;


            //Display the details of all Empoyees
            foreach (Employee e in emps)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e.EmployeeId + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.city);
            }
            Console.Read();
        }

        static void NotMumbai()
        {
            Console.WriteLine("-----EMPLOYEE WHOSE CITY IS NOT MUMBAI-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.city != "Mumbai"
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();
        }
        static void Asstmanger()
        {
            Console.WriteLine("-----EMPLOYEE WHOSE TITLE IS ASSGMANAGER-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.Title.Equals("AsstManager")
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();

        }
        static void LastName()
        {
            Console.WriteLine("-----EMPLOYEE LASTNAME START WITH S-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.LastName.StartsWith("S")
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();

        }
        static void DOJbefore()
        {
            Console.WriteLine("-----EMPLOYEE WHERE DOJ BEFORE 01/01/2015-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.DOJ < Convert.ToDateTime("01/01/2015")
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();

        }
        static void DOBafter()
        {
            Console.WriteLine("-----EMPLOYEE WHERE DOB AFTER 01/01/1990-------- ");
            IEnumerable<Employee> emps1 = from emp1 in Employee.GetEmployeeData()
                                          where emp1.DOB > Convert.ToDateTime("01/01/1990")
                                          select emp1;

            foreach (Employee e1 in emps1)
            {
                Console.WriteLine("Id  FirstName  LastName Title   DOB  DOJ city");
                Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
            }
            Console.Read();

        }
        static void consultantNassoc()
        {
            Console.WriteLine("-----EMPLOYEE WHERE DESIGNATION IS CONSULTANT AND ASSOCIATE -------- ");
            //Employee e1 = Employee.GetEmployeeData().Find(emp => (emp.Title == "Associate"));
            Employee e1 = Employee.GetEmployeeData().Find(emp => (emp.Title == "Consultant"));

            Console.Read();

        }
        static void TotalEmp()
        {

            Console.WriteLine("-----TOTAL EMPLOYEE-------- ");

            var emp = Employee.GetEmployeeData().Count();
            //Using Query Syntax
            var TotalEmp = (from e1 in Employee.GetEmployeeData()
                            select e1).Count();

            Console.WriteLine("Total No of Employees = " + TotalEmp);
            Console.Read();
        }
        static void TotalEmpChennai()
        {

            Console.WriteLine("-----TOTAL EMPLOYEE FOR CHENNAI-------- ");

            var emp = Employee.GetEmployeeData().Count();
            //Using Query Syntax
            var TotalEmp = (from e1 in Employee.GetEmployeeData()
                            where e1.city == "Chennai"
                            select e1).Count();

            Console.WriteLine("Total No of Employees = " + TotalEmp);
            Console.Read();
        }
        static void MaxID()
        {

            Console.WriteLine("----- Highest Employee ID from the List-------- ");

            var emp = Employee.GetEmployeeData().Max(e => e.EmployeeId);
            //Using Query Syntax
            var MaxId = (from e1 in Employee.GetEmployeeData()
                         select e1).Max(e => e.EmployeeId);

            Console.WriteLine(" Highest Employee ID : " + MaxId);
            Console.Read();
        }

        static void TotalAfter()
        {



            var emp = Employee.GetEmployeeData().Count();
            //Using Query Syntax
            var TotalEmpafter = (from e1 in Employee.GetEmployeeData()
                                 where e1.DOJ > Convert.ToDateTime("01/01/2015")
                                 select e1).Count();

            Console.WriteLine("Total No of Employees  Who join After 01/01/2015: " + TotalEmpafter);
            Console.Read();

        }



        static void TotalNotAssoc()
        {



            var emp = Employee.GetEmployeeData().Count();
            //Using Query Syntax
            var TotalEmpafter = (from e1 in Employee.GetEmployeeData()
                                 where e1.Title != "Associate"
                                 select e1).Count();

            Console.WriteLine("Total No of Employees whose designation is not An Associate: " + TotalEmpafter);
            Console.Read();

        }
        static void TotalBasedonCity()
        {


            var GroupByQS = from std in Employee.GetEmployeeData()
                                //First store the data into a group
                            group std by std.city into stdGroup
                            //Then Sorting the data based on key in Descending Order
                            orderby stdGroup.Key descending
                            select new
                            {
                                Key = stdGroup.Key,
                                //Sorting the Students in Each Group based on Name in Ascending order
                                Employees = stdGroup.OrderBy(x => x.FirstName)
                            };
            //It will iterate through each groups
            foreach (var group in GroupByQS)
            {
                Console.WriteLine(group.Key + " : " + group.Employees.Count());

                foreach (var emp in group.Employees)
                {
                    // Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
                    Console.WriteLine("ID" + emp.EmployeeId + ",  FirstName :" + emp.FirstName + ", Lastname: " + emp.LastName + ", Designation :" + emp.Title + ", DOB :" + emp.DOB + ",  DOJ:" + emp.DOJ + ",City:" + emp.city);
                }
            }



            Console.Read();

        }

        static void TotalBasedonCityNtitle()
        {

            Console.WriteLine("-----------------Total Number of Employees based on City And title----------------");
            var GroupBy = from emp in Employee.GetEmployeeData()
                              //First store the data into a group
                          group emp by new
                          {
                              emp.city,
                              emp.Title

                          } into empGrp
                          select new
                          {
                              City = empGrp.Key.city,
                              Title = empGrp.Key.Title,



                              Employees = empGrp.OrderBy(x => x.FirstName)
                          };

            //Then Sorting the data based on key in Descending Order

            //It will iterate through each groups
            foreach (var group in GroupBy)
            {
                Console.WriteLine($"City: {group.City} ,Title : {group.Title} ,No of Employee : {group.Employees.Count()} ");

                foreach (var emp in group.Employees)
                {
                    // Console.WriteLine(e1.EmployeeId + " " + e1.FirstName + " " + e1.LastName + " " + e1.Title + " " + e1.DOB + " " + e1.DOJ + " " + e1.city);
                    Console.WriteLine("ID" + emp.EmployeeId + ",  FirstName :" + emp.FirstName + ", Lastname: " + emp.LastName + ", Designation :" + emp.Title + ", DOB :" + emp.DOB + ",  DOJ:" + emp.DOJ + ",City:" + emp.city);
                }
            }



            Console.Read();

        }

        static void youngest()
        {

            Console.WriteLine("----- Youngest Employee from the List-------- ");

            var emp = Employee.GetEmployeeData().Max(e => e.DOB);
            //Using Query Syntax
            var maxyear = (from e1 in Employee.GetEmployeeData()
                           select e1).Max(e => e.DOB);

            Console.WriteLine(" Youngest Employee ID : " + maxyear);
            Console.Read();
        }

    }
}
