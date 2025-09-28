using System.ComponentModel.DataAnnotations;


namespace ProjectApp.Models
{
    public class Activity
    {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        // REQUIRED FK — each activity has exactly one worker
        [Required]
        [Display(Name = "Assigned To")]
        public int AssignedToId { get; set; }

        [Display(Name = "Assigned To")]
        public Worker AssignedTo { get; set; }

    }
}
