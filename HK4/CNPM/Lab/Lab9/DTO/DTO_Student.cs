namespace DTO
{
    public class DTO_Student
    {
        private string txtSID, txtPID, IP;
        private int distance;
        private decimal result;

        public string _txtSID
        {
            get
            {
                return txtSID;
            }
            set
            {
                txtSID = value;
            }
        }

        public string _txtPID
        {
            get
            {
                return txtPID;
            }
            set
            {
                txtPID = value;
            }
        }

        public string _IP
        {
            get
            {
                return IP;
            }
            set
            {
                IP = value;
            }
        }

        public int _distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }

        public decimal _result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        public DTO_Student(string txtSID, string txtPID, string IP, int distance, decimal result)
        {
            this.txtSID = txtSID;
            this.txtPID = txtPID;
            this.IP = IP;
            this.distance = distance;
            this.result = result;
        }
    }
}
