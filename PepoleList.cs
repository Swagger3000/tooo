﻿

namespace pubes
{
    public class PeopleList
    {
        public static readonly List<People> people = new List<People>
        {
                new People()
                {
                    Id = 1,
                    Name = "Joonas",
                    Age = 33,
                    GenderId = Guid.Parse("dad88543-2ab1-4fa0-822b-b83f6d07753e")
                },
                new People()
                {
                    Id = 2,
                    Name = "Moona",
                    Age = 21,
                    GenderId = Guid.Parse("34b30f10-bdb3-4d01-8115-3b66f6d2373e")
                },
                new People()
                {
                    Id = 3,
                    Name = "Ron",
                    Age = 18,
                    GenderId = Guid.Parse("dad88543-2ab1-4fa0-822b-b83f6d07753e")
                },
                new People()
                {
                    Id = 4,
                    Name = "Anna",
                    Age = 20,
                    GenderId = Guid.Parse("34b30f10-bdb3-4d01-8115-3b66f6d2373e")
                },
                new People()
                {
                    Id = 5,
                    Name = "Mari",
                    Age = 17,
                    GenderId = Guid.Parse("34b30f10-bdb3-4d01-8115-3b66f6d2373e")
                },
                new People()
                {
                    Id = 6,
                    Name = "Bill",
                    Age = 15,
                    GenderId = Guid.Parse("dad88543-2ab1-4fa0-822b-b83f6d07753e")
                },
                new People()
                {
                    Id = 7,
                    Name = "Jumbo",
                    Age = 21,
                    GenderId = Guid.Parse("dad88543-2ab1-4fa0-822b-b83f6d07753e")
                }
        };
    }
}
