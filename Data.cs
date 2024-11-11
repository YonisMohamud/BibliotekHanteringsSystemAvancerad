using System.Collections.Generic;

namespace BibliotekHanteringsSystemAvancerad

{
    public class Data
    {
        public List<Bok> Böcker { get; set; }
        public List<Författare> Författarlista { get; set; }

        public Data()
        {
            Böcker = new List<Bok>();
            Författarlista = new List<Författare>();
        }
    }
}

