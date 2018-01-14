using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D1Part2 : MonoBehaviour {

    //change this string to your input value
    string input = "pasteyourstringhere";

    // Use this for initialization
    void Start () {

        int sum = 0;
        int halfRotationOffset;

        //iterate over each character in the array
        for (int i=1; i<=input.Length; i++)
        {
            //declare character variables to store this character and the one half way around the string
            char c = input.ToCharArray()[i-1];
            char cHalfRotation;

            //Calculate the position of the character half way from the current position
            halfRotationOffset = i-1+ input.Length / 2;

            //adjust position so it can't be out of index of the array (circling back to zero once 2098 is reached)
            if (halfRotationOffset >= input.Length)
            {
                halfRotationOffset -= input.Length;
            }

            //exact position of halfway point
            cHalfRotation = input.ToCharArray()[halfRotationOffset];

            //Checks if the digit is the same as the next digit, and if so adds the digit value to the total
            if (c==cHalfRotation)
            {
                Debug.Log("Match" + c);
                sum += int.Parse(c.ToString());
            }
            
        }
        //Spits out the sum
        Debug.Log("Sum: " + sum);
    }
	
}
