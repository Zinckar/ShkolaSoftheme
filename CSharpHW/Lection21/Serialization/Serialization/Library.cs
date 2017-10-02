using System.Collections;


namespace Serialization
{
    class Library : IEnumerable
    {
        readonly Book[] _books;

        public Library()
        {
            _books = new[] { new Book("Book1"), new Book("Book2"), new Book("Book3") };
        }

        public int Length
        {
            get { return _books.Length; }
        }

        public Book this[int index]
        {
            get
            {
                return _books[index];
            }
            set
            {
                _books[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _books.GetEnumerator();
        }
    }
}