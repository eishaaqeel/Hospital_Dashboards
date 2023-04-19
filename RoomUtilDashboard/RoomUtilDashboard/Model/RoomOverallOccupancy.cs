namespace RoomUtilDashboard
{
    public class RoomOverallOccupancy
    {
        public string Location {get; set;}
        public string Type {get; set;}
        public string? PatientNo {get; set;}
        public string? PatientName {get; set;}
        public string? DateAdmitted {get; set;}

        public RoomOverallOccupancy(string location, string type, string? pno, string? pname, string? date)
        {
            this.Location = location;
            this.Type = type;
            this.PatientNo = pno;
            this.PatientName = pname;
            this.DateAdmitted = date;
        }
    }
}