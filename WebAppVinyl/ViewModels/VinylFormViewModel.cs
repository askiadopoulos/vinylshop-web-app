using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVinyl.Models;

namespace WebAppVinyl.ViewModels
{
    public class VinylFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Artist { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseYear { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        [Required]
        public byte Label { get; set; }

        public IEnumerable<Label> Labels { get; set; }

        public VinylFormViewModel()
        {
            Id = 0;
        }
    }
}