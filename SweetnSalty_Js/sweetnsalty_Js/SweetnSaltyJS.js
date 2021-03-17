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

let s = "";
for(let i = startIndex; i <= endIndex; i++)
{
    if ((i % firstNum == 0) && (i % secondNum == 0))
    {
         s += (thirdWord + " ");
         thirdWordCounter++;
    }
    else if (i % firstNum == 0)
    {
        s += (firstWord + " ");
        firstWordCounter++;
    }
    else if (i % secondNum == 0)
    {
        s += (secondWord + " ");
        secondWordCounter++;
    }
    else
    {
        s += (i + " ");
    }

    if(i % 10 == 0)
    {
        console.log(s);
        s = "";
    }
    
}

console.log("The number of times " + firstWord + " occurs: " + firstWordCounter);
console.log("The number of times " + secondWord + " occurs: " + secondWordCounter);
console.log("The number of times " + thirdWord + " occurs: " + thirdWordCounter);


