using System;

namespace GrassNamespace
{
    public class Grass
    {
        //Embed the grass image
        private class GrassImage
        {
            // Image source path
            private string source = "../images/grass.png";
        }

        //Private properties
        private DisplayObject _grassImage = new GrassImage();
        private Sprite _grass = new Sprite();

        public Grass()
        {
            _grass.addChild(_grassImage);
            this.addChild(_grass);
        }
    }
}