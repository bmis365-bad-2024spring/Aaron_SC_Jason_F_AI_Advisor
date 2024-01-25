class Student {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }
    public string Email { get; set; }

    public List<Class> Classes { get; set; }

    public Dictionary<Class, double> Grades { get; set; }

    public Student(string name, int age, string major, string email) {
        Name = name;
        Age = age;
        Major = major;
        Email = email;
    }
}