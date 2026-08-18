using UnityEngine;

public class Workshop : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //As01_SyntaxIf();
        //As02_StringComparisonExample();
        //As03_NumberComparisonExample();
        //As04_AndOrOperatorExample();
        //As05_GuessingNumberExample();
        //As06_GuessingNumberMoreOrLessExample();
        As07_VerifyIdentityExample();
    }

    public bool isSixOClock;
    public void As01_SyntaxIf()
    {
        if (isSixOClock)
        {
            Debug.Log("The Door Open");
        }
        Debug.Log("Knock Knock!");
    }

    public string password;
    public void As02_StringComparisonExample()
    {
        if (password == "Moon")
        {
            Debug.Log("correcct");
        }
    }

    public int as03Number;
    public void As03_NumberComparisonExample()
    {
        if (as03Number > 10)
        {
            Debug.Log("as03Number > 10");
        }

        if (as03Number < 10)
        {
            Debug.Log("as03Number < 10");

        }

        if (as03Number == 10)
        {
            Debug.Log("as03Number == 10");

        }

        if (as03Number >= 10)
        {
            Debug.Log("as03Number >= 10");

        }

        if (as03Number != 10)
        {
            Debug.Log("as03Number != 10");
        }
    }

    public int as04Number;
    public void As04_AndOrOperatorExample()
    {
        if (as04Number > 8 && as04Number < 12)
        {
            Debug.Log("as04Number > 8 && as04Number < 12");
        }
        if (as04Number > 8 || as04Number < 12)
        {
            Debug.Log("as04Number > 8 || as04Number < 12");
        }
        
    }

    public int as05GuessingNumber;
    public int as05RandomNumber;
    public void As05_GuessingNumberExample()
    {
        if (as05GuessingNumber == as05RandomNumber)
        {
            Debug.Log("Congrat");
        }

        if (as05GuessingNumber != as05RandomNumber)
        {
            Debug.Log("Wrong");
        }
    }

    public int as06GuessingNumber;
    public int as06RandomNumber;
    public void As06_GuessingNumberMoreOrLessExample()
    {
        if (as06GuessingNumber > as05RandomNumber)
        {
            Debug.Log("Too high");
        }
        else if (as06GuessingNumber < as05RandomNumber)
        {
            Debug.Log("Too low");
        }
        else
        {
            Debug.Log("Correct");
        }
    }

    public string as07Username;
    public string as07Password;
    public int as07Age;
    public bool as07IsPaid;
    public void As07_VerifyIdentityExample()
    {
        if (as07Username == "user" && as07Password == "1234")
        {
            Debug.Log("Logged in");
            if (as07IsPaid == true)
            {
                Debug.Log("VIP member");
            }
            else
            {
             Debug.Log("Free member");   
            }

            if (as07Age >= 18)
            {
                Debug.Log("you have access to exclusive content");
            }
        }
        else
        {
            Debug.Log("Guest mode");
        }
    }
}
