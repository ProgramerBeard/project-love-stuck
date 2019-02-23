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
// Purpose: This generates clients.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generator
{
    [System.Serializable]
    public class ClientGenerator
    {
        #region Match_Fields
        [HideInInspector] public string[] givenNames;
        [HideInInspector] public string[] surnames;
        public enum Ages { YOUNG_ADULT, MIDDLE_AGED, OLD_AGED, ACIENT };
        public enum Genders { MALE, FEMALE };
        public enum Races { HUMAN, ELF, DRAWF, FAE, DRAGON_BORN };
        public MatchSystem.Attribute[] likes;
        public MatchSystem.Attribute[] disLikes;
        #endregion

        private MatchSystem.Attribute[] attributes;

        public void InitilizeClinetGenerator()
        {
            givenNames = ParseNames(GameManagers.GameManager.instance.datasetManager.givenNameSet);
            surnames = ParseNames(GameManagers.GameManager.instance.datasetManager.surnameSet);
            attributes = ParseAttributes(GameManagers.GameManager.instance.datasetManager.attributeSet);
        }

        public string GenerateGivenName()
        {
            return Utilities.Utility.GetRandomElement(givenNames);
        }

        public string GenerateSurname()
        {
            return Utilities.Utility.GetRandomElement(surnames);
        }

        public string GenerateFullName()
        {
            return GenerateGivenName() + " " + GenerateSurname();
        }

        public Ages GenerateAge()
        {
            return Utilities.Utility.GetRandomEnumValue<Ages>();
        }

        public Genders GenerateGender()
        {
            return Utilities.Utility.GetRandomEnumValue<Genders>();
        }

        public Races GenerateRace()
        {
            return Utilities.Utility.GetRandomEnumValue<Races>();
        }

        public MatchSystem.Attribute[] GenerateLikes(int _min, int _max)
        {
            int vallength = Utilities.Utility.random.Next((_max - _min) + 1) + _min;
            MatchSystem.Attribute[] val = new MatchSystem.Attribute[vallength];

            for (int i = 0; i < vallength; i++)
            {
                val[i] = GetAttribute();
            }

            return val;
        }

        public MatchSystem.Attribute[] GenerateDislikes(int _min, int _max)
        {
            int vallength = Utilities.Utility.random.Next((_max - _min) + 1) + _min;
            MatchSystem.Attribute[] val = new MatchSystem.Attribute[vallength];

            for (int i = 0; i < vallength; i++)
            {
                val[i] = GetAttribute();
            }

            return val;
        }

        public MatchSystem.Client GenerateClient ()
        {
            return new MatchSystem.Client(
                GenerateFullName(),
                GenerateAge(),
                GenerateRace(),
                GenerateGender(),
                GenerateLikes(1, 3),
                GenerateDislikes(1, 3)
            );
        }

        public Sprite GenerateHead ()
        {
            return GameManagers.GameManager.instance.imageGenerator.heads
            [
                Utilities.Utility.random.Next(GameManagers.GameManager.instance.imageGenerator.heads.Length)
            ];
        }

        public Sprite GenerateHair ()
        {
            return GameManagers.GameManager.instance.imageGenerator.hair
            [
                Utilities.Utility.random.Next(GameManagers.GameManager.instance.imageGenerator.hair.Length)
            ];
        }

        public Sprite GenerateEyebrows ()
        {
            return GameManagers.GameManager.instance.imageGenerator.eyebrows
            [
                Utilities.Utility.random.Next(GameManagers.GameManager.instance.imageGenerator.eyebrows.Length)
            ];
        }

        public Sprite GenerateEyes ()
        {
            return GameManagers.GameManager.instance.imageGenerator.eyes
            [
                Utilities.Utility.random.Next(GameManagers.GameManager.instance.imageGenerator.eyes.Length)
            ];
        }

        public Sprite GenerateMouth ()
        {
            return GameManagers.GameManager.instance.imageGenerator.mouths
            [
                Utilities.Utility.random.Next(GameManagers.GameManager.instance.imageGenerator.mouths.Length)
            ];
        }

        private string[] ParseNames (TextAsset nameSet)
        {
            return System.Text.RegularExpressions.Regex.Split(nameSet.text, "\n");
        }

        private MatchSystem.Attribute[] ParseAttributes(TextAsset _attributeText)
        {
            string[] fLines = System.Text.RegularExpressions.Regex.Split(_attributeText.text, "\n");
            MatchSystem.Attribute[] value = new MatchSystem.Attribute[fLines.Length];
            foreach (string rawAttribute in fLines)
            {
                string[] attributeValues = System.Text.RegularExpressions.Regex.Split(rawAttribute, ",");

                string[] strAttributeComplments = System.Text.RegularExpressions.Regex.Split(attributeValues[2], ";");
                int[] attributeComplments = new int[strAttributeComplments.Length];

                for(int i = 0; i < attributeComplments.Length; i++)
                {
                    attributeComplments[i] = int.Parse(strAttributeComplments[i]);
                }

                string[] strAttributeBlocks = System.Text.RegularExpressions.Regex.Split(attributeValues[3], ";");
                int[] attributeBlocks = new int[strAttributeBlocks.Length];

                for(int i = 0; i < strAttributeBlocks.Length; i++)
                {
                    attributeBlocks[i] = int.Parse(strAttributeBlocks[i]);
                }

                MatchSystem.Attribute attribute;
                attribute = new MatchSystem.Attribute(
                    int.Parse(attributeValues[1]),
                    attributeComplments,
                    attributeBlocks,
                    attributeValues[0]
                );
            }

            return value;
        }

        private MatchSystem.Attribute GetAttribute()
        {
           return GameManagers.GameManager.instance.atributeManager.attributes[Utilities.Utility.random.Next(attributes.Length)];
        }
    }
}