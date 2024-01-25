public class Class {
    public int crn { get; set; }
    public string cNum { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int credits { get; set; }
    public int classSize { get; set; }
    public bool isOnline { get; set; }
    public List<string> meetingDays { get; set; } // M, T, W, R, F
    public List<Class> prereqs { get; set; }
    public DateTime startTime { get; set; }
    public DateTime endTime { get; set; }
    Department department { get; set; }

    public Class(int crn, string cNum, string name, string description, int credits, int classSize, bool isOnline, List<string> meetingDays, List<Class> prereqs, DateTime startTime, DateTime endTime, Department department) {
        this.crn = crn;
        this.cNum = cNum;
        this.name = name;
        this.description = description;
        this.credits = credits;
        this.classSize = classSize;
        this.isOnline = isOnline;
        this.meetingDays = meetingDays;
        this.prereqs = prereqs;
        this.startTime = startTime;
        this.endTime = endTime;
        this.department = department;
    }

}