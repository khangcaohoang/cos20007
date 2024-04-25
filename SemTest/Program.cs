using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemTest
{
    internal class Program
    {
        static void Main()
        {
         
            Sales sales = new Sales();

            
            Batch compSciBooksBatch = new Batch("#2024x00001", "CompSci Books");
            compSciBooksBatch.Add(new Transaction("1", "Deep Learning in Python", 67.90m));
            compSciBooksBatch.Add(new Transaction("2", "C# in Action", 54.10m));
            compSciBooksBatch.Add(new Transaction("3", "Design Patterns", 129.75m));
            sales.Add(compSciBooksBatch);

            Batch fantasyBooksBatch = new Batch("#2024x00002", "Fantasy Books");
            fantasyBooksBatch.Add(new Transaction("00-0001", "Compilers", 134.60m));
            fantasyBooksBatch.Add(new Transaction("10-0003", "Hunger Games 1-3", 45.00m));
            fantasyBooksBatch.Add(new Transaction("15-0020", "Learning Blender", 56.90m));
            sales.Add(fantasyBooksBatch);

            
            Batch nestedBatch = new Batch("#2024x00003", "Nested Batch");
            nestedBatch.Add(new Transaction("100", "Item A", 20.00m));
            nestedBatch.Add(new Transaction("101", "Item B", 30.00m));

            Batch nestedSubBatch = new Batch("#2024x00004", "Sub Batch");
            nestedSubBatch.Add(new Transaction("200", "Sub Item X", 10.00m));
            nestedSubBatch.Add(new Transaction("201", "Sub Item Y", 15.00m));

            nestedBatch.Add(nestedSubBatch);
            sales.Add(nestedBatch);

            
            Batch emptyBatch = new Batch("#2024x00005", "Empty Batch");
            sales.Add(emptyBatch);

            // Print all orders
            sales.PrintOrders();
        }
    }
}

