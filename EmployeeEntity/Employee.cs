using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity
{
    public enum Gender
    {
        Male,
        Female
    }
    public enum Designation
    {
        HR,
        Scheduler,
        CEO,
        Reviewer,
        Reviewee,
        Tester,
        Developer
    }

    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string id { get; set; }
        public string emailId { get; set; }
        public Gender gender { get; set; }
        public long mobileNumber { get; set; }
        public DateTime dob { get; set; }
        public DateTime doj { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public Designation designation { get; set; }    
    }
}
