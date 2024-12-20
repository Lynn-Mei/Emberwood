﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberwood.Display
{
    public sealed class GameController
    {
        private static GameController instance = null;
        private Game1 game;
        public Game1 Game { 
            get 
            { 
                if (game == null) { 
                    game = new Game1();
                }
                return this.game; 
            } 
            
            set { this.game = value; } 
        }

        private GameController() { }
        public static GameController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameController();
                }
                return instance;
            }
        }

    }
}
