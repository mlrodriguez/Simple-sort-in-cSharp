using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class Sort {
    public static void simpleSort(int[] array) {
        for (int i = 0; i < array.Length-1; i++) {
            for (int j = i + 1; j < array.Length; j++) {
                if (array[j] < array[i]) {
                    int aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                }

            }           
        }
    }

    
}

