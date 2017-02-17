# CigniumChallenge

Solution to the challenge Search Fight

###Searchfight
To determine the popularity of programming languages on the internet we want to you to write an application that queries search engines and compares how many results they return, for example:

``` 
    C:\> searchfight.exe .net java
    .net: Google: 4450000000 MSN Search: 12354420
    java: Google: 966000000 MSN Search: 94381485
    Google winner: .net
    MSN Search winner: java
    Total winner: .net
```
- The application should be able to receive a variable amount of words
- The application should support quotation marks to allow searching for terms with spaces (e.g. searchfight.exe “java script”)
- The application should support at least two search engines

#To add new search engines
1. Open *config.xml*
2. Use the following template:
```
	<SearchEngine xsi:type="SearchRunner" SearchEngineName="________" Address="________">
      <Client />
      <Parser GroupIndex="1">
        <Pattern>________</Pattern>
      </Parser>
    </SearchEngine>

```
3. In `SearchEngineName` enter the name of the new search engine (it will be using for printing the results)
4. In `Address` enter the search addres that the your new serch engine uses (e.g. "https://search.yahoo.com/search?p="), make sure it contains the QueryName (in this case the "q") and the "="
5. In `Parser` leave GroupIndex in 1, you can modify it depending of your Pattern
6. In `Pattern` enter the regex pattern that will filter the response text
