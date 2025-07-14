namespace LeaveManagement.web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } //primary key 
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
