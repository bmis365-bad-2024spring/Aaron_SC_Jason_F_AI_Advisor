class Class {
    int crn { get; set; }
    string cNum { get; set; }
    string name { get; set; }
    string description { get; set; }
    int credits { get; set; }
    List<string> meetingDays { get; set; } // M, T, W, R, F
    List<Class> prereqs { get; set; }
    DateTime startTime { get; set; }
    DateTime endTime { get; set; }
    Department department { get; set; }

}