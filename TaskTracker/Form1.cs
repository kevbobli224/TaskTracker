using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool moving;
        Point offset;
        Point original;
        public List<Task> tasklist = new List<Task>();
        private List<Task> completed = new List<Task>();
        public Task currentTask;
        private int totalSeconds;

        public void AddTask(Task atask)
        {
            if (tasklist.Count() == 0)
            {
                tasklist.Add(atask);
            }
            else
            {
                var toappend = true;
                foreach (var task in tasklist)
                {
                    if (task.id == atask.id)
                    {
                        task.description = atask.description;
                        task.seconds = atask.seconds;
                        toappend = false;
                        //Console.WriteLine("not added");
                        break;
                    }
                }
                if (toappend)
                {
                    tasklist.Add(atask);
                    //Console.WriteLine("added");
                }
            }
            listBox1.Items.Clear();
            foreach (var ctask in tasklist)
            {
                listBox1.Items.Add(ctask);
            }
            //listBox1.Items.Add(atask);
            RefreshList();
        }

        void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            panel1.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        void Panel1_Mousemove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            panel1.Capture = false;
        }

        void Xbutton(object s, MouseEventArgs e)
        {
            this.Close();
        }

        void Minimizebutton(object s, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aesButtonClass4_Click(object sender, EventArgs e)
        {
            if (aesTextField1.Text != string.Empty && !aesTable1.namelist.Contains(aesTextField1.Text))
            {
                aesTable1.CreateNewSet(aesTextField1.Text);
            }
        }

        private void listboxDoubleClick(object sender, EventArgs e)
        {
            var selectbox = (ListBox)sender;
            if (selectbox.SelectedItem != null)
            {
                Task selected = (Task)selectbox.SelectedItem;
                currentTask = selected;
                l_task.Text = selected.taskname;
                l_des.Text = selected.description;
                UpdateTimeLabels(selected.seconds);
                //Console.WriteLine("gg");
            }
        }
        private void listbox2DoubleClick(object sender, EventArgs e)
        {
            var selectbox = (ListBox)sender;
            if (selectbox.SelectedItem != null)
            {
                Task selected = (Task)selectbox.SelectedItem;
                AddTask(selected);
                selectbox.Items.Remove(selectbox.SelectedItem);
                RefreshList();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Task task in listBox2.Items)
            {
                AddTask(task);
            }
            listBox2.Items.Clear();
        }
        public bool timerstate = false;
        private void aesButtonClass3_Click(object sender, EventArgs e)
        {
            if (currentTask != null)
            {
                if (!timerstate)
                {
                    timer1.Start();

                    timerstate = true;
                    aesButtonClass3.Styles = FStyles.Pause;
                    aesButtonClass3.Invalidate();
                }
                else
                {
                    timer1.Stop();

                    timerstate = false;
                    aesButtonClass3.Styles = FStyles.Play;
                    aesButtonClass3.Invalidate();
                }
            }
        }
        void UpdateTimeLabels(float sec, float elapsed = 0)
        {
            if (currentTask != null)
            {
                var seconds = sec - elapsed;
                var hours = (int)seconds / (60 * 60);
                var minutes = ((int)seconds - (hours * 3600)) / 60;
                var remain = (int)seconds - (hours * 3600) - (minutes * 60);
                l_hour.Text = hours.ToString();
                l_min.Text = minutes.ToString();
                l_sec.Text = remain.ToString();
            }
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentTask != null)
            {
                currentTask.elapsed += 1;
                UpdateTimeLabels(currentTask.seconds, currentTask.elapsed);
                //Console.WriteLine((currentTask.elapsed / currentTask.seconds) * 100);
                var value = (int)((currentTask.elapsed / currentTask.seconds) * 100);
                if (value < progressBar1.Maximum)
                    progressBar1.Value = value;
                else
                {
                    aesButtonClass3.PerformClick();
                    currentTask.elapsed = 0;
                    UpdateTimeLabels(currentTask.seconds, currentTask.elapsed);
                    progressBar1.Value = 0;
                    listBox2.Items.Add(currentTask);
                    tasklist.Remove(currentTask);
                    completed.Add(currentTask);
                    RefreshList();
                }
            }
        }
        private string lastDirectory;
        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            if (lastDirectory == null)
                dialog.InitialDirectory = "C:\\Users";
            else
            {
                dialog.InitialDirectory = lastDirectory;
            }
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lastDirectory = dialog.FileName;
                using (StreamWriter file = File.CreateText(Path.Combine(dialog.FileName, textBox1.Text + ".json")))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, tasklist);
                }
                using (StreamWriter file = File.CreateText(Path.Combine(dialog.FileName, textBox1.Text + "_c.json")))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, completed);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Filters.Add(new CommonFileDialogFilter("Json files", "*.json"));
            if (lastDirectory == null)
                dialog.InitialDirectory = "C:\\Users";
            else
            {
                dialog.InitialDirectory = lastDirectory;
            }
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lastDirectory = dialog.FileName;
                //Console.WriteLine(dialog.FileName);
                using (StreamReader file = File.OpenText(dialog.FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    List<Task> tasks = (List<Task>)serializer.Deserialize((file), typeof(List<Task>));
                    tasklist = tasks;
                }
            }
            RefreshList();
            aesTable1.ClearList();
            foreach (var task in tasklist)
            {
                aesTable1.CreateNewSet(task.taskname);

            }
        }
        void RefreshList()
        {
            listBox1.Items.Clear();
            totalSeconds = 0;
            foreach (Task t in tasklist)
            {
                listBox1.Items.Add(t);
                totalSeconds += (int)t.seconds;
            }
        }
    }
}
