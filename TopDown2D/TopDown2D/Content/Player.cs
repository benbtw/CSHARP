using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown2D.Content
{
    internal class Player
    {
        Texture2D fox;
        private Vector2 foxPos;
        private float speed;

        public Player() 
        {
            foxPos = new Vector2(10, 10);
            speed = 250f;
            //fox = Content.Load<Texture2D>("player-idle-1");
        }
    }
}
