char firstNotRepeatingCharacter(string s) {
    //abacabad
    //01234567
    bool flag;
    for(int i = 0; i < s.Length; i++){
        flag = true;
        for(int j = 0; j < s.Length; j++){
            if(j!=i && s[i]==s[j]){
                flag = false;
                break;
            }
        }
        if(flag){
            return s[i];
        }
    }
    return '_';
}
