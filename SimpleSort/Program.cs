using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


class Program {
    static void Main(string[] args) {
        int[] array = {2,4,8,5,465,678,9,345,234,234,467,78,3,2,4,6,7,89,-10,0};

        Sort.simpleSort(array);
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine("Test OK!");
        Thread.Sleep(5000);
    }

}

