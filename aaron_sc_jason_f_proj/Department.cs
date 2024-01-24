class Department {
    int id { get; set; }
    string name { get; set; }
    string description { get; set; }
    List<Class> classes { get; set; }
    List<Professor> professors { get; set; }
}