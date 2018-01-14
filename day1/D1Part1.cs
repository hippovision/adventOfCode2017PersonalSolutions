using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D1Part1 : MonoBehaviour {

    //change this string to your input value
    string input = "pasteyouruniqueinputstringhere";
    
    // Use this for initialization
    void Start () {

        int sum = 0;

        //iterate over each character in the array
        for (int i=1; i<=input.Length; i++)
        {
            //grab this character and the next character
            char c = input.ToCharArray()[i-1];
            char cNext;

            //If we've reached the end of the string, the next character comes from the beginning of the string
            if (i==input.Length)
            {
                cNext = input.ToCharArray()[0];
            }
            else
            {
                cNext = input.ToCharArray()[i];
            }

            //This debug logging is useful for verifying that values in the 'for' statement are correct and that the function is reaching the end of the array
            Debug.Log("Length:" + input.Length + " Position:" +i +" Value:" +c +" Next:" +cNext);

            //Checks if the digit is the same as the next digit, and if so adds the digit value to the total
            if (c==cNext)
            {
                Debug.Log("Match" + c);
                sum += int.Parse(c.ToString());
            }
            
        }
        //Spits out the sum
        Debug.Log("Sum: " + sum);
    }
	
}
