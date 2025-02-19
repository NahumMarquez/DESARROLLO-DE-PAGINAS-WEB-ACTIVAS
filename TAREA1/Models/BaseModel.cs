namespace TAREA1.Models
{
    public class BaseModel
    {
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } 
        public string? EditedBy { get; set; }
        public DateTime? Edited { get; set; }
    }
}