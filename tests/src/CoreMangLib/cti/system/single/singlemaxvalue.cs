using System;
using System.Collections;
/// <summary>
///MaxValue
/// </summary>
public class SingleMaxValue
{
    public const float ExpectMaxValue = (float)3.40282346638528859e+38;
    
    public static int Main()
    {
        SingleMaxValue SingleMaxValue = new SingleMaxValue();

        TestLibrary.TestFramework.BeginTestCase("SingleMaxValue");
        if (SingleMaxValue.RunTests())
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
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Compare to ExpectMaxValue.");
        try
        {
            float actualValue = Single.MaxValue;
            if (actualValue != ExpectMaxValue)
            {
                TestLibrary.TestFramework.LogError("001", "MaxValue has error.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
   
}
