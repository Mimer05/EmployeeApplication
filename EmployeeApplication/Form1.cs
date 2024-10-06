using EmployeeNamespace;
namespace EmployeeApplication
{
    public partial class FrmEmployeeDataBase : Form
    {
        public FrmEmployeeDataBase()
        {
            InitializeComponent();
        }

        private void FrmEmployeeDataBase_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //userinput into submit
            long ID = Convert.ToInt64(TBEmployeeID.Text);
            string FirstName = TBFirstName.Text;
            string LastName = TBLastName.Text;
            string Position = TBPosition.Text;

            //the object which got in other namespace and class
            Employee employee = new Employee(ID, FirstName, LastName, Position);

            ListViewItem item = new ListViewItem(TBEmployeeID.Text);
            item.SubItems.Add(TBFirstName.Text);
           item.SubItems.Add(TBLastName.Text);
            item.SubItems.Add(TBPosition.Text);
            listView.Items.Add(item);
           
            //clear when next click submit
            TBEmployeeID.Clear();
            TBFirstName.Clear();
            TBLastName.Clear();
            TBPosition.Clear();



        }
    }
}
//another namespace
namespace EmployeeNamespace
{
    public class Employee
    {//private fields
        private long ID;
        private string FirstName;
        private string LastName;
        private string Position;

        //overloaded constructors
        public Employee(long iD, string firstName, string lastName, string position)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
        }
        public Employee(string firstName, string lastName, string position)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
        }
        //getter and setter for private fields
        public long EmployeeID
        {
            get
            {
                return this.ID;
            }
            set
            {
                this.ID = value;
            }
        }
        public string EmployeeFirstName
        {
            get
            {
                return this.FirstName;
            }
            set
            {
                this.FirstName = value;
            }
        }
        public string EmployeeLastName
        {
            get
            {
                return this.LastName;
            }
            set
            {
                this.LastName = value;
            }
        }
        public string EmployeePosition
        {
            get
            {
                return this.Position;
            }
            set
            {
                this.Position = value;
            }
        }
    }

    }


