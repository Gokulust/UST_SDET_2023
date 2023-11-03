using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TaskItem
    {
        public int TaskId { get; set; }
        public string TaskDescription {  get; set; }
        public bool IsCompleted { get; set; }

        public static List<TaskItem>TaskItemList = new List<TaskItem>();

        public TaskItem(int taskId, string taskDescription, bool isCompleted)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
        }

        public static void AddTask(TaskItem item)
        {
            TaskItemList.Add(item);
        }
        public static void RemoveTask(TaskItem item)
        {
            TaskItemList.Remove(item);
        }
        public static void UpdateTask(int taskId)
        {
            var task = TaskItemList.Find(x => x.TaskId == taskId);
            if (task != null)
            {
                task.IsCompleted = true;
            }

        }
        public static void Display()
        {
            foreach (var item in TaskItemList)
            {
                Console.WriteLine("Task Id: {0} Task Description : {1} IsCompleted :{2}",item.TaskId,item.TaskDescription,item.IsCompleted);
            }
        }
    }
}
