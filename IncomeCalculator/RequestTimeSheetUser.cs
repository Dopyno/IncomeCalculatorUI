namespace IncomeCalculator
{
    public static class RequestTimeSheetUser
    {
        public static int AppleTimeSheetCalculator(int hourWorked)
        {
            int result;
            result = hourWorked * 150;
            return result;
        }
        public static int SamsungTimeSheetCalculator( int hourWorked)
        {
            int result;
            result = hourWorked * 125;
            return result;
        }
    }
}
