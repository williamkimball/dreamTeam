namespace dreamteam

{
    public class Teammate {
        //         Specialty property - This holds the technology that the person enjoys the most.
        public string Speciality { get; set; }
        // FirstName property
        public string FirstName { get; set; }
        // LastName property
        public string LastName { get; set; }
        // FullName property - This property is a readonly property that returns the first and last name concatenated.
        public string FullName () {
            return $"{FirstName}  {LastName}";
        }
        // Work() method - This will write a comical message to the console that describes the work they will do on a group project, based on their speciality.

        public string WorkMessage { get; set; }
        public string Work () {
            return WorkMessage;
        }
    }
}