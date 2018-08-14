bool isCryptSolution(string[] crypt, char[][] solution) {
    
    int numb1 = 0;
    int numb2 = 0;
    int sumOfNumbers = 0;
    
    string newWord = crypt[0];
    
    try{
        for(int i=0; i< solution.GetLength(0); i++)
            newWord = newWord.Replace(solution[i][0],solution[i][1]);
        
        if(newWord[0] == '0' && newWord.Length > 1)
            return false;
        
        numb1 = (int)Convert.ToInt64(newWord);

        newWord = crypt[1];
        
        for(int i=0; i< solution.GetLength(0); i++)
            newWord = newWord.Replace(solution[i][0],solution[i][1]);
        
        if(newWord[0] == '0' && newWord.Length > 1)
            return false;
        
        numb2 = (int)Convert.ToInt64(newWord);

        newWord = crypt[2];
        
        for(int i=0; i< solution.GetLength(0); i++)
            newWord = newWord.Replace(solution[i][0],solution[i][1]);
        
        if(newWord[0] == '0' && newWord.Length > 1)
            return false;
        
        sumOfNumbers = Convert.ToInt64(newWord);

        if(numb1 + numb2 == sumOfNumbers)
            return true;

        return false;
    }
    
    catch(Exception ex){
        return false;
    }
}
