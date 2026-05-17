using System;

namespace demochka
{
    public static class CurrentUser
    {
        public static string Login { get; set; } = "";
        public static string Role { get; set; } = "";
        public static string FirstName { get; set; } = "";
        public static string LastName { get; set; } = "";
        public static string Patronymic { get; set; } = "";

        public static string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(LastName) && string.IsNullOrEmpty(FirstName))
                    return "Гость";

                string fullName = LastName + " " + FirstName;
                if (!string.IsNullOrEmpty(Patronymic))
                    fullName += " " + Patronymic;

                return fullName.Trim();
            }
        }

        public static bool IsAuthenticated
        {
            get { return Login != "" && Role != "Гость"; }
        }
    }
}