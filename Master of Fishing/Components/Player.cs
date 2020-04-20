using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_of_Fishing.Components
{
    class Player : Component
    {
        private float speed;
        //private Vector2 origin;
        private SpriteRenderer spriteRenderer;
        private bool canShoot;
        private float shootTime;
        private float cooldown = 1;

        public Player()
        {
            this.speed = 100;
            canShoot = true;
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
            GameWorld.Instance.GraphicsDevice.Viewport.Height);

            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
        }

        public override void Start()
        {
            SpriteRenderer sr = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            //sr.SetSprite("INSET SPRITE HERE");
            //sr.Origin = new Vector2(sr.Sprite.Width / 2, (sr.Sprite.Height / 2) + 40);

        }

        public override void Update(GameTime gameTime)
        {
            shootTime += GameWorld.Instance.Deltatime;

            if (shootTime >= cooldown)
            {
                canShoot = true;
            }
        }

        public override string ToString()
        {
            return "Player";
        }

    }
}
