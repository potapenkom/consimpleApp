using consimpleApp.Models;
using System;
using System.Collections.Generic;

namespace consimpleApp.View
{
    public static class DisplayTable
    {

        public static void Display(string columnA, string columnB, IEnumerable<dynamic> list)
        {
            Table table = new Table();
            table.SetHeaders(columnA, columnB);
            foreach (var product in list)
            {
                table.AddRow(product.Name, product.Category);
            }

            Console.WriteLine(table.ToString());
        }
    }
}
