using PluralSightTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PluralSightTestTest
{
    public class FilePRocessTest
    {

        [Fact]
        public void FileExistIsNameIsNullOrEmpty()
        {
            //Arrange
            var fileProcess = new FileProcess();

            //ACT
            bool result = fileProcess.FileExists(string.Empty);

            //ASSERT
            Assert.False(result);
        }
        [Fact]
        public void FileExistIsNameIsNotNullOrEmpty()
        {
            var fileProcess = new FileProcess();

            //ACT
            bool result = fileProcess.FileExists("batatinha.txt");

            //ASSERT
            Assert.True(result);
        }
    }
}
