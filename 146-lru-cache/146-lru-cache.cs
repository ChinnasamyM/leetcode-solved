public class LRUCache {
    
    private int capacity;    
    private class cacheItem{
        public int Key{get; set;}
        public int Value{get; set;}
    }
    private Dictionary<int, LinkedListNode<cacheItem>> dict;
    private LinkedList<cacheItem> cache;    

    public LRUCache(int capacity) {
        dict = new Dictionary<int, LinkedListNode<cacheItem>>(capacity);
        cache = new LinkedList<cacheItem>();
        this.capacity = capacity;        
    }
    
    public int Get(int key) {
        LinkedListNode<cacheItem> res;
        if(dict.TryGetValue(key, out res)){
            cache.Remove(res);
            cache.AddFirst(res);
            return res.Value.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        LinkedListNode<cacheItem> res;
        if(dict.TryGetValue(key, out res)){
            res.Value.Value = value; 
            cache.Remove(res);
        }
        
        if(cache.Count +1 > capacity)
            evict();
        
        cache.AddFirst(new cacheItem{Key=key, Value=value});
        dict[key] = cache.First;
    }
    
    private void evict(){
        dict.Remove(cache.Last.Value.Key);
        cache.RemoveLast();
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */