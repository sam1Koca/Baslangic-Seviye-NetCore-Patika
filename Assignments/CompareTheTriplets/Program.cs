using System;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            int alice = 0, bob = 0;
            for(int i = 0; i < a.Count; i++){
            
            if(a[i] > b[i]){
                alice++;
            }
            
            else if(b[i] > a[i]){
                bob++;
                }
            }
            result.Add(alice);
            result.Add(bob);
            return result;
        }
    }
}
