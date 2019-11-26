using System.Collections.Generic;

namespace generics{

    public interface IStation<T>
    {
        int capacity{get; set;}

        void refuel(List<T> vehicles);
    }
}