def LongestWordOnFile():
    # Read the file
    f = open("PythonTest.txt", "r")
    words = f.read().split()
    #Verify the longest Word
    max_len = len(max(words, key=len))
    longest = [word for word in words if len(word) == max_len]
    print(longest)
    #reverse the word
    reverseWord = longest[0][::-1]
    #Show the largest word and the largest word reversed.
    print(longest[0] + " " + reverseWord)

    #Write positive and negative unit tests.
    #Positive
    assert sum([1, 2, 3]) == 6, "Should be 6"
    #Negative
    assert sum([1,2,3,5]) == 1

LongestWordOnFile()