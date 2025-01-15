using System.Collections;

internal class DaysInMonthCollection : IEnumerable<MonthWithDays>
{
    public IEnumerator<MonthWithDays> GetEnumerator()
    {
        return new DaysInMonthEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
