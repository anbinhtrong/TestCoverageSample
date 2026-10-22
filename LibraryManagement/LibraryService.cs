namespace LibraryManagement;

public class LibraryService
{
    private const decimal DailyFine = 5000m;

    public decimal CalculateLateFee(int overdueDays)
    {
        if (overdueDays < 0)
        {
            throw new ArgumentException(
                "Overdue days cannot be negative.");
        }

        if (overdueDays == 0)
        {
            return 0;
        }

        return overdueDays * DailyFine;
    }
}
