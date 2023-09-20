using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLabFall23
{
    /// <summary>
    /// Represents relation between 2 persons
    /// </summary>
    internal class Relation
    {
        // Fields
        private string person1Relation;
        private Person person1;

        private string person2Relation;
        private Person person2;

        //Properties
        public string Person1Relation { get { return person1Relation; } }
        public string Person2Relation { get { return person2Relation; } }

        public Person Person1 { get { return person1; } }
        public Person Person2 { get { return person2; } }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="person1Relation">Relation of person 1</param>
        /// <param name="person1">First Person instance</param>
        /// <param name="person2Relation">Relation of person 2</param>
        /// <param name="person2">Second Person instance</param>
        public Relation (string person1Relation, Person person1, string person2Relation, Person person2)
        {
            this.person1Relation = person1Relation;
            this.person1 = person1;
            this.person2Relation = person2Relation;
            this.person2 = person2;
        }

        /// <summary>
        /// Gets string with information on relation between persons
        /// </summary>
        /// <returns>Formatted string</returns>
        public override string ToString ()
        {
            string formatted;
            formatted = "Relationship between " + person1.FirstName + " and " + person2.FirstName + " is: " + Person1Relation;

            return formatted;
        }
    }
}
