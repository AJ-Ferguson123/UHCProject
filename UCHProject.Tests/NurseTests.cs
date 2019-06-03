using System;
using Xunit;
using UCHProject;

namespace UCHProject.Tests
{
    public class NurseTests
    {
        [Fact]
        public void Nurse_constructor_should_Use_employee_base_constructor_and_then_overwrite_via_class_constructor()
        {
            //arange
            Hospital hospital = new Hospital("Univeristy Clinic Hospital");
            string name = "jonna smith";
            int employeeNumber = 001;
            int numberOfPatients = 5;
            

            
            //act
            Nurse sut = new Nurse(name, employeeNumber, numberOfPatients, hospital);

            //assert
            Assert.Equal("jonna smith", sut.Name);
            Assert.Equal(001, sut.EmployeeNumber);
            Assert.Equal("Nurse", sut.EmployeeType);
            Assert.Equal(50000, sut.Salary);
            Assert.False(sut.BeenPaid);
            Assert.Equal(5, sut.NumberOfPatients);

        }

    }
}
