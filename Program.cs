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
                vertices.Add(new Vertex(size));
                vertices[i].Description = Console.ReadLine(); 
            }

            string line = Console.ReadLine();
            while(line != null)
            {
                string[] array = line.Split(' ');
                int token1 = int.Parse(array[0]);
                int token2 = int.Parse(array[1]);
                vertices[token1].AddNeighbour(vertices[token2]);
                vertices[token2].Incoming++;

                line = Console.ReadLine();
            }

            List<Vertex> startList = new List<Vertex>();
            List<Vertex> sortedList = new List<Vertex>();

            foreach(Vertex v in vertices)
            {
                if(v.Incoming == 0)
                {
                    startList.Add(v);
                }
            }

            while(startList.Count > 0)
            {
                Vertex temp = startList[0];
                startList.RemoveAt(0);
                sortedList.Add(temp);

                foreach(var aj in temp.adj)
                {
                    aj.Incoming--;
                    if(aj.Incoming == 0)
                    {
                        startList.Add(aj);
                    }
                }
            }
            foreach(var s1 in sortedList)
            {
                Console.WriteLine(s1.Description);
            }
            Console.ReadLine();
        }
    }
}
