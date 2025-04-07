namespace Scenes.Main
{
    using GameFoundation.Scripts.DI;
    using UnityEngine;
    using VContainer;

    public class MainSceneScope : SceneScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            Debug.Log("Init Main Scene");
        }
    }
}