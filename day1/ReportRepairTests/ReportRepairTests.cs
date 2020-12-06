using System;
using Xunit;
using ReportRepair;
using System.Linq;

namespace ReportRepairTests
{
    public class EntriesFinderTests
    {
        [Fact]
        public void Empty_result_for_an_empty_entry_list()
        {
            //Arrange
            var sut = new EntriesFinder();
            
            //Act
            var result = sut.GetEntriesThatSum2020(new int[0]);

            //Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Empty_result_for_an_entry_list_with_a_single_number()
        {
            //Arrange
            var sut = new EntriesFinder();
            
            //Act
            var result = sut.GetEntriesThatSum2020(new int[]{1});

            //Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Sum_of_result_is_2020_for_an_entry_list_with_two_numbers_that_sum_2020()
        {
            //Arrange
            var sut = new EntriesFinder();
            
            //Act
            var result = sut.GetEntriesThatSum2020(new int[]{2020,0});

            //Assert
            Assert.Equal(2020,result.Sum());
        }

        [Fact]
        public void Sum_of_result_is_2020_for_an_entry_list_with_two_members_that_sum_2020()
        {
            //Arrange
            var sut = new EntriesFinder();
            
            //Act
            var result = sut.GetEntriesThatSum2020(new int[]{878,19,10,29,22,100,90,1142,100});

            //Assert
            Assert.Equal(2020,result.Sum());
        }


    }
}
