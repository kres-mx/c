namespace University.Data_Model
{
    public class HeadOfDepartment : Lecturer
    {
        // Additional properties specific to Head of Department
        // You can add properties related to the head of department here

        public HeadOfDepartment(string id, string name, int age, string phoneNumber, string email, string track, string specialization, int totalGrade, int currentGrade)
            : base(id, name, phoneNumber, email, track, specialization, totalGrade, currentGrade)
        {
            // Initialize additional properties for Head of Department
        }

        // Additional methods specific to Head of Department
        // You can add methods related to the head of department here
    }
}
