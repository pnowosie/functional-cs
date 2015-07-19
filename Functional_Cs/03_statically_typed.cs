using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Cs
{
    // POCO example
    public class Person
    {
        public int PersonId { get; set; }         //?

        public string FirstName { get; set; }
        
        // other props ...

    }

    class Example
    {
        public Example(IRepository<Person> peopleRepository, int bookId)
        {
            var me = peopleRepository.Get(
                (int)( Math.Pow( Math.E, Math.PI ) )
                // what's wrong? I'm supposed to pass an int, right?
                );

            var eventuallySomeoneElse = peopleRepository.Get(
                bookId
                // As above, int is an int
                );  
        }

        public interface IRepository<T>
        {
            Person Get(int id);
        }

    }

    public interface IntIdentity
    {
        int Id { get; }
    }

    public class BookIdentity : IntIdentity
    {
        public int Id
        {
            get;
            private set;
        }

        public BookIdentity(int id)
        {
            Id = id;
        }
    }

    public class Book
    {
        public BookIdentity BookId { get; set; }

        public string Title { get; set; }
        // ... other
    }
}
