using System;
using Xunit;
using UCHProject

namespace UCHProject.Tests
{
    class DoctorTests
    {
        [Fact]
        public void Doctor_constructor_should_Use_employee_base_constructor_and_then_overwrite_via_class_constructor()
        {
            //arange

            //act

            //assert
            Assert.Equal("Fail", EmployeeType);

        }


    }
}
