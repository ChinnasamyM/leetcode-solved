public class FileSystem {
    
    public class Dir{
        public Dictionary<string, Dir> dirs = new Dictionary<string, Dir>();
        public Dictionary<string, string> files=new Dictionary<string, string>();
    }
    
    Dir root;
    public FileSystem() {
        root = new Dir();
    }
      
    public IList<string> Ls(string path) {
        Dir t = root;
        List<string> listed = new List<string>();
        //Console.WriteLine(path);
        Dir _val;
        String[] d =path.Split('/');
        if(path !="/"){
            for(int i=1; i<d.Length; i++){// path= /etc/app/log                
                if(t.dirs.TryGetValue(d[i], out _val))
                    t = t.dirs[d[i]];
            }           
        }
        //Console.WriteLine("{0}", t.dirs.Count);
        if(t.files.ContainsKey(d[d.Length-1]))
            listed.Add(d[d.Length-1]);
        else
        {
            if(t.dirs.Count>0){ //t.dirs.TryGetValue(d[d.Length-1], out _val )
                    listed.AddRange(t.dirs.Keys);
                }
            if(t.files.Count>0)
                listed.AddRange(t.files.Keys);
            listed.Sort();
        }
        
        return listed;
    }
    
    public void Mkdir(string path) {
        Dir t = root;
        string[] d = path.Split('/');
        Dir obj;//=new Dir();
        for(int i=1; i<d.Length-1; i++ )
            if(t.dirs.ContainsKey(d[i]))
                t = t.dirs[d[i]];
            else{
                obj=new Dir();
                 t.dirs.Add(d[i], obj);  // creating the dir if doesnt exists
                 t = t.dirs[d[i]];
            }
        // Condition can be added not create any existing dir on same path
        obj=new Dir();
        if(!t.dirs.ContainsKey(d[d.Length-1]))
            t.dirs.Add(d[d.Length-1], obj);
    }
    
    public void AddContentToFile(string filePath, string content) {
          Dir t = root;
        string[] d = filePath.Split('/');
        for(int i=0; i<d.Length-1; i++ )
            if(t.dirs.ContainsKey(d[i]))
                t = t.dirs[d[i]];
        if(!t.files.ContainsKey(d[d.Length-1]))
            t.files.Add(d[d.Length-1], content);
        else
            t.files[d[d.Length-1]] += content;
    }
    
    public string ReadContentFromFile(string filePath) {
           Dir t = root;
        string[] d = filePath.Split('/');
        for(int i=1; i<d.Length-1; i++ )
            if(t.dirs.ContainsKey(d[i]))
                t = t.dirs[d[i]];
            else
                return "";
        // now t is in current cursor
        return t.files[d[d.Length-1]];
    }
}

/**
 * Your FileSystem object will be instantiated and called as such:
 * FileSystem obj = new FileSystem();
 * IList<string> param_1 = obj.Ls(path);
 * obj.Mkdir(path);
 * obj.AddContentToFile(filePath,content);
 * string param_4 = obj.ReadContentFromFile(filePath);
 */