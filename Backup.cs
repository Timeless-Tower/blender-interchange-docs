/**
 * Convert Value to character buffer for given base. Caller is responsible for freeing memory. 
 * @param Value Value to use in conversion
 * @param Base Base to convert to (8,10,or 16)
 * @return Value as a character array or nullptr if Base is not 8,10, or 16
 */
static char* itoa(int Value, int Base)
{
    if (Base != 8 && Base != 10 && Base != 16)
    {
        return nullptr; // This function only supports these bases
    }

    //Get buffer length ahead of time adding extra space for '-' and '\0' and at least 1 character
    const bool bNegative = Value < 0;
    int BufferLength = bNegative ? 3 : 2;
    for (int Leftover = Value / Base;Leftover != 0;Leftover /= Base)
    {
        ++BufferLength; 
    }
    
    static const char* CharacterLookup = "0123456789ABCDEF";
    char* Result = new char[BufferLength];
    int Index = BufferLength - 2;
    Result[BufferLength-1] = '\0';

    //INT_MIN will overflow INT_MAX if negated b/c of sign-complement storage
    //Process first digit now and divide so we can negate remainder safely
    if (Value == INT_MIN)
    {
        //INT_MAX is one less than INT_MIN so use last digit of that instead of multiplying
        const int LastDigit = ((INT_MAX % Base) + 1) % Base;
        Result[Index--] = CharacterLookup[LastDigit];
        Value = Value / Base;
    }

    //Convert to positive for modulus to be able to extract digits
    if (bNegative)
    {
        Value *= -1;
        Result[0] = '-';
    }
    
    //Fill character buffer from end
    while (Value >= Base)
    {
        Result[Index--] = CharacterLookup[Value % Base];
        Value = Value / Base;
    }
    Result[Index] = CharacterLookup[Value];
    return Result;
}
