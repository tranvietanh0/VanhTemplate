namespace Scenes.Loading
{
    using GameFoundation.Scripts.DI;
    using UnityEngine;
    using VContainer;

    public class LoadingSceneScope : SceneScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            Debug.Log($"Loading Scene Scope");
        }
    }
}