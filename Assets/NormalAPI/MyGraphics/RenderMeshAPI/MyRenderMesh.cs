using UnityEngine;

namespace NormalAPI.MyGraphics.RenderMeshAPI
{
    public class MyRenderMesh : MonoBehaviour
    {
        public Material material;
        public Mesh mesh;

        void Update()
        {
            RenderParams rp = new RenderParams(material);
            for(int i=0; i<100; ++i)
                //这个方法是一个个画的，同时会进行视窗内的裁剪，每画一个会增加一个drawCall
                Graphics.RenderMesh(rp, mesh, 0, Matrix4x4.Translate(new Vector3(-4.5f+i, 0.0f, 5.0f)));
        }
    }
}
