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
// Date Created: 02/16/19
// Purpose: This class manages the UI elements. It controls when to display
// UI elements.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Breaks from overall style because UI elements will
//                       use a lot of UI elements.

namespace GameManagers
{
    public class UIManager : MonoBehaviour
    {
        [Header  ("Score Elements")]
        public Text scoreText;

        [Header ("Countdown Elements")]
        public Image countdownImage;
        public Text countdownText;

        [Header("Client Feilds")]
        public Text clientName;
        public Text clientFeature;
        public Text clientLikesText;
        public Text clientDislikesText;
        public Image clientHead;
        public Image clientHair;
        public Image clientEyebrows;
        public Image clientEyes;
        public Image clientMouth;

        [Header("Match 1 Feilds")]
        public Text match1Name;
        public Text match1Feature;
        public Text match1LikeText;
        public Text match1DislikeText;
        public Image match1Head;
        public Image match1Hair;
        public Image match1Eyebrows;
        public Image match1Eyes;
        public Image match1Mouth;

        [Header("Match 2 Feilds")]
        public Text match2Name;
        public Text match2Feature;
        public Text match2LikeText;
        public Text match2DislikeText;
        public Image match2Head;
        public Image match2Hair;
        public Image match2Eyebrows;
        public Image match2Eyes;
        public Image match2Mouth;

        [Header("End Game Score")]
        public GameObject endGameContainer;
        public Text finalScore;

        public void EndGame ()
        {
            endGameContainer.SetActive(true);
            finalScore.text = GameManagers.GameManager.instance.scoreManager.Score.ToString("D6");
        }

        public void UpdateScore(int _val)
        {
            scoreText.text = "Score:" + _val.ToString("D6");
        }

        // _r is the ratio between the current time and max time.
        // come up with a better name.
        public void UpdateTimer (float _val, float _r)
        {
            if (_val < 0)
                return;

            countdownText.text = "" + _val;
            countdownImage.fillAmount = _r;
        }

        public void UpdateClientInformation(string _name, string _features, string _likes, string _dislikes)
        {
            clientName.text = _name;
            clientFeature.text = _features;
            clientLikesText.text = _likes;
            clientDislikesText.text = _dislikes;
        }

        public void UpdateClientImage (Sprite _head, Sprite _hair, Sprite _eyebrows, Sprite _eyes, Sprite _mouth)
        {
            clientHead.sprite = _head;
            clientHair.sprite = _hair;
            clientEyebrows.sprite = _eyebrows;
            clientEyes.sprite = _eyes;
            clientMouth.sprite = _mouth;
        }

        public void UpdateMatch1Information (string _name, string _features, string _likes, string _dislikes)
        {
            match1Name.text = _name;
            match1Feature.text = _features;
            match1LikeText.text = _likes;
            match1DislikeText.text = _dislikes;
        }

        public void UpdateMatch1Image (Sprite _head, Sprite _hair, Sprite _eyebrows, Sprite _eyes, Sprite _mouth)
        {
            match1Head.sprite = _head;
            match1Hair.sprite = _hair;
            match1Eyebrows.sprite = _eyebrows;
            match1Eyes.sprite = _eyes;
            match1Mouth.sprite = _mouth;
        }

        public void UpdateMatch2Information (string _name, string _features, string _likes, string _dislikes)
        {
            match2Name.text = _name;
            match2Feature.text = _features;
            match2LikeText.text = _likes;
            match2DislikeText.text = _dislikes;
        }

        public void UpdateMatch2Image (Sprite _head, Sprite _hair, Sprite _eyebrows, Sprite _eyes, Sprite _mouth)
        {
            match2Head.sprite = _head;
            match2Hair.sprite = _hair;
            match2Eyebrows.sprite = _eyebrows;
            match2Eyes.sprite = _eyes;
            match2Mouth.sprite = _mouth;
        }

        public void ReloadScene (string _sceneName)
        {
            Destroy(GameManagers.GameManager.instance.gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName);
        }
    }
}