using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Assignment1.Models
{
   
    [Table("FootballLeague")]
    public class FootBallLeague
    {
        [Key]
        [Required]
        public int MatchId { get; set; }

        [Required]
        public string TeamName1 { get; set; }

        [Required]
        public string TeamName2 { get; set; }

        [Required]
        public string MatchStatus { get; set; }

        public string WinningTeam { get; set; }

        [Required]
        public int Points { get; set; }
    }
         
 }