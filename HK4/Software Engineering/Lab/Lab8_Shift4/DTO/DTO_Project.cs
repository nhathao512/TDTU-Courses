namespace DTO
{
    public class DTO_Project
    {
        private string PID, PName, Supervisor;
        private int Funding;

        public string _PID
        {
            get
            {
                return PID;
            }
            set
            {
                PID = value;
            }
        }

        public string _PNAME
        {
            get
            {
                return PName;
            }
            set
            {
                PName = value;
            }
        }

        public string _SUPERVISOR
        {
            get
            {
                return Supervisor;
            }
            set
            {
                Supervisor = value;
            }
        }

        public int _FUNDING
        {
            get
            {
                return Funding;
            }
            set
            {
                Funding = value;
            }
        }

        public DTO_Project(string PID, string PName, string Supervisor, int fun)
        {
            this.PID = PID;
            this.PName = PName;
            this.Supervisor = Supervisor;
            this.Funding = fun;
        }
    }
}
