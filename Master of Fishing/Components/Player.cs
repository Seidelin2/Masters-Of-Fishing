using Master_of_Fishing.CommandPattern;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_of_Fishing.Components
{
    public class Player : Component
    {
        private float speed;

        public Player()
        {
            this.speed = 300;
			InputHandler.Instance.Entity = this;
        }

        public void Move(Vector2 velocity)
        {
            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }

            velocity *= speed;

            GameObject.Transform.Translate(velocity * GameWorld.Instance.Deltatime);
        }

        public override void Awake()
        {
            GameObject.Transform.Position = new Vector2(GameWorld.Instance.GraphicsDevice.Viewport.Width / 2,
            GameWorld.Instance.GraphicsDevice.Viewport.Height / 2);
        }

        public override void Start()
        {
            //sr.Origin = new Vector2(sr.Sprite.Width / 2, (sr.Sprite.Height / 2));

        }

        public override void Update(GameTime gameTime)
        {

        }

        public override string ToString()
        {
            return "Player";
        }

    }
}
