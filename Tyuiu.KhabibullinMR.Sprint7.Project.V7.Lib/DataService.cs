namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public int NumP {  get; set; }
        public int NumK { get; set; }
        public int TotalArea { get; set; }
        public int UsableArea {  get; set; }
        public int NumberOfRooms { get; set; }
        public string Surname { get; set; }
        public string TimeReg { get; set; }
        public int NumOfFamMem { get; set; }
        public int NumOfKids { get; set; }
        public bool Arreas { get; set; }
        public string Note { get; set; }
        public DataService() { }

        public DataService(int numP, int numK, int totalArea, int usableArea, int numberOfRooms, string surname, string timeReg, int numOfFamMem, int numOfKids, bool arreas, string note)
        {
            NumP = numP;
            NumK = numK;
            TotalArea = totalArea;
            UsableArea = usableArea;
            NumberOfRooms = numberOfRooms;
            Surname = surname;
            TimeReg = timeReg;
            NumOfFamMem = numOfFamMem;
            NumOfKids = numOfKids;
            Arreas = arreas;
            Note = note;
        }
    }
}
