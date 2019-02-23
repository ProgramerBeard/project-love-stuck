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
// Purpose: This is responsable for manageing the game. It follows a singleton
// pattern. It also will follow what I am calling "Really Bad Toolkit". This
// will hold referances to other submanagers i.e. UIManager.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManagers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance = null;

        #region SubManagers
        public UIManager uIManager;
        public Generator.ClientGenerator clientGenerator;
        public Generator.MatchGenerator matchGenerator;
        public AttributeManager atributeManager;
        public ScoreManager scoreManager;
        public Generator.ImageGenerator imageGenerator;
        public DatasetManager datasetManager;
        #endregion

        private MatchSystem.Client currentClient;
        private MatchSystem.Match match1;
        private MatchSystem.Match match2;

        public void Match(MatchSystem.Client _client, MatchSystem.Match _match)
        {
            int compatablity = _client.ScoreMatch(_match);

            // Add to score * modifier.
            // Get new client and matchs.
            scoreManager.AddToScore(compatablity * 100);

            RegenerateFields();
        }

        public void MatchWithOne ()
        {
            Match(currentClient, match1);
        }

        public void MatchWithTwo ()
        {
            Match(currentClient, match1);
        }

        public void GenerateClient()
        {
            currentClient = clientGenerator.GenerateClient();
            uIManager.UpdateClientInformation(
                currentClient.name,
                currentClient.race + " " + currentClient.gender + " (" + currentClient.age + ")",
                currentClient.GetLikesText(),
                currentClient.GetDislikesText()
            );

            uIManager.UpdateClientImage (
                clientGenerator.GenerateHead(),
                clientGenerator.GenerateHair(),
                clientGenerator.GenerateEyebrows(),
                clientGenerator.GenerateEyes(),
                clientGenerator.GenerateMouth()
            );
        }

        public void GenerateMatchs()
        {
            match1 = matchGenerator.GenerateMatch();
            uIManager.UpdateMatch1Information (
                match1.name,
                match1.race + " " + match1.gender + " (" + match1.age + ")",
                match1.GetLikesText(),
                match1.GetDislikesText()
            );

            uIManager.UpdateMatch1Image (
                matchGenerator.GenerateHead(),
                matchGenerator.GenerateHair(),
                matchGenerator.GenerateEyebrows(),
                matchGenerator.GenerateEyes(),
                matchGenerator.GenerateMouth()
            );

            match2 = matchGenerator.GenerateMatch();
            uIManager.UpdateMatch2Information (
                match2.name,
                match2.race + " " + match2.gender + " (" + match2.age + ")",
                match2.GetLikesText(),
                match2.GetDislikesText()
            );

            uIManager.UpdateMatch2Image (
                matchGenerator.GenerateHead(),
                matchGenerator.GenerateHair(),
                matchGenerator.GenerateEyebrows(),
                matchGenerator.GenerateEyes(),
                matchGenerator.GenerateMouth()
            );
        }

        public void RegenerateFields ()
        {
            GenerateClient();
            GenerateMatchs();
        }

        protected void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        protected void Start()
        {
            matchGenerator = new Generator.MatchGenerator();
            matchGenerator.InitilizeMatchGenerator();

            clientGenerator = new Generator.ClientGenerator();
            clientGenerator.InitilizeClinetGenerator();

            RegenerateFields();
        }
    }
}