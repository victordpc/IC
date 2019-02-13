using System;
using WaveEngine.Adapter;
using Windows.System.Display;
using Windows.UI.Xaml.Controls;

namespace Practica1
{
    public class GameRenderer : Application
    {
        private DisplayRequest displayRequest;

        private Practica1.Game game;

        public GameRenderer(SwapChainPanel panel)
            : base(panel)
        {
            this.FullScreen = true;
        }

        public override void Update(TimeSpan gameTime)
        {
            game.UpdateFrame(gameTime);
        }

        public override void Draw(TimeSpan gameTime)
        {
            game.DrawFrame(gameTime);
        }

        public override void Initialize()
        {
            base.Initialize();

            this.displayRequest = new DisplayRequest();
            this.displayRequest.RequestActive();

            game = new Practica1.Game();
            game.Initialize(this);
        }

        public override void OnResuming()
        {
            base.OnResuming();

            game.OnActivated();
        }

        public override void OnSuspending()
        {
            base.OnSuspending();

            game.OnDeactivated();
        }
    }
}
