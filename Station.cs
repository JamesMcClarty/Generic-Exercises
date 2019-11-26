using System.Collections.Generic;

namespace generics{

    public class Station<T>
    {
        int capacity{get; set;}

        public virtual void refuel (List<T> vehicles){
            
        }
    }
}