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
// Date Created: 02/22/19
// Purpose: This manages the menu stuff.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class MenuManager : MonoBehaviour
    {
        public Transform cube;
        public float cubeRotateSpeed = 5.0f;

        public GameObject creditsContainer;
        public GameObject storyContainer;

        public void ToggleCredits ()
        {
            creditsContainer.SetActive(!creditsContainer.activeSelf);
        }

        public void ToggleStory ()
        {
            storyContainer.SetActive(!storyContainer.activeSelf);
        }

        public void LoadScene (string scene)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        protected void Update ()
        {
            cube.Rotate(0, cubeRotateSpeed * Time.deltaTime, 0);
        }
    }
}