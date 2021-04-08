using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BitShift : MonoBehaviour
{
    //string A = "110111";
    //string B = "10001";
    //string C = "1101";

    string A = "1111";
    string B = "101";
    string C = "11011";

    // Start is called before the first frame update
    void Start()
    {
        //int aBits = Convert.ToInt32(A, 2);
        //Debug.Log(aBits);
        //int bBits = Convert.ToInt32(B, 2);
        //int cBits = Convert.ToInt32(C, 2);

        int aBits = Convert.ToInt32(A, 2);
        Debug.Log(aBits);
        int bBits = Convert.ToInt32(B, 2);
        int cBits = Convert.ToInt32(C, 2);

        int packed = 0;

        //packed |= (aBits << 26) | (bBits << 21) | (cBits << 17);
        packed |= (aBits << 28) | (bBits << 25) | (cBits << 20);

        Debug.Log(Convert.ToString(packed, 2).PadLeft(32, '0'));
    }

    // Bit unpacking
    // A = 0011001
    // B = 11000
    // C = 0101
    // space bars only to viusalize better
    // X = 0011001 11000 0101
    // MaskA = 1111111 00000 0000
    // A = (X & MaskA >> 9) = 00000 0000 0011001
    // MaskB = 0000000 11111 0000
    // B = (X & MaskB >> 4) = 0000000 0000 11000
    // MaskC = 0000000 00000 1111
    // C = (X & MaskC) = 0000000 00000 0101
}
