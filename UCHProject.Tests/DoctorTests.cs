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
            string name = "john smith";
            int employeeNumber = 001;
            string specialty = "Neuro";

            //act
            Doctor sut = new Doctor(name, employeeNumber, specialty);

            //assert
            Assert.Equal("john smith", sut.Name);
            Assert.Equal(001, sut.EmployeeNumber);
            Assert.Equal("Doctor", sut.EmployeeType);
            Assert.Equal(90000, sut.Salary);
            Assert.False(sut.BeenPaid);
            Assert.Equal("Neuro", sut.Specialty);

        }


    }
}
