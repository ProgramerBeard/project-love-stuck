// Copyright 2019 Justin Selsor
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the 
// "Software"), to deal in the Software without restriction, including 
// without limitation the rights to use, copy, modify, merge, publish, 
// distribute, sublicense, and/or sell copies of the Software, and to 
// permit persons to whom the Software is furnished to do so, subject 
// to the following conditions:
//
// The above copyright notice and this permission notice shall be 
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
// OTHER DEALINGS IN THE SOFTWARE.
//
// Author: Justin Selsor
// Date Created: 02/20/19
// Purpose: This class was made because of bugs. Please forgive me.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeManager : MonoBehaviour
{
    [HideInInspector] public MatchSystem.Attribute[] attributes = new MatchSystem.Attribute[35];

    protected void Awake()
    {
        // Forgive me.
        attributes[0] = new MatchSystem.Attribute (
            1,
            new int[] {3},
            new int[] {2},
            "Dogs"
        );
        attributes[1] = new MatchSystem.Attribute (
            2,
            new int[] {3},
            new int[] {1},
            "Cats"
        );
        attributes[2] = new MatchSystem.Attribute (
            3,
            new int[] {2, 3},
            new int[] {0},
            "Pets"
        );
        attributes[3] = new MatchSystem.Attribute (
            4,
            new int[] {6},
            new int[] {5, 10},
            "Books"
        );
        attributes[4] = new MatchSystem.Attribute (
            5,
            new int[] {10},
            new int[] {5},
            "Movies"
        );
        attributes[5] = new MatchSystem.Attribute (
            6,
            new int[] {6, 9},
            new int[] {0},
            "Comics"
        );
        attributes[6] = new MatchSystem.Attribute (
            7,
            new int[] {8},
            new int[] {0},
            "Food"
        );
        attributes[7] = new MatchSystem.Attribute (
            8,
            new int[] {7},
            new int[] {0},
            "Drinks"
        );
        attributes[8] = new MatchSystem.Attribute (
            9,
            new int[] {6, 16},
            new int[] {0},
            "Video Games"
        );
        attributes[9] = new MatchSystem.Attribute (
            10,
            new int[] {5},
            new int[] {4},
            "TV"
        );
        attributes[10] = new MatchSystem.Attribute (
            11,
            new int[] {19, 20, 21, 22, 35},
            new int[] {0},
            "Programming"
        );
        attributes[11] = new MatchSystem.Attribute (
            12,
            new int[] {23},
            new int[] {0},
            "Drawing"
        );
        attributes[12] = new MatchSystem.Attribute (
            13,
            new int[] {0},
            new int[] {0},
            "Cars"
        );
        attributes[13] = new MatchSystem.Attribute (
            14,
            new int[] {0},
            new int[] {0},
            "Planes"
        );
        attributes[14] = new MatchSystem.Attribute (
            15,
            new int[] {0},
            new int[] {0},
            "Going to the Gym"
        );
        attributes[15] = new MatchSystem.Attribute (
            16,
            new int[] {6},
            new int[] {0},
            "Puzzles"
        );
        attributes[16] = new MatchSystem.Attribute (
            17,
            new int[] {0},
            new int[] {0},
            "Poltics"
        );
        attributes[17] = new MatchSystem.Attribute (
            18,
            new int[] {0},
            new int[] {0},
            "Money"
        );
        attributes[18] = new MatchSystem.Attribute (
            19,
            new int[] {11},
            new int[] {0},
            "C++"
        );
        attributes[19] = new MatchSystem.Attribute (
            20,
            new int[] {11},
            new int[] {0},
            "Python"
        );
        attributes[20] = new MatchSystem.Attribute (
            21,
            new int[] {11, 22},
            new int[] {0},
            "Java"
        );
        attributes[21] = new MatchSystem.Attribute (
            22,
            new int[] {11, 21},
            new int[] {0},
            "C#"
        );
        attributes[22] = new MatchSystem.Attribute (
            23,
            new int[] {12, 24},
            new int[] {0},
            "Art"
        );
        attributes[23] = new MatchSystem.Attribute (
            24,
            new int[] {23},
            new int[] {0},
            "Sculpting"
        );
        attributes[24] = new MatchSystem.Attribute (
            25,
            new int[] {29, 32, 33, 34},
            new int[] {30},
            "Fiction"
        );
        attributes[25] = new MatchSystem.Attribute (
            26,
            new int[] {28},
            new int[] {27},
            "Rock Music"
        );
        attributes[26] = new MatchSystem.Attribute (
            27,
            new int[] {28},
            new int[] {26},
            "Pop Music"
        );
        attributes[27] = new MatchSystem.Attribute (
            28,
            new int[] {26, 27},
            new int[] {0},
            "Indie Music"
        );
        attributes[28] = new MatchSystem.Attribute (
            29,
            new int[] {25},
            new int[] {32},
            "Fansty"
        );
        attributes[29] = new MatchSystem.Attribute (
            30,
            new int[] {31, 33},
            new int[] {25},
            "Nonfiction"
        );
        attributes[30] = new MatchSystem.Attribute (
            31,
            new int[] {30, 33},
            new int[] {0},
            "History"
        );
        attributes[31] = new MatchSystem.Attribute (
            32,
            new int[] {19},
            new int[] {25},
            "Scifi"
        );
        attributes[32] = new MatchSystem.Attribute (
            33,
            new int[] {25, 30, 31},
            new int[] {0},
            "Westerns"
        );
        attributes[33] = new MatchSystem.Attribute (
            34,
            new int[] {25},
            new int[] {0},
            "Romance"
        );
        attributes[34] = new MatchSystem.Attribute (
            35,
            new int[] {11},
            new int[] {19, 20, 21, 22},
            "PHP"
        );
    }
}
