using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        if (as01Number == 0)
        {
            Debug.Log("Zero");
            return;
        }
        
        Debug.Log(as01Number > 0 ? "Positive" : "Negative");
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        if (as02Day == 1) Debug.Log("Monday");
        else if (as02Day == 2) Debug.Log("Tuesday");
        else if (as02Day == 3) Debug.Log("Wednesday");
        else if (as02Day == 4) Debug.Log("Thursday");
        else if (as02Day == 5) Debug.Log("Friday");
        else if (as02Day == 6) Debug.Log("Saturday");
        else if (as02Day == 7) Debug.Log("Sunday");
        else Debug.Log("Invalid day");    
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
        bool isPasswordMatch = (as03InputPassword == as03CorrectPassword);
        Debug.Log(isPasswordMatch ? "True" : "False");    
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        if (as04Score < 50) { Debug.Log("F"); return; }
        if (as04Score < 60) { Debug.Log("D"); return; }
        if (as04Score < 70) { Debug.Log("C"); return; }
        if (as04Score < 80) { Debug.Log("B"); return; }
        Debug.Log("A");    
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        bool isLeap = (as05Year % 4 == 0 && as05Year % 100 != 0) || (as05Year % 400 == 0);
        Debug.Log(isLeap ? "True" : "False");    
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        if (as06Op == '+')
            Debug.Log("Result: " + (as06Num1 + as06Num2));
        else if (as06Op == '-')
            Debug.Log("Result: " + (as06Num1 - as06Num2));
        else if (as06Op == '*')
            Debug.Log("Result: " + (as06Num1 * as06Num2));
        else if (as06Op == '/')
        {
            if (as06Num2 == 0)
                Debug.Log("Error: Cannot divide by zero.");
            else
                Debug.Log("Result: " + (as06Num1 / as06Num2));
        }
        else
        {
            Debug.Log("Invalid operator. Please use +, -, *, or /.");
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        switch (as07Month)
        {
            case 12: case 1: case 2: 
                Debug.Log("It's Winter."); break;
            case 3: case 4: case 5: 
                Debug.Log("It's Spring."); break;
            case 6: case 7: case 8: 
                Debug.Log("It's Summer."); break;
            case 9: case 10: case 11: 
                Debug.Log("It's Fall."); break;
            default: 
                Debug.Log("Invalid month number. Please enter a number between 1 and 12."); break;
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity > 0)
        {
            if (as08Payment > as08Price)
            {
                Debug.Log("คุณได้รับสินค้าแล้ว");
                Debug.Log("คุณได้รับเงินทอน " + (as08Payment - as08Price) + " บาท");
            }
            else if (as08Payment == as08Price)
            {
                Debug.Log("คุณได้รับสินค้าแล้ว");
            }
            else
            {
                Debug.Log("คุณมีเงินไม่พอ");
            }
        }
        else
        {
            Debug.Log("สินค้าหมด");
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        bool isInputValid = as09UserChoice >= 0 && as09UserChoice <= 2;
        if (!isInputValid)
        {
            Debug.Log("กรุณาเลือกเป็นตัวเลขที่ถูกต้อง");
            return;
        }

        if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("เสมอ");
            return;
        }

        bool isPlayerWin = (as09UserChoice == 0 && as09ComputerChoice == 2) ||
                           (as09UserChoice == 1 && as09ComputerChoice == 0) ||
                           (as09UserChoice == 2 && as09ComputerChoice == 1);

        if (isPlayerWin)
            Debug.Log("คุณชนะ!");
        else
            Debug.Log("คุณแพ้!");
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        string weapon = string.IsNullOrEmpty(as10WeaponType) ? "" : as10WeaponType.ToLower();
        double mult = 1.0;

        if (weapon == "sword") mult = 1.3;
        else if (weapon == "axe") mult = 1.4;
        else if (weapon == "bow") mult = 1.2;
        else if (weapon == "staff") mult = 1.5;
        else if (weapon == "dagger") mult = 1.1;

        Debug.Log((int)(as10BaseDamage * mult));    
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        if (as11Score < 0 || as11CompletionTime < 0)
        {
            Debug.Log("Invalid score or time");
            return;
        }

        int totalReward = 0;
        string currentRank = "";

        if (as11Score < 4000) { currentRank = "Participation"; totalReward = 25; }
        else if (as11Score < 6000) { currentRank = "Bronze"; totalReward = 50; }
        else if (as11Score < 8000) { currentRank = "Silver"; totalReward = 75; }
        else { currentRank = "Gold"; totalReward = 100; }

        if (as11CompletionTime <= 30)
            totalReward += 25;
        else if (as11CompletionTime <= 60)
            totalReward += 10;

        Debug.Log(currentRank + " Rank\n" + totalReward + " coins earned!");
    }
}
