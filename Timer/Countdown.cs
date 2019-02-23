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
// Date Created: 02/18/19
// Purpose: This is time timer for the game. This will control wether the
// game should end.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Timer
{
    public class Countdown : MonoBehaviour
    {
        public float gameTime = 60.0f;

        public float TimeLeft {protected set; get;}

        protected void Start()
        {
            TimeLeft = gameTime;
            StartCoroutine("LoseTime");
            Time.timeScale = 1;
        }

        protected void Update()
        {
            float r = TimeLeft / gameTime;

            GameManagers.GameManager.instance.uIManager.UpdateTimer(TimeLeft, r);

            if (TimeLeft <= 0)
            {
                Debug.Log("Apple");
                GameManagers.GameManager.instance.uIManager.EndGame();
            }
        }

        private IEnumerator LoseTime()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                TimeLeft --;
            }
        }
    }
}