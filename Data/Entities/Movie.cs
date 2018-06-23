using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RuntimeInMinutes { get; set; }
        public decimal BudgetInMilions { get; set; }
        public decimal BoxOfficeRevenueInMilions { get; set; }
        public string AcademyAwardNominations { get; set; }
        public string AcademyAwardWins { get; set; }
        public decimal RottenTomatoesScore { get; set; }
    }
}
