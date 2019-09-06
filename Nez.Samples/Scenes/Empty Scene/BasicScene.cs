﻿using Nez.Sprites;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Nez.Samples
{
	[SampleScene( "Basic Scene", 9999, "Scene with a single Entity. The minimum to have something to show" )]
	public class BasicScene : SampleScene
	{
		public override void Initialize()
		{
			base.Initialize();

			// default to 1280x720 with no SceneResolutionPolicy
			SetDesignResolution( 1280, 720, Scene.SceneResolutionPolicy.None );
			Screen.SetSize( 1280, 720 );

			var moonTex = Content.Load<Texture2D>( Nez.Content.Shared.moon );
			var playerEntity = CreateEntity( "player", new Vector2( Screen.Width / 2, Screen.Height / 2 ) );
			playerEntity.AddComponent( new Sprite( moonTex ) );
		}
	}
}

