using System;
using System.Collections.Generic;
using System.Collections;
/// <summary>
///Capacity
/// </summary>
public class ListCapacity
{
    public static int Main()
    {
        ListCapacity ListCapacity = new ListCapacity();
        TestLibrary.TestFramework.BeginTestCase("ListCapacity");
        if (ListCapacity.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        TestLibrary.TestFramework.LogInformation("[Negitive]");
        retVal = NegTest1() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Calling Capacity Property,T is Value type.");
        try
        {
            List<int> myList = new List<int>();
            int count = 10;
            int element = 0;
            for (int i = 1; i <= count; i++)
            {
                element = i * count;
                myList.Add(element);
               
            }
            if (myList.Capacity <myList.Count)
            {
                TestLibrary.TestFramework.LogError("001.1", " Capacity should be always greater than or equal to Count." );
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Calling Capacity Property,T is reference type.");
        try
        {
            List<string> myList = new List<string>();
            int count = 10;
            string element = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                element = i.ToString();
                myList.Add(element);
                
            }
            if (myList.Capacity < myList.Count)
            {
                TestLibrary.TestFramework.LogError("002.1", " Capacity should be always greater than or equal to Count.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3: Calling Capacity Property,set a new capacity.");
        try
        {
            List<int> myList = new List<int>();
            int expectValue = 20;
            myList.Capacity = expectValue;
            if (myList.Capacity != expectValue)
            {
                TestLibrary.TestFramework.LogError("003.1", " Capacity should return " + expectValue);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool NegTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("NegTest1: Capacity is set to a value that is less than Count.");
        try
        {
            List<int> myList = new List<int>();
            int count = 10;
            int element = 0;
            for (int i = 1; i <= count; i++)
            {
                element = i * count;
                myList.Add(element);

            }
            myList.Capacity = 5;
            TestLibrary.TestFramework.LogError("101.1.", "ArgumentOutOfRangeException should be caught.");
            retVal = false;

        }
        catch (ArgumentOutOfRangeException)
        {
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("101.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
   

}
