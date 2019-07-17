using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topolgical_Algorithm
{
    class Vertex : IComparable<Vertex>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Incoming { get; set; }
        List<Vertex> adj = new List<Vertex>();

        public Vertex(int id)
        {
            this.Id = id;
        }

        public void AddNeighbour(Vertex v)
        {
            adj.Add(v);
        }

        public override string ToString()
        {
            adj.Sort();
            string s = "";
            foreach(Vertex v in adj)
            {
                s += string.Format("{0}", v.Description);
            }
            return s;
        }

        public int CompareTo(Vertex other)
        {
           return Id.CompareTo(other.Id);
        }
    }
}
