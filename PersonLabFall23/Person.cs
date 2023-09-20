using System.Runtime.CompilerServices;

namespace PersonLabFall23
{
    internal class Person
    {
        // Fields
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        //Properties
        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age
        {
            get { return age; }
            set
            {
                // Ensure age is valid
                if (value >= 0 && value <= 122)
                {
                    age = value;
                }
            }
        }

        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        /// <summary>
        /// User-defines constructor for Person
        /// </summary>
        public Person(int personId, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
            FavoriteColor = favoriteColor;
            IsWorking = isWorking;
        }

        /// <summary>
        /// Generates string with current persons info
        /// </summary>
        /// <returns>Formatted string</returns>
        /// 
        public string DisplayPersonInfo()
        {
            string formatted = "";

            formatted += personId + ": " + firstName + " " + lastName + "'s " + "favorite colour is: " + favoriteColor;
            return formatted;
        }

        /// Changes persons favorite color to white
        /// 
        public void ChangeFavoriteColor()
        {
            favoriteColor = "White";
        }

        /// Gets current person age in 10 years
        public int GetAgeInTenYears()
        {
            int ageInTenYears = age + 10;
            return ageInTenYears;
        }

        /// Get Person as human readable string
        /// 
        public override string ToString()
        {
            string formatted = "";

            formatted += "PersonId: " + personId + "\n";
            formatted += "FirstName: " + firstName + "\n";
            formatted += "LastName: " + lastName + "\n";
            formatted += "FavoriteColour: " + favoriteColor + "\n";
            formatted += "Age: " + age + "\n";
            formatted += "IsWorking: " + isWorking;

            return formatted;
        }
    }
}
