string minSubstringWithAllChars(string s, string t) {
    int cont = s.Length;
    int j = 0;
    string current = "";
    string result = "";
    
    if(t.Length < 2){
        if(checkString(s,t))
            return t;
        else
            return "";
    }
    
    while(j < s.Length)
    {
        current += s[j];
        if(current.Length < t.Length)
        {
            j++;
        }
        else{
            if(checkString(current, t))
            {
                if(current.Length <= cont)
                {
                    if((current.Length == cont && result == "") || current.Length < cont)
                    {
                        cont = current.Length;
                        result =  current;
                    }
                }
                current = current.Substring(1,current.Length-2);
            }
            else
                j++;
        }
    }
    return result;
}

bool checkString(string current, string t){
    
    foreach(char c in t){
        if(!current.Contains(c))
            return false;
    }
    return true;
}