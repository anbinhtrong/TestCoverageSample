namespace LibraryManagement.Tests;

public class LibraryServiceTests
{
    [Fact]
    public void CalculateLateFee_WhenReturnedOnTime_ReturnsZero()
    {
        var service = new LibraryService();

        var result = service.CalculateLateFee(0);

        Assert.Equal(0m, result);
    }

    [Fact]
    public void CalculateLateFee_WhenOverdue_ReturnsExpectedFee()
    {
        var service = new LibraryService();

        var result = service.CalculateLateFee(3);

        Assert.Equal(15000m, result);
    }

    [Fact]
    public void CalculateLateFee_WhenDaysAreNegative_ThrowsException()
    {
        var service = new LibraryService();

        Assert.Throws<ArgumentException>(
            () => service.CalculateLateFee(-1));
    }
}