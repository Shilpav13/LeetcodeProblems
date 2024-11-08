public class RandomizedSet {
    private Dictionary<int, int> numMap;
    private List<int> numList;
    private Random random;

    public RandomizedSet() {
        numMap = new Dictionary<int, int>();
        numList = new List<int>();
        random = new Random();
        
    }
    
    public bool Insert(int val) {
        if(numMap.ContainsKey(val))
        {
            return false;
        }
        numMap[val]=numList.Count();
        numList.Add(val);
        return true;
        
    }
    
    public bool Remove(int val) {
        if(!numMap.ContainsKey(val))
        {
            return false;
        }
        int idx = numMap[val];              
        int lastVal = numList[numList.Count - 1];

        numList[idx] = lastVal;             
        numMap[lastVal] = idx;               
        numList.RemoveAt(numList.Count - 1); 
        numMap.Remove(val);                 

        return true;
    }
    
    public int GetRandom() {
        int randomIndex = random.Next(numList.Count);
        return numList[randomIndex];
        
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */