namespace TaskTracker
{
    public class Task
    {
        public int id;
        public string taskname;
        public string description;
        public float seconds;
        public float elapsed;
        public Task(int id, string taskname, string description, float seconds)
        {
            this.id = id;
            this.taskname = taskname;
            this.description = description;
            this.seconds = seconds;
        }
        public override string ToString()
        {
            return taskname;
        }
    }
}
