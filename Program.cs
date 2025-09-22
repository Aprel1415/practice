using practice;

// Calculator
string? numberOne = Console.ReadLine();
int.TryParse(numberOne, out int firstNum);
string? numberTwo = Console.ReadLine();
int.TryParse(numberTwo, out int secondNum);
Console.WriteLine("Choose operation:");
string? operationNumber = Console.ReadLine();
int.TryParse(operationNumber, out int chosedOperation);
switch (chosedOperation)
{
    case 1:
        int answerForPlus = firstNum + secondNum;
        Console.WriteLine(answerForPlus);
        return answerForPlus;
    case 2:
        int answerForMin = firstNum - secondNum;
        Console.WriteLine(answerForMin);
        return answerForMin;
    case 3:
        int answerForMul = firstNum * secondNum;
        Console.WriteLine(answerForMul);
        return answerForMul;
    case 4:
        if (secondNum == 0)
        {
            Console.WriteLine("Error!");
            return 0;
        }

        int answerForDec = firstNum / secondNum;
        Console.WriteLine(answerForDec);
        return answerForDec;
    default:
        return 0;
}
