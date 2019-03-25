﻿using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

namespace LearnOpenGL_TK
{
    //This is where all OpenGL code will be written.
    //OpenTK allows for several functions to be overriden to extend functionality; this is how we'll be writing code.
    class Game : GameWindow
    {
        //A simple constructor to let us set the width/height/title of the window.
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        //This function runs on every update frame.
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            //Get the current state of the keyboard on this frame.
            KeyboardState input = Keyboard.GetState();

            //Check if the Escape button is currently being pressed.
            if (input.IsKeyDown(Key.Escape))
            {
                //If it is, exit the window.
                Exit();
            }

            base.OnUpdateFrame(e);
        }
    }
}
