namespace IncomeCalculator
{
    public class UserInfo
    {
        public string IdBadge { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"Welcome {FirstName.ToUpper()} {LastName.ToUpper()}\n Id badge: {IdBadge.ToUpper()}"; }
        }
    }
}
