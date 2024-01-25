public class Professor {
    int id { get; set; }
    string fName { get; set; }
    string lName { get; set; }
    string email { get; set; }
    public List<Class> classes { get; set; }
    public List<Department> departments { get; set; }
}