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
// Date Created: 02/17/19
// Purpose: Holds the data on likes and dislikes. Has a string for the text of
// the attribute, an int for the attribute's id (used to easly test for
// equality), and array of ints for the attributes that complment it.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchSystem
{
    [System.Serializable]
    public class Attribute
    {
        public int attributeID;
        public int[] complements;
        public int[] blocks;
        public string attributeText;

        public Attribute (int _attributeID, int[] _complments, int[] _blocks, string _attributeText)
        {
            attributeID = _attributeID;
            complements = _complments;
            blocks = _blocks;
            attributeText = _attributeText;
        }

        public bool CompatableAttribute (int[] _matchComplments)
        {
            Debug.Log((this == null).ToString());
            return Utilities.Utility.BelongsTo<int>(attributeID, _matchComplments);
        }
    }
}