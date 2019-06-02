using System;
using Xunit;
using UCHProject;

namespace UCHProject.Tests
{
    public class PatientTests
    {
        [Fact]    
        public void Create_Patient_Should_Create_Patients_for_employees_to_interact_with()
        {
            //arrange
            Hospital sut = new Hospital("Univeristy Circle Hospital");
            //act
            sut.CreatePatients();
            //assert
            Assert.Equal(2, sut.PatientNumber);





        }


        
        }



    }
}
