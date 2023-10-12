
using UnityEngine;

namespace NormalAPI.MyGraphics.DrawTexture
{
    public class MyDrawTexture : MonoBehaviour
    {
        // Draws a texture on the screen at 10, 10 with 100 width, 100 height.

        public Texture aTexture;

        private void Update()
        {
            //Graphics.DrawTexture(new Rect(10, 10, 100, 100), aTexture);
        }

        void OnGUI()
        {
            if (Event.current.type.Equals(EventType.Repaint))
            { 
                //只有OnGUI之后的逻辑才会生效
                Graphics.DrawTexture(new Rect(10, 10, 100, 100), aTexture);
            }
        }

    }
}
