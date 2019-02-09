using System.Collections.Generic;

namespace MoviesRentalStore.Models
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}
