using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topolgical_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("rsg.txt");
            Console.SetIn(reader);
            int size = Convert.ToInt32(Console.ReadLine());
            List<Vertex> vertices = new List<Vertex>();
 
            for(int i = 0; i < size; i++)
            {
                vertices.Add(new Vertex(i));
            }

            string line = Console.ReadLine();
            while(line != null)
            {
                string[] array = line.Split(' ');
                int token1 = int.Parse(array[0]);
                int token2 = int.Parse(array[1]);
                vertices[token1].AddNeighbour(vertices[token2]);
                line = Console.ReadLine();
            }

            foreach(Vertex v in vertices)
            {
                Console.WriteLine(v.Description);
            }
            Console.ReadLine();
        }
    }
}
