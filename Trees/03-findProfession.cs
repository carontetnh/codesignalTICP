/*
string findProfession(int level, int pos) {
    return printResult(returnProfession(level, pos, true, 1, 1));
}

string printResult(bool isEngineer){
    if(isEngineer)
        return "Engineer";
    
    return "Doctor";
}

bool returnProfession(int level, int pos, bool isEngineer, int currentLevel, int currentPos)
{
    if(currentLevel == level  && currentPos == pos)
        return isEngineer;
    
    if(currentLevel < level && (currentPos * 2) - 1 <= pos)
            return returnProfession(level, pos, isEngineer, currentLevel + 1, (currentPos * 2) - 1) || 
        returnProfession(level, pos, !isEngineer, currentLevel + 1, (currentPos * 2));
    
    return false;
}
*/
string findProfession(int level, int pos){
    if (level == 1)
        return "Engineer";
    
    if (findProfession(level - 1, (pos + 1) / 2) == "Doctor")
        return (pos % 2 > 0) ? "Doctor" : "Engineer";
    
    return (pos % 2 > 0) ? "Engineer" : "Doctor";
}