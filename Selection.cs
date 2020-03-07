using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmCodingChallenge.Algorithms;

namespace AlgorithmCodingChallenge
{
    class Selection
    {
        // Method selection
        public void select(int num)
        {
          
            switch (num)
            {
                case 1:
                    basic display = new basic();
                    display.one();
                    display.two();
                    display.three();
                    break;
                case 2:
                    summation res = new summation();
                    res.four();
                    res.five();
                    res.six();
                    break;
                case 3:
                    MultiplicationTable multiply = new MultiplicationTable();
                    multiply.seven();
                    break;
                case 4:
                    PrimeNumbers printPrime = new PrimeNumbers();
                    printPrime.eight();
                    break;
                case 5:
                    MaxNum maxi = new MaxNum();
                    maxi.nine();
                    break;
                case 6:
                    ReverseList rev = new ReverseList();
                    rev.ten();
                    break;
                case 7:
                    ContainsElement con = new ContainsElement();
                    con.eleven();
                    break;
                case 8:
                    ReturnItemsOddPos oddPos = new ReturnItemsOddPos();
                    oddPos.twelve();
                    break;
                case 9:
                    RunningTotal runTotal = new RunningTotal();
                    runTotal.thirteen();
                    break;
                case 10:
                    Palindrome pali = new Palindrome();
                    pali.fourteen();
                    break;
                case 11:
                    SumFunct sumF = new SumFunct();
                    sumF.fifteenA();
                    sumF.fifteenB();
                    sumF.fifteenC();
                    break;
                case 12:
                    Concatenation conca = new Concatenation();
                    conca.display();
                    conca.seventeen();
                    conca.nineteen();
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
                    
        }
    }
}
