using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_WPF.Data_Layer
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskPriority { get; set; }
        public DateTime TaskEndDate { get; set; }

        public override string ToString()
        {
            return TaskTitle + @"{TaskTitle}";
        }
    }
}