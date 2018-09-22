using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker

{
    class AesTable : TableLayoutPanel
    {
        public float rowHeight { get; set; } = 50f;
        private List<GroupBox> boxlist = new List<GroupBox>();
        private Task currentTask;
        public List<string> namelist = new List<string>();
        public Form1 currentform {
            get { return GetParentForm(this.Parent); }
        }
        public void ClearList()
        {
            boxlist.Clear();
            this.Controls.Clear();
        }
        private Form1 GetParentForm(Control parent)
        {
            Form1 form = parent as Form1;
            if (form != null)
                return form;
            if (parent != null)
                return GetParentForm(parent.Parent);
            return null;
        }
        public AesTable()
        {
            this.AutoScroll = true;
            this.VerticalScroll.Visible = true;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.RowCount = 1;
            this.ColumnCount = 1;
            this.Anchor = AnchorStyles.Top;
        }
        public void CreateNewSet(string setname)
        {
            namelist.Add(setname);
            GroupBox b = new GroupBox() {
                Text = string.Empty,
                Margin = new Padding(10,0,10,0)
                
            };
            b.Click += new EventHandler(GClick);
            b.Controls.Add(new Label() {
                Name = "Task",
                Text = setname,
                Location = new Point(5, 20),
                //Size = new Size(b.Size.Width-30, 20),
                MaximumSize = new Size(b.Size.Width, b.Size.Height),
                MinimumSize = new Size(b.Size.Width - 65, 0),
                Enabled = false,
                AutoSize = false,
                AutoEllipsis = true,
                //BackColor = Color.Transparent,
                ForeColor = Color.Black
            });
            b.Size = new Size(this.Parent.Width, (int)this.rowHeight); 
            this.RowCount += 1;
            this.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
            this.Controls.Add(b, 1, this.RowCount - 1);
            boxlist.Add(b);
            //this.Controls.Add(new Label() { Text = setname }, 1, this.RowCount-1);
        }
        public void GClick(object sender, EventArgs e)
        {
            //Console.WriteLine(currentform.Name);
            //Create new form2 template
            Form2 f2 = new Form2();
            //Set form2's parent form variable to form1
            f2.currentform = currentform;
            //Cast sender as GroupBox object
            var test = (GroupBox)sender;
            //Search embedded label control in GroupBox
            var labelname = test.Controls.Find("Task", true)[0];
            //Get index of GroupBox object in boxlist
            var id = boxlist.IndexOf(test);
            //Set f2's id to searched index
            f2.id = id;
            //Set form2's id label control to id
            f2.l_id.Text = id.ToString();
            //Console.WriteLine(sender.ToString());
            //Set form2's name label to Groupbox's label name
            f2.l_name.Text = labelname.Text;
            //Call form1's NameSet to append to the list of task
            //currentform.NameSet(id, labelname.Text);
            currentTask = new Task(id, labelname.Text, string.Empty, 0);
            f2.currentTask = currentTask;
            //Show form2
            f2.ShowDialog();


        }
    }
}
