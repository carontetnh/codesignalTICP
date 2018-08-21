int arrayMaxConsecutiveSum2(int[] inputArray) {
    int total = -1000, 
        totalInit = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        totalInit += inputArray[i];

        if (total < totalInit)
            total = totalInit;

        if (totalInit < 0)
            totalInit = 0;
    }

    return total;
}
