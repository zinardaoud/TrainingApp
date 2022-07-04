using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Models
{
    internal class Match
    {
        [Key]
        public int MatchId { get; set; }
        [Required]
        public string Field { get; set; }
        [Required]
        public DateTime SessionDate { get; set; }
        [Required]
        public string SessionStart { get; set; }
        [Required]
        public string SessionEnd { get; set; }

    }
}
