namespace MvcTodoApp.Models
{
    // <summary> 
    // يمثل نموذج مهمة في التطبيق
    // </summary>
    public class TaskItem
    {
        public int Id { get; set; }
        //ملاحظة:قمت بتعديل هذه التعليمة لأني أستخدم .net 6
        public string Title { get; set; } = string.Empty;
        public bool IsComplete { get; set; }
    }
}