public class Department {
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public List<Class> classes { get; set; }
    List<Professor> professors { get; set; }

    public Department(string name, string description) {
        this.name = name;
        this.description = description;
    }
}