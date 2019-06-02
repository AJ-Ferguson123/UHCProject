using System;
using Xunit;
using UCHProject;

namespace UCHProject.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void Doctor_constructor_should_Use_employee_base_constructor_and_then_overwrite_via_class_constructor()
        {
            //arange
            string name = "johnsmith";
            int employeeNumber = 001;
            string specialty = "Neuro";

            //act
            Doctor sut = new Doctor(name, employeeNumber, specialty);

            //assert
            Assert.Equal(000, sut.EmployeeNumber);
            //Assert.Equal("Fail", sut.EmployeeType);
            //Assert.Equal(0, sut.Salary);
            //Assert.True(sut.BeenPaid);
            //Assert.Equal("fail", sut.Specialty);
            //Assert.Equal("johnsmith", sut.Name);

        }


    }
}
