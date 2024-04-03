namespace FlightLogNet.Tests.Operation
{
    using System.IO;
    using System.Text;
    using FlightLogNet.Operation;
    using Xunit;

    public class GetExportToCsvOperationTests(GetExportToCsvOperation getExportToCsvOperation)
    {
        [Fact]
        public void Execute_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var expectedCsv = File.ReadAllBytes("export.csv");
            // Act
            var resultCsv = getExportToCsvOperation.Execute();
            // Assert
            Assert.Equal(
                Encoding.UTF8.GetString(expectedCsv),
                Encoding.UTF8.GetString(resultCsv)
                );
        }
    }
}
