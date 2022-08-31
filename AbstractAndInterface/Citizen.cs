using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    internal class Citizen : IPerson , IIdentifiable , IBirthable
    {
        public string Name{get;set;}
        public int Age { get;set; }
        public string Id { get;set; }
        public string id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Birthdate { get;set; }

        public string Birthable => throw new NotImplementedException();
    }

    internal interface IPerson
    {
    }
}
