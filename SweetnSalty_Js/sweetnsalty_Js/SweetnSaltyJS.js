//init variables
let startIndex = 1;
let endIndex = 1000;
let firstWord = "sweet";
let secondWord = "salty";
let thirdWord = "saltNSalty";
let firstNum = 3;
let secondNum = 5;
let firstWordCounter = 0;
let secondWordCounter = 0;
let thirdWordCounter = 0;

// set a string to hold 10 numbers in a line to later print to console
let s = "";

// loop to check each number
for(let i = startIndex; i <= endIndex; i++)
{
    // if the current number is divisible by the first and second number, I want to add the third word 
    // to the s string plus a space and increment counter by one 
    if ((i % firstNum == 0) && (i % secondNum == 0))
    {
         s += (thirdWord + " ");
         thirdWordCounter++;
    }
    // if the current number is divisible by the first number, I want to add the first word 
    // to the s string plus a space and increment counter by one
    else if (i % firstNum == 0)
    {
        s += (firstWord + " ");
        firstWordCounter++;
    }
    // if the current number is divisible by the second number, I want to add the second word 
    // to the s string plus a space and increment counter by one
    else if (i % secondNum == 0)
    {
        s += (secondWord + " ");
        secondWordCounter++;
    }
    // if the current number is not divisble by either number, just print the number
    else
    {
        s += (i + " ");
    }
    // once 10 values have been concatenated to string, so print it to the console and reset the
    // string to hold the next 10 values
    if(i % 10 == 0)
    {
        console.log(s);
        s = "";
    }
    
}

console.log("The number of times " + firstWord + " occurs: " + firstWordCounter);
console.log("The number of times " + secondWord + " occurs: " + secondWordCounter);
console.log("The number of times " + thirdWord + " occurs: " + thirdWordCounter);


